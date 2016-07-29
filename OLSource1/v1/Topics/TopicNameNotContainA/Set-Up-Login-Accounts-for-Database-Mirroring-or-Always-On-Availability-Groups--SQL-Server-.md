---
title: "Set Up Login Accounts for Database Mirroring or Always On Availability Groups (SQL Server)"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e9f5287b-1325-4cda-88a6-19eaaa52a652
caps.latest.revision: 20
manager: jhubbard
---
# Set Up Login Accounts for Database Mirroring or Always On Availability Groups (SQL Server)
For two server instances to connect to each other's [database mirroring endpoint](../../Topics/TopicNameNotContainA/The-Database-Mirroring-Endpoint--SQL-Server-.md) point, the login account of each instance requires access to the other instance. Also, each login account requires connect permission to the Database Mirroring endpoint of the other instance.  
  
 The impact of this requirement depends on whether the server instances run as the same domain user account:  
  
-   If the server instances run as the same domain user account, the correct user logins exist automatically in both **master** databases. This simplifies the security configuration for Database Mirroring and Always On Availability Groups.  
  
-   If the server instances run as different user accounts, user logins on the server instance that hosts the principal server or primary replica must be manually reproduced on the server instance that hosts the mirror server or on every server instance that hosts a secondary replica. For more information, see [Create a Login for a Different Account](#CreateLogin) and [Grant Connect Permission](#GrantConnect), later in this topic.  
  
    > [!IMPORTANT]  
    >  To create a more secure environment, consider using separate domain accounts for each server instance.  
  
##  <a name="CreateLogin"></a> Create a Login for a Different Account  
 If two server instances run as different accounts, the system administrator must use the CREATE LOGIN [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statement to create a login for the startup service account of the remote instance for each server instance. For more information, see [CREATE LOGIN (Transact-SQL)](assetId:///eb737149-7c92-4552-946b-91085d8b1b01).  
  
> [!IMPORTANT]  
>  If you run [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] under a non-domain account, you must use certificates. For more information, see [Use Certificates for a Database Mirroring Endpoint (Transact-SQL)](../../Topics/TopicNameContainA/Use-Certificates-for-a-Database-Mirroring-Endpoint--Transact-SQL-.md).  
  
 For example, for the server instance sqlA, which runs under loginA, to connect to the server instance sqlB, which runs under loginB, loginA must exist on sqlB, and loginB must exist on sqlA. In addition, for a database mirroring session that includes a witness server instance (sqlC) and in which the three server instances run under different domain accounts, the following logins must be created:  
  
|On instance...|Create logins for and grant connection permission to ...|  
|--------------------|--------------------------------------------------------------|  
|sqlA|sqlB and sqlC|  
|sqlB|sqlA and sqlC|  
|sqlC|sqlA and sqlB|  
  
> [!NOTE]  
>  It is possible to connect with the network service account by using the machine account instead of a domain user. If the machine account is used, it must be added as a user on the other server instance.  
  
##  <a name="GrantConnect"></a> Grant Connect Permission  
 Once a login has been created on a server instance, the login must be granted permission to connect to the database mirroring endpoint of the server instance. The system administrator grants the connect permission using a GRANT [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statement. For more information, see [GRANT (Transact-SQL)](assetId:///a760c16a-4d2d-43f2-be81-ae9315f38185).  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Create a Login](../../Topics/TopicNameContainA/Create-a-Login.md)  
  
-   [Allow Network Access to a Database Mirroring Endpoint Using Windows Authentication (SQL Server)](../../Topics/TopicNameContainA/Allow-Network-Access-to-a-Database-Mirroring-Endpoint-Using-Windows-Authentication--SQL-Server-.md).  
  
-   [Use Certificates for a Database Mirroring Endpoint (Transact-SQL)](../../Topics/TopicNameContainA/Use-Certificates-for-a-Database-Mirroring-Endpoint--Transact-SQL-.md)  
  
## See Also  
 [The Database Mirroring Endpoint (SQL Server)](../../Topics/TopicNameNotContainA/The-Database-Mirroring-Endpoint--SQL-Server-.md)   
 [Troubleshoot Database Mirroring Configuration (SQL Server)](../../Topics/TopicNameNotContainA/Troubleshoot-Database-Mirroring-Configuration--SQL-Server-.md)   
 [Troubleshoot Always On Availability Groups Configuration (SQL Server)](../../Topics/TopicNameNotContainA/Troubleshoot-Always-On-Availability-Groups-Configuration--SQL-Server-.md)