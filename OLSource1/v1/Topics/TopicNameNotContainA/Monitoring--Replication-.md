---
title: "Monitoring (Replication)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f182f43a-6af8-45bc-a708-08d5f7a6984a
caps.latest.revision: 40
manager: jhubbard
---
# Monitoring (Replication)
Monitoring a replication topology is an important aspect of deploying replication. Because replication activity is distributed, it is essential to track activity and status across all computers involved in replication. The following tools can be used to monitor replication:  
  
-   [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Replication Monitor  
  
     Replication Monitor is the most important tool for monitoring replication, presenting a Publisher-focused view of all replication activity. For more information, see [Monitoring Replication](../../Topics/TopicNameNotContainA/Monitoring-Replication.md).  
  
-   [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]  
  
     [!INCLUDE[ssManStudio](../../Topics/TopicNameContainA/includes/ssManStudio_md.md)] provides access to Replication Monitor. It also allows you to view the current status and last message logged by the following agents and allows you start and stop each agent: Log Reader Agent, Snapshot Agent, Merge Agent, and Distribution Agent. For more information, see [Monitor Replication Agents](../../Topics/TopicNameNotContainA/Monitor-Replication-Agents.md).  
  
-   [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] and Replication Management Objects (RMO)  
  
     Both interfaces allow you to monitor all types of replication from the Distributor. Merge replication also provides the ability to monitor replication from the Subscriber.  
  
-   Alerts for replication agent events  
  
     Replication provides a number of predefined alerts for replication agent events, and you can create additional alerts if necessary. Alerts can be used to trigger an automated response to an event and/or notify an administrator. For more information, see [Use Alerts for Replication Agent Events](../../Topics/TopicNameNotContainA/Use-Alerts-for-Replication-Agent-Events.md).  
  
-   System Monitor  
  
     System Monitor can be useful for monitoring performance, providing a number of counters for replication. For more information, see [Monitoring Replication with System Monitor](../../Topics/TopicNameNotContainA/Monitoring-Replication-with-System-Monitor.md).  
  
## See Also  
 [Administration (Replication)](../../Topics/TopicNameNotContainA/Administration--Replication-.md)   
 [Best Practices for Replication Administration](../../Topics/TopicNameNotContainA/Best-Practices-for-Replication-Administration.md)   
 [Monitoring Replication](../../Topics/TopicNameNotContainA/Monitoring-Replication.md)