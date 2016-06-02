---
title: Metadata Visibility Configuration
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 50d2e015-05ae-4014-a1cd-4de7866ad651
---
# Metadata Visibility Configuration
  The visibility of metadata is limited to securables that a user either owns or on which the user has been granted some permission. For example, the following query returns a row if the user has been granted a permission such as SELECT or INSERT on the table `myTable`.  
  
```  
SELECT name, object_id  
FROM sys.tables  
WHERE name = 'myTable';  
GO  
```  
  
 However, if the user does not have any permission on `myTable`, the query returns an empty result set.  
  
## Scope and Impact of Metadata Visibility Configuration  
 Metadata visibility configuration only applies to the following securables.  
  
|||  
|-|-|  
|Catalog views|[!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] **sp\_help** stored procedures|  
|Metadata exposing built\-in functions|Information schema views|  
|Compatibility views|Extended properties|  
  
 Metadata visibility configuration does not apply to the following securables.  
  
|||  
|-|-|  
|Log shipping system tables|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Agent system tables|  
|Database maintenance plan system tables|Backup system tables|  
|Replication system tables|Replication and [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Agent **sp\_help** stored procedures|  
  
 Limited metadata accessibility means the following:  
  
-   Applications that assume **public** metadata access will break.  
  
-   Queries on system views might only return a subset of rows, or sometimes an empty result set.  
  
-   Metadata\-emitting, built\-in functions such as OBJECTPROPERTYEX may return NULL.  
  
-   The [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] **sp\_help** stored procedures might return only a subset of rows, or NULL.  
  
 SQL modules, such as stored procedures and triggers, run under the security context of the caller and, therefore, have limited metadata accessibility. For example, in the following code, when the stored procedure tries to access metadata for the table `myTable` on which the caller has no rights, an empty result set is returned. In earlier releases of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], a row is returned.  
  
```  
CREATE PROCEDURE assumes_caller_can_access_metadata  
BEGIN  
SELECT name, id   
FROM sysobjects   
WHERE name = 'myTable';  
END;  
GO  
```  
  
 To allow callers to view metadata, you can grant the callers VIEW DEFINITION permission at an appropriate scope: object level, database level or server level. Therefore, in the previous example, if the caller has VIEW DEFINITION permission on `myTable`, the stored procedure returns a row. For more information, see [GRANT &#40;Transact-SQL&#41;](../Topic/GRANT%20\(Transact-SQL\).md) and [GRANT Database Permissions &#40;Transact-SQL&#41;](../Topic/GRANT%20Database%20Permissions%20\(Transact-SQL\).md).  
  
 You can also modify the stored procedure so that it executes under the credentials of the owner. When the procedure owner and the table owner are the same owner, ownership chaining applies, and the security context of the procedure owner enables access to the metadata for `myTable`. Under this scenario, the following code returns a row of metadata to the caller.  
  
> [!NOTE]  
>  The following example uses the [sys.objects](../Topic/sys.objects%20\(Transact-SQL\).md) catalog view instead of the [sys.sysobjects](../Topic/sys.sysobjects%20\(Transact-SQL\).md) compatibility view.  
  
```  
CREATE PROCEDURE does_not_assume_caller_can_access_metadata  
WITH EXECUTE AS OWNER  
AS  
BEGIN  
SELECT name, id  
FROM sys.objects   
WHERE name = 'myTable'   
END;  
GO  
```  
  
> [!NOTE]  
>  You can use EXECUTE AS to temporarily switch to the security context of the caller. For more information, see [EXECUTE AS &#40;Transact-SQL&#41;](../Topic/EXECUTE%20AS%20\(Transact-SQL\).md).  
  
## Benefits and Limits of Metadata Visibility Configuration  
 Metadata visibility configuration can play an important role in your overall security plan. However, there are cases in which a skilled and determined user can force the disclosure of some metadata. We recommend that you deploy metadata permissions as one of many defenses\-in\-depth.  
  
 It is theoretically possible to force the emission of metadata in error messages by manipulating the order of predicate evaluation in queries. The possibility of such *trial\-and\-error attacks* is not specific to [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. It is implied by the associative and commutative transformations permitted in relational algebra. You can mitigate this risk by limiting the information returned in error messages. To further restrict the visibility of metadata in this way, you can start the server with trace flag 3625. This trace flag limits the amount of information shown in error messages. In turn, this helps to prevent forced disclosures. The tradeoff is that error messages will be terse and might be difficult to use for debugging purposes. For more information, see [Database Engine Service Startup Options](../../Topics\TopicNameNotContainA/Database-Engine-Service-Startup-Options.md) and [Trace Flags &#40;Transact-SQL&#41;](../Topic/Trace%20Flags%20\(Transact-SQL\).md).  
  
 The following metadata is not subject to forced disclosure:  
  
-   The value stored in the **provider\_string** column of **sys.servers**. A user that does not have ALTER ANY LINKED SERVER permission will see a NULL value in this column.  
  
-   Source definition of a user\-defined object such as a stored procedure or trigger. The source code is visible only when one of the following is true:  
  
    -   The user has VIEW DEFINITION permission on the object.  
  
    -   The user has not been denied VIEW DEFINITION permission on the object and has CONTROL, ALTER, or TAKE OWNERSHIP permission on the object. All other users will see NULL.  
  
-   The definition columns found in the following catalog views:  
  
    |||  
    |-|-|  
    |**sys.all\_sql\_modules**|**sys.sql\_modules**|  
    |**sys.server\_sql\_modules**|**sys.check\_constraints**|  
    |**sys.default\_constraints**|**sys.computed\_columns**|  
    |**sys.numbered\_procedures**||  
  
-   The **ctext** column in the **syscomments** compatibility view.  
  
-   The output of the **sp\_helptext** procedure.  
  
-   The following columns in the information schema views:  
  
    |||  
    |-|-|  
    |INFORMATION\_SCHEMA.CHECK\_CONSTRAINTS.CHECK\_CLAUSE|INFORMATION\_SCHEMA.COLUMNS.COLUMN\_DEFAULT|  
    |INFORMATION\_SCHEMA.DOMAINS.DOMAIN\_DEFAULT|INFORMATION\_SCHEMA.ROUTINE\_COLUMNS.COLUMN\_DEFAULT|  
    |INFORMATION\_SCHEMA.ROUTINES.ROUTINE\_DEFINITION|INFORMATION\_SCHEMA.VIEWS.VIEW\_DEFINITION|  
  
-   OBJECT\_DEFINITION\(\) function  
  
-   The value stored in the password\_hash column of **sys.sql\_logins**.  A user that does not have CONTROL SERVER permission will see a NULL value in this column.  
  
> [!NOTE]  
>  The SQL definitions of built\-in system procedures and functions are publicly visible through the **sys.system\_sql\_modules** catalog view, the **sp\_helptext** stored procedure, and the OBJECT\_DEFINITION\(\) function.  
  
## General Principles of Metadata Visibility  
 The following are some general principles to consider regarding metadata visibility:  
  
-   Fixed roles implicit permissions  
  
-   Scope of permissions  
  
-   Precedence of DENY  
  
-   Visibility of subcomponent metadata  
  
### Fixed Roles and Implicit Permissions  
 Metadata that can be accessed by fixed roles depends upon their corresponding implicit permissions.  
  
### Scope of Permissions  
 Permissions at one scope imply the ability to see metadata at that scope and at all enclosed scopes. For example, SELECT permission on a schema implies that the grantee has SELECT permission on all securables that are contained by that schema. The granting of SELECT permission on a schema therefore enables a user to see the metadata of the schema and also all tables, views, functions, procedures, queues, synonyms, types, and XML schema collections within it. For more information about scopes, see [Permissions Hierarchy &#40;Database Engine&#41;](../Topic/Permissions%20Hierarchy%20\(Database%20Engine\).md).  
  
### Precedence of DENY  
 DENY typically takes precedence over other permissions. For example, if a database user is granted EXECUTE permission on a schema but has been denied EXECUTE permission on a stored procedure in that schema, the user cannot view the metadata for that stored procedure.  
  
 Additionally, if a user is denied EXECUTE permission on a schema but has been granted EXECUTE permission on a stored procedure in that schema, the user cannot view the metadata for that stored procedure.  
  
 For another example, if a user has been granted and denied EXECUTE permission on a stored procedure, which is possible through your various role memberships, DENY takes precedence and the user cannot view the metadata of the stored procedure.  
  
### Visibility of Subcomponent Metadata  
 The visibility of subcomponents, such as indexes, check constraints, and triggers is determined by permissions on the parent. These subcomponents do not have grantable permissions. For example, if a user has been granted some permission on a table, the user can view the metadata for the tables, columns, indexes, check constraints, triggers, and other such subcomponents.  
  
#### Metadata That Is Accessible to All Database Users  
 Some metadata must be accessible to all users in a specific database. For example, filegroups do not have conferrable permissions; therefore, a user cannot be granted permission to view the metadata of a filegroup. However, any user that can create a table must be able to access filegroup metadata to use the ON *filegroup* or TEXTIMAGE\_ON *filegroup* clauses of the CREATE TABLE statement.  
  
 The metadata that is returned by the DB\_ID\(\) and DB\_NAME\(\) functions is visible to all users.  
  
 The following table lists the catalog views that are visible to the **public** role.  
  
|||  
|-|-|  
|**sys.partition\_functions**|**sys.partition\_range\_values**|  
|**sys.partition\_schemes**|**sys.data\_spaces**|  
|**sys.filegroups**|**sys.destination\_data\_spaces**|  
|**sys.database\_files**|**sys.allocation\_units**|  
|**sys.partitions**|**sys.messages**|  
|**sys.schemas**|**sys.configurations**|  
|**sys.sql\_dependencies**|**sys.type\_assembly\_usages**|  
|**sys.parameter\_type\_usages**|**sys.column\_type\_usages**|  
  
## See Also  
 [GRANT &#40;Transact-SQL&#41;](../Topic/GRANT%20\(Transact-SQL\).md)   
 [DENY &#40;Transact-SQL&#41;](../Topic/DENY%20\(Transact-SQL\).md)   
 [REVOKE &#40;Transact-SQL&#41;](../Topic/REVOKE%20\(Transact-SQL\).md)   
 [EXECUTE AS Clause &#40;Transact-SQL&#41;](../Topic/EXECUTE%20AS%20Clause%20\(Transact-SQL\).md)   
 [Catalog Views &#40;Transact-SQL&#41;](../Topic/Catalog%20Views%20\(Transact-SQL\).md)   
 [Compatibility Views &#40;Transact-SQL&#41;](../Topic/Compatibility%20Views%20\(Transact-SQL\).md)  
  
  