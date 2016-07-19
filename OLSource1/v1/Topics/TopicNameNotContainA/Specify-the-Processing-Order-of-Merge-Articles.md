---
title: Specify the Processing Order of Merge Articles
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d151e2c5-cf50-4cb3-a829-8f32455dbd66
manager: jhubbard
---
# Specify the Processing Order of Merge Articles
Beginning with [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)], it is possible to override the default order of article processing for merge publications. This is useful, for example, if you define referential integrity through triggers and those triggers must fire in a certain order.  
  
 **To specify the processing order of articles**  
  
-   Replication Transact-SQL programming: [Specify the Processing Order of Merge Table Articles (Replication Transact-SQL Programming)](../../Topics/TopicNameNotContainA/Specify-the-Processing-Order-of-Merge-Table-Articles--Replication-Transact-SQL-Programming-.md)  
  
## How Processing Order is Determined  
 During merge synchronization, articles are, by default, processed in the order required by the dependencies between objects, including the declarative referential integrity (DRI) constraints defined on the base tables. Processing involves enumerating the changes to a table and then applying those changes. If no DRI is present but join filters or logical records exist between table articles, the articles are processed in the order required by the filters and logical records. Articles not related to any other article through DRI, join filters, logical records, or other dependencies are processed according to the article nickname in the [sysmergearticles (Transact-SQL)](assetId:///e9b1648e-4660-4688-9f56-18b2baf7228c) system table.  
  
 Consider a publication that includes the tables **SalesOrderHeader** and **SalesOrderDetail** with a primary key column **SalesOrderID** in the **SalesOrderHeader** table and a corresponding foreign key column **SalesOrderID** in the **SalesOrderDetail** table. During synchronization, merge replication prevents foreign key violations by inserting any new rows in **SalesOrderHeader** before inserting associated rows in **SalesOrderDetail**. Similarly, rows are deleted from **SalesOrderDetail** before the associated row is deleted from **SalesOrderHeader**.  
  
 However, in some applications referential integrity is enforced through database triggers, or at the application level, rather than through DRI. Given the publication described above, instead of DRI, the **SalesOrderDetail** table could have an insert trigger that ensures the associated row in the **SalesOrderHeader** table exists before allowing an insert. **SalesOrderHeader** could have a delete trigger that ensures there are no associated rows in **SalesOrderDetail** before allowing a delete. Merge replication does not take into account triggers when determining processing order of articles because it cannot determine what the result of the trigger will be until it has fired. Similarly, replication cannot take into account constraints defined at the application level.  
  
 When referential integrity is maintained through triggers or at the application level, you should specify the order in which the articles should be processed. In the example with triggers, you would specify that the **SalesOrderHeader** table should be processed before **SalesOrderDetail**, because article ordering is based on insert order. Merge replication will automatically reverse the order for deletes. Merge replication will not fail without article ordering, because the Merge Agent continues to process articles if a constraint violation occurs; it then retries any operations that failed after other articles have been processed. Specifying article order simply avoids retries and the additional processing associated with them. If you specify an incorrect order (for example, one that results in detail records being processed before header records), merge replication will retry processing until it succeeds.  
  
## See Also  
 [Article Options for Merge Replication](../../Topics/TopicNameNotContainA/Article-Options-for-Merge-Replication.md)   
 [Group Changes to Related Rows with Logical Records](../../Topics/TopicNameNotContainA/Group-Changes-to-Related-Rows-with-Logical-Records.md)   
 [Join Filters](../../Topics/TopicNameNotContainA/Join-Filters.md)