---
title: Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: edbab896-42bb-4d17-8d75-e92ca11f7abb
manager: jhubbard
---
# Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)
This topic describes considerations for deploying [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)], including prerequisites, restrictions, and recommendations for host computers, Windows Server Failover Clustering (WSFC) clusters, server instances, and availability groups. For each of these components security considerations and required permissions, if any, are indicated.  
  
> [!IMPORTANT]  
>  Before you deploy [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)], we strongly recommend that you read every section of this topic.  
  
 **In this Topic:**  
  
-   [.Net Hotfixes that Support Always On Availability Groups](#DotNetHotfixes)  
  
-   [Windows System Requirements and Recommendations](#SystemReqsForAOAG)  
  
-   [SQL Server Instance Prerequisites and Restrictions](#ServerInstance)  
  
-   [Network Connectivity Recommendations](#NetworkConnect)  
  
-   [Client Connectivity Support](#ClientConnSupport)  
  
-   [Prerequisites and Restrictions for Using a SQL Server Failover Cluster Instance (FCI) to Host an Availability Replica](#FciArLimitations)  
  
-   [Availability Group Prerequisites and Restrictions](#PrerequisitesForAGs)  
  
-   [Availability Database Prerequisites and Restrictions](#PrerequisitesForDbs)  
  
-   [Related Content](#RelatedContent)  
  
##  <a name="DotNetHotfixes"></a> .Net Hotfixes that Support Always On Availability Groups  
 Depending on the [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] components and features you will use with [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)], you may need to install additional .Net hotfixes identified in the following table. The hotfixes can be installed in any order.  
  
||Dependent Feature|Hotfix|Link|  
|------|-----------------------|------------|----------|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|[!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)]|Hotfix for .Net 3.5 SP1 adds support to SQL Client for Always On features of Read-intent, readonly, and multisubnetfailover. The hotfix needs to be installed on each [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] report server.|KB 2654347: [Hotfix for .Net 3.5 SP1 to add support for Always On features](http://go.microsoft.com/fwlink/?LinkId=242896)|  
  
##  <a name="SystemReqsForAOAG"></a> Windows System Requirements and Recommendations  
 **In This Section:**  
  
-   [Checklist: Requirements](#SystemRequirements)  
  
-   [Windows Hotfixes that Support Always On Availability Groups (Windows System)](#WinHotfixes)  
  
-   [Recommendations for Computers That Host Availability Replicas (Windows System](#ComputerRecommendations)  
  
-   [Permissions](#PermissionsWindows)  
  
-   [Related Tasks](#RelatedTasksWindows)  
  
-   [Related Content](#RelatedContentWS)  
  
###  <a name="SystemRequirements"></a> Checklist: Requirements (Windows System)  
 To support the [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] feature, ensure that every computer that is to participate in one or more availability groups meets the following fundamental requirements:  
  
||Requirement|Link|  
|------|-----------------|----------|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Ensure that the system is not a domain controller.|Availability groups are not supported on domain controllers.|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Ensure that each computer is running either x86 (non-WOW64) or x64 Windows Server 2008 or later versions.|WOW64 (Windows 32-bit on Windows 64-bit) does not support [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)].|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Ensure that each computer is a node in a Windows Server Failover Clustering (WSFC) cluster.|[Windows Server Failover Clustering (WSFC) with SQL Server](../../Topics/TopicNameNotContainA/Windows-Server-Failover-Clustering--WSFC--with-SQL-Server.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Ensure that the WSFC cluster contains sufficient nodes to support your availability group configurations.|A WSFC node can host only one availability replica for a given availability group. On a given WSFC node, one or more instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] can host availability replicas for many availability groups.<br /><br /> Ask your database administrators how many WSFC nodes are required for to support the availability replicas of the planned availability groups.<br /><br /> [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md).|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Ensure that all applicable Window hotfixes have been installed on every node in the WSFC cluster.|**\*\* Important \*\*** A number of hotfixes are required or recommended for the nodes of a WSFC cluster on which [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] is being deployed. For more information, see [Windows Hotfixes that Support Always On Availability Groups (Windows System)](#WinHotfixes), later in this section.|  
  
> [!IMPORTANT]  
>  Also ensure that your environment is correctly configured for connecting to an availability group. For more information, see [Always On Client Connectivity (SQL Server)](../../Topics/TopicNameNotContainA/Always-On-Client-Connectivity--SQL-Server-.md).  
  
####  <a name="WinHotfixes"></a> Windows Hotfixes that Support Always On Availability Groups (Windows System)  
 Depending on your cluster topology, several additional Windows Server 2008 Service Pack 2 (SP2) or Windows Server 2008 R2 hotfixes might be applicable for supporting [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)]. The following table identifies these hotfixes. They hotfixes can be installed in any order.  
  
||Applies to Windows 2008 SP2|Applies to Windows 2008 R2 SP1|Included in Windows 2012|To Support…|Hotfix|Link|  
|------|---------------------------------|------------------------------------|------------------------------|-----------------|------------|----------|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|√|√|Yes|**Configuring optimal WSFC quorum**|On each WSFC node, ensure that the hotfix described in Knowledge Base article 2494036 is installed.<br /><br /> This hotfix supports configuring optimal quorum with non-automatic failover targets. This functionality improves multi-site clusters by enabling you to select which nodes vote.|KB 2494036:  [A hotfix is available to let you configure a cluster node that does not have quorum votes in Windows Server 2008 and in Windows Server 2008 R2](http://support.microsoft.com/kb/2494036)<br /><br /> For information about quorum voting, see [WSFC Quorum Modes and Voting Configuration (SQL Server)](../../Topics/TopicNameNotContainA/WSFC-Quorum-Modes-and-Voting-Configuration--SQL-Server-.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|√|√|Yes|**More efficient use of network bandwidth**|On each WSFC node, ensure that the hotfix described in Knowledge Base article 2616514 is installed.<br /><br /> Without this hotfix, the Cluster service sends unnecessary registry notifications among cluster nodes. This behavior limits network bandwidth, which is a serious issue for [!INCLUDE[ssHADRc](../../Topics/TopicNameNotContainA/includes/ssHADRc_md.md)].|KB 2616514:  [Cluster service sends unnecessary registry key change notifications among cluster nodes in Windows Server 2008 or in Windows Server 2008 R2](http://support.microsoft.com/kb/2616514)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")||√|Not applicable|**VPD storage testing on disks that are not available to all WSFC nodes**|If a WSFC node is running Windows Server 2008 R2 Service Pack 1 (SP1) and the Validate SCSI Device Vital Product Data (VPD) storage test fails after incorrectly running on disks that are online and not available to all nodes in the WSFC cluster, install the hotfix described in Knowledge Base article 2531907.<br /><br /> This hotfix eliminates incorrect warnings or errors in the validation report when disks are online.|KB 2531907:  [Validate SCSI Device Vital Product Data (VPD) test fails after you install Windows Server 2008 R2 SP1](http://support.microsoft.com/kb/2531907)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")||√|Yes|**Faster failover to local replicas**|If a WSFC node is running Windows Server 2008 R2 Service Pack 1 (SP1), ensure that the hotfix described in Knowledge Base article 2687741 is installed.<br /><br /> This hotfix improves the performance of [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] failover to local replicas.|KB 2687741:  [A hotfix that improves the performance of the "Always On Availability Group" feature in SQL Server 2012 is available for Windows Server 2008 R2](http://support.microsoft.com/KB/2687741)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|√|√|Yes|**Asymmetric storage—for Failover Cluster Instances (FCIs)**|If any Failover Cluster Instance (FCI) will be enabled for [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)], install the Windows Server 2008 hotfix 976097.<br /><br /> This hotfix enables the Failover Cluster Management Microsoft Management Console (MMC) snap-in to support asymmetric storage—shared disks that are available on only some of the WSFC nodes.|KB 976097:  [Hotfix to add support for asymmetric storages to the Failover Cluster Management MMC snap-in for a failover cluster that is running Windows Server 2008 or Windows Server 2008 R2](http://support.microsoft.com/kb/976097)<br /><br /> [Always On Architecture Guide: Building a High Availability and Disaster Recovery Solution by Using Failover Cluster Instances and Availability Groups](http://technet.microsoft.com/library/jj215886.aspx)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|√|√|Not applicable|**Internet Protocol Security (IPsec)**|If your environment uses IPsec connections, you could experience a long time delay (about two or three minutes) when a client computer reestablishes the IPsec connection to a virtual network name (in this context, to connect to the availability group listener). If you use IPsec connections, we recommend that you review the specific scenarios detailed in Knowledge Base article (KB 980915).|KB 980915:  [A long time delay occurs when you reconnect an IPSec connection from a computer that is running Windows Server 2003, Windows Vista, Windows Server 2008, Windows 7, or Windows Server 2008 R2](http://support.microsoft.com/kb/980915)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|√|√|Yes|**IPv6**|If you use IPv6, we recommend that you review the specific scenarios detailed in Knowledge Base article 2578103 or 2578113, depending on your Windows Server operating system.<br /><br /> If your Windows Server topology uses IP version 6 (IPv6), the WSFC Cluster service requires about 30 seconds to fail over the IPv6 IP address. This causes clients to wait for about 30 seconds to reconnect to the IPv6 IP address.|KB 2578103 (Windows Server 2008):  [The Cluster service takes about 30 seconds to fail over IPv6 IP addresses in Windows Server 2008](http://support.microsoft.com/kb/2578103)<br /><br /> KB 2578113 (Windows Server 2008 R2):  **Windows Server 2008 R2:** [The Cluster service takes about 30 seconds to fail over IPv6 IP addresses in Windows Server 2008 R2](http://support.microsoft.com/kb/2578113)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|√|√|Yes|**No Router Between cluster and application server**|If no router exists between the failover cluster and the application server, the Cluster service fails over network-related resources slowly. This delays client reconnections after an availability group fails over. In the absence of a router, we recommend that you review the specific scenarios detailed in Knowledge Base article 2582281 and install the hotfix, if applicable to your environment.|KB 2582281:  [Slow failover operation if no router exists between the cluster and an application server](http://support.microsoft.com/kb/2582281)|  
  
###  <a name="ComputerRecommendations"></a> Recommendations for Computers That Host Availability Replicas (Windows System)  
  
-   **Comparable systems:**  For a given availability group, all the availability replicas should run on comparable systems that can handle identical workloads.  
  
-   **Dedicated network adapters:**  For best performance, use a dedicated network adapter (network interface card) for [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)].  
  
-   **Sufficient disk space:**  Every computer on which a server instance hosts an availability replica must possess sufficient disk space for all the databases in the availability group. Keep in mind that as primary databases grow, their corresponding secondary databases grow the same amount.  
  
###  <a name="PermissionsWindows"></a> Permissions (Windows System)  
 To administer a WSFC cluster, the user must be a system administrator on every cluster node.  
  
 For more information about the account for administering the cluster, see [Appendix A: Failover Cluster Requirements](http://technet.microsoft.com/library/dd197454\(WS.10\).aspx).  
  
###  <a name="RelatedTasksWindows"></a> Related Tasks (Windows System)  
  
|Task|Link|  
|----------|----------|  
|Set the HostRecordTTL value.|[Change the HostRecordTTL (Using Windows PowerShell)](#ChangeHostRecordTTLps)|  
  
####  <a name="ChangeHostRecordTTLps"></a> Change the HostRecordTTL (Using Windows PowerShell)  
  
1.  Open PowerShell window via **Run as Administrator**.  
  
2.  Import the FailoverClusters module.  
  
3.  Use the **Get-ClusterResource** cmdlet to find the Network Name resource, then use **Set-ClusterParameter** cmdlet to set the **HostRecordTTL** value, as follows:  
  
     Get-ClusterResource “*<NetworkResourceName\>*” &#124; Set-ClusterParameter HostRecordTTL *<TimeInSeconds\>*  
  
     The following PowerShell example sets the HostRecordTTL to 300 seconds for a Network Name resource named "`SQL Network Name (SQL35)`".  
  
    ```  
    Import-Module FailoverClusters  
  
    $nameResource = "SQL Network Name (SQL35)"  
    Get-ClusterResource $nameResource | Set-ClusterParameter ClusterParameter HostRecordTTL 300  
    ```  
  
    > [!TIP]  
    >  Every time you open a new PowerShell window, you need to import the **FailoverClusters** module.  
  
##### Related Content (PowerShell)  
  
-   [Clustering and High-Availability](http://blogs.msdn.com/b/clustering/archive/2009/05/23/9636665.aspx) (Failover Clustering and Network Load Balancing Team Blog)  
  
-   [Getting Started with Windows PowerShell on a Failover Cluster](http://technet.microsoft.com/library/ee619762\(WS.10\).aspx)  
  
-   [Cluster resource commands and equivalent Windows PowerShell cmdlets](http://msdn.microsoft.com/library/ee619744.aspx#BKMK_resource)  
  
###  <a name="RelatedContentWS"></a> Related Content (Windows System)  
  
-   [Configure DNS settings in a Multi-Site Failover Cluster](http://technet.microsoft.com/library/dd197562\(WS.10\).aspx)  
  
-   [DNS Registration with Network Name Resource](http://blogs.msdn.com/b/clustering/archive/2009/07/17/9836756.aspx)  
  
-   [Windows 2008 R2 Failover Multi-Site Clustering](http://www.microsoft.com/windowsserver2008/en/us/failover-clustering-multisite.aspx)  
  
##  <a name="ServerInstance"></a> SQL Server Instance Prerequisites and Restrictions  
 Each availability group requires a set of failover partners, known as *availability replicas*, which are hosted by instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. A given server instance can be a *stand-alone instance* or a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]*failover cluster instance* (FCI).  
  
 **In This Section:**  
  
-   [Checklist: Prerequisites](#PrerequisitesSI)  
  
-   [Thread Usage by Availability Groups](#ThreadUsage)  
  
-   [Permissions](#PermissionsSI)  
  
-   [Related Tasks](#RelatedTasksSI)  
  
-   [Related Content](#RelatedContentSI)  
  
###  <a name="PrerequisitesSI"></a> Checklist: Prerequisites (Server Instance)  
  
||Prerequisite|Links|  
|-|------------------|-----------|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|The host computer must be a Windows Server Failover Clustering (WSFC) node. The instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that host availability replicas for a given availability group must reside on separate nodes of a single WSFC cluster. The only exception is that while being migrated to another WSFC cluster, an availability group can temporarily straddle two clusters.|[Windows Server Failover Clustering (WSFC) with SQL Server](../../Topics/TopicNameNotContainA/Windows-Server-Failover-Clustering--WSFC--with-SQL-Server.md)<br /><br /> [Failover Clustering and Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Failover-Clustering-and-Always-On-Availability-Groups--SQL-Server-.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|If you want an availability group to work with Kerberos:<br /><br /> All server instances that host an availability replica for the availability group must use the same SQL Server service account.<br /><br /> The domain administrator needs to manually register a Service Principal Name (SPN) with Active Directory on the SQL Server service account for the virtual network name (VNN) of the availability group listener. If the SPN is registered on an account other than the SQL Server service account, authentication will fail.<br /><br /> <br /><br /> **\*\* Important \*\*** If you change the SQL Server service account, the domain administrator will need to manually re-register the SPN.|[Register a Service Principal Name for Kerberos Connections](../../Topics/TopicNameContainA/Register-a-Service-Principal-Name-for-Kerberos-Connections.md)<br /><br /> **Brief explanation:**<br /><br /> Kerberos and SPNs enforce mutual authentication. The SPN maps to the Windows account that starts the SQL Server services. If the SPN is not registered correctly or if it fails, the Windows security layer cannot determine the account associated with the SPN, and Kerberos authentication cannot be used.<br /><br /> <br /><br /> Note: NTLM does not have this requirement.|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|If you plan to use a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] failover cluster instance (FCI) to host an availability replica, ensure that you understand the FCI restrictions and that the FCI requirements are met.|[Prerequisites and Requirements on Using a SQL Server Failover Cluster Instance (FCI) to Host an Availability Replica](#FciArLimitations) (later in this topic)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Each server instance must be running the Enterprise Edition of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)].|[Features Supported by the Editions of SQL Server 2016](../../Topics/TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|All the server instances that host availability replicas for an availability group must use the same [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] collation.|[Set or Change the Server Collation](../../Topics/TopicNameNotContainA/Set-or-Change-the-Server-Collation.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Enable the [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] feature on each server instance that will host an availability replica for any availability group. On a given computer, you can enable as many server instances for [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] as your [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] installation supports.|[Enable and Disable Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Enable-and-Disable-Always-On-Availability-Groups--SQL-Server-.md)<br /><br /> <br /><br /> **\*\* Important \*\*** If you delete and re-create a WSFC cluster, you must disable and re-enable the [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] feature on each server instance that was enabled for [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] on the original WSFC cluster.|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Each server instance requires a database mirroring endpoint. Note that this endpoint is shared by all the availability replicas and database mirroring partners and witnesses on the server instance.<br /><br /> If a server instance that you select to host an availability replica is running under a domain user account and does not yet have a database mirroring endpoint, the [New Availability Group Wizard](../../Topics/TopicNameNotContainA/Use-the-Availability-Group-Wizard--SQL-Server-Management-Studio-.md) (or [Add Replica to Availability Group Wizard](../../Topics/TopicNameNotContainA/Use-the-Add-Replica-to-Availability-Group-Wizard--SQL-Server-Management-Studio-.md)) can create the endpoint and grant CONNECT permission to the server instance service account. However, if the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] service is running as a built-in account, such as Local System, Local Service, or Network Service, or a nondomain account, you must use certificates for endpoint authentication, and the wizard will be unable to create a database mirroring endpoint on the server instance. In this case, we recommend that you create the database mirroring endpoints manually before you launch the wizard.<br /><br /> <br /><br /> **\*\* Security Note \*\*** Transport security for [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] is the same as for database mirroring.|[The Database Mirroring Endpoint (SQL Server)](../../Topics/TopicNameNotContainA/The-Database-Mirroring-Endpoint--SQL-Server-.md)<br /><br /> [Transport Security for Database Mirroring and Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Transport-Security-for-Database-Mirroring-and-Always-On-Availability-Groups--SQL-Server-.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|If any databases that use FILESTREAM will be added to an availability group, ensure that FILESTREAM is enabled on every server instance that will host an availability replica for the availability group.|[Enable and Configure FILESTREAM](../../Topics/TopicNameNotContainA/Enable-and-Configure-FILESTREAM.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|If any contained databases will be added to an availability group, ensure that the **contained database authentication** server option is set to **1** on every server instance that will host an availability replica for the availability group.|[contained database authentication Server Configuration Option](../../Topics/TopicNameNotContainA/contained-database-authentication-Server-Configuration-Option.md)<br /><br /> [Server Configuration Options (SQL Server)](../../Topics/TopicNameNotContainA/Server-Configuration-Options--SQL-Server-.md)|  
  
###  <a name="ThreadUsage"></a> Thread Usage by Availability Groups  
 [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] has the following requirements for worker threads:  
  
-   On an idle instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] uses 0 threads.  
  
-   The maximum number of threads used by availability groups is the configured setting for the maximum number of server threads ('**max worker threads**') minus 40.  
  
-   The availability replicas hosted on a given server instance share a single thread pool.  
  
     Threads are shared on an on-demand basis, as follows:  
  
    -   Typically, there are 3–10 shared threads, but this number can increase depending on the primary replica workload.  
  
    -   If a given thread is idle for a while, it is released back into the general [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] thread pool. Normally, an inactive thread is released after ~15 seconds of inactivity. However, depending on the last activity, an idle thread might be retained longer.  
  
-   In addition, availability groups use unshared threads, as follows:  
  
    -   Each primary replica uses 1 Log Capture thread for each primary database. In addition, it uses 1 Log Send thread for each secondary database. Log send threads are released after ~15 seconds of inactivity.  
  
    -   Each secondary replica uses 1 redo thread for each secondary database. Redo threads are released after ~15 seconds of inactivity.  
  
    -   A backup on a secondary replica holds a thread on the primary replica for the duration of the backup operation.  
  
 For more information, see [Always On - HADRON Learning Series: Worker Pool Usage for HADRON Enabled Databases](http://blogs.msdn.com/b/psssql/archive/2012/05/17/Always%20On-hadron-learning-series-worker-pool-usage-for-hadron-enabled-databases.aspx) (a CSS [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Engineers Blog).  
  
###  <a name="PermissionsSI"></a> Permissions (Server Instance)  
  
|Task|Required Permissions|  
|----------|--------------------------|  
|Creating the database mirroring endpoint|Requires CREATE ENDPOINT permission, or membership in the **sysadmin** fixed server role.  Also requires CONTROL ON ENDPOINT permission. For more information, see [GRANT Endpoint Permissions (Transact-SQL)](assetId:///9eda885c-fc3a-4c9d-8de6-ce07fb35a934).|  
|Enabling [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)]|Requires membership in the **Administrator** group on the local computer and full control on the WSFC cluster.|  
  
###  <a name="RelatedTasksSI"></a> Related Tasks (Server Instance)  
  
|Task|Topic|  
|----------|-----------|  
|Determining whether database mirroring endpoint exists|[sys.database_mirroring_endpoints (Transact-SQL)](assetId:///f2285199-97ad-473c-a52d-270044dd862b)|  
|Creating the database mirroring endpoint (if it does not yet exist)|[Create a Database Mirroring Endpoint for Windows Authentication (Transact-SQL)](../../Topics/TopicNameContainA/Create-a-Database-Mirroring-Endpoint-for-Windows-Authentication--Transact-SQL-.md)<br /><br /> [Use Certificates for a Database Mirroring Endpoint (Transact-SQL)](../../Topics/TopicNameContainA/Use-Certificates-for-a-Database-Mirroring-Endpoint--Transact-SQL-.md)<br /><br /> [Create a Database Mirroring Endpoint for Always On Availability Groups (SQL Server PowerShell)](../../Topics/TopicNameContainA/Create-a-Database-Mirroring-Endpoint-for-Always-On-Availability-Groups--SQL-Server-PowerShell-.md)|  
|Enabling Always On Availability Groups|[Enable and Disable Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Enable-and-Disable-Always-On-Availability-Groups--SQL-Server-.md)|  
  
###  <a name="RelatedContentSI"></a> Related Content (Server Instance)  
  
-   [Always On - HADRON Learning Series: Worker Pool Usage for HADRON Enabled Databases](http://blogs.msdn.com/b/psssql/archive/2012/05/17/Always%20On-hadron-learning-series-worker-pool-usage-for-hadron-enabled-databases.aspx)  
  
##  <a name="NetworkConnect"></a> Network Connectivity Recommendations  
 We strongly recommend that you use the same network links for communications between WSFC cluster members and communications between availability replicas.  Using separate network links can cause unexpected behaviors if some of links fail (even intermittently).  
  
 For example, for an availability group to support automatic failover, the secondary replica that is the automatic-failover partner must be in the SYNCHRONIZED state. If the network link to this secondary replica fails (even intermittently), the replica enters the UNSYNCHRONIZED state and cannot begin to resynchronize until the link is restored. If the WSFC cluster requests an automatic failover while the secondary replica is unsynchronized, automatic failover will not occur.  
  
##  <a name="ClientConnSupport"></a> Client Connectivity Support  
 For information about [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] support for client connectivity, see [Always On Client Connectivity (SQL Server)](../../Topics/TopicNameNotContainA/Always-On-Client-Connectivity--SQL-Server-.md).  
  
##  <a name="FciArLimitations"></a> Prerequisites and Restrictions for Using a SQL Server Failover Cluster Instance (FCI) to Host an Availability Replica  
 **In This Section:**  
  
-   [Restrictions](#RestrictionsFCI)  
  
-   [Checklist: Prerequisites](#PrerequisitesFCI)  
  
-   [Related Tasks](#RelatedTasksFCIs)  
  
-   [Related Content](#RelatedContentFCIs)  
  
###  <a name="RestrictionsFCI"></a> Restrictions (FCIs)  
  
> [!NOTE]  
>  Beginning in [!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)], Always On Failover Cluster Instances supports Clustered Shared Volumes (CSV) in both [!INCLUDE[winserver2008r2](../../Topics/TopicNameContainA/includes/winserver2008r2_md.md)] and [!INCLUDE[win8srv](../../Topics/TopicNameContainA/includes/win8srv_md.md)]. For more information on CSV, see [Understanding Cluster Shared Volumes in a Failover Cluster](http://technet.microsoft.com/library/dd759255.aspx).  
  
-   **The cluster nodes of an FCI can host only one replica for a given availability group:**  If you add an availability replica on an FCI, the WSFC cluster nodes that are possible FCI owners cannot host another replica for the same availability group.  
  
     Furthermore, every other replica must be hosted by an instance of SQL Server 2012 that resides on a different WSFC node in the same WSFC cluster. The only exception is that while being migrated to another WSFC cluster, an availability group can temporarily straddle two clusters.  
  
-   **FCIs do not support automatic failover by availability groups:**  FCIs do not support automatic failover by availability groups, so any availability replica that is hosted by an FCI can be configured for manual failover only.  
  
-   **Changing FCI network name:**  If you need to change the network name of an FCI that hosts an availability replica, you will need to remove the replica from its availability group and then add the replica back into the availability group. You cannot remove the primary replica, so if you are renaming an FCI that is hosting the primary replica, you should fail over to a secondary replica and then remove the former primary replica and add it back. Note that renaming an FCI might alter the URL of its database mirroring endpoint. When you add the replica ensure that you specify the current endpoint URL.  
  
###  <a name="PrerequisitesFCI"></a> Checklist: Prerequisites (FCIs)  
  
||Prerequisite|Link|  
|-|------------------|----------|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Before you use an FCI to host an availability replica, ensure that your system administrator has installed the Windows Server 2008 hotfix described in Knowledge Base article KB 976097. This hotfix enables the Failover Cluster Management Microsoft Management Console (MMC) snap-in to support asymmetric storage—shared disks that are available on only some of the WSFC nodes.|KB 976097:  [Hotfix to add support for asymmetric storages to the Failover Cluster Management MMC snap-in for a failover cluster that is running Windows Server 2008 or Windows Server 2008 R2](http://support.microsoft.com/kb/976097)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Ensure that each SQL Server failover cluster instance (FCI) possesses the required shared storage as per standard SQL Server failover cluster instance installation.||  
  
###  <a name="RelatedTasksFCIs"></a> Related Tasks (FCIs)  
  
|Task|Topic|  
|----------|-----------|  
|Installing a SQL Server Failover Cluster|[Create a New SQL Server Failover Cluster (Setup)](../../Topics/TopicNameContainA/Create-a-New-SQL-Server-Failover-Cluster--Setup-.md)|  
|In-place upgrade of your existing SQL Server Failover Cluster|[Upgrade a SQL Server Failover Cluster Instance (Setup)](../../Topics/TopicNameContainA/Upgrade-a-SQL-Server-Failover-Cluster-Instance--Setup-.md)|  
|Maintaining your existing SQL Server Failover Cluster|[Add or Remove Nodes in a SQL Server Failover Cluster (Setup)](../../Topics/TopicNameContainA/Add-or-Remove-Nodes-in-a-SQL-Server-Failover-Cluster--Setup-.md)|  
  
###  <a name="RelatedContentFCIs"></a> Related Content (FCIs)  
  
-   [Failover Clustering and Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Failover-Clustering-and-Always-On-Availability-Groups--SQL-Server-.md)  
  
-   [Always On Architecture Guide: Building a High Availability and Disaster Recovery Solution by Using Failover Cluster Instances and Availability Groups](http://technet.microsoft.com/library/jj215886.aspx)  
  
##  <a name="PrerequisitesForAGs"></a> Availability Group Prerequisites and Restrictions  
 **In This Section:**  
  
-   [Restrictions](#RestrictionsAG)  
  
-   [Requirements](#RequirementsAG)  
  
-   [Security](#SecurityAG)  
  
-   [Related Tasks](#RelatedTasksAGs)  
  
###  <a name="RestrictionsAG"></a> Restrictions (Availability Groups)  
  
-   **Availability replicas must be hosted by different nodes of one WSFC cluster:**  For a given availability group, availability replicas must be hosted by server instances running on different nodes of the same WSFC cluster. The only exception is that while being migrated to another WSFC cluster, an availability group can temporarily straddle two clusters.  
  
    > [!NOTE]  
    >  Virtual machines on the same physical computer can each host an availability replica for the same availability group because each virtual machine acts as a separate computer.  
  
-   **Unique availability group name:**  Each availability group name must be unique on the WSFC cluster. The maximum length for an availability group name is 128 characters.  
  
-   **Availability replicas:**  Each availability group supports one primary replica and up to eight secondary replicas. All of the replicas can run under asynchronous-commit mode, or up to three of them can run under synchronous-commit mode (one primary replica with two synchronous secondary replicas).  
  
-   **Maximum number of availability groups and availability databases per computer:** The actual number of databases and availability groups you can put on a computer (VM or physical) depends on the hardware and workload, but there is no enforced limit. Microsoft has extensively tested with 10 AGs and 100 DBs per physical machine. Signs of overloaded systems can include, but are not limited to, worker thread exhaustion, slow response times for Always On system views and DMVs, and/or stalled dispatcher system dumps. Please make sure to thoroughly test your environment with a production-like workload to ensure it can handle peak workload capacity within your application SLAs. When considering SLAs be sure to consider load under failure conditions as well as expected response times.  
  
-   **Do not use the Failover Cluster Manager to manipulate availability groups:**  
  
     For example:  
  
    -   Do not change any availability group properties, such as the possible owners.  
  
    -   Do not use the Failover Cluster Manager to fail over availability groups. You must use [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] or [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)].  
  
###  <a name="RequirementsAG"></a> Prerequisites (Availability Groups)  
 When creating or reconfiguring an availability group configuration, ensure that you adhere to the following requirements.  
  
||Prerequisite|Description|  
|-|------------------|-----------------|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|If you plan to use a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] failover cluster instance (FCI) to host an availability replica, ensure that you understand the FCI restrictions and that the FCI requirements are met.|[Prerequisites and Restrictions for Using a SQL Server Failover Cluster Instance (FCI) to Host an Availability Replica](#FciArLimitations) (earlier in this topic)|  
  
###  <a name="SecurityAG"></a> Security (Availability Groups)  
  
-   Security is inherited from the Windows Server Failover Clustering (WSFC) cluster. WSFC provides two levels of user security at granularity of entire WSFC cluster APIs:  
  
    -   Read-only access  
  
    -   Full control  
  
         [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] needs full control, and enabling [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] on an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] gives it full control of the WSFC cluster (through Service SID).  
  
         You cannot directly add or remove security for a server instance in the WSFC Failover Cluster Manager. To manage WSFC security sessions, use the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager or the WMI equivalent from [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
-   Each instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] must have permissions to access the registry, cluster, and soforth.  
  
-   We recommend that you use encryption for connections between server instances that host [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] availability replicas.  
  
#### Permissions (Availability Groups)  
  
|Task|Required Permissions|  
|----------|--------------------------|  
|Creating an availability group|Requires membership in the **sysadmin** fixed server role and either CREATE AVAILABILITY GROUP server permission, ALTER ANY AVAILABILITY GROUP permission, or CONTROL SERVER permission.|  
|Altering an  availability group|Requires ALTER AVAILABILITY GROUP permission on the availability group, CONTROL AVAILABILITY GROUP permission, ALTER ANY AVAILABILITY GROUP permission, or CONTROL SERVER permission.<br /><br /> In addition, joining a database to an availability group requires membership in the **db_owner** fixed database role.|  
|Dropping/deleting an availability group|Requires ALTER AVAILABILITY GROUP permission on the availability group, CONTROL AVAILABILITY GROUP permission, ALTER ANY AVAILABILITY GROUP permission, or CONTROL SERVER permission. To drop an availability group that is not hosted on the local replica location you need CONTROL SERVER permission or CONTROL permission on that Availability Group.|  
  
###  <a name="RelatedTasksAGs"></a> Related Tasks (Availability Groups)  
  
|Task|Topic|  
|----------|-----------|  
|Creating an availability group|[Use the Availability Group (New Availability Group Wizard)](../../Topics/TopicNameNotContainA/Use-the-Availability-Group-Wizard--SQL-Server-Management-Studio-.md)<br /><br /> [Create an Availability Group (Transact-SQL)](../../Topics/TopicNameNotContainA/Create-an-Availability-Group--Transact-SQL-.md)<br /><br /> [Create an Availability Group (SQL Server PowerShell)](../../Topics/TopicNameNotContainA/Create-an-Availability-Group--SQL-Server-PowerShell-.md)<br /><br /> [Specify the Endpoint URL When Adding or Modifying an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Specify-the-Endpoint-URL-When-Adding-or-Modifying-an-Availability-Replica--SQL-Server-.md)|  
|Modifying the number of availability replicas|[Add a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md)<br /><br /> [Join a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md)<br /><br /> [Remove a Secondary Replica from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Replica-from-an-Availability-Group--SQL-Server-.md)|  
|Creating an  availability group listener|[Create or Configure an Availability Group Listener (SQL Server)](../../Topics/TopicNameNotContainA/Create-or-Configure-an-Availability-Group-Listener--SQL-Server-.md)|  
|Dropping an  availability group|[Remove an Availability Group (SQL Server)](../../Topics/TopicNameNotContainA/Remove-an-Availability-Group--SQL-Server-.md)|  
  
##  <a name="PrerequisitesForDbs"></a> Availability Database Prerequisites and Restrictions  
 To be eligible to be added to an availability group, a database must meet the following prerequisites and restrictions.  
  
 **In This Section:**  
  
-   [Requirements](#RequirementsDb)  
  
-   [Restrictions](#RestrictionsDb)  
  
-   [Recommendations for Computers That Host Availability Replicas (Windows System](#TDEdbs)  
  
-   [Permissions](#PermissionsDbs)  
  
-   [Related Tasks](#RelatedTasksADb)  
  
###  <a name="RequirementsDb"></a> Checklist: Requirements (Availability Databases)  
 To be eligible to be added to an availability group, a database must:  
  
||Requirements|Link|  
|-|------------------|----------|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Be a user database. System databases cannot belong to an availability group.||  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Reside on the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] where you create the availability group and be accessible to the server instance.||  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Be a read-write database. Read-only databases cannot be added to an availability group.|[sys.databases](assetId:///46c288c1-3410-4d68-a027-3bbf33239289) (**is_read_only** = 0)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Be a multi-user database.|[sys.databases](assetId:///46c288c1-3410-4d68-a027-3bbf33239289) (**user_access** = 0)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Not use AUTO_CLOSE.|[sys.databases](assetId:///46c288c1-3410-4d68-a027-3bbf33239289) (**is_auto_close_on** = 0)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Use the full recovery model (also known as, full recovery mode).|[sys.databases](assetId:///46c288c1-3410-4d68-a027-3bbf33239289) (**recovery_model** = 1)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Possess at least one full database backup.<br /><br /> Note: After setting a database to full recovery mode, a full backup is required to initiate the full-recovery log chain.|[Create a Full Database Backup (SQL Server)](../../Topics/TopicNameContainA/Create-a-Full-Database-Backup--SQL-Server-.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Not belong to any existing availability group.|[sys.databases](assetId:///46c288c1-3410-4d68-a027-3bbf33239289) (**group_database_id** = NULL)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Not be configured for database mirroring.|[sys.database_mirroring](assetId:///480de2b0-2c16-497d-a6a3-bf7f52a7c9a0) (If the database does not participate in mirroring, all columns prefixed with "mirroring_" are NULL.)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Before adding a database that uses FILESTREAM to an availability group, ensure that FILESTREAM is enabled on every server instance that hosts or will host an availability replica for the availability group.|[Enable and Configure FILESTREAM](../../Topics/TopicNameNotContainA/Enable-and-Configure-FILESTREAM.md)|  
|![Checkbox](../../Topics/TopicNameNotContainA/media/CheckboxEmptyCenterXtraSpaceTopAndRight.gif "CheckboxEmptyCenterXtraSpaceTopAndRight")|Before adding a contained database to an availability group, ensure that the **contained database authentication** server option is set to **1** on every server instance that hosts or will host an availability replica for the availability group.|[contained database authentication Server Configuration Option](../../Topics/TopicNameNotContainA/contained-database-authentication-Server-Configuration-Option.md)<br /><br /> [Server Configuration Options (SQL Server)](../../Topics/TopicNameNotContainA/Server-Configuration-Options--SQL-Server-.md)|  
  
> [!NOTE]  
>  [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] works with any supported database compatibility level.  
  
###  <a name="RestrictionsDb"></a> Restrictions (Availability Databases)  
  
-   If the file path (including the drive letter) of a secondary database differs from the path of the corresponding primary database, the following restrictions apply:  
  
    -   **[!INCLUDE[ssAoNewAgWiz](../../Topics/TopicNameNotContainA/includes/ssAoNewAgWiz_md.md)]/[!INCLUDE[ssAoAddDbWiz](../../Topics/TopicNameNotContainA/includes/ssAoAddDbWiz_md.md)]:**  The **Full** option is not supported (on the[Select Initial Data Synchronization Page](../../Topics/TopicNameNotContainA/Select-Initial-Data-Synchronization-Page--Always-On-Availability-Group-Wizards-.md) page),  
  
    -   **RESTORE WITH MOVE:**  To create the secondary databases, the database files must be RESTORED WITH MOVE on each instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that hosts a secondary replica.  
  
    -   **Impact on add-file operations:**  A later add-file operation on the primary replica might fail on the secondary databases. This failure could cause the secondary databases to be suspended. This, in turn, causes the secondary replicas to enter the NOT SYNCHRONIZING state.  
  
        > [!NOTE]  
        >  For information about responding to a failed ad-file operation, see [Troubleshoot a Failed Add-File Operation (Always On Availability Groups)](../../Topics/TopicNameContainA/Troubleshoot-a-Failed-Add-File-Operation--Always-On-Availability-Groups-.md).  
  
-   You cannot drop a database that currently belongs to an availability group.  
  
###  <a name="TDEdbs"></a> Follow Up for TDE Protected Databases  
 If you use transparent data encryption (TDE), the certificate or asymmetric key for creating and decrypting other keys must be the same on every server instance that hosts an availability replica for the availability group. For more information, see [Move a TDE Protected Database to Another SQL Server](../../Topics/TopicNameContainA/Move-a-TDE-Protected-Database-to-Another-SQL-Server.md).  
  
###  <a name="PermissionsDbs"></a> Permissions (Availability Databases)  
 Requires ALTER permission on the database.  
  
###  <a name="RelatedTasksADb"></a> Related Tasks (Availability Databases)  
  
|Task|Topic|  
|----------|-----------|  
|Preparing a secondary database (manually)|[Manually Prepare a Secondary Database for an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Manually-Prepare-a-Secondary-Database-for-an-Availability-Group--SQL-Server-.md)|  
|Joining a secondary database to availability group (manually)|[Join a Secondary Database to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Database-to-an-Availability-Group--SQL-Server-.md)|  
|Modifying the number of availability databases|[Add a Database to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Database-to-an-Availability-Group--SQL-Server-.md)<br /><br /> [Remove a Secondary Database from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Database-from-an-Availability-Group--SQL-Server-.md)<br /><br /> [Remove a Primary Database from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Primary-Database-from-an-Availability-Group--SQL-Server-.md)|  
  
##  <a name="RelatedContent"></a> Related Content  
  
-   [Microsoft SQL Server Always On Solutions Guide for High Availability and Disaster Recovery](http://go.microsoft.com/fwlink/?LinkId=227600)  
  
-   [SQL Server Always On Team Blog: The official SQL Server Always On Team Blog](http://blogs.msdn.com/b/sqlAlways%20On/)  
  
-   [Always On - HADRON Learning Series: Worker Pool Usage for HADRON Enabled Databases](http://blogs.msdn.com/b/psssql/archive/2012/05/17/Always%20On-hadron-learning-series-worker-pool-usage-for-hadron-enabled-databases.aspx)  
  
## See Also  
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)   
 [Failover Clustering and Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Failover-Clustering-and-Always-On-Availability-Groups--SQL-Server-.md)   
 [Always On Client Connectivity (SQL Server)](../../Topics/TopicNameNotContainA/Always-On-Client-Connectivity--SQL-Server-.md)