---
title: "Availability Group Properties: New Availability Group (General Page)"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9af5379f-91b8-4729-9f75-4a80242a30e9
caps.latest.revision: 16
manager: jhubbard
---
# Availability Group Properties: New Availability Group (General Page)
This topic applies to the **General** tab of both the **New Availability Group** dialog box and the **Availability Group Properties** dialog box.  The **New Availability Group** dialog box enables you to create a new availability group without using the [!INCLUDE[ssAoNewAgWiz](../../Topics/TopicNameNotContainA/includes/ssAoNewAgWiz_md.md)]. The **Availability Group Properties** dialog box enables you to view and alter the configuration of an existing availability group.  
  
 **To view availability group properties**  
  
-   [View Availability Group Properties (SQL Server)](../../Topics/TopicNameNotContainA/View-Availability-Group-Properties--SQL-Server-.md)  
  
-   [Use the Always On Dashboard (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Use-the-Always-On-Dashboard--SQL-Server-Management-Studio-.md)  
  
## UIElement List  
 **Availability group name**  
 Name of the availability group. This is a user-specified name that must be unique within the Windows Server Failover Cluster (WSFC).  
  
## Availability Databases  
 **Database Name**  
 Name of a database that has been added to the availability group.  
  
 **Add**  
 Click to add a database to the availability group.  
  
 **Remove**  
 Click to remove a selected database from the availability group.  
  
## Availability Replicas  
 **Server instance**  
 Server name of the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that is hosting this replica and, for a non-default instance, its instance name.  
  
 **Role**  
 **Primary**  
 Currently the primary replica.  
  
 **Secondary**  
 Currently a secondary replica.  
  
 **Resolving**  
 Currently the replica role is in the process of being resolved to either the primary or secondary role.  
  
 **Availability Mode**  
 The availability mode of the replica, one of:  
  
 **Asynchronous commit**  
 The primary replica can commit transactions without waiting for the secondary to write the log to disk.  
  
 **Synchronous commit**  
 The primary replica waits to commit a given transaction until the secondary replica has written the transaction to disk.  
  
 For more information, see [Availability Modes (Always On Availability Groups)](../../Topics/TopicNameNotContainA/Availability-Modes--Always-On-Availability-Groups-.md).  
  
 **Failover Mode**  
 The failover mode of the replica, one of:  
  
 **Automatic**  
 Automatic failover. The replica is a target for automatic failovers. This is supported only if the availability mode is set to synchronous commit.  
  
 **Manual**  
 Manual failover. The replica can only be failed over to manually by the database administrator.  
  
 **Connections in Primary Role**  
 The type of client connections supported when the replica owns the primary role.  
  
 **Allow all connections**  
 All connections are allowed to the databases in the primary replica. This is the default setting.  
  
 **Allow read/write connections**  
 Connections where the Application Intent connection property is set to **ReadOnly** are disallowed. When the Application Intent property is set to **ReadWrite** or the Application Intent connection property is not set, the connection is allowed. For more information about Application Intent connection property, see [Using Connection String Keywords with SQL Server Native Client](assetId:///16008eec-eddf-4d10-ae99-29db26ed6372).  
  
 **Readable Secondary**  
 Whether an availability replica that is performing the secondary role (that is, a secondary replica) can accept connections from clients, one of:  
  
 **No**  
 No direct connections are allowed to secondary databases of this replica. They are not available for read access. This is the default setting.  
  
 **Read-intent only**  
 Only direct read-only connections are allowed to secondary databases of this replica. The secondary database(s) are all available for read access.  
  
 **Yes**  
 All connections are allowed to secondary databases of this replica, but only for read access. The secondary database(s) are all available for read access.  
  
 **Session Timeout (seconds)**  
 The number of seconds for the session-timeout period on this replica.  
  
 **Endpoint URL**  
 The URL of the endpoint. For information the format of these URLs, see [Specify the Endpoint URL When Adding or Modifying an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Specify-the-Endpoint-URL-When-Adding-or-Modifying-an-Availability-Replica--SQL-Server-.md).  
  
 **Add**  
 Click to add a secondary replica to the availability group.  
  
 **Remove**  
 Click to remove a secondary replica from the availability group.  
  
## See Also  
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)