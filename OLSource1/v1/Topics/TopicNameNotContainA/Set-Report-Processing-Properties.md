---
title: "Set Report Processing Properties"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b5cbc453-5986-423e-af44-1f243ef3edb1
caps.latest.revision: 44
manager: mblythe
---
# Set Report Processing Properties
Report execution properties control how a report is processed. Execution properties must be set for each report individually.  
  
 To set report execution properties, open the report in Report Manager, and then navigate to the Execution properties page. For more information, see [Processing Options Properties Page (Report Manager)](../../Topics/TopicNameNotContainA/Processing-Options-Properties-Page--Report-Manager-.md). You can also set properties using [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssManStudio](../../Topics/TopicNameContainA/includes/ssManStudio_md.md)]; see [Processing Options Properties Page (Report Manager)](../../Topics/TopicNameNotContainA/Processing-Options-Properties-Page--Report-Manager-.md).  
  
## Report Execution Modes  
 You can run a report either on demand or as a snapshot. The following section describes each approach.  
  
### Running Reports On Demand  
 You can specify that a report query a data source each time a user runs the report, resulting in on-demand reports that contain the most up-to-date data. A new instance of the report is created for each user who opens or requests the report; each new instance contains the results of a new query. With this approach, if ten users open the report at the same time, ten queries are sent to the data source for processing.  
  
### Running Reports On Demand From Cache  
 To enhance performance, you can specify a report (and data) to be cached temporarily when a user runs the report. The cached copy is subsequently available to other users who access the same report. With this approach, if ten users open the report, only the first request results in report processing. The report is subsequently cached, and the remaining nine users view the cached report.  
  
 Cached reports are removed from the cache at intervals that you define. You can specify intervals in minutes, or you can schedule a specific date and time to empty the cache. For more information, see [Caching Reports (SSRS)](../../Topics/TopicNameNotContainA/Caching-Reports--SSRS-.md).  
  
### Running Reports From Snapshots  
 A report snapshot is a report that contains layout information and data that is retrieved at a specific point in time. You can run a report as a report snapshot to prevent the report from being run at arbitrary times (for example, during a scheduled backup). A report snapshot is usually created and subsequently refreshed on a schedule, allowing you to time exactly when report and data processing will occur. If a report is based on queries that take a long time to run, or on queries that use data from a data source that you prefer no one access during certain hours, you should run the report as a snapshot.  
  
 A report snapshot is stored in a report server database, where it is subsequently retrieved when a user or process (such as a subscription) requests the report. When a report snapshot is updated, it is overwritten with a new instance. The report server does not save earlier versions of a report snapshot unless you specifically set options to add it to report history. For more information, see [Create, Modify, and Delete Snapshots in Report History](../../Topics/TopicNameNotContainA/Create--Modify--and-Delete-Snapshots-in-Report-History.md).  
  
 Not all reports can be configured to run as a snapshot. You cannot create a snapshot for a report that prompts users for credentials or uses Windows integrated security to get data for the report. If you want to run a parameterized report as a snapshot, you must specify a default parameter to use when creating the snapshot. In contrast with reports that run on demand, it is not possible to specify a different parameter value for a report snapshot when the report is open. Choosing a different parameter value would result in a new report processing request, which is not allowed.  
  
 In some cases, configuring an on-demand report to run as a snapshot can deactivate subscriptions. The following condition will cause a report server to deactivate existing subscriptions that were defined when the report was configured to run on demand:  
  
-   The report uses query parameters, and you select a specific value as the default parameter to meet the requirements for running the report as a snapshot.  
  
-   Existing subscriptions are configured to use parameter values that differ from the default parameter value that you specified for the snapshot.  
  
 When this condition exists, the report server will disable the subscription the next time the subscription is scheduled to run. To reactivate the subscription, open and then save the subscription. When you open the subscription, the report server updates the subscription parameter values to those specified for the snapshot. For more information about subscriptions, see [Subscriptions and Delivery (Reporting Services)](../../Topics/TopicNameNotContainA/Subscriptions-and-Delivery--Reporting-Services-.md).  
  
## See Also  
 [Set Processing Options (Reporting Services in SharePoint Integrated Mode)](../../Topics/TopicNameNotContainA/Set-Processing-Options--Reporting-Services-in-SharePoint-Integrated-Mode-.md)   
 [Configure Execution Properties for a Report  (Report Manager)](../../Topics/TopicNameContainA/Configure-Execution-Properties-for-a-Report---Report-Manager-.md)   
 [Reporting Services Concepts (SSRS)](../../Topics/TopicNameNotContainA/Reporting-Services-Concepts--SSRS-.md)   
 [How to: Add a Snapshot to Report History](../../Topics/TopicNameContainA/Add-a-Snapshot-to-Report-History--Report-Manager-.md)   
 [Specify Credential and Connection Information for Report Data Sources](../../Topics/TopicNameNotContainA/Specify-Credential-and-Connection-Information-for-Report-Data-Sources.md)