---
title: "Monitor Data-tier Applications"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-data-tier-apps
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d2765828-2385-4019-aef2-1de3ab7d1b26
caps.latest.revision: 12
manager: jhubbard
---
# Monitor Data-tier Applications
A data-tier application (DAC) can be monitored from the **Utility Explorer** and **Object Explorer** in [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] (SSMS), along with system views and tables. In addition, all objects in the database contained in the DAC can be monitored using standard database and [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] monitoring techniques.  
  
## Before You Begin  
 If you deploy a DAC to a managed instance of the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)], information about the deployed DAC is incorporated into the SQL Server Utility the next time the utility collection set is sent from the instance to the utility control point. You can then view basic health information about the DAC by using the [!INCLUDE[ssManStudio](../../Topics/TopicNameContainA/includes/ssManStudio_md.md)] **Utility Explorer**.  
  
 The SSMS **Object Explorer** displays basic configuration information about each DAC deployed to an instance of the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)], regardless of whether the instance is managed in the SQL Server Utility. Also, the database associated with a deployed DAC can be monitored using the same procedures for monitoring any database.  
  
## Using the SQL Server Utility  
 The **Deployed Data-tier Applications** detail page in the [!INCLUDE[ssManStudio](../../Topics/TopicNameContainA/includes/ssManStudio_md.md)] **Utility Explorer** displays a dashboard that reports the resource utilization of all DACs that have been deployed to managed instances of the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)]. The top pane of the details page lists each deployed DAC with visual indicators showing whether their utilization of CPU and file resources are outside the policies defined for the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Utility. If you select any DAC in the list view, further details are displayed in tabs in the bottom pane of the page. For more information about the information presented on the details page, see [Deployed Data-tier Application Details (SQL Server Utility)](../../Topics/TopicNameNotContainA/Deployed-Data-tier-Application-Details--SQL-Server-Utility-.md).  
  
 After using the **Deployed Data-tier Applications** detail page to quickly identify any DACs that are either under-utilizing or stressing their hardware resource, you can make plans to address any problems. Multiple DACs that are not fully utilizing their current hardware resources could be consolidated to a single server, freeing some of the servers for other uses. If a DAC is stressing the resources on its current server, the DAC can be moved to a larger server, or additional resources can be added to the current server.  
  
 The minimum and maximum limits for resource usage are defined by application monitoring policies defined in the **Utility Administration** details page. Database administrators can tailor the policies to match the limits established by their organizations. For example, one company might set 75% as the maximum CPU utilization for a DAC, while another company might set the maximum at 80%. For more information about setting application monitoring policies, see [Utility Administration (SQL Server Utility)](../../Topics/TopicNameNotContainA/Utility-Administration--SQL-Server-Utility-.md).  
  
 To view the **Deployed Data-tier Applications** detail page:  
  
1.  Select the **View/Utility Explorer** menu.  
  
2.  Connect the **Utility Explorer** to the utility control point (UCP).  
  
3.  Select the **View/Utility Explorer Details** menu.  
  
4.  Select the **Deployed Data-tier Applications** node in the **Utility Explorer**.  
  
 The information in the **Deployed Data-tier Applications** detail page comes from the data in the utility management data warehouse, which defaults to collecting the data every 15 minutes. The interval can also be tailored using the **Utility Administration** details page.  
  
## Using Object Explorer  
 The SSMS **Object Explorer** displays basic configuration information about each DAC deployed to an instance of the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)]. This includes both managed instances that have been enrolled in the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Utility, and stand-alone instances that cannot be viewed in the **Utility Explorer**.  
  
 To view the details of a DAC deployed to an instance of the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)]:  
  
1.  Select the **View/Object Explorer** menu.  
  
2.  Connect to the instance of the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)]from the Object Explorer pane.  
  
3.  Select the **View/Object Explorer Details** menu.  
  
4.  Select the server node in **Object Explorer** that maps to the instance, and then navigate to the **Management\Data-tier Applications** node.  
  
5.  The list view in the top pane of the details page lists each DAC deployed to the instance of the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)]. Select a DAC to display the information in the detail pane at the bottom of the page.  
  
 The right-click menu of the **Data-tier Applications** node is also used to deploy a new DAC or delete an existing DAC.  
  
## Using the DAC System Views and Tables  
 The msdb.dbo.sysdac_history_internal system table records the success or failure of all DAC management actions performed on an instance of the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)]. The table records the time each action occurred, and which login initiated the action. For more information, see [sysdac_history_internal (Transact-SQL)](assetId:///774a1678-0b27-42be-8adc-a6d7a4a56510).  
  
 The DAC system views report basic catalog information. For more information, see [Data-tier Application Views (Transact-SQL)](assetId:///0de01328-d7a6-4677-b7a0-dcd3098c23d4).  
  
## Monitoring DAC Databases  
 After a DAC has been successfully deployed, the database contained in the DAC operates the same as any other database. Use standard [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] techniques and tools for monitoring the performance, log, events, and resource utilization of the database.  
  
## See Also  
 [Data-tier Applications](../../Topics/TopicNameNotContainA/Data-tier-Applications.md)   
 [Deploy a Data-tier Application](../../Topics/TopicNameContainA/Deploy-a-Data-tier-Application.md)