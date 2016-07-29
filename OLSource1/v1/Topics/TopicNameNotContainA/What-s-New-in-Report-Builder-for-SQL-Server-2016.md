---
title: "What&#39;s New in Report Builder for SQL Server 2016"
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8223c19b-4b0d-4b1d-a042-9a726c18e708
caps.latest.revision: 14
manager: mblythe
robots: noindex,nofollow
---
# What&#39;s New in Report Builder for SQL Server 2016
The [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] introduces a number of [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] features.  
  
 For information about features in this release for other [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] products and technologies, see [What's New in SQL Server 2016](../../Topics/TopicNameNotContainA/What-s-New-in-SQL-Server-2016.md).  
  
> [!TIP]  
>  For the most recent information and resources regarding new features in this release, see [Additional information on what is new in SQL Server Reporting Services (SSRS)](http://go.microsoft.com/fwlink/?LinkId=207147).  
  
##  <a name="ExcelRenderer"></a> Excel Renderer for Microsoft Excel 2007-2010 and Microsoft Excel 2003  
 The [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Excel rendering extension, new in [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)], renders a report as an Excel document that is compatible with [!INCLUDE[ofprexcel](../../Topics/TopicNameContainA/includes/ofprexcel_md.md)] 2007-2010 as well as [!INCLUDE[ofprexcel](../../Topics/TopicNameContainA/includes/ofprexcel_md.md)] 2003 with the Microsoft Office Compatibility Pack for Word, Excel, and PowerPoint installed. The format is Office Open XML and the file extension of files is .xlsx.  
  
 This Excel-rendering extension removes limitations of the earlier version, compatible with Excel 2003. The following lists the improvement in the rendering extension:  
  
-   Maximum rows per worksheet is 1,048,576.  
  
-   Maximum columns per worksheet is 16,384.  
  
-   Number of colors allowed in a worksheet is approximately 16 million (24-bit color).  
  
-   ZIP compression provides smaller files sizes.  
  
 For more information, see [Exporting to Microsoft Excel (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Exporting-to-Microsoft-Excel--Report-Builder-and-SSRS-.md).  
  
##  <a name="WordRenderer"></a> Word Renderer for Microsoft Word 2007-2010 and Microsoft Word 2003  
 The [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Word rendering extension, new in [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)], renders a report as a Word document that is compatible with [!INCLUDE[ofprword](../../Topics/TopicNameContainA/includes/ofprword_md.md)] 2007-2010 as well as [!INCLUDE[ofprword](../../Topics/TopicNameContainA/includes/ofprword_md.md)] 2003 with the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Office Compatibility Pack for Word, Excel, and PowerPoint installed. The format is Office Open XML and the file extension of files is docx.  
  
 In addition to making the features that are new in Word 2007-2010 available to exported reports, *.docx files of exported reports tend to be smaller. Reports exported by using the Word renderer are typically significantly smaller than the same reports exported by using the Word 2003 renderer.  
  
 For more information, see [Exporting to Microsoft Word (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Exporting-to-Microsoft-Word--Report-Builder-and-SSRS-.md).  
  
## See Also  
 [Report Builder in SQL Server 2016](../../Topics/TopicNameNotContainA/Report-Builder-in-SQL-Server-2016.md)