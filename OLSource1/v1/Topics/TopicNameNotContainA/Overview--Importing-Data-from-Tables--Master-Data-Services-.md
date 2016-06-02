---
title: Overview: Importing Data from Tables (Master Data Services)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 181d1e22-379c-45d1-b03c-e1e22ff14164
---
# Overview: Importing Data from Tables (Master Data Services)
  Once you've created a model for your data in [!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)], you can start adding data and make changes to data.   You use [!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)] staging tables, stored procedures and Master Data Manager .  
  
 For instructions on how to add and modify data, see [Import Data from Tables &#40;Master Data Services&#41;](../Topic/Import%20Data%20from%20Tables%20\(Master%20Data%20Services\).md).  
  
> [!NOTE]  
>  You can also use the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)][!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)][!INCLUDE[ssMDSXLS](../../Token\Other/ssMDSXLS_md.md)], to add data to the MDS repository \([!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)] database\) from Excel. For more information, see [Overview: Importing Data from Excel &#40;MDS Add-in for Excel&#41;](../Topic/Overview:%20Importing%20Data%20from%20Excel%20\(MDS%20Add-in%20for%20Excel\).md).  
  
 When you add and modify data, you can do the following.  
  
-   Load and update members, and update attribute values  
  
-   Deactivate and delete members  
  
-   Move explicit hierarchy members  
  
 Adding and updating data  includes the following main tasks.  
  
1.  Load data into the staging tables in the [!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)] database.  
  
2.  Load the data from the staging tables into the appropriate [!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)] tables.  
  
     You use staging stored procedures or [!INCLUDE[ssMDSmdm](../../Token\Other/ssMDSmdm_md.md)] to load the data.  
  
> [!NOTE]  
>  In [!INCLUDE[ssSQL15](../../Token\Other/ssSQL15_md.md)], support for the [!INCLUDE[ssKilimanjaro](../../Token\Other/ssKilimanjaro_md.md)] staging processes is deprecated.  
  
## Deactivating and Deleting Members \(MDS\)  
 Deactivating means the member can be reactivated. If you reactivate a member, its attributes and its membership in hierarchies and collections are restored. All previous transactions are intact. Deactivation transactions are visible to administrators in the **Version Management** functional area of the Master Data Manager.  
  
 Deleting means purging the member from the system permanently. All transactions for the member, all relationships, and all attributes are permanently deleted.  
  
> [!NOTE]  
>  You cannot use staging to reactivate members. You must do it manually in the Master Data Manager. For more information, see [Reactivate a Member or Collection &#40;Master Data Services&#41;](../Topic/Reactivate%20a%20Member%20or%20Collection%20\(Master%20Data%20Services\).md).  
>   
>  You cannot use staging to delete or deactivate collections. For more information on manually deactivating collections, see [Delete a Member or Collection &#40;Master Data Services&#41;](../Topic/Delete%20a%20Member%20or%20Collection%20\(Master%20Data%20Services\).md).  
  
## Moving explicit hierarchy members \(MDS\)  
 When you move the location of members in explicit hierarchies in bulk, you can designate the following.  
  
-   A consolidated member as a parent of a consolidated member.  
  
-   A consolidated member as a parent of a leaf member.  
  
-   A leaf member as a sibling of a leaf or consolidated member.  
  
-   A consolidated member as a sibling of a leaf or consolidated member.  
  
## Staging Tables and Stored Procedures \(MDS\)  
 The [!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)] database includes the following types of staging tables that you can populate with your  data.  
  
-   [Leaf Member Staging Table &#40;Master Data Services&#41;](../Topic/Leaf%20Member%20Staging%20Table%20\(Master%20Data%20Services\).md)  
  
-   [Consolidated Member Staging Table &#40;Master Data Services&#41;](../Topic/Consolidated%20Member%20Staging%20Table%20\(Master%20Data%20Services\).md)  
  
-   [Relationship Staging Table &#40;Master Data Services&#41;](../Topic/Relationship%20Staging%20Table%20\(Master%20Data%20Services\).md)  
  
 For each entity in the model, there is a staging table. The table name indicates the corresponding entity, and the entity type such as leaf member. The following image shows the staging tables for the currency, customer, and product entities.  
  
 ![Staging Tables in MDS database](../../Images\Image\ImageNotContaina/mds_Staging_Tables.png "mds_Staging_Tables")  
  
 The name of the  table is specified when an entity is created and cannot be changed. If the staging table name contains a \_1 or other number, another table of that name already existed when the entity was created.  
  
 The [!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)] includes the following types of staging stored procedures.  
  
-   stg.udp\_\<name\>\_Leaf  
  
-   stg.udp\_\<name\>\_Consolidated  
  
-   stg.udp\_\<name\>\_Relationship  
  
 For each entity in the model, there are three stored procedures that correspond to the leaf member, consolidated member, and relationship staging tables.  The following image shows the staging stored procedures for the currency, customer, and product entities.  
  
 ![Staging stored procedures in the MDS database](../../Images\Image\ImageNotContaina/mds_staging_storedProcedures.png "mds_staging_storedProcedures")  
  
 For more information on the stored procedures, see [Staging Stored Procedure &#40;Master Data Services&#41;](../Topic/Staging%20Stored%20Procedure%20\(Master%20Data%20Services\).md).  
  
## Logging Transactions \(MDS\)  
 All transactions that occur when data or relationships are imported or updated can be logged. An option in the stored procedure allows this logging. If you initiate the staging process using [!INCLUDE[ssMDSmdm](../../Token\Other/ssMDSmdm_md.md)], no logging occurs.  
  
 In [!INCLUDE[ssMDScfgmgr](../../Token\Other/ssMDScfgmgr_md.md)], the **Log staging transactions** setting does not apply to this method of staging data.  
  
## Related Content  
  
-   [Validation &#40;Master Data Services&#41;](../Topic/Validation%20\(Master%20Data%20Services\).md)  
  
-   [Business Rules &#40;Master Data Services&#41;](../Topic/Business%20Rules%20\(Master%20Data%20Services\).md)  
  
  