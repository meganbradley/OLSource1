---
title: Configure the default full-text language Server Configuration Option
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0fa8785b-0830-4a52-aff5-fcf8268b72fc
manager: jhubbard
---
# Configure the default full-text language Server Configuration Option
This topic describes how to configure the **default full-text language** server configuration option in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)]. The **default full-text language** option specifies a default language value for full-text indexes. Linguistic analysis is performed on all data that is full-text indexed and is dependent on the language of the data. The default value of this option is the language of the server. For a localized version of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Setup sets the **default full-text language** option to the language of the server if an appropriate match exists. For a non-localized version of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], the **default full-text language** option is English.  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
     [Recommendations](#Recommendations)  
  
     [Security](#Security)  
  
-   **To configure the default full-text language option, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
-   **Follow Up:**  [After you configure the default full-text language option](#FollowUp)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   The value of the **default full-text language** option is used in a full-text index when no language is specified for a column through the LANGUAGE **language_term** option in the CREATE FULLTEXT INDEX or ALTER FULLTEXT INDEX statements. If the default full-text language is not supported or the linguistic analysis package is not available, the CREATE or ALTER operation will fail and [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] will return an error message stating that the language specified is not valid.  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   This option is an advanced option and should be changed only by an experienced database administrator or certified [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] technician.  
  
-   The **default full-text language** option requires an LCID value. For a list of supported LCIDs and their related languages, see [sys.fulltext_languages (Transact-SQL)](assetId:///2ed6b53d-1cf2-4763-9d58-36ea24a610ef). Other languages may also be available from independent software vendors, for example. If no specific language dialect is found, the Full-Text Engine will automatically switch to the primary language.  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 Execute permissions on **sp_configure** with no parameters or with only the first parameter are granted to all users by default. To execute **sp_configure** with both parameters to change a configuration option or to run the RECONFIGURE statement, a user must be granted the ALTER SETTINGS server-level permission. The ALTER SETTINGS permission is implicitly held by the **sysadmin** and **serveradmin** fixed server roles.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To configure the default full-text language option  
  
1.  In Object Explorer, right-click a server and select **Properties**.  
  
2.  Click the **Advanced** node.  
  
3.  Under Miscellaneous, use **Default Full Text Language** to specify a default language value for full-text indexed columns.  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
  
#### To configure the default full-text language option  
  
1.  Connect to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example shows how to use [sp_configure](assetId:///d18b251d-b37a-4f5f-b50c-502d689594c8) to set the value of the `default full-text` option to Dutch (`1043`).  
  
```tsql  
USE AdventureWorks2012 ;  
GO  
EXEC sp_configure 'show advanced options', 1 ;  
GO  
RECONFIGURE  
GO  
EXEC sp_configure 'default full-text language', 1043 ;  
GO  
RECONFIGURE  
GO  
  
```  
  
 For more information, see [Server Configuration Options (SQL Server)](../../Topics/TopicNameNotContainA/Server-Configuration-Options--SQL-Server-.md).  
  
##  <a name="FollowUp"></a> Follow Up: After you configure the default full-text language option  
 The setting takes effect immediately without restarting the server.  
  
## See Also  
 [sys.fulltext_languages (Transact-SQL)](assetId:///2ed6b53d-1cf2-4763-9d58-36ea24a610ef)   
 [RECONFIGURE (Transact-SQL)](assetId:///2e6e4eeb-b70b-4f45-a253-28ac4e595d75)   
 [Server Configuration Options (SQL Server)](../../Topics/TopicNameNotContainA/Server-Configuration-Options--SQL-Server-.md)   
 [sp_configure (Transact-SQL)](assetId:///d18b251d-b37a-4f5f-b50c-502d689594c8)   
 [CREATE FULLTEXT INDEX (Transact-SQL)](assetId:///8b80390f-5f8b-4e66-9bcc-cabd653c19fd)   
 [ALTER FULLTEXT INDEX (Transact-SQL)](assetId:///b6fbe9e6-3033-4d1b-b6bf-1437baeefec3)