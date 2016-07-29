---
title: "Data synchronization state of some availability database is not healthy"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 89f95d15-33c6-4768-bccd-9dbf8c4f49a9
caps.latest.revision: 16
manager: jhubbard
---
# Data synchronization state of some availability database is not healthy
## Introduction  
  
|||  
|-|-|  
|**Policy Name**|Availability Replica Data Synchronization State|  
|**Issue**|Data synchronization state of some availability database is not healthy.|  
|**Category**|**Warning**|  
|**Facet**|Availability replica|  
  
## Description  
 This policy checks the data synchronization state of the availability database (also known as a "database replica"). The policy is in an unhealthy state when the data synchronization state is NOT SYNCHRONIZING or the state is not SYNCHRONIZED for the synchronous-commit database replica.  
  
> [!NOTE]  
>  For this release of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)], information about possible causes and solutions is located at [Data synchronization state of availability database is not healthy](http://go.microsoft.com/fwlink/p/?LinkId=220863) on the TechNet Wiki.  
  
## Possible Causes  
 At least one availability database on the replica has an unhealthy data synchronization state. If this is an asynchronous-commit availability replica, all availability databases should be in the SYNCHRONIZING state. If this is a synchronous-commit availability replica, all availability databases should be in the SYNCHRONIZED state. This issue can be caused by the following:  
  
-   The availability replica might be disconnected.  
  
-   The data movement might be suspended.  
  
-   The database might not be accessible.  
  
-   There might be a temporary delay issue due to network latency or the load on the primary or secondary replica.  
  
## Possible Solution  
 Resolve any connection or data movement suspend issues. Check the events for this issue using SQL Server Management Studio, and find the database error. Follow the troubleshooting steps for the specific error.  
  
## See Also  
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)   
 [Use the Always On Dashboard (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Use-the-Always-On-Dashboard--SQL-Server-Management-Studio-.md)