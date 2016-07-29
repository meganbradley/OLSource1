---
title: "Requirements for Using Memory-Optimized Tables"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine-imoltp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 47d9a7e8-c597-4b95-a58a-dcf66df8e572
caps.latest.revision: 61
manager: jhubbard
---
# Requirements for Using Memory-Optimized Tables
For using In-Memory OLTP in Azure DB see [Get started with In-Memory in SQL Database](http://azure.microsoft.com/documentation/articles/sql-database-in-memory/).  
  
 In addition to the [Hardware and Software Requirements for Installing SQL Server 2016](../../Topics/TopicNameNotContainA/Hardware-and-Software-Requirements-for-Installing-SQL-Server-2016.md), the following are requirements to use In-Memory OLTP:  
  
-   64-bit Enterprise, Developer, or Evaluation edition of [!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)] or SQL Server 2016.  
  
-   [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] needs enough memory to hold the data in memory-optimized tables and indexes. To account for row versions, you should provide an amount of memory that is two times the expected size of memory-optimized tables and indexes. But the actual amount of memory needed will depend on your workload. You should monitor your memory usage and make adjustments as needed. The size of data in memory-optimized tables must not exceed the allowed percentage of the pool. To discover the size of a memory-optimized table, see [sys.dm_db_xtp_table_memory_stats (Transact-SQL)](assetId:///ad0efc06-3d9c-4861-9dfa-a7a87822d0c8).  
  
     If you have disk-based tables in the database, you need to provide enough memory for the buffer pool and query processing on those tables.  
  
     It is important to know how much memory your In-Memory OLTP application will require. See [Estimate Memory Requirements for Memory-Optimized Tables](../../Topics/TopicNameNotContainA/Estimate-Memory-Requirements-for-Memory-Optimized-Tables.md) for more information.  
  
-   Free disk space that is two times the size of your durable memory-optimized tables.  
  
-   A processor needs to support the instruction **cmpxchg16b** to use In-Memory OLTP. All modern 64-bit processors support **cmpxchg16b**.  
  
     If you are using a VM host application and [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] displays an error caused by an older processor, see if the application has a configuration option to allow **cmpxchg16b**. If not, you could use Hyper-V, which supports **cmpxchg16b** without needing to modify a configuration option.  
  
-   In-Memory OLTP is installed as part of **Database Engine Services**.  
  
     To install report generation ([Determining if a Table or Stored Procedure Should Be Ported to In-Memory OLTP](../../Topics/TopicNameContainA/Determining-if-a-Table-or-Stored-Procedure-Should-Be-Ported-to-In-Memory-OLTP.md)) and [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] (to manage In-Memory OLTP via [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] Object Explorer), select **Management Tools—Basic** or **Management Tools—Advanced** when you install [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] or [Download SQL Server Management Studio (SSMS)](https://msdn.microsoft.com/library/mt238290.aspx).  
  
## Important Notes on Using [!INCLUDE[hek_2](../../Topics/TopicNameContainA/includes/hek_2_md.md)]  
  
-   The total in-memory size of all durable tables in a database should not exceed 250 GB for SQL Server 2014 databases, or 2 TB for SQL Server 2016. For more information, see [Durability for Memory-Optimized Tables](../../Topics/TopicNameNotContainA/Durability-for-Memory-Optimized-Tables.md).  
  
-   If you create one or more databases with memory-optimized tables, you should enable Instant File Initialization (grant the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] service startup account the SE_MANAGE_VOLUME_NAME user right) for the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance. Without Instant File Initialization, memory-optimized storage files (data and delta files) will be initialized upon creation, which can have negative impact on the performance of your workload. For more information about Instant File Initialization, see [Database File Initialization](http://msdn.microsoft.com/library/ms175935\(SQL.105\).aspx). For information on how to enable Instant File Initialization, see [How and Why to Enable Instant File Initialization](http://blogs.msdn.com/b/sql_pfe_blog/archive/2009/12/23/how-and-why-to-enable-instant-file-initialization.aspx).  
  
## See Also  
 [In-Memory OLTP (In-Memory Optimization)](../../Topics/TopicNameNotContainA/In-Memory-OLTP--In-Memory-Optimization-.md)