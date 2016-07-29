---
title: "Overview of Transact-SQL Statements for Always On Availability Groups (SQL Server)"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 184d0a81-2259-4db9-9d0d-01aac0b502c8
caps.latest.revision: 24
manager: jhubbard
---
# Overview of Transact-SQL Statements for Always On Availability Groups (SQL Server)
This topic introduces the [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statements that support deploying [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] and creating and managing an given availability group, availability replica and availability database.  
  
 **In This Topic:**  
  
-   [CREATE ENDPOINT](#CreateEndpoint)  
  
-   [CREATE AVAILABILITY GROUP](#CreateAG)  
  
-   [ALTER AVAILABILITY GROUP](#AlterAG)  
  
-   [ALTER DATABASE SET HADR Options](#AlterDB)  
  
-   [DROP AVAILABILITY GROUP](#DropAG)  
  
-   [Restrictions on the AVAILABILITY GROUP Transact-SQL statements](#Restrictions)  
  
##  <a name="CreateEndpoint"></a> CREATE ENDPOINT  
 [CREATE ENDPOINT … FOR DATABASE_MIRRORING](assetId:///6405e7ec-0b5b-4afd-9792-1bfa5a2491f6) creates a database mirroring endpoint, if none exists on the server instance. Every server instance on which you intend to deploy [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] or database mirroring requires a database mirroring endpoint.  
  
 Execute this statement on the server instance on which you are creating the endpoint. You can create only one database mirroring endpoint on a given server instance. For more information, see [The Database Mirroring Endpoint (SQL Server)](../../Topics/TopicNameNotContainA/The-Database-Mirroring-Endpoint--SQL-Server-.md).  
  
##  <a name="CreateAG"></a> CREATE AVAILABILITY GROUP  
 [CREATE AVAILABILITY GROUP](assetId:///a3d55df7-b4e4-43f3-a14b-056cba36ab98) creates a new availability group and optionally an availability group listener. Minimally, you must specify your local server instance, which will become the initial primary replica. Optionally, you can also specify up to four secondary replicas.  
  
 Execute CREATE AVAILABILITY GROUP on the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that you want to host the initial primary replica of your new availability group. This server instance must reside on a node of a Windows Server Failover Cluster (WSFC) (for more information, see [Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Prerequisites--Restrictions--and-Recommendations-for-Always-On-Availability-Groups--SQL-Server-.md).  
  
##  <a name="AlterAG"></a> ALTER AVAILABILITY GROUP  
 [ALTER AVAILABILITY GROUP](assetId:///f039d0de-ade7-4aaf-8b7b-d207deb3371a) supports changing an existing availability group or availability group listener and for failing over an availability group.  
  
 Execute ALTER AVAILABILITY GROUP on the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that hosts the current primary replica.  
  
##  <a name="AlterDb"></a> ALTER DATABASE … SET HADR …  
 The options of the [SET HADR](assetId:///20e6e803-d6d5-48d5-b626-d1e0a73d174c) clause of the ALTER DATABASE statement enables you to join a secondary database to the availability group of the corresponding primary database, remove a joined database, and suspend data synchronization on a joined database, and resume data synchronization.  
  
##  <a name="DropAG"></a> DROP AVAILABILITY GROUP  
 [DROP AVAILABILITY GROUP](assetId:///c1600289-c990-454a-b279-dba0ebd5d63e) removes a specified availability group and all of its replicas. DROP AVAILABILITY GROUP can be run from any [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] node in the WSFC failover cluster.  
  
##  <a name="Restrictions"></a> Restrictions on the AVAILABILITY GROUP Transact-SQL Statements  
 The CREATE AVAILABILITY GROUP, ALTER AVAILABILITY GROUP, and DROP AVAILABILITY GROUP [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statements have the following limitations:  
  
-   With the exception of DROP AVAILABILITY GROUP, executing these statements requires that the HADR service is enabled on the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. For more information, see [Enable and Disable Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Enable-and-Disable-Always-On-Availability-Groups--SQL-Server-.md).  
  
-   These statements cannot be executed within transactions or batches.  
  
-   Though they make a best effort to clean up after a failure, these statements do not guarantee that they will roll back all changes on failure. However, systems should be able cleanly handle and then ignore partial failures.  
  
-   These statements do not support expressions or variables.  
  
-   If a [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statement is executed while another availability group action or recovery is in process, the statement returns an error. Wait for the action or recovery to complete, and retry the statement, if necessary.  
  
## See Also  
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)