---
title: Disk Space Requirements for Index DDL Operations
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-indexes
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 35930826-c870-44c1-a966-a6a4638f62ef
---
# Disk Space Requirements for Index DDL Operations
  Disk space is an important consideration when you create, rebuild, or drop indexes. Inadequate disk space can degrade performance or even cause the index operation to fail. This topic provides general information that can help you determine the amount of disk space required for index data definition language \(DDL\) operations.  
  
## Index Operations That Require No Additional Disk Space  
 The following index operations require no additional disk space:  
  
-   ALTER INDEX REORGANIZE; however, log space is required.  
  
-   DROP INDEX when you are dropping a nonclustered index.  
  
-   DROP INDEX when you are dropping a clustered index offline without specifying the MOVE TO clause and nonclustered indexes do not exist.  
  
-   CREATE TABLE \(PRIMARY KEY or UNIQUE constraints\)  
  
## Index Operations That Require Additional Disk Space  
 All other index DDL operations require additional temporary disk space to use during the operation, and permanent disk space to store the new index structure or structures.  
  
 When a new index structure is created, disk space for both the old \(source\) and new \(target\) structures is required in their appropriate files and filegroups. The old structure is not deallocated until the index creation transaction commits.  
  
 The following index DDL operations create new index structures and require additional disk space:  
  
-   CREATE INDEX  
  
-   CREATE INDEX WITH DROP\_EXISTING  
  
-   ALTER INDEX REBUILD  
  
-   ALTER TABLE ADD CONSTRAINT \(PRIMARY KEY or UNIQUE\)  
  
-   ALTER TABLE DROP CONSTRAINT \(PRIMARY KEY or UNIQUE\) when the constraint is based on a clustered index  
  
-   DROP INDEX MOVE TO \(Applies only to clustered indexes.\)  
  
## Temporary Disk Space for Sorting  
 Besides the disk space required for the source and target structures, temporary disk space is required for sorting, unless the query optimizer finds an execution plan that does not require sorting.  
  
 If sorting is required, sorting occurs one new index at a time. For example, when you rebuild a clustered index and associated nonclustered indexes within a single statement, the indexes are sorted one after the other. Therefore, the additional temporary disk space that is required for sorting only has to be as large as the largest index in the operation. This is almost always the clustered index.  
  
 If the SORT\_IN\_TEMPDB option is set to ON, the largest index must fit into **tempdb**. Although this option increases the amount of temporary disk space that is used to create an index, it may reduce the time that is required to create an index when **tempdb** is on a set of disks different from the user database.  
  
 If SORT\_IN\_TEMPDB is set to OFF \(the default\) each index, including partitioned indexes, is sorted in its destination disk space; and only the disk space for the new index structures is required.  
  
 For an example of calculating disk space, see [Index Disk Space Example](../../Topics\TopicNameNotContainA/Index-Disk-Space-Example.md).  
  
## Temporary Disk Space for Online Index Operations  
 When you perform index operations online, additional temporary disk space is required.  
  
 If a clustered index is created, rebuilt, or dropped online, a temporary nonclustered index is created to map old bookmarks to new bookmarks. If the SORT\_IN\_TEMPDB option is set to ON, this temporary index is created in **tempdb**. If SORT\_IN\_TEMPDB is set to OFF, the same filegroup or partition scheme as the target index is used. The temporary mapping index contains one record for each row in the table, and its contents is the union of the old and new bookmark columns, including uniqueifiers and record identifiers and including only a single copy of any column used in both bookmarks. For more information about online index operations, see [Perform Index Operations Online](../../Topics\TopicNameNotContainA/Perform-Index-Operations-Online.md).  
  
> [!NOTE]  
>  The SORT\_IN\_TEMPDB option cannot be set for DROP INDEX statements. The temporary mapping index is always created in the same filegroup or partition scheme as the target index.  
  
 Online index operations use row versioning to isolate the index operation from the effects of modifications made by other transactions. This avoids the need for requesting share locks on rows that have been read. Concurrent user update and delete operations during online index operations require space for version records in **tempdb**. For more information, see [Perform Index Operations Online](../../Topics\TopicNameNotContainA/Perform-Index-Operations-Online.md) .  
  
## Related Tasks  
 [Index Disk Space Example](../../Topics\TopicNameNotContainA/Index-Disk-Space-Example.md)  
  
 [Transaction Log Disk Space for Index Operations](../../Topics\TopicNameNotContainA/Transaction-Log-Disk-Space-for-Index-Operations.md)  
  
 [Estimate the Size of a Table](../../Topics\TopicNameContainA/Estimate-the-Size-of-a-Table.md)  
  
 [Estimate the Size of a Clustered Index](../../Topics\TopicNameContainA/Estimate-the-Size-of-a-Clustered-Index.md)  
  
 [Estimate the Size of a Nonclustered Index](../../Topics\TopicNameContainA/Estimate-the-Size-of-a-Nonclustered-Index.md)  
  
 [Estimate the Size of a Heap](../../Topics\TopicNameContainA/Estimate-the-Size-of-a-Heap.md)  
  
## Related Content  
 [CREATE INDEX &#40;Transact-SQL&#41;](../Topic/CREATE%20INDEX%20\(Transact-SQL\).md)  
  
 [ALTER INDEX &#40;Transact-SQL&#41;](../Topic/ALTER%20INDEX%20\(Transact-SQL\).md)  
  
 [DROP INDEX &#40;Transact-SQL&#41;](../Topic/DROP%20INDEX%20\(Transact-SQL\).md)  
  
 [Specify Fill Factor for an Index](../../Topics\TopicNameNotContainA/Specify-Fill-Factor-for-an-Index.md)  
  
 [Reorganize and Rebuild Indexes](../../Topics\TopicNameNotContainA/Reorganize-and-Rebuild-Indexes.md)  
  
  