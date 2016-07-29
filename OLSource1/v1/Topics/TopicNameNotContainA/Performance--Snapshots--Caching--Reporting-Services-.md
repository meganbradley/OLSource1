---
title: "Performance, Snapshots, Caching (Reporting Services)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 85afd00f-e8d7-4ef7-9174-2ff84d82f960
caps.latest.revision: 21
manager: mblythe
---
# Performance, Snapshots, Caching (Reporting Services)
Report server performance is affected by a combination of factors that include hardware, number of concurrent users accessing reports, the amount of data in a report, and output format. To understand the performance factors that are specific to your installation and which remedies will produce the results you want, you will need to get baseline data and run tests. For more information about tools and guidelines, see the following publications on MSDN: [Reporting Services Performance Optimization](http://blogs.msdn.com/b/sqlcat/archive/2013/10/30/reporting-services-performance-and-optimization.aspx) and [Using Visual Studio 2005 to Perform Load Testing on a SQL Server 2005 Reporting Services Report Server](http://go.microsoft.com/fwlink/?LinkID=77519).  
  
 General principles to consider include the following:  
  
-   Report processing and rendering are memory intensive operations. When possible, choose a computer that has a lot of memory.  
  
-   Hosting the report server and the report server database on separate computers tends to provide better performance than hosting both on a single high-end computer.  
  
-   If all reports are processing slowly, consider a scale-out deployment where multiple report server instances support a single report server database. For best results, use load balancing software to distribute requests evenly across the deployment.  
  
-   If a single report is processing slowly, tune report dataset queries if the report must run on demand. You might also consider using shared datasets that you can cache, caching the report, or running the report as a snapshot.  
  
-   If all reports process slowly in a specific format (for example, while rendering to PDF), consider file share delivery, adding more memory, or choosing a different format.  
  
-   To find out how long it takes to process a report and other usage metrics, review the report server execution log. For more information, see [Report Server ExecutionLog and the ExecutionLog3 View](../../Topics/TopicNameNotContainA/Report-Server-ExecutionLog-and-the-ExecutionLog3-View.md).  
  
-   For more information about how to mitigate performance issues by tuning memory management configuration settings, see [Configure Available Memory for Report Server Applications](../../Topics/TopicNameNotContainA/Configure-Available-Memory-for-Report-Server-Applications.md).  
  
## In This Section  
 [Monitoring Report Server Performance](../../Topics/TopicNameNotContainA/Monitoring-Report-Server-Performance.md)  
 Describes the performance objects you can use to track the processing load on your server.  
  
 [Set Report Processing Properties](../../Topics/TopicNameNotContainA/Set-Report-Processing-Properties.md)  
 Describes ways of configuring a report to run on demand, from cache, or on a schedule as a report snapshot.  
  
 [Configure Available Memory for Report Server Applications](../../Topics/TopicNameNotContainA/Configure-Available-Memory-for-Report-Server-Applications.md)  
 Describes how you can override default memory management behavior.  
  
 [Caching Reports (SSRS)](../../Topics/TopicNameNotContainA/Caching-Reports--SSRS-.md)  
 Describes report caching behavior on a report server.  
  
 [Cache Shared Datasets (SSRS)](../../Topics/TopicNameNotContainA/Cache-Shared-Datasets--SSRS-.md)  
 Describes shared dataset caching behavior on a report server.  
  
 [Process Large Reports](../../Topics/TopicNameNotContainA/Process-Large-Reports.md)  
 Provides recommendations on how to configure and distribute a large report.  
  
 [Setting Time-out Values for Report and Shared Dataset Processing (SSRS)](../../Topics/TopicNameNotContainA/Setting-Time-out-Values-for-Report-and-Shared-Dataset-Processing--SSRS-.md)  
 Explains how to set time outs on query and report processing.  
  
## See Also  
 [Manage a Running Process](../../Topics/TopicNameContainA/Manage-a-Running-Process.md)   
 [Verifying a Report Run](../../Topics/TopicNameContainA/Verifying-a-Report-Run.md)