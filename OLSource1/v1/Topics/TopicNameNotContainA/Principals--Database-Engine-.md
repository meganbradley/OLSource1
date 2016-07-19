---
title: Principals (Database Engine)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3f7adbf7-6e40-4396-a8ca-71cbb843b5c2
manager: jhubbard
---
# Principals (Database Engine)
*Principals* are entities that can request [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] resources. Like other components of the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] authorization model, principals can be arranged in a hierarchy. The scope of influence of a principal depends on the scope of the definition of the principal: Windows, server, database; and whether the principal is indivisible or a collection. A Windows Login is an example of an indivisible principal, and a Windows Group is an example of a principal that is a collection. Every principal has a security identifier (SID).  
  
 **Windows-level principals**  
  
-   Windows Domain Login  
  
-   Windows Local Login  
  
 **SQL Server**-**level** **principals**  
  
-   [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Login  
  
-   Server Role  
  
 **Database-level principals**  
  
-   Database User  
  
-   Database Role  
  
-   Application Role  
  
## The SQL Server sa Login  
 The [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] sa log in is a server-level principal. By default, it is created when an instance is installed. Beginning in [!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)], the default database of sa is master. This is a change of behavior from earlier versions of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
## public Database Role  
 Every database user belongs to the public database role. When a user has not been granted or denied specific permissions on a securable, the user inherits the permissions granted to public on that securable.  
  
## INFORMATION_SCHEMA and sys  
 Every database includes two entities that appear as users in catalog views: INFORMATION_SCHEMA and sys. These entities are required by [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. They are not principals, and they cannot be modified or dropped.  
  
## Certificate-based SQL Server Logins  
 Server principals with names enclosed by double hash marks (##) are for internal system use only. The following principals are created from certificates when [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] is installed, and should not be deleted.  
  
-   \##MS_SQLResourceSigningCertificate##  
  
-   \##MS_SQLReplicationSigningCertificate##  
  
-   \##MS_SQLAuthenticatorCertificate##  
  
-   \##MS_AgentSigningCertificate##  
  
-   \##MS_PolicyEventProcessingLogin##  
  
-   \##MS_PolicySigningCertificate##  
  
-   \##MS_PolicyTsqlExecutionLogin##  
  
## The guest User  
 Each database includes a **guest**. Permissions granted to the **guest** user are inherited by users who have access to the database, but who do not have a user account in the database. The **guest** user cannot be dropped, but it can be disabled by revoking it's **CONNECT** permission. The **CONNECT** permission can be revoked by executing `REVOKE CONNECT FROM GUEST` within any database other than master or tempdb.  
  
## Client and Database Server  
 By definition, a client and a database server are security principals and can be secured. These entities can be mutually authenticated before a secure network connection is established. [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] supports the [Kerberos](http://go.microsoft.com/fwlink/?LinkId=100758) authentication protocol, which defines how clients interact with a network authentication service.  
  
## Related Tasks  
 For information about designing a permissions system, see [Getting Started with Database Engine Permissions](../../Topics/TopicNameNotContainA/Getting-Started-with-Database-Engine-Permissions.md).  
  
 The following topics are included in this section of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Books Online:  
  
-   [Managing Logins, Users, and Schemas How-to Topics](../../Topics/TopicNameNotContainA/Managing-Logins--Users--and-Schemas-How-to-Topics.md)  
  
-   [Server-Level Roles](../../Topics/TopicNameNotContainA/Server-Level-Roles.md)  
  
-   [Database-Level Roles](../../Topics/TopicNameNotContainA/Database-Level-Roles.md)  
  
-   [Application Roles](../../Topics/TopicNameNotContainA/Application-Roles.md)  
  
## See Also  
 [Securing SQL Server](../../Topics/TopicNameNotContainA/Securing-SQL-Server.md)   
 [sys.database_principals (Transact-SQL)](assetId:///8cb239e9-eb8c-4109-9cec-0d35de95fa0e)   
 [sys.server_principals (Transact-SQL)](assetId:///c5dbe0d8-a1c8-4dc4-b9b1-22af20effd37)   
 [sys.sql_logins (Transact-SQL)](assetId:///0d9c5b09-86fe-40ff-baab-00b7c051402f)   
 [sys.database_role_members (Transact-SQL)](assetId:///ed1b019d-ca48-4db3-85df-cf6d2db591cf)   
 [Server-Level Roles](../../Topics/TopicNameNotContainA/Server-Level-Roles.md)   
 [Database-Level Roles](../../Topics/TopicNameNotContainA/Database-Level-Roles.md)