---
title: "Replication Agents Overview"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a35ecd7d-f130-483c-87e3-ddc8927bb91b
caps.latest.revision: 43
manager: jhubbard
---
# Replication Agents Overview
Replication uses a number of standalone programs, called agents, to carry out the tasks associated with tracking changes and distributing data. By default, replication agents run as jobs scheduled under [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent, and [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent must be running for the jobs to run. Replication agents can also be run from the command line and by applications that use Replication Management Objects (RMO). Replication agents can be administered from [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Replication Monitor and [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)].  
  
## SQL Server Agent  
 [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent hosts and schedules the agents used in replication and provides an easy way to run replication agents. [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent also controls and monitors operations outside of replication. For more information, see [Administering Replication Agents](assetId:///2e361a62-9e92-4fcd-80d7-d6960f127900).  
  
> [!IMPORTANT]  
>  By default, the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent service is disabled when [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] is installed unless you explicitly choose to autostart the service during installation. For more information about starting the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent service, see [Start, Stop, or Pause the SQL Server Agent Service](assetId:///c95a9759-dd30-4ab6-9ab0-087bb3bfb97c).  
  
## Snapshot Agent  
 The Snapshot Agent is typically used with all types of replication. It prepares schema and initial data files of published tables and other objects, stores the snapshot files, and records information about synchronization in the distribution database. The Snapshot Agent runs at the Distributor. For more information, see [Replication Snapshot Agent](../../Topics/TopicNameNotContainA/Replication-Snapshot-Agent.md).  
  
## Log Reader Agent  
 The Log Reader Agent is used with transactional replication. It moves transactions marked for replication from the transaction log on the Publisher to the distribution database. Each database published using transactional replication has its own Log Reader Agent that runs on the Distributor and connects to the Publisher (the Distributor can be on the same computer as the Publisher). For more information, see [Replication Log Reader Agent](../../Topics/TopicNameNotContainA/Replication-Log-Reader-Agent.md).  
  
## Distribution Agent  
 The Distribution Agent is used with snapshot replication and transactional replication. It applies the initial snapshot to the Subscriber and moves transactions held in the distribution database to Subscribers. The Distribution Agent runs at either the Distributor for push subscriptions or at the Subscriber for pull subscriptions. For more information, see [Replication Distribution Agent](../../Topics/TopicNameNotContainA/Replication-Distribution-Agent.md).  
  
## Merge Agent  
 The Merge Agent is used with merge replication. It applies the initial snapshot to the Subscriber and moves and reconciles incremental data changes that occur. Each merge subscription has its own Merge Agent that connects to both the Publisher and the Subscriber and updates both. The Merge Agent runs at either the Distributor for push subscriptions or the Subscriber for pull subscriptions. By default, the Merge Agent uploads changes from the Subscriber to the Publisher and then downloads changes from the Publisher to the Subscriber. For more information, see [Replication Merge Agent](../../Topics/TopicNameNotContainA/Replication-Merge-Agent.md).  
  
## Queue Reader Agent  
 The Queue Reader Agent is used with transactional replication with the queued updating option. The agent runs at the Distributor and moves changes made at the Subscriber back to the Publisher. Unlike the Distribution Agent and the Merge Agent, only one instance of the Queue Reader Agent exists to service all Publishers and publications for a given distribution database. For more information about the Queue Reader Agent, see [Replication Queue Reader Agent](../../Topics/TopicNameNotContainA/Replication-Queue-Reader-Agent.md). For more information about updatable subscriptions, see [Updatable Subscriptions for Transactional Replication](../../Topics/TopicNameNotContainA/Updatable-Subscriptions-for-Transactional-Replication.md).  
  
## Replication Maintenance Jobs  
 Replication has a number of maintenance jobs that perform scheduled and on-demand maintenance. For more information, see [Replication Agent Administration](../../Topics/TopicNameNotContainA/Replication-Agent-Administration.md).  
  
## See Also  
 [Start and Stop a Replication Agent (SQL Server Management Studio)](../../Topics/TopicNameContainA/Start-and-Stop-a-Replication-Agent--SQL-Server-Management-Studio-.md)   
 [Run Replication Maintenance Jobs (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Run-Replication-Maintenance-Jobs--SQL-Server-Management-Studio-.md)   
 [Programming Replication Agent Executables](assetId:///cba476df-d4ea-44c9-bb86-81488971e328)   
 [Replication Agent Administration](../../Topics/TopicNameNotContainA/Replication-Agent-Administration.md)