---
title: Report Manager URL  - Reporting Services Native mode (Configuration Manager)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 45768952-23a6-45a5-b541-e7bf192b4a78
manager: mblythe
robots: noindex,nofollow
---
# Report Manager URL  - Reporting Services Native mode (Configuration Manager)
Use the Report Manager URL page to configure or modify the URL used to access Report Manager. By default, the Report Manager URL inherits the prefix, IP address, and port of the Report Server Web service URL. This is because Report Manager provides front-end access to the Web service that runs within the same Report Server service. If you are isolating the service applications and using Report Manager to access a Report Server Web service on a different computer, you must edit RSReportServer.config file to point Report Manager to a different instance. For more information about configuring a Report Manager connection to a remote report server, see [Reporting Services Configuration Manager (Native Mode)](../../Topics/TopicNameNotContainA/Reporting-Services-Configuration-Manager--Native-Mode-.md).  
  
 [!INCLUDE[applies](../../Topics/TopicNameContainA/includes/applies_md.md)] [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Native mode.  
  
 If you are configuring the report server to run in SharePoint integrated mode, do not create a Report Manager URL. Report Manager is not supported on a report server that runs in SharePoint integrated mode. If a URL already exists for Report Manager, it will become unavailable after you configure the report server to run in SharePoint integrated mode.  
  
 To open this page, start the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Configuration Manager and click **Report Manager URL** in the navigation pane. For more information about how to start the Configuration Manager, see [Reporting Services Configuration Manager (Native Mode)](../../Topics/TopicNameNotContainA/Reporting-Services-Configuration-Manager--Native-Mode-.md).  
  
> [!NOTE]  
>  If Report Manager is not enabled, you cannot set options on this page. For more information about enabling Report Manager, see [Reporting Services Configuration Manager (Native Mode)](../../Topics/TopicNameNotContainA/Reporting-Services-Configuration-Manager--Native-Mode-.md).  
  
## Options  
 **Virtual Directory**  
 Specifies the virtual directory name for Report Manager. You can only have one virtual directory name for each Report Manager instance on the same computer.  
  
 **URLs**  
 Displays the URL defined for the current Report Manager instance.  
  
 **Advanced**  
 Add an additional URL for the current Report Manager instance.  
  
## See Also  
 [Configure a URL  (SSRS Configuration Manager)](../../Topics/TopicNameContainA/Configure-a-URL---SSRS-Configuration-Manager-.md)   
 [URLs in Configuration Files  (SSRS Configuration Manager)](../../Topics/TopicNameNotContainA/URLs-in-Configuration-Files---SSRS-Configuration-Manager-.md)   
 [Configure Report Server URLs  (SSRS Configuration Manager)](../../Topics/TopicNameNotContainA/Configure-Report-Server-URLs---SSRS-Configuration-Manager-.md)