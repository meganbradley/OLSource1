---
title: Migrate to a Partially Contained Database
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 90faac38-f79e-496d-b589-e8b2fe01c562
manager: jhubbard
---
# Migrate to a Partially Contained Database
This topic discusses how to prepare to change to the partially contained database model and then provides the migration steps.  
  
 **In this topic:**  
  
-   [Preparing to Migrate a Database](#prepare)  
  
-   [Enable Partially Contained Databases](#enable)  
  
-   [Converting a Database to Partially contained](#convert)  
  
-   [Migrating Users to Contained Database Users](#users)  
  
##  <a name="prepare"></a> Preparing to Migrate a Database  
 Review the following items when considering migrating a database to the partially contained database model.  
  
-   You should understand the partially contained database model. For more information, see [Contained Databases](../../Topics/TopicNameNotContainA/Contained-Databases.md).  
  
-   You should understand risks that are unique to partially contained databases. For more information, see [Security Best Practices with Contained Databases](../../Topics/TopicNameNotContainA/Security-Best-Practices-with-Contained-Databases.md).  
  
-   Contained databases do not support replication, change data capture, or change tracking. Confirm the database does not use these features.  
  
-   Review the list of database features that are modified for partially contained databases. For more information, see [Modified Features (Contained Database)](../../Topics/TopicNameNotContainA/Modified-Features--Contained-Database-.md).  
  
-   Query [sys.dm_db_uncontained_entities](assetId:///f417efd4-8c71-4f81-bc9c-af13bb4b88ad) to find uncontained objects or features in the database. For more information, see.  
  
-   Monitor the **database_uncontained_usage** XEvent to see when uncontained features are used.  
  
##  <a name="enable"></a> Enable Contained Databases  
 Contained databases must be enabled on the instance of [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)], before contained databases can be created.  
  
### Enabling Contained Databases Using Transact-SQL  
 The following example enables contained databases on the instance of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)].  
  
```tsql  
sp_configure 'contained database authentication', 1;  
GO  
RECONFIGURE ;  
GO  
```  
  
#### Enabling Contained Databases Using Management Studio  
 The following example enables contained databases on the instance of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)].  
  
1.  In Object Explorer, right-click the server name, and then click **Properties**.  
  
2.  On the **Advanced** page, in the **Containment** section, set the **Enable Contained Databases** option to **True**.  
  
3.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
##  <a name="convert"></a> Converting a Database to Partially Contained  
 A database is converted to a contained database by changing the **CONTAINMENT** option.  
  
### Converting a Database to Partially Contained Using Transact-SQL  
 The following example converts a database named `Accounting` to a partially contained database.  
  
```tsql  
USE [master]  
GO  
ALTER DATABASE [Accounting] SET CONTAINMENT = PARTIAL  
GO  
```  
  
### Converting a Database to Partially contained Using Management Studio  
 The following example converts a database to a partially contained database.  
  
1.  In Object Explorer, expand **Databases**, right-click the database to be converted, and then click **Properties**.  
  
2.  On the **Options** page, change the **Containment type** option to **Partial**.  
  
3.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
##  <a name="users"></a> Migrating Users to Contained Database Users  
 The following example migrates all users that are based on [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] logins to contained database users with passwords. The example excludes logins that are not enabled. The example must be executed in the contained database.  
  
```tsql  
DECLARE @username sysname ;  
DECLARE user_cursor CURSOR  
    FOR   
        SELECT dp.name   
        FROM sys.database_principals AS dp  
        JOIN sys.server_principals AS sp   
        ON dp.sid = sp.sid  
        WHERE dp.authentication_type = 1 AND sp.is_disabled = 0;  
OPEN user_cursor  
FETCH NEXT FROM user_cursor INTO @username  
    WHILE @@FETCH_STATUS = 0  
    BEGIN  
        EXECUTE sp_migrate_user_to_contained   
        @username = @username,  
        @rename = N'keep_name',  
        @disablelogin = N'disable_login';  
    FETCH NEXT FROM user_cursor INTO @username  
    END  
CLOSE user_cursor ;  
DEALLOCATE user_cursor ;  
```  
  
## See Also  
 [Contained Databases](../../Topics/TopicNameNotContainA/Contained-Databases.md)   
 [sp_migrate_user_to_contained (Transact-SQL)](assetId:///b3a49ff6-46ad-4ee7-b6fe-7e54213dc33e)   
 [sys.dm_db_uncontained_entities](assetId:///f417efd4-8c71-4f81-bc9c-af13bb4b88ad)