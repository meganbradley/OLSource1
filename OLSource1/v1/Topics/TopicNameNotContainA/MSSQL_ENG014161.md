---
title: MSSQL_ENG014161
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4b983e76-bb77-43c5-b44b-19919d3da619
---
# MSSQL_ENG014161
    
## Message Details  
  
|||  
|-|-|  
|Product Name|SQL Server|  
|Event ID|14161|  
|Event Source|MSSQLSERVER|  
|Component|[!INCLUDE[ssDEnoversion](../../Token\Other/ssDEnoversion_md.md)]|  
|Symbolic Name||  
|Message Text|The threshold \[%s:%s\] for the publication \[%s\] has been set. Make sure that the logreader and distribution agents are running and can match the latency requirement.|  
  
## Explanation  
 Replication lets you enable warnings for several conditions. This includes exceeding a specified latency for transactional subscriptions. Latency is the period of time that elapses between a data change being committed at the Publisher and the corresponding change being committed at the Subscriber.  
  
 When you enable a warning by using Replication Monitor or [sp\_replmonitorchangepublicationthreshold](../Topic/sp_replmonitorchangepublicationthreshold%20\(Transact-SQL\).md), you specify a threshold that determines when a warning is triggered. When that threshold is met or exceeded, a warning is displayed in Replication Monitor, and an event is written to the Windows event log. Reaching a threshold can also trigger a SQL Server Agent alert. For more information, see [Set Thresholds and Warnings in Replication Monitor](../../Topics\TopicNameNotContainA/Set-Thresholds-and-Warnings-in-Replication-Monitor.md) and [Programmatically Monitor Replication](../../Topics\TopicNameNotContainA/Programmatically-Monitor-Replication.md).  
  
## User Action  
 If a subscription exceeds a latency threshold, you must determine whether there is a performance issue with the system or whether the threshold should be adjusted. After you configure replication, develop a performance baseline that will let you determine how replication behaves with a workload that is typical for your applications and topology. Include latency in this baseline so that you can set an appropriate value for the threshold.  
  
 If the threshold value is appropriate, but it is being exceeded, you must determine where the performance bottleneck is in the system. For more information about how to monitor and troubleshoot replication performance, see the following topics:  
  
-   [Measure Latency and Validate Connections for Transactional Replication](../../Topics\TopicNameNotContainA/Measure-Latency-and-Validate-Connections-for-Transactional-Replication.md)  
  
-   [Monitor Performance with Replication Monitor](../../Topics\TopicNameNotContainA/Monitor-Performance-with-Replication-Monitor.md)  
  
## See Also  
 [Errors and Events Reference &#40;Replication&#41;](../Topic/Errors%20and%20Events%20Reference%20\(Replication\).md)  
  
  