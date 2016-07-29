---
title: "Always On Client Connectivity (SQL Server)"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b456448d-1757-48c8-8bbb-2d1c2d6d61e9
caps.latest.revision: 22
manager: jhubbard
---
# Always On Client Connectivity (SQL Server)
This topic describes considerations for client connectivity to Always On Availability Groups, including prerequisites, restrictions, and recommendations for client configurations and settings.  
  
 **In this Topic:**  
  
-   [Client Connectivity Support](#ClientConnSupport)  
  
-   [Related Tasks](#RelatedTasks)  
  
##  <a name="ClientConnSupport"></a> Client Connectivity Support  
 The section below provides information about [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] support for client connectivity.  
  
 **Driver Support**  
  
 The following table summarizes driver support for [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)]:  
  
|Driver|Multi-Subnet Failover|Application Intent|Read-Only Routing|Multi-Subnet Failover: Faster Single Subnet Endpoint Failover|Multi-Subnet Failover: Named Instance Resolution For SQL Clustered Instances|  
|------------|----------------------------|------------------------|------------------------|--------------------------------------------------------------------|-----------------------------------------------------------------------------------|  
|SQL Native Client 11.0 ODBC|Yes|Yes|Yes|Yes|Yes|  
|SQL Native Client 11.0 OLEDB|No|Yes|Yes|No|No|  
|ADO.NET with .NET Framework 4.0 with connectivity patch*|Yes|Yes|Yes|Yes|Yes|  
|ADO.NET with .NET Framework 3.5 SP1 with connectivity patch**|Yes|Yes|Yes|Yes|Yes|  
|Microsoft JDBC driver 4.0 for SQL Server|Yes|Yes|Yes|Yes|Yes|  
  
 *Download the connectivity patch for ADO .NET with .NET Framework 4.0: [http://support.microsoft.com/kb/2600211](http://support.microsoft.com/kb/2600211).  
  
 **Download the connectivity patch for ADO.NET with .NET Framework 3.5 SP1: [http://support.microsoft.com/kb/2654347](http://support.microsoft.com/kb/2654347).  
  
> [!IMPORTANT]  
>  To connect to an availability group listener, a client must use a TCP connection string.  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Creation and Configuration of Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Creation-and-Configuration-of-Availability-Groups--SQL-Server-.md)  
  
-   [Create or Configure an Availability Group Listener (SQL Server)](../../Topics/TopicNameNotContainA/Create-or-Configure-an-Availability-Group-Listener--SQL-Server-.md)  
  
## See Also  
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)   
 [Failover Clustering and Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Failover-Clustering-and-Always-On-Availability-Groups--SQL-Server-.md)   
 [Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Prerequisites--Restrictions--and-Recommendations-for-Always-On-Availability-Groups--SQL-Server-.md)   
 [Availability Group Listeners, Client Connectivity, and Application Failover (SQL Server)](../../Topics/TopicNameNotContainA/Availability-Group-Listeners--Client-Connectivity--and-Application-Failover--SQL-Server-.md)   
 [About Client Connection Access to Availability Replicas (SQL Server)](../../Topics/TopicNameNotContainA/About-Client-Connection-Access-to-Availability-Replicas--SQL-Server-.md)   
 [Microsoft SQL Server Always On Solutions Guide for High Availability and Disaster Recovery](http://go.microsoft.com/fwlink/?LinkId=227600)   
 [SQL Server Always On Team Blog: The official SQL Server Always On Team Blog](http://blogs.msdn.com/b/sqlAlways%20On/)   
 [A long time delay occurs when you reconnect an IPSec connection from a computer that is running Windows Server 2003, Windows Vista, Windows Server 2008, Windows 7, or Windows Server 2008 R2](http://support.microsoft.com/kb/980915)   
 [The Cluster service takes about 30 seconds to fail over IPv6 IP addresses in Windows Server 2008 R2](http://support.microsoft.com/kb/2578113)   
 [Slow failover operation if no router exists between the cluster and an application server](http://support.microsoft.com/kb/2582281)