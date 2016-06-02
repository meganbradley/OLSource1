---
title: Database Mirroring and Full-Text Catalogs (SQL Server)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e34072ae-fe8a-462d-bb03-02fa0987f793
---
# Database Mirroring and Full-Text Catalogs (SQL Server)
  To mirror a database that has a full\-text catalog, use backup as usual to create a full database backup of the principal database, and then restore the backup to copy the database to the mirror server. For more information, see [Prepare a Mirror Database for Mirroring &#40;SQL Server&#41;](../Topic/Prepare%20a%20Mirror%20Database%20for%20Mirroring%20\(SQL%20Server\).md).  
  
## Full\-Text Catalog and Indexes Before Failover  
 In a newly created mirror database, the full\-text catalog is the same as when the database was backed up. After database mirroring starts, any catalog\-level changes that were made by DDL statements \(CREATE FULLTEXT CATALOG, ALTER FULLTEXT CATALOG, DROP FULLTEXT CATALOG\) are logged and sent to the mirror server to be replayed on the mirror database. However, index\-level changes are not reproduced on the mirror database because it is not logged on to the principal server. Therefore, as the contents of the full\-text catalog change on the principal database, the contents of the full\-text catalog on the mirror database are unsynchronized.  
  
## Full\-Text Indexes After Failover  
 After a failover, a full crawl of a full\-text index on the new principal server might be required or useful in the following situations:  
  
-   If change\-tracking is turned OFF on a full text index, you must start a full crawl on that index by using the following statement:  
  
     ALTER FULLTEXT INDEX ON *table\_name* START FULL POPULATION  
  
-   If a full\-text index is configured for automatic change tracking, the full\-text index is automatically synchronized. However, synchronization slows full\-text performance somewhat. If performance is too slow, you can cause a full crawl by setting change tracking off and then resetting it to automatic:  
  
    -   To set change tracking off:  
  
         ALTER FULLTEXT INDEX ON *table\_name* SET CHANGE\_TRACKING OFF  
  
    -   To set on automatic change tracking to automatic:  
  
         ALTER FULLTEXT INDEX ON *table\_name* SET CHANGE\_TRACKING AUTO  
  
    > [!NOTE]  
    >  To see whether auto change tracking is on, you can use the [OBJECTPROPERTYEX](../Topic/OBJECTPROPERTYEX%20\(Transact-SQL\).md) function to query the **TableFullTextBackgroundUpdateIndexOn** property of the table.  
  
 For more information, see [ALTER FULLTEXT INDEX &#40;Transact-SQL&#41;](../Topic/ALTER%20FULLTEXT%20INDEX%20\(Transact-SQL\).md).  
  
> [!NOTE]  
>  Starting a crawl after failover works the same as starting a crawl after a restore.  
  
## After Forcing Service  
 After service is forced to the mirror server \(with possible data loss\), start a full crawl. The method to use for starting a full crawl depends on whether the full\-text index is change tracked. For more information, see "Full\-Text Indexes After Failover," earlier in this topic.  
  
## See Also  
 [ALTER FULLTEXT INDEX &#40;Transact-SQL&#41;](../Topic/ALTER%20FULLTEXT%20INDEX%20\(Transact-SQL\).md)   
 [CREATE FULLTEXT INDEX &#40;Transact-SQL&#41;](../Topic/CREATE%20FULLTEXT%20INDEX%20\(Transact-SQL\).md)   
 [DROP FULLTEXT INDEX &#40;Transact-SQL&#41;](../Topic/DROP%20FULLTEXT%20INDEX%20\(Transact-SQL\).md)   
 [Database Mirroring &#40;SQL Server&#41;](../Topic/Database%20Mirroring%20\(SQL%20Server\).md)   
 [Back Up and Restore Full-Text Catalogs and Indexes](../../Topics\TopicNameNotContainA/Back-Up-and-Restore-Full-Text-Catalogs-and-Indexes.md)  
  
  