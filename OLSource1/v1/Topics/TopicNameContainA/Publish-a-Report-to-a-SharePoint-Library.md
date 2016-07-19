---
title: Publish a Report to a SharePoint Library
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
ms.assetid: 3f6dfc28-50d8-4231-bd25-871b5f77cce6
manager: mblythe
---
# Publish a Report to a SharePoint Library
To publish a report to a SharePoint site configured for SharePoint integration, you must set the project properties in Report Designer. In the project properties, all references to servers, reports, and shared data sources must be fully qualified URLs. In the report definition, all references to subreports, drillthrough reports, and resources such as Web-based images, must be fully qualified URLS.  
  
 You must have **Member** or **Owner** permission on the SharePoint site to set the properties on the project. For more information, see [URL Examples for Published Report Items on a Report Server in SharePoint Mode (SSRS)](../../Topics/TopicNameContainA/URL-Examples-for-Published-Report-Items-on-a-Report-Server-in-SharePoint-Mode--SSRS-.md).  
  
### To publish a report to a SharePoint site  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], open an existing or new Report Server project.  
  
2.  From the **Project** menu, click **Properties**. The *<project\>***Property Pages** dialog box opens.  
  
3.  In the **Configuration** list, select the name of a solution build configuration to use to build and publish your report. The current configuration is listed as **Active**(*<configuration\>*).  
  
4.  If you want to publish the shared data sources in your project and overwrite previously published shared data sources, set **OverwriteDataSources** to **True**.  
  
5.  (Optional) For **TargetDataSourceFolder**, type a URL to a SharePoint library or library folder (for example, *http://TestServer/TestSite/Documents/DataSources)*.  
  
     If you do not specify a value, the **TargetReportFolder** value is used.  
  
6.  For **TargetReportFolder**, type a URL to a library or library folder (for example, *http://TestServer/TestSite/Documents/Reports)*.  
  
7.  For **TargetServerURL**, type a URL to a SharePoint top-level site or subsite. If you do not specify a site, the default top-level site is used (for example, *http://servername*, *http://servername/site*, or *http://servername/site/subsite*).  
  
8.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
9. In Solution Explorer, right-click the report you want to publish, and click **Deploy**. The report is published to the location specified in **TargetReportFolder**. Deployment errors appear in the Output window.  
  
## See Also  
 [Project Property Pages Dialog Box](../../Topics/TopicNameNotContainA/Project-Property-Pages-Dialog-Box.md)   
 [Set Deployment Properties (Reporting Services)](../../Topics/TopicNameNotContainA/Set-Deployment-Properties--Reporting-Services-.md)   
 [Publishing Reports to a Report Server](../../Topics/TopicNameContainA/Publishing-Reports-to-a-Report-Server.md)   
 [URL Examples for Published Report Items on a Report Server in SharePoint Mode (SSRS)](../../Topics/TopicNameContainA/URL-Examples-for-Published-Report-Items-on-a-Report-Server-in-SharePoint-Mode--SSRS-.md)   
 [Use an Office Data Connection (.odc) with Reports (Reporting Services in SharePoint Integrated Mode)](../../Topics/TopicNameNotContainA/Use-an-Office-Data-Connection--.odc--with-Reports--Reporting-Services-in-SharePoint-Integrated-Mode-.md)