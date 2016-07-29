---
title: "Reports, Report Parts, and Report Definitions (Report Builder and SSRS)"
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
ms.assetid: 2d746550-f8cc-4e97-8a06-d0f03cffc18d
caps.latest.revision: 26
manager: mblythe
---
# Reports, Report Parts, and Report Definitions (Report Builder and SSRS)
[!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] uses a variety of terms to describe a paginated report in different states, including the initial definition, the published report, and the viewed report as it appears to the user.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Report Definition (.rdl) Files  
 A report definition is a file that you create in Report Builder or Report Designer. It provides a complete description of data source connections, queries used to retrieve data, expressions, parameters, images, text boxes, tables, and any other design-time elements that you might include in a report. Although report definitions can be complex, at a minimum they specify a query and other report content, report properties, and a report layout.  
  
 Report definitions are rendered at run time as a processed report. At that time, the data is retrieved from the data source and formatted according to the instructions in the report definition. A report definition can be run directly from your computer and saved locally, or it can be published to a report server for others to run as well.  
  
 Report definitions are written in XML that conforms to an XML grammar called Report Definition Language (RDL). RDL describes the XML elements, encompassing all possible variations that a report can assume.  
  
## Client Report Definition (.rdlc) Files  
 The Visual Studio Report Designer produces client report definition (.rdlc) files for use with the ReportViewer control. The .rdlc files can be converted to .rdl files for use with Reporting Services Report Designer.  
  
## Report Part (.rsc) Files  
 Report parts are self-contained report items that are stored on the report server and can be included in other reports. Use Report Builder to browse and select parts from the Report Part Gallery to add to your reports. Use Report Designer or Report Builder to save report parts for use in the Report Part Gallery.  
  
 A report part definition is an XML fragment of a report definition file. You create report parts by creating a report definition, and then selecting report items in the report to publish separately as report parts. Report parts include data regions, rectangles and their contained items, and images. You can save a report part with its dependent datasets and shared data source references so it can be reused in other reports.  
  
 For more information, see [Report Parts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Parts--Report-Builder-and-SSRS-.md) and [Report Parts in Report Designer (SSRS)](../../Topics/TopicNameNotContainA/Report-Parts-in-Report-Designer--SSRS-.md).  
  
## Published Reports  
 After you create an .rdl file, you can save it locally, or save it to a personal folder (such as the My Reports folder) on the report server. When the report is ready for others to see, you publish it by saving it from Report Builder to a public folder on the report server, uploading it through the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] web portal, or deploying a report project solution from Report Designer. A published report is an item that is stored in a report server database and managed on a report server or SharePoint site.  
  
 A published report is secured through role assignments using the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] role-based security model. Published reports are accessed through URLs, SharePoint Web parts, or the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] web portal, or you can navigate to and open them in Report Builder.  
  
### Report Snapshots  
 A report can also be published as a snapshot that contains both layout information and data as of the time the report was initially run. Report snapshots are not saved in a particular rendering format. Instead, report snapshots are rendered in a final viewing format (such as HTML) only when a user or an application requests it. For more information, see [Finding and Viewing Reports in the web portal (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Finding-and-Viewing-Reports-in-the-web-portal--Report-Builder-and-SSRS-.md).  
  
## Rendered Reports  
 A rendered report is a fully processed report that contains both data and layout information in a format suitable for viewing (such as HTML). Until a report is rendered into an output format, it cannot be viewed. You can render a report by doing one of the following:  
  
-   Create or open a report in Report Builder or Report Designer and run it.  
  
-   Find and run a report in the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] web portal.  
  
-   Find and run a report on a SharePoint site that is integrated with a [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] report server.  
  
-   Subscribe to a report, which is delivered to an e-mail inbox or a file share in an output format that you specify.  
  
 Subscribe to a report, which is delivered to an e-mail inbox or a file share in an output format that you specify. The default rendering format for a report is HTML 4.0. In addition to HTML, reports can be rendered in a variety of output formats, including Excel, Word, XML, PDF, TIFF, and CSV. As with published reports, rendered reports cannot be edited or saved back to a report server. For more information, see [Export Reports (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Export-Reports--Report-Builder-and-SSRS-.md).  
  
## See Also  
 [Report Authoring Concepts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Authoring-Concepts--Report-Builder-and-SSRS-.md)   
 [Report Builder in SQL Server 2016](../../Topics/TopicNameNotContainA/Report-Builder-in-SQL-Server-2016.md)   
 [Finding, Viewing, and Managing Reports (Report Builder and SSRS )](../../Topics/TopicNameNotContainA/Finding--Viewing--and-Managing-Reports--Report-Builder-and-SSRS--.md)   
 [Export Reports (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Export-Reports--Report-Builder-and-SSRS-.md)