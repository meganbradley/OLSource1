---
title: "MSSQL_ENG020554"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ef1a1b88-b2ab-43e8-99cd-163a973262d6
caps.latest.revision: 17
manager: jhubbard
---
# MSSQL_ENG020554
## Message Details  
  
|||  
|-|-|  
|Product Name|SQL Server|  
|Event ID|20554|  
|Event Source|MSSQLSERVER|  
|Component|[!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)]|  
|Symbolic Name||  
|Message Text|The replication agent has not logged a progress message in %ld minutes. This might indicate an unresponsive agent or high system activity. Verify that records are being replicated to the destination and that connections to the Subscriber, Publisher, and Distributor are still active.|  
  
## Explanation  
 The **Replication agents checkup** job runs at a specified interval (10 minutes by default) to check on the status of each replication agent. If an agent has not logged any progress messages since the last time the agent checkup job ran, error MSSQL_ENG020554 can be raised. The agent is expected at least to log history messages even if no other replication activity is occurring. Although the replication agent is not responding as expected, it has not necessarily stopped or failed (if an agent has failed, error MSSQL_ENG020536 should be raised).  
  
 The following issues can cause error MSSQL_ENG020554 to be raised:  
  
-   The agent is busy.  
  
     If the agent is too busy to respond when polled by the agent checkup job, the agent checkup job cannot report whether the replication agent is functioning properly. There are a number of reasons why the replication agent could be busy: there might be a lot of data being replicated, or there might be application design or configuration issues that result in processes that run for a long time.  
  
-   The agent cannot log in to one of the computers in the topology.  
  
     All agents have a parameter **-LoginTimeOut** (set to 15 seconds by default), which governs how long an agent attempts to log in to a replication node, such as a Merge Agent logging in to the Publisher. If the **-LoginTimeOut** value is set higher than the interval at which the replication agent checkup job runs, a login problem could be the root cause of the error: error MSSQL_ENG020554 is raised before the agent is able to raise a more specific error.  
  
## User Action  
 The action required depends on the cause of the error:  
  
-   For all cases in which this error is raised:  
  
     Check the error details in Replication Monitor, and then restart the agent if it has stopped. The error details might provide additional information on why the agent was not running properly. If the agent is running, do not stop and restart the agent, because that can exacerbate the problem. For information about viewing agent status and error details in Replication Monitor, see the following topics:  
  
    -   For the Snapshot Agent, Log Reader Agent, and Queue Reader Agent, see [View Information and Perform Tasks for the Agents Associated With a Publication (Replication Monitor)](../../Topics/TopicNameContainA/View-Information-and-Perform-Tasks-for-the-Agents-Associated-With-a-Publication--Replication-Monitor-.md).  
  
    -   For the Distribution Agent and Merge Agent, see [View Information and Perform Tasks for the Agents Associated With a Subscription (Replication Monitor)](../../Topics/TopicNameContainA/View-Information-and-Perform-Tasks-for-the-Agents-Associated-With-a-Subscription--Replication-Monitor-.md).  
  
-   If this error is raised frequently because the agent is busy:  
  
     You might need to redesign your application so that the agent spends less time processing.  
  
     You can increase the interval at which agent status is checked using the **Job Properties** dialog box. For information about accessing this dialog box for replication jobs, see [View Information and Perform Tasks for a Publisher (Replication Monitor)](../../Topics/TopicNameContainA/View-Information-and-Perform-Tasks-for-a-Publisher--Replication-Monitor-.md).  
  
-   If an agent cannot log in to one of the computers in the topology:  
  
     We recommend that the **-LoginTimeOut** value be set lower than the interval at which the replication agent checkup job runs. In some cases, the value for **-LoginTimeOut** is set higher because of network issues that cause logins to time out. If the **-LoginTimeOut** is set lower, replication can report more specific errors, allowing you to troubleshoot login problems that could be caused by permissions, network problems, or other issues. Agent parameters can be specified in agent profiles and on the command line. For more information, see:  
  
    -   [Work with Replication Agent Profiles](../../Topics/TopicNameNotContainA/Work-with-Replication-Agent-Profiles.md)  
  
    -   [View and Modify Replication Agent Command Prompt Parameters (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/View-and-Modify-Replication-Agent-Command-Prompt-Parameters--SQL-Server-Management-Studio-.md)  
  
    -   [Programming Replication Agent Executables](assetId:///cba476df-d4ea-44c9-bb86-81488971e328).  
  
## See Also  
 [Replication Agent Administration](../../Topics/TopicNameNotContainA/Replication-Agent-Administration.md)   
 [Errors and Events Reference (Replication)](../../Topics/TopicNameNotContainA/Errors-and-Events-Reference--Replication-.md)   
 [Replication Distribution Agent](../../Topics/TopicNameNotContainA/Replication-Distribution-Agent.md)   
 [Replication Log Reader Agent](../../Topics/TopicNameNotContainA/Replication-Log-Reader-Agent.md)   
 [Replication Merge Agent](../../Topics/TopicNameNotContainA/Replication-Merge-Agent.md)   
 [Replication Queue Reader Agent](../../Topics/TopicNameNotContainA/Replication-Queue-Reader-Agent.md)   
 [Replication Snapshot Agent](../../Topics/TopicNameNotContainA/Replication-Snapshot-Agent.md)