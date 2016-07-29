---
title: "What&#39;s New in Master Data Services (MDS)"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 2016-04-01
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ad530f60-d480-4457-ba7a-93a10c8a1695
caps.latest.revision: 80
manager: jhubbard
---
# What&#39;s New in Master Data Services (MDS)
This topic summarizes the changes and updates in the [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] release of [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)].  
  
 **To install Master Data Services, set up the database and Website, and deploy the sample models, see** [Get Started with Master Data Services (SQL Server 2016)](../../Topics/TopicNameNotContainA/Get-Started-with-Master-Data-Services--SQL-Server-2016-.md).  
  
 **Download**  
  
-   To download [!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)], go to  **[Evaluation Center](https://www.microsoft.com/en-us/evalcenter/evaluate-sql-server-2016)**.  
  
-   Have an Azure account?  Then go **[Here](https://azure.microsoft.com/en-us/marketplace/partners/microsoft/sqlserver2016rc0evaluationwindowsserver2012r2/?wt.mc_id=sqL16_vm)** to spin up a Virtual Machine with [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] already installed.  
  
## What’s New in  MDS  
 **[CTP 2.0]**  
 **Improved Performance**  
  
 Performance improvements enable you to create larger models, load data more efficiently, and get better overall performance. This includes improvement the performance of the add-in for Microsoft Excel has been improved to decrease data load times and enable the add-in to handle larger entities.  
  
 For more information about the add-in for Microsoft Excel, see [Master Data Services Add-in for Microsoft Excel](../../Topics/TopicNameNotContainA/Master-Data-Services-Add-in-for-Microsoft-Excel.md).  
  
 The following feature improvements are included.  
  
-   There is data compression on the entity level, which by default is enabled. When data compression is enabled, all the entity related tables and indexes are compressed with SQL Row Level compression. This significantly reduces the disk I/O when reading or updating the master data, especially when the master data has millions of rows and/or has a lot of NULL value columns.  
  
     Because there is a slight increase in the CPU usage on the SQL Server engine side, if you have CPU bound on the server you can turn off data compression by editing the entity.  
  
     For more information, see [Create an Entity (Master Data Services)](../../Topics/TopicNameNotContainA/Create-an-Entity--Master-Data-Services-.md)and [Data Compression](../../Topics/TopicNameNotContainA/Data-Compression.md).  
  
-   The Dynamic Content Compression IIS feature is enabled, by default. This significantly reduces the size of the xml response and saves the network I/O, though CPU usage is increased. If you have CPU bound on the server, you can turn off data compression by adding the following setting to the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] Web.config file.  
  
    ```  
    <configuration>  
       <system.webServer>  
          <urlCompression doStaticCompression="true" doDynamicCompression="false " />  
       </system.webServer>  
    </configuration>  
  
    ```  
  
     For more information, see [URL Compression](http://www.iis.net/configreference/system.webserver/urlcompression)  
  
-   The following new SQL Server Agent jobs do index and log maintenance.  
  
    -   MDS_MDM_Sample_Index_Maintenace  
  
    -   MDS_MDM_Sample_Log_Maintenace  
  
 By default the MDS_MDM_Sample_Index_Maintenance job runs weekly. You can modify the schedule. You can also manually run the job at any time by using the udpDefragmentation stored procedure. It is recommended that you run the stored procedure each time a large volume of master data is inserted or updated, or after a new version is created from the existing version.  
  
 An index with more than 30% fragmentation is rebuilt online. During the rebuild, the performance is affected on the CRUD operation on the same table. If performance degradation is a concern, it is recommended that you run the store procedure during off business hours. For more information about index fragmentation, see [Reorganize and Rebuild Indexes](../../Topics/TopicNameNotContainA/Reorganize-and-Rebuild-Indexes.md).  
  
 For more information, see this post on the Master Data Services Blog, [Performance and Scale Improvement in SQL Server 2016](http://go.microsoft.com/fwlink/p/?LinkId=615375).  
  
 **[CTP 2.0]**  
 **Improved Security**  
  
 The new Super User function permission gives a user or group the same permissions as the Server Admin in the previous release of [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)]. The Super User permission can be assigned to multiple users and groups. In the previous release, the user who originally installed [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] was the server admin, and it was difficult to transfer this permission to another user or a group. For more information, see [Functional Area Permissions (Master Data Services)](../../Topics/TopicNameNotContainA/Functional-Area-Permissions--Master-Data-Services-.md).  
  
 A user can now explicitly be assigned the Admin permission at the model level. This means that if the user is later assigned permissions in the model subtree, such as the entity level, he will not lose this Admin permission.  
  
 In this release of [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], we’re providing more levels of permissions by introducing the following new permissions: Read, Create, Update and Delete. For example, a user that has only the Update permission can now update the master data without creating or deleting the data. When you give a user the Create, Update or Delete permission, the user is automatically assigned the Read permission. You can also combine the Read, Create, Update and Delete permissions.  
  
 When you upgrade to [!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)][!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], old permissions are converted to new permissions as shown in the following table.  
  
|Permission in previous release|New permission|  
|------------------------------------|--------------------|  
|User who originally installs [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] has the Server Admin permission.|User has the Super User function permission|  
|User has Update permissions at the model level and no permissions in the model subtree, and so is implicitly a model admin.|User has explicit Admin permissions at the model level.|  
|User has Read-only permissions.|User has Read access permissions.|  
|User has Update permissions.|User has all four access permissions: Create, Update, Delete, and Read.|  
|User has Deny permissions|User has Deny permissions|  
  
 For more information about permissions, see [Security (Master Data Services)](../../Topics/TopicNameNotContainA/Security--Master-Data-Services-.md).  
  
 **[CTP 2.0]**  
 **Transaction Log Maintenance**  
  
 You can now clean transaction logs at pre-determined intervals or on a schedule, using the System settings and at the model level. For a MDS system with lot of data changes and ETL processes these tables can grow exponentially and lead to performance degradation and storage space issues.  
  
 The following types of data can be removed from the logs.  
  
-   Transaction history older than a specified number of days.  
  
-   Validation issues history older than a specified number of days.  
  
-   Staging batches that ran before a specified number of days.  
  
 You can configure the frequency that data is removed from the transaction logs, using the System settings and at the model level. For more information, see [System Settings (Master Data Services)](../../Topics/TopicNameNotContainA/System-Settings--Master-Data-Services-.md)and [Create a Model (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Model--Master-Data-Services-.md). For more information about transactions, see [Transactions (Master Data Services)](../../Topics/TopicNameNotContainA/Transactions--Master-Data-Services-.md).  
  
 The SQL Server Agent job, MDS_MDM_Sample_Log_Maintenace, triggers cleanup of the transaction logs and runs every night. You can use SQL Server Agent to modify the schedule for this job.  
  
 You can also call stored procedures to clean the transaction logs. For more information, see [Transactions (Master Data Services)](../../Topics/TopicNameNotContainA/Transactions--Master-Data-Services-.md).  
  
 **[CTP 2.0]**  
 **Improved Troubleshooting**  
  
 In [!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)][!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], features have been added to improve debugging and make it easier to troubleshoot issues. For more information, see [Tracing (Master Data Services)](../../Topics/TopicNameNotContainA/Tracing--Master-Data-Services-.md).  
  
 **[CTP 2.0]**  
 **Improved Manageability**  
  
 Improvements in manageability help to lower maintenance costs and positively impact your return on investment (ROI). These improvements include transaction log maintenance and improvements to security, as well as the following new features.  
  
-   Using attribute names that are longer than 50 characters.  
  
-   Renaming and hiding Name and Code attributes.  
  
 For more information, see the following topics.  
  
-   [Models (Master Data Services)](../../Topics/TopicNameNotContainA/Models--Master-Data-Services-.md)  
  
-   [Entities (Master Data Services)](../../Topics/TopicNameNotContainA/Entities--Master-Data-Services-.md)  
  
-   [Transactions (Master Data Services)](../../Topics/TopicNameNotContainA/Transactions--Master-Data-Services-.md)  
  
-   [Security (Master Data Services)](../../Topics/TopicNameNotContainA/Security--Master-Data-Services-.md)  
  
 **[CTP 2.2] Custom Indexes**  
  
 You can create a non-clustered index on one attribute (single index) or on a list of attributes (composite index), in an entity, to help improve the query performance. For more information, see [Custom Index (Master Data Services)](../../Topics/TopicNameNotContainA/Custom-Index--Master-Data-Services-.md).  
  
 **[CTP 2.2] Entity Sync Relationship**  
  
 You can share entity data between different models by creating an entity sync relationship. For more information, see [Entity Sync Relationship (Master Data Services)](../../Topics/TopicNameNotContainA/Entity-Sync-Relationship--Master-Data-Services-.md).  
  
 **[CTP 2.2] Member Revision History**  
  
 A member revision history is recorded when a member is changed. You can rollback a revision history, as well as view and annotate revisions. Using the **Log Retention Days** property, you can specify how long historical data is retained. For more information, see [Member Revision History (Master Data Services)](../../Topics/TopicNameNotContainA/Member-Revision-History--Master-Data-Services-.md).  
  
 **[CTP 2.3] Manage Business Rules (MDS Add-in for Excel)**  
  
 In the Master Data Services Add-in for Excel you can manage Business Rules, such as creating and editing business rules. Business rules are used to validate data.  
  
 **[CTP 2.3] Many-to-Many Relationships in Derived Hierarchies**  
  
 You can now create a Derived Hierarchy that displays  many-to-many relationships. A many-to-many relationship between two entities may be modeled through the use of a third entity that provides a mapping between them. The mapping entity is an entity that has two or more domain-based attributes referencing other entities.  
  
 For example, entity M has a domain-based attribute that references A and a domain-based attribute that references B. You can create a hierarchy from A to B using the mapping entity.  
  
 For more information, see [Show Many-to-Many Relationships in Derived Hierarchies (Master Data Services)](../../Topics/TopicNameNotContainA/Show-Many-to-Many-Relationships-in-Derived-Hierarchies--Master-Data-Services-.md)  
  
 **[CTP 2.3] Merge Conflicts**  
  
 If you try to publish data that has been changed by another user, the publish will fail with a conflict error. To resolve this error, you can perform merge conflicts and republish the changes. For more information, see [Merge Conflicts (Master Data Services)](../../Topics/TopicNameNotContainA/Merge-Conflicts--Master-Data-Services-.md) and [Merge Conflicts (MDS Add-in for Excel)](../../Topics/TopicNameNotContainA/Merge-Conflicts--MDS-Add-in-for-Excel-.md).  
  
 **[CTP 2.4] Business Rules Extension**  
  
 You can apply user-defined SQL scripts as an extension of business rule conditions and actions. SQL functions can be used as a condition. SQL stored procedures can be used as an action. For more information, see [Business Rules Extension (Master Data Services)](../../Topics/TopicNameNotContainA/Business-Rules-Extension--Master-Data-Services-.md).  
  
 **[CTP 3.0] Attribute Filters**  
  
 For a domain-based attribute, for a leaf member, you can use a filter parent attribute to constrain the allowed values for the domain-based attribute. For more information, see [Create a Domain-Based Attribute (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Domain-Based-Attribute--Master-Data-Services-.md).  
  
 **[CTP 3.0] Change Sets**  
  
 You can use change sets to save pending changes to an entity, and you can view and modify pending changes. If the entity requires approval for changes, you must save the pending changes into a change set and submit for approval by the administrator. For more information, see [Changesets (Master Data Services)](../../Topics/TopicNameNotContainA/Changesets--Master-Data-Services-.md).  
  
 **[CTP 3.2] Purge Soft Deleted Members**  
  
 You can now purge (permanently delete) all soft-deleted members in a model version. Deleting a member only deactivates, or soft-deletes, the member. For more information, see [Purge Version Members (Master Data Services)](../../Topics/TopicNameNotContainA/Purge-Version-Members--Master-Data-Services-.md).  
  
 **[CTP 3.2] Change Set Email and Management**  
  
 In this release, you can now view and manage all changes by model and version. You can  also receive email notifications each time a change set status changes for an entity that requires approval. For more information, see [Manage Changesets (Master Data Services)](../../Topics/TopicNameNotContainA/Manage-Changesets--Master-Data-Services-.md) and [Notifications (Master Data Services)](../../Topics/TopicNameNotContainA/Notifications--Master-Data-Services-.md).  
  
 **[CTP 3.2] Edit Many-to-Many Relationships in Derived Hierarchies**  
  
 You can edit the many-to-many relationship by modifying the mapping entity members. For more information, see [Show Many-to-Many Relationships in Derived Hierarchies (Master Data Services)](../../Topics/TopicNameNotContainA/Show-Many-to-Many-Relationships-in-Derived-Hierarchies--Master-Data-Services-.md).  
  
 **[CTP 3.2] View and Manage Revision History**  
  
 You can view and manage revision history, by entity and by member. If you have update permissions, you can roll back a member to a previous version. For more information, see [Member Revision History (Master Data Services)](../../Topics/TopicNameNotContainA/Member-Revision-History--Master-Data-Services-.md).  
  
 **[CTP 3.3] Save or Open Query Files in MDS Add-in for Excel**  
  
 From the Entity Explorer page, you can click **Excel** to save the shortcut query files. Or you can open the query file stored on your computer, in the MDS Add-in for Excel. The saved file can be opened using QueryOpener application. For more information, see [Shortcut Query Files (MDS Add-in for Excel)](../../Topics/TopicNameNotContainA/Shortcut-Query-Files--MDS-Add-in-for-Excel-.md).  
  
 The query file contains the filters and hierarchy information from the explorer page.  
  
 **[CTP 3.3]  Business Rule Management Experience Redesigned**  
  
 The business rule management experience in MDS has been completely redesigned to improve the experience. For more information about this feature, see [Business Rules (Master Data Services)](../../Topics/TopicNameNotContainA/Business-Rules--Master-Data-Services-.md).  
  
 **[CTP 3.3]  Business Rule Management Functionality Removed from the MDS Add-in for Excel**  
  
 Business Rule management functionality has been removed from the MDS Add-in for Excel because we redesigned the experience.  
  
 **[RC0] Derived Hierarchy Management Experience Improved**  
  
 The derived hierarchy management experience in MDS has been improved. For more information about this feature, see [Create a Derived Hierarchy (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Derived-Hierarchy--Master-Data-Services-.md).  
  
 Business Rule management functionality has been removed from the MDS Add-in for Excel because we redesigned the experience.  
  
 **[RC1] New Business Rule Conditions**  
  
 Seven new business rule conditions were added to provide a complete set of conditions. For more information, see [Business Rule Conditions (Master Data Services)](../../Topics/TopicNameNotContainA/Business-Rule-Conditions--Master-Data-Services-.md).  
  
 **[RC1] Sample Model Deployment Packages Updated**  
  
 The sample packages were updated to support new scenarios. For more information, see [Samples: Model Deployment Packages (Master Data Services)](../Topic/Samples:%20Model%20Deployment%20Packages%20\(Master%20Data%20Services\).md).  
  
## See Also  
 [Features Supported by the Editions of SQL Server 2016](../../Topics/TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md)   
 [Deprecated Master Data Services Features](../../Topics/TopicNameNotContainA/Deprecated-Master-Data-Services-Features.md)   
 [Discontinued Master Data Services Features](../../Topics/TopicNameNotContainA/Discontinued-Master-Data-Services-Features.md)