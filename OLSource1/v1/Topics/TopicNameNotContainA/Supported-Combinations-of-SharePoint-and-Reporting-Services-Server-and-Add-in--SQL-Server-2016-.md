---
title: Supported Combinations of SharePoint and Reporting Services Server and Add-in (SQL Server 2016)
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dc6a3372-db26-43f0-b7aa-f725acc635c2
manager: mblythe
---
# Supported Combinations of SharePoint and Reporting Services Server and Add-in (SQL Server 2016)
A [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] report server installed in SharePoint mode requires a version of SharePoint and the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] add-in (rsSharePoint.msi) for SharePoint products, which you install on the SharePoint servers.  This topic summarizes the supported combinations.  
  
## Supported Combinations of SharePoint and Reporting Services Components  
 The following table summarizes the supported combinations of report server, the Reporting Services add-in for SharePoint products, and SharePoint products. Combinations that are not list in the following table are not supported  
  
### Supported Combinations  
  
||Report server|Add-in|SharePoint version|  
|-|-------------------|-------------|------------------------|  
|1|[!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)]|[!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)]|SharePoint 2016 Preview|  
|2|[!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)]|[!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)]|SharePoint 2013|  
|3|[!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)]|[!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)]|SharePoint 2013|  
|4|[!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)]|[!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)]|SharePoint 2010|  
|5|[!INCLUDE[ssSQL11SP1](../../Topics/TopicNameNotContainA/includes/ssSQL11SP1_md.md)]|[!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)] and [!INCLUDE[ssSQL11SP1](../../Topics/TopicNameNotContainA/includes/ssSQL11SP1_md.md)]|SharePoint 2013|  
|6|[!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)] and [!INCLUDE[ssSQL11SP1](../../Topics/TopicNameNotContainA/includes/ssSQL11SP1_md.md)]*|[!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)]|SharePoint 2010|  
|7|[!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)]|[!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)]|SharePoint 2010|  
|8|[!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)]|[!INCLUDE[ssSQL14](../../Topics/TopicNameContainA/includes/ssSQL14_md.md)]|SharePoint 2010|  
|9|[!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)]|[!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)] and [!INCLUDE[ssSQL11SP1](../../Topics/TopicNameNotContainA/includes/ssSQL11SP1_md.md)]|SharePoint 2010|  
|10|[!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)]|[!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)]|SharePoint 2010|  
|11|[!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)]|[!INCLUDE[ssKatmai](../../Topics/TopicNameContainA/includes/ssKatmai_md.md)] SP2|SharePoint 2007|  
|12|[!INCLUDE[ssKatmai](../../Topics/TopicNameContainA/includes/ssKatmai_md.md)] SP2|[!INCLUDE[ssKatmai](../../Topics/TopicNameContainA/includes/ssKatmai_md.md)] R2|SharePoint 2010|  
|13|[!INCLUDE[ssKatmai](../../Topics/TopicNameContainA/includes/ssKatmai_md.md)] SP2|[!INCLUDE[ssKatmai](../../Topics/TopicNameContainA/includes/ssKatmai_md.md)] and [!INCLUDE[ssKatmai](../../Topics/TopicNameContainA/includes/ssKatmai_md.md)] SP2|SharePoint 2007|  
  
 *Exception: Power view integration is not supported.  
  
 For links to the add-in download pages, see [Where to find the Reporting Services add-in for SharePoint Products](../../Topics/TopicNameNotContainA/Where-to-find-the-Reporting-Services-add-in-for-SharePoint-Products.md).  
  
 **Additional Notes:**  
  
-   SharePoint 2013 support, including Power view integration, requires the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] report server and the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] add-in version of SQL Server 2012 SP1 or later.  
  
-   Power View was introduced in [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)]. Therefore, Power View integration with SharePoint 2010 requires the [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)] or later of the add-in.  
  
-   The SQL Server 2008 R2 Add-In is not supported by SQL Server 2012 (or later) report servers. The SharePoint 2010 prerequisite installer automatically installs the SQL Server 2008 R2 Add-In. It must be uninstalled before installing newer versions of the add-in. In place upgrade of the add-in is not supported.  
  
-   **Upgrade:** SharePoint 2010 with the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Add-In installed, cannot be upgraded in-place to SharePoint 2013. SharePoint 2013 requires [!INCLUDE[ssSQL11SP1](../../Topics/TopicNameNotContainA/includes/ssSQL11SP1_md.md)] or later of the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] add-in and report server. For more information on upgrade, see [Upgrade and Migrate Reporting Services](../../Topics/TopicNameNotContainA/Upgrade-and-Migrate-Reporting-Services.md).  
  
## See Also  
 [Where to find the Reporting Services add-in for SharePoint Products](../../Topics/TopicNameNotContainA/Where-to-find-the-Reporting-Services-add-in-for-SharePoint-Products.md)   
 [Features Supported by the Editions of SQL Server 2016](../../Topics/TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md)   
 [Hardware and Software Requirements for Installing SQL Server 2016](../../Topics/TopicNameNotContainA/Hardware-and-Software-Requirements-for-Installing-SQL-Server-2016.md)