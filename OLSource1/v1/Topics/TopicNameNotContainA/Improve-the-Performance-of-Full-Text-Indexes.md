---
title: Improve the Performance of Full-Text Indexes
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-search
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ef39ef1f-f0b7-4582-8e9c-31d4bd0ad35d
---
# Improve the Performance of Full-Text Indexes
  Performance for full\-text indexing and full\-text queries is influenced by hardware resources, such as memory, disk speed, CPU speed, and machine architecture.  
  
##  <a name="causes"></a> Common Causes of Performance Issues  
 The main cause for reduced full\-text indexing performance is hardware\-resource limits:  
  
-   If CPU usage by the filter daemon host process \(fdhost.exe\) or the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] process \(sqlservr.exe\) is close to 100 percent, the CPU is the bottleneck.  
  
-   If the average disk\-waiting queue length is more than two times the number of disk heads, there is a bottleneck on the disk. The primary workaround is to create full\-text catalogs that are separate from the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] database files and logs. Put the logs, database files, and full\-text catalogs on separate disks. Buying faster disks and using RAID can also help improve indexing performance.  
  
-   If there is a shortage of physical memory, memory might be the bottleneck.  
  
    > [!NOTE]  
    >  Beginning in [!INCLUDE[ssKatmai](../../Token\Other/ssKatmai_md.md)], the Full\-Text Engine can use AWE memory because the Full\-Text Engine is part of the sqlservr.exe.  
  
 If the system has no hardware bottlenecks, the indexing performance of full\-text search mostly depends on the following:  
  
-   How long it takes [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to create full\-text batches.  
  
-   How quickly the filter daemon can consume those batches.  
  
> [!NOTE]  
>  Unlike full population, incremental, manual, and auto change tracking population are not designed to maximize hardware resources to achieve faster speed. Therefore, these tuning suggestions may not enhance performance for full\-text indexing.  
  
 When a population has completed, a final merge process is triggered that merges the index fragments together into one master full\-text index. This results in improved query performance since only the master index needs to be queried rather than a number of index fragments, and better scoring statistics may be used for relevance ranking. Note that the master merge can be I\/O intensive, because large amounts of data must be written and read when index fragments are merged, though it does not block incoming queries.  
  
> [!IMPORTANT]  
>  Master merging a large amount of data can create a long running transaction, delaying truncation of the transaction log during checkpoint. In this case, under the full recovery model, the transaction log might grow significantly. As a best practice, before reorganizing a large full\-text index in a database that uses the full recovery model, ensure that your transaction log contains sufficient space for a long\-running transaction. For more information, see [Manage the Size of the Transaction Log File](../../Topics\TopicNameNotContainA/Manage-the-Size-of-the-Transaction-Log-File.md).  
  
##  <a name="tuning"></a> Tuning the Performance of Full\-Text Indexes  
 To maximize the performance of your full\-text indexes, implement the following best practices:  
  
-   To use all processors or cores to the maximum, set [sp\_configure](../Topic/sp_configure%20\(Transact-SQL\).md)‘**max full\-text crawl ranges**’ to the number of CPUs on the system. For information about this configuration option, see [max full-text crawl range Server Configuration Option](../../Topics\TopicNameNotContainA/max-full-text-crawl-range-Server-Configuration-Option.md).  
  
-   Make sure that the base table has a clustered index. Use an integer data type for the first column of the clustered index. Avoid using GUIDs in the first column of the clustered index. A multi\-range population on a clustered index can produce the highest population speed. We recommend that the column serving as the full\-text key be an integer data type.  
  
-   Update the statistics of the base table by using the [UPDATE STATISTICS](../Topic/UPDATE%20STATISTICS%20\(Transact-SQL\).md) statement. More important, update the statistics on the clustered index or the full\-text key for a full population. This helps a multi\-range population to generate good partitions on the table.  
  
-   Build a secondary index on a **timestamp** column if you want to improve the performance of incremental population.  
  
-   Before you perform a full population on a large multi\-CPU computer, we recommend that you temporarily limit the size of the buffer pool by setting the **max server memory** value to leave enough memory for the fdhost.exe process and operating system use. For more information, see "Estimating the Memory Requirements of the Filter Daemon Host Process \(fdhost.exe\)," later in this topic.  
  
##  <a name="full"></a> Troubleshooting the Performance of Full Populations  
 To diagnose performance problems, look at the full\-text crawl logs. For information about crawl logs, see [Populate Full-Text Indexes](../../Topics\TopicNameNotContainA/Populate-Full-Text-Indexes.md).  
  
 It is recommended that the following order of troubleshooting be followed if the performance of full populations is not satisfactory.  
  
### Physical Memory Usage  
 During a full\-text population, it is possible for fdhost.exe or sqlservr.exe to run low on memory or to run out of memory. If the full\-text crawl log shows that fdhost.exe is being restarted often or that error code 8007008 is being returned it means one of these processes is running out of memory. If fdhost.exe is producing dumps, particularly on large, multi\-CPU computers, it might be running out of memory.  
  
> [!NOTE]  
>  To obtain information about memory buffers used by a full\-text crawl, see [sys.dm_fts_memory_buffers &#40;Transact-SQL&#41;](../Topic/sys.dm_fts_memory_buffers%20\(Transact-SQL\).md).  
  
 The possible causes are as follows:  
  
-   If amount of physical memory that is available during a full population is zero, the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] buffer pool might be consuming most of the physical memory on the system.  
  
     The sqlservr.exe process tries to grab all available memory for the buffer pool, up to the configured maximum server memory. If the **max server memory** allocation is too large, out\-of\-memory conditions and failure to allocate shared memory can occur for the fdhost.exe process.  
  
    > [!NOTE]  
    >  During a full\-text population on a multi\-CPU computer, contention for the buffer pool memory can occur between fdhost.exe or sqlservr.exe. The resulting lack of shared memory causes batch retries, memory thrashing, and dumps by the fdhost.exe process.  
  
     You can solve this problem by setting the **max server memory** value of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] buffer pool appropriately. For more information, see "Estimating the Memory Requirements of the Filter Daemon Host Process \(fdhost.exe\)," later in this topic. Reducing the batch size used for full\-text indexing may also help.  
  
-   A paging issue  
  
     Insufficient page\-file size, such as on a system that has a small page file with restricted growth, can also cause the fdhost.exe or sqlservr.exe to run out of memory.  
  
     If the crawl logs do not indicate any memory\-related failures, it is likely that performance is slow due to excessive paging.  
  
### Estimating the Memory Requirements of the Filter Daemon Host Process \(fdhost.exe\)  
 The amount of memory required by the fdhost.exe process for a population depends mainly on the number of full\-text crawl ranges it uses, the size of inbound shared memory \(ISM\), and the maximum number of ISM instances.  
  
 The amount of memory \(in bytes\) consumed by the filter daemon host can be roughly estimated by using the following formula:  
  
 *number\_of\_crawl\_ranges* \**ism\_size*\**max\_outstanding\_isms*\* 2  
  
 The default values of the variables in the preceding formula are as follows:  
  
|**Variable**|**Default value**|  
|------------------|-----------------------|  
|*number\_of\_crawl\_ranges*|The number of CPUs|  
|*ism\_size*|1 MB for x86 computers<br /><br /> 4 MB, 8 MB, or 16MB for x64 computers, depending on the total physical memory|  
|*max\_outstanding\_isms*|25 for x86 computers<br /><br /> 5 for x64 computers|  
  
 The following table presents guidelines about how to estimate the memory requirements of fdhost.exe. The formulas in this table use the following values:  
  
-   *F*, which is an estimate of memory needed by fdhost.exe \(in MB\).  
  
-   *T*, which is the total physical memory available on the system \(in MB\).  
  
-   *M*, which is the optimal **max server memory** setting.  
  
> [!IMPORTANT]  
>  For essential information about the formulas, see \(1\), \(2\), and \(3\), below.  
  
|Platform|Estimating fdhost.exe memory requirements in MB—*F*^1|Formula for calculating max server memory—*M*^2|  
|--------------|-----------------------------------------------------------|-----------------------------------------------------|  
|x86|*F* **\=** *Number of crawl ranges* **\*** 50|*M* **\=minimum\(** *T* **,** 2000**\)–***F***–** 500|  
|x64|*F* **\=** *Number of crawl ranges* **\*** 10 **\*** 8|*M* **\=** *T* **–** *F* **–** 500|  
  
 \(1\) If multiple full populations are in progress, calculate the fdhost.exe memory requirements of each separately, as *F1*, *F2*, and so forth. Then calculate *M* as *T***–** sigma**\(***F*i**\)**.  
  
 \(2\) 500 MB is an estimate of the memory required by other processes in the system. If the system is doing additional work, increase this value accordingly.  
  
 \(3\) .*ism\_size* is assumed to be 8 MB for x64 platforms.  
  
 **Example: Estimating the Memory Requirements of fdhost.exe**  
  
 This example is for an AMD64 computer that has 8GM of RAM and 4 dual core processors. The first calculation estimates of memory needed by fdhost.exe—*F*. The number of crawl ranges is `8`.  
  
 `F = 8*10*8=640`  
  
 The next calculation obtains the optimal value for **max server memory**—*M*. *T*he total physical memory available on this system in MB—*T*—is `8192`.  
  
 `M = 8192-640-500=7052`  
  
 **Example: Setting max server memory**  
  
 This example uses the [sp\_configure](../Topic/sp_configure%20\(Transact-SQL\).md) and [RECONFIGURE](../Topic/RECONFIGURE%20\(Transact-SQL\).md)[!INCLUDE[tsql](../../Token\Other/tsql_md.md)] statements to set **max server memory** to the value calculated for *M* in the preceding example, `7052`:  
  
```  
USE master;  
GO  
EXEC sp_configure 'max server memory', 7052;  
GO  
RECONFIGURE;  
GO  
```  
  
 **To set the max server memory configuration option**  
  
-   [Server Memory Server Configuration Options](../../Topics\TopicNameNotContainA/Server-Memory-Server-Configuration-Options.md)  
  
### Factors that Can Reduce CPU Consumption  
 We expect that the performance of full populations is not optimal when the average CPU consumption is lower than about 30 percent. This section discusses some factors that affect CPU consumption.  
  
-   High wait for pages  
  
     To find out whether a page wait time is high, execute the following [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] statement:  
  
    ```  
    Execute SELECT TOP 10 * FROM sys.dm_os_wait_stats ORDER BY wait_time_ms DESC;  
    ```  
  
     The following table describes the wait types of interest here.  
  
    |Wait type|Description|Possible resolution|  
    |---------------|-----------------|-------------------------|  
    |PAGEIO\_LATCH\_SH \(\_EX or \_UP\)|This could indicate an IO bottleneck, in which case you would typically also see a high average disk\-queue length.|Moving the full\-text index to a different filegroup on a different disk could help reduce the IO bottleneck.|  
    |PAGELATCH\_EX \(or \_UP\)|This could indicate a lot of contention among threads that are trying to write to the same database file.|Adding files to the filegroup on which the fulltext index resides could help alleviate such contention.|  
  
     For more information, see [sys.dm_os_wait_stats &#40;Transact-SQL&#41;](../Topic/sys.dm_os_wait_stats%20\(Transact-SQL\).md).  
  
-   Inefficiencies in scanning the base table  
  
     A full population scans the base table to produce batches. This table scanning could be inefficient in the following scenarios:  
  
    -   If the base table has a high percentage of out\-of\-row columns that are being full\-text indexed, scanning the base table to produce batches might be the bottleneck. In this case, moving the smaller data in\-row using **varchar\(max\)** or **nvarchar\(max\)** might help.  
  
    -   If the base table is very fragmented, scanning might be inefficient. For information about computing out\-of\-row data and index fragmentation, see [sys.dm_db_partition_stats &#40;Transact-SQL&#41;](../Topic/sys.dm_db_partition_stats%20\(Transact-SQL\).md) and [sys.dm_db_index_physical_stats &#40;Transact-SQL&#41;](../Topic/sys.dm_db_index_physical_stats%20\(Transact-SQL\).md).  
  
         To reduce fragmentation, you can reorganize or rebuild the clustered index. For more information, see [Reorganize and Rebuild Indexes](../../Topics\TopicNameNotContainA/Reorganize-and-Rebuild-Indexes.md).  
  
##  <a name="filters"></a> Troubleshooting Slow Indexing Performance Due to Filters  
 When populating a full\-text index, the Full\-Text Engine uses two types of filters: multithreaded and single\-threaded. Some documents, such as [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Word documents, are filtered using a multithreaded filter. Other documents, such as Adobe Acrobat Portable Document Format \(PDF\) documents, are filtered using a single\-threaded filter.  
  
 For security reasons, filters are loaded by filter daemon host processes. A server instance uses a multithreaded process for all multithreaded filters and a single\-threaded process for all single\-threaded filters. When a document that uses a multithreaded filter contains an embedded document that uses a single\-threaded filter, the Full\-Text Engine launches a single\-threaded process for the embedded document. For example, on encountering a Word document that contains a PDF document, the Full\-Text Engine uses the multithreaded process for the Word content and launches a single\-threaded process for the PDF content. A single\-threaded filter might not work well in this environment, however, and could destabilize the filtering process. In certain circumstances where such embedding is common, destabilization might lead to filtering\-process crashes. When this occurs, the Full\-Text Engine re\-routes any failed document \(for example, a Word document that contains embedded PDF content\) to the single\-threaded filtering process. If re\-routing occurs frequently, it results in performance degradation of the full\-text indexing process.  
  
 To work around this problem, mark the filter for the container document \(Word in this case\) as a single\-threaded filter. You can change the filter registry value to mark a given filter as a single\-threaded filter. To mark a filter as a single\-threaded filter, you need to set the **ThreadingModel** registry value for the filter to **Apartment Threaded**. For information about single\-threaded apartments, see the white paper [Understanding and Using COM Threading Models](http://go.microsoft.com/fwlink/?LinkId=209159).  
  
## See Also  
 [Server Memory Server Configuration Options](../../Topics\TopicNameNotContainA/Server-Memory-Server-Configuration-Options.md)   
 [max full-text crawl range Server Configuration Option](../../Topics\TopicNameNotContainA/max-full-text-crawl-range-Server-Configuration-Option.md)   
 [Populate Full-Text Indexes](../../Topics\TopicNameNotContainA/Populate-Full-Text-Indexes.md)   
 [Create and Manage Full-Text Indexes](../../Topics\TopicNameNotContainA/Create-and-Manage-Full-Text-Indexes.md)   
 [sys.dm_fts_memory_buffers &#40;Transact-SQL&#41;](../Topic/sys.dm_fts_memory_buffers%20\(Transact-SQL\).md)   
 [sys.dm_fts_memory_pools &#40;Transact-SQL&#41;](../Topic/sys.dm_fts_memory_pools%20\(Transact-SQL\).md)   
 [Troubleshoot Full-Text Indexing](../../Topics\TopicNameNotContainA/Troubleshoot-Full-Text-Indexing.md)  
  
  