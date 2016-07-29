---
title: "Prerequisites, Restrictions, and Recommendations for Database Mirroring"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fdcf2251-9895-44c6-b81e-768fef32e732
caps.latest.revision: 55
manager: jhubbard
---
# Prerequisites, Restrictions, and Recommendations for Database Mirroring
> [!NOTE]  
>  [!INCLUDE[ssNoteDepFutureAvoid](../../Topics/TopicNameContainA/includes/ssNoteDepFutureAvoid_md.md)] Use [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] instead.  
  
 This topic describes the prerequisites and recommendations for setting up database mirroring. For an introduction to database mirroring, see [Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Database-Mirroring--SQL-Server-.md).  
  
 **In This Topic:**  
  
-   [Support For Database Mirroring](#DbmSupport)  
  
-   [Prerequisites](#Prerequisites)  
  
-   [Restrictions](#Restrictions)  
  
-   [Recommendations for Configuring Partner Servers](#RecommendationsForPartners)  
  
-   [Recommendations for Deploying Database Mirroring](#RecommendationsForDeploying)  
  
##  <a name="DbmSupport"></a> Support For Database Mirroring  
 For information about support for database mirroring in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)], see [Features Supported by the Editions of SQL Server 2016](../../Topics/TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md).  
  
 Note that database mirroring works with any supported database compatibility level. For information about the supported compatibility levels, see [ALTER DATABASE Compatibility Level (Transact-SQL)](assetId:///ca5fd220-d5ea-4182-8950-55d4101a86f6).  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="Prerequisites"></a> Prerequisites  
  
-   For a mirroring session to be established, the partners and the witness, if any, must be running on the same version of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
-   The two partners, that is the principal server and mirror server, must be running the same edition of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. The witness, if any, can run on any edition of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that supports database mirroring.  
  
    > [!NOTE]  
    >  You can upgrade server instances that are partners in a mirroring session to a more recent version of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. For more information, see [Upgrading Mirrored Instances](../../Topics/TopicNameNotContainA/Upgrading-Mirrored-Instances.md).  
  
-   The database must use the full recovery model. The simple and bulk-logged recovery models do not support database mirroring. Therefore, bulk operations are always fully logged for a mirrored database. For information about recovery models, see [Recovery Models (SQL Server)](../../Topics/TopicNameNotContainA/Recovery-Models--SQL-Server-.md).  
  
-   Verify that the mirror server has sufficient disk space for the mirror database.  
  
    > [!NOTE]  
    >  For information about how to use database mirroring on a replicated database, see [Database Mirroring and Replication (SQL Server)](../../Topics/TopicNameNotContainA/Database-Mirroring-and-Replication--SQL-Server-.md).  
  
-   When you are creating the mirror database on the mirror server, make sure that you restore the backup of the principal database specifying the same database name WITH NORECOVERY. Also, all log backups that were created after that backup was taken must also be applied, again WITH NORECOVERY.  
  
    > [!IMPORTANT]  
    >  If database mirroring has been stopped, before you can restart it, any subsequent log backups taken on the principal database must be applied to the mirror database.  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="Restrictions"></a> Restrictions  
  
-   Only user databases can be mirrored. You cannot mirror the **master**, **msdb**, **tempdb**, or **model** databases.  
  
-   A mirrored database cannot be renamed during a database mirroring session.  
  
-   Database mirroring does not support FILESTREAM. A FILESTREAM filegroup cannot be created on the principal server. Database mirroring cannot be configured for a database that contains FILESTREAM filegroups.  
  
-   Database mirroring is not supported with either cross-database transactions or distributed transactions. For more information, see [Cross-Database Transactions and Distributed Transactions for Always On Availability Groups and Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Cross-Database-Transactions-and-Distributed-Transactions-for-Always-On-Availability-Groups-and-Database-Mirroring--SQL-Server-.md).  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="RecommendationsForPartners"></a> Recommendations for Configuring Partner Servers  
  
-   The partners should run on comparable systems that can handle identical workloads.  
  
    > [!NOTE]  
    >  If you plan to use high-safety mode with automatic failover, the normal load on each failover partner should be less than 50 percent of the CPU. If your work load overloads the CPU, a failover partner might be unable to ping the other server instances in the mirroring session. This causes a unnecessary failover. If you cannot keep the CPU usage under 50 percent, we recommend that you use either high-safety mode without automatic failover or high-performance mode.  
  
-   If possible, the path (including the drive letter) of the mirror database should be identical to the path of the principal database. You must include the MOVE option in the RESTORE statement if the file layouts must differ. For example, if the principal database is on drive 'F:' but the mirror system lacks an F: drive.  
  
    > [!IMPORTANT]  
    >  If you move the database files when you create the mirror database, you might be unable to add files to the database later without mirroring being suspended.  
  
-   All of the server instances in a mirroring session should use the same master code page and collation. Differences can cause a problem during mirroring setup.  
  
-   Optionally, estimate the time to fail over a database, to make sure that the system configuration will provide the performance you require. For more information, see [Estimate the Interruption of Service During Role Switching (Database Mirroring)](../../Topics/TopicNameNotContainA/Estimate-the-Interruption-of-Service-During-Role-Switching--Database-Mirroring-.md).  
  
-   For best performance, use a dedicated network adapter (network interface card) for mirroring.  
  
-   We make no recommendations about whether a wide-area network (WAN) is reliable enough for database mirroring in high-safety mode. If you decide to use high-safety mode over a WAN, be cautious about how you add a witness to the session, because unwanted automatic failovers can occur. For more information, see [Recommendations for Deploying Database Mirroring](#RecommendationsForDeploying), later in this topic.  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="RecommendationsForDeploying"></a> Recommendations for Deploying Database Mirroring  
 Optimal database mirroring performance is obtained by using asynchronous operation. A mirroring session that uses synchronous operation might experience slowed performance when its workload generates large amounts of transaction log data.  
  
 In test environments, it is appropriate to explore all the operating modes to evaluate how database mirroring performs. However, before you deploy mirroring into a production environment, make sure that you understand how the network functions in the real world.  
  
 High-safety mode with automatic failover is designed for a high-service network that has either a dedicated connection or a fairly simple network configuration that minimizes the sources of possible network failures. Such a high-quality network environment is necessary for high-safety mode with automatic failover and is recommended for all database mirroring sessions. However, high-performance mode and high-safety mode without automatic failover are much less affected by network reliability.  
  
 Therefore, for production environments we recommend that you adhere to the following deployment guidelines:  
  
1.  Start running in asynchronous, high-performance mode. This mode is the least sensitive to the network environment and provides the best configuration for exploring how mirroring works. We recommend that you run your system asynchronously until you are confident that your bandwidth supports mirroring and you have developed an understanding of mirroring setup and of the performance of asynchronous mode in your environment. For more information, see [Database Mirroring Operating Modes](../../Topics/TopicNameNotContainA/Database-Mirroring-Operating-Modes.md).  
  
    > [!IMPORTANT]  
    >  Throughout testing, we recommend that you monitor your sessions for network errors that cause database mirroring to fail. For more information about potential sources of failure, see [Possible Failures During Database Mirroring](../../Topics/TopicNameNotContainA/Possible-Failures-During-Database-Mirroring.md). For information about how to monitor database mirroring, see [Monitoring Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Monitoring-Database-Mirroring--SQL-Server-.md).  
  
2.  When you are confident that asynchronous operation is meeting the business needs, you might want to try synchronous operation to improve your data protection. When you test how synchronous mirroring works in your environment, we recommend that first you test high-safety mode without automatic failover. The primary purpose of this testing is to see how synchronous operation affects the database performance. For more information, see [Database Mirroring Operating Modes](../../Topics/TopicNameNotContainA/Database-Mirroring-Operating-Modes.md).  
  
3.  Wait to enable automatic failover until you are confident that high-safety mode without automatic failover is meeting the business needs and that network errors are not causing failures. For more information, see [Role Switching During a Database Mirroring Session (SQL Server)](../../Topics/TopicNameContainA/Role-Switching-During-a-Database-Mirroring-Session--SQL-Server-.md).  
  
 [&#91;Top&#93;](#Top)  
  
## See Also  
 [Setting Up Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Setting-Up-Database-Mirroring--SQL-Server-.md)   
 [Transport Security for Database Mirroring and Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Transport-Security-for-Database-Mirroring-and-Always-On-Availability-Groups--SQL-Server-.md)   
 [Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Database-Mirroring--SQL-Server-.md)   
 [Troubleshoot Database Mirroring Configuration (SQL Server)](../../Topics/TopicNameNotContainA/Troubleshoot-Database-Mirroring-Configuration--SQL-Server-.md)