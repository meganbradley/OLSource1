---
title: "Security Center for SQL Server Database Engine and Azure SQL Database"
ms.custom: na
ms.date: 2016-05-03
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dfb39d16-722a-4734-94bb-98e61e014ee7
caps.latest.revision: 54
manager: jhubbard
---
# Security Center for SQL Server Database Engine and Azure SQL Database
This page provides links to help you locate the information that you need about security and protection in the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)] and [!INCLUDE[ssSDSfull](../../Topics/TopicNameContainA/includes/ssSDSfull_md.md)].  
  
 **Legend**  
  
 ![security&#45;center&#45;legend](../../Topics/TopicNameNotContainA/media/security-center-legend.PNG "security-center-legend")  
  
##  <a name="Who"></a> Authentication: Who are you?  
  
|||  
|-|-|  
|**Who Authenticates?**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Windows Authentication<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Authentication|Who Authenticates? (Windows or [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)])<br /><br /> [Choose an Authentication Mode](../../Topics/TopicNameNotContainA/Choose-an-Authentication-Mode.md)<br /><br /> [Connecting to SQL Database By Using Azure Active Directory Authentication](https://azure.microsoft.com/documentation/articles/sql-database-aad-authentication/)|  
|**Where Authenticated?**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") At master Database: Logins and DB Users<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") At User Database: Contained DB Users|Authenticate at the master database (Logins and database users)<br /><br /> [Create a SQL Server Login](../../Topics/TopicNameContainA/Create-a-Login.md)<br /><br /> [Managing Databases and Logins in Azure SQL Database](http://msdn.microsoft.com/library/ee336235.aspx)<br /><br /> [Create a Database User](../../Topics/TopicNameContainA/Create-a-Database-User.md)<br /><br /> <br /><br /> Authenticate at a user database<br /><br /> [Contained Database Users - Making Your Database Portable](../../Topics/TopicNameNotContainA/Contained-Database-Users---Making-Your-Database-Portable.md)|  
|**Using Other Identities**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Credentials<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") Execute as Another Login<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Execute as Another Database User|[Credentials (Database Engine)](../../Topics/TopicNameNotContainA/Credentials--Database-Engine-.md)<br /><br /> [Execute as Another Login](assetId:///613b8271-7f7d-4378-b7a2-5a7698551dbd)<br /><br /> [Execute as Another Database User](assetId:///613b8271-7f7d-4378-b7a2-5a7698551dbd)|  
  
##  <a name="What"></a> Authorization: What can you do?  
  
|||  
|-|-|  
|**Granting, Revoking, and Denying Permissions**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Securable Classes<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") Granular Server Permissions<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Granular Database Permissions|[Permissions Hierarchy (Database Engine)](../../Topics/TopicNameNotContainA/Permissions-Hierarchy--Database-Engine-.md)<br /><br /> [Permissions](../../Topics/TopicNameNotContainA/Permissions--Database-Engine-.md)<br /><br /> [Securables](../../Topics/TopicNameNotContainA/Securables.md)<br /><br /> [Getting Started with Database Engine Permissions](../../Topics/TopicNameNotContainA/Getting-Started-with-Database-Engine-Permissions.md)|  
|**Security by Roles**<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") Server Level Roles<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Database Level Roles|[Server-Level Roles](../../Topics/TopicNameNotContainA/Server-Level-Roles.md)<br /><br /> [Database-Level Roles](../../Topics/TopicNameNotContainA/Database-Level-Roles.md)|  
|**Restricting Data Access to Selected Data Elements**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Restrict Data Access With Views/Procedures<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Row-Level Security<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Dynamic Data Masking<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Signed Objects|Restrict Data Access Using [Views](../../Topics/TopicNameNotContainA/Views.md) and [Procedures](../../Topics/TopicNameNotContainA/Stored-Procedures--Database-Engine-.md)<br /><br /> [Row-Level Security (SQL Server)](../../Topics/TopicNameNotContainA/Row-Level-Security.md)<br /><br /> [Row-Level Security (Azure SQL Database)](http://msdn.microsoft.com/library/azure/dn765131.aspx)<br /><br /> [Dynamic Data Masking (SQL Server)](../../Topics/TopicNameNotContainA/Dynamic-Data-Masking.md)<br /><br /> [Dynamic Data Masking (Azure SQL Database)](http://azure.microsoft.com/documentation/articles/sql-database-dynamic-data-masking-get-started/)<br /><br /> [Signed Objects](assetId:///64d8b682-6ec1-4e5b-8aee-3ba11e72d21f)|  
  
##  <a name="Encrypt"></a> Encryption: Storing Secret Data  
  
|||  
|-|-|  
|**Encrypting Files**<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") BitLocker Encryption (Drive Level)<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") NTFS Encryption (Folder Level)<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Transparent Data Encryption (File Level)<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Backup Encryption (File Level)|[BitLocker (Drive Level)](http://support.microsoft.com/kb/2855131)<br /><br /> [NTFS Encryption (Folder Level)](http://msdn.microsoft.com/library/dd163562.aspx)<br /><br /> [Transparent Data Encryption (File Level)](../../Topics/TopicNameNotContainA/Transparent-Data-Encryption--TDE-.md)<br /><br /> [Backup Encryption (File Level)](../../Topics/TopicNameNotContainA/Backup-Encryption.md)|  
|**Encrypting Sources**<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") Extensible Key Management Module<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") Keys Stored in the Azure Key Vault<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Always Encrypted|[Extensible Key Management Module](../../Topics/TopicNameNotContainA/Extensible-Key-Management--EKM-.md)<br /><br /> [Keys Stored in the Azure Key Vault](../../Topics/TopicNameNotContainA/Extensible-Key-Management-Using-Azure-Key-Vault--SQL-Server-.md)<br /><br /> [Always Encrypted](../../Topics/TopicNameNotContainA/Always-Encrypted--Database-Engine-.md)|  
|**Column, Data, & Key Encryption**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Encrypt by Certificate<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Encrypt by Symmetric Key<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Encrypt by Asymmetric Key<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Encrypt by Passphrase|[Encrypt by Certificate](assetId:///ab66441f-e2d2-4e3a-bcae-bcc09e12f3c1)<br /><br /> [Encrypt by Asymmetric Key](assetId:///86bb2588-ab13-4db2-8f3c-42c9f572a67b)<br /><br /> [Encrypt by Symmetric Key](assetId:///0e11f8c5-f79d-46c1-ab11-b68ef05d6787)<br /><br /> [Encrypt by Passphrase](assetId:///f8dbb9e6-94d6-40d7-8b38-6833a409d597)<br /><br /> [Encrypt a Column of Data](../../Topics/TopicNameContainA/Encrypt-a-Column-of-Data.md)|  
  
##  <a name="Connect"></a> Connection Security: Restricting and Securing  
  
|||  
|-|-|  
|**Firewall Protection**<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") Windows Firewall Settings<br /><br /> ![security&#45;center&#45;sqldb](../../Topics/TopicNameNotContainA/media/security-center-sqldb.png "security-center-sqldb") Azure Service Firewall Settings<br /><br /> ![security&#45;center&#45;sqldb](../../Topics/TopicNameNotContainA/media/security-center-sqldb.png "security-center-sqldb") Database Firewall Settings|[Configure a Windows Firewall for Database Engine Access](../../Topics/TopicNameContainA/Configure-a-Windows-Firewall-for-Database-Engine-Access.md)<br /><br /> [Azure SQL Database Firewall Settings](assetId:///8f0506b6-a4ac-4e4d-91db-8077c40cb17a)<br /><br /> [Azure Service Firewall Settings](assetId:///a974a561-5382-4039-8499-3a56767bcefe)|  
|**Encrypting Data in Transit**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Forced SSL Connections<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") Optional SSL Connections|[Secure Sockets Layer for the Database Engine](../../Topics/TopicNameNotContainA/Enable-Encrypted-Connections-to-the-Database-Engine--SQL-Server-Configuration-Manager-.md)<br /><br /> [Secure Sockets Layer for SQL Database](https://msdn.microsoft.com/library/azure/ff394108.aspx)<br /><br /> [TLS 1.2 support for Microsoft SQL Server](https://support.microsoft.com/kb/3135244)|  
  
##  <a name="Audit"></a> Auditing: Recording Access  
  
|||  
|-|-|  
|**Automated Auditing**<br /><br /> ![security&#45;center&#45;sqlserver](../../Topics/TopicNameNotContainA/media/security-center-sqlserver.png "security-center-sqlserver") [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Audit (Server and DB Level)<br /><br /> ![security&#45;center&#45;sqldb](../../Topics/TopicNameNotContainA/media/security-center-sqldb.png "security-center-sqldb") [!INCLUDE[ssSDS](../../Topics/TopicNameContainA/includes/ssSDS_md.md)] Audit (Database Level)<br /><br /> ![security&#45;center&#45;sqldb](../../Topics/TopicNameNotContainA/media/security-center-sqldb.png "security-center-sqldb") Threat Detection|[SQL Server Audit (Database Engine)](../../Topics/TopicNameNotContainA/SQL-Server-Audit--Database-Engine-.md)<br /><br /> [SQL Database Auditing](http://azure.microsoft.com/documentation/articles/sql-database-auditing-get-started/)<br /><br /> [Get started with SQL Database Threat Detection](https://azure.microsoft.com/documentation/articles/sql-database-threat-detection-get-started/)|  
|**Custom Audit**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Triggers|Custom Audit Implementation: Creating [DDL Triggers](../../Topics/TopicNameNotContainA/DDL-Triggers.md) and [DML Triggers](../../Topics/TopicNameNotContainA/DML-Triggers.md)|  
|**Compliance**<br /><br /> ![security&#45;center&#45;both](../../Topics/TopicNameNotContainA/media/security-center-both.png "security-center-both") Compliance|SQL Server:<br />                        [Common Criteria](http://go.microsoft.com/fwlink/?LinkId=616319)<br /><br /> SQL Database:<br />                        [Microsoft Azure Trust Center: Compliance by Feature](http://azure.microsoft.com/support/trust-center/services/)|  
  
##  <a name="SQLInjection"></a> SQL Injection  
 SQL injection is an attack in which malicious code is inserted into strings that are later passed to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] for parsing and execution. Any procedure that constructs SQL statements should be reviewed for injection vulnerabilities because [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] will execute all syntactically valid queries that it receives. All database systems have some risk of SQL Injection, and many of the vulnerabilities are introduced in the application that is querying the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)]. You can thwart SQL injection attacks by using stored procedures and parameterized commands, avoiding dynamic SQL, and restricting permissions on all users.  For more information, see [SQL Injection](../../Topics/TopicNameNotContainA/SQL-Injection.md).  
  
 Additional links for application programmers:  
  
-   [Application Security Scenarios in SQL Server](https://msdn.microsoft.com/library/bb669057.aspx)  
  
-   [Writing Secure Dynamic SQL in SQL Server](https://msdn.microsoft.com/library/bb669091.aspx)  
  
-   [How To: Protect From SQL Injection in ASP.NET](https://msdn.microsoft.com/library/ff648339.aspx)  
  
## See Also  
 [Getting Started with Database Engine Permissions](../../Topics/TopicNameNotContainA/Getting-Started-with-Database-Engine-Permissions.md)   
 [Securing SQL Server](../../Topics/TopicNameNotContainA/Securing-SQL-Server.md)   
 [Principals (Database Engine)](../../Topics/TopicNameNotContainA/Principals--Database-Engine-.md)   
 [SQL Server Certificates and Asymmetric Keys](../../Topics/TopicNameNotContainA/SQL-Server-Certificates-and-Asymmetric-Keys.md)   
 [SQL Server Encryption](../../Topics/TopicNameNotContainA/SQL-Server-Encryption.md)   
 [Surface Area Configuration](../../Topics/TopicNameNotContainA/Surface-Area-Configuration.md)   
 [Strong Passwords](../../Topics/TopicNameNotContainA/Strong-Passwords.md)   
 [TRUSTWORTHY Database Property](../../Topics/TopicNameNotContainA/TRUSTWORTHY-Database-Property.md)   
 [Database Engine Features and Tasks](../../Topics/TopicNameNotContainA/Database-Engine-Features-and-Tasks.md)