---
title: "SQL Server, Availability Replica"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e402f996-c1fb-484a-b804-45c49972f2e0
caps.latest.revision: 25
manager: jhubbard
---
# SQL Server, Availability Replica
The **SQLServer:Availability Replica** performance object contains performance counters that report information about the availability replicas in Always On availability groups in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)]. All availability replica performance counters apply to both the primary replica and the secondary replicas, with send/receive counters reflecting the local replica. For the most part, the primary replica sends most of the data, and the secondary replicas receive the data. However, secondary replicas send ACKs and some other background traffic to the primary replicas. Note that on a given availability replica, some counters will show a zero value, depending on the current role, primary or secondary, of the local replica.  
  
|Counter Name|Description|  
|------------------|-----------------|  
|**Bytes Received from Replica/sec**|Number of bytes received from the availability replica per second. Pings and status updates will generate network traffic even on databases with no user updates.|  
|**Bytes Sent to Replica/sec**|Number of bytes sent to the remote availability replica per second. On the primary replica this is the number of bytes sent to the secondary replica. On the secondary replica this is the number of bytes sent to the primary replica.|  
|**Bytes Sent to Transport/sec**|Actual number of bytes sent per second over the network to the remote availability replica. On the primary replica this is the number of bytes sent to the secondary replica. On the secondary replica this is the number of bytes sent to the primary replica.|  
|**Flow Control Time (ms/sec)**|Time in milliseconds that log stream messages waited for send flow control, in the last second.|  
|**Flow Control/sec**|Number of times flow-control initiated in the last second. **Flow Control Time (ms/sec)** divided by **Flow Control/sec** is the average time per wait.|  
|**Receives from Replica/sec**|Number of Always On messages received from thereplica per second.|  
|**Resent Messages/sec**|Number of Always On messages resent in the last second.|  
|**Sends to Replica/sec**|Number of Always On messages sent to this availability replica per second.|  
|**Sends to Transport/sec**|Actual number of Always On messages sent per second over the network to the remote availability replica. On the primary replica this is the number of messages sent to the secondary replica. On the secondary replica this is the number of messages sent to the primary replica.|  
  
## See Also  
 [Monitor Resource Usage (System Monitor)](../../Topics/TopicNameNotContainA/Monitor-Resource-Usage--System-Monitor-.md)   
 [SQL Server, Database Replica](../../Topics/TopicNameNotContainA/SQL-Server--Database-Replica.md)   
 [Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Always-On-Availability-Groups--SQL-Server-.md)