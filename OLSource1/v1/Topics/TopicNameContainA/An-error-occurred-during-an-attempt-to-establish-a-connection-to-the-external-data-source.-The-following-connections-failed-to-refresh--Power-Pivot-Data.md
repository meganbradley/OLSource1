---
title: An error occurred during an attempt to establish a connection to the external data source. The following connections failed to refresh: Power Pivot Data
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1b951da1-f62d-43d2-b40b-270a4a9ab92c
manager: mblythe
---
# An error occurred during an attempt to establish a connection to the external data source. The following connections failed to refresh: Power Pivot Data
This error occurs if you query [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] data on a server that does not have [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] for SharePoint installed. It also occurs if the SQL Server Analysis Services ([!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)]) service is stopped, or if you are attempting to view [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] data from an earlier version.  
  
## Details  
  
|||  
|-|-|  
|Applies to|[!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] for SharePoint|  
|Product Version|[!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)], [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)], [!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)]|  
|Cause|The data connection failed.|  
|Message Text|An error occurred during an attempt to establish a connection to the external data source. The following connections failed to refresh: [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] Data|  
  
## Explanation  
 Excel Services returns this error when you query [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] data in an Excel workbook that is published to SharePoint, and the SharePoint environment does not have a [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] for SharePoint server, or the SQL Server Analysis Services ([!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)]) service is stopped.  
  
 The error occurs when you slice or filter [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] data when the query engine is not available.  
  
## User Action  
 Install [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] for SharePoint or move the [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] workbook to a SharePoint environment that has [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] for SharePoint installed. For more information, see [Power Pivot for SharePoint 2010 Installation](assetId:///8d47dde7-c941-4280-a934-e2fe3f9a938f).  
  
 If the software is installed, verify that the SQL Server Analysis Services ([!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)]) instance is running. Check **Manage services on server** in Central Administration. Also check the Services console application in Administrative Tools.  
  
 For [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] workbooks that were created in a SQL Server 2008 R2 version of [!INCLUDE[ssGemini](../../Topics/TopicNameContainA/includes/ssGemini_md.md)] for Excel, you must install the SQL Server 2008 R2 version of the Analysis Services OLE DB provider. This error will occur if you installed the provider, but did not register the Microsoft.AnalysisServices.ChannelTransport.dll file. For more information about file registration, see [Install the Analysis Services OLE DB Provider on SharePoint Servers](assetId:///2c62daf9-1f2d-4508-a497-af62360ee859).  
  
## See Also  
 [The data connection uses Windows Authentication and user credentials could not be delegated. The following connections failed to refresh: Power Pivot Data](../Topic/The%20data%20connection%20uses%20Windows%20Authentication%20and%20user%20credentials%20could%20not%20be%20delegated.%20The%20following%20connections%20failed%20to%20refresh:%20Power%20Pivot%20Data.md)