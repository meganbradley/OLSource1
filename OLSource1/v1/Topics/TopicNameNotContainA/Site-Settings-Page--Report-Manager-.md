---
title: "Site Settings Page (Report Manager)"
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
ms.assetid: 4d67a01c-eae4-49ba-a6e8-8e983c0248f5
caps.latest.revision: 6
manager: mblythe
robots: noindex,nofollow
---
# Site Settings Page (Report Manager)
Use the Site Settings page to change the application title, set server-wide defaults for report history limits and report processing timeout values, manage system-level role assignments, and manage shared schedules. You must have Content Manager and System Administrator permissions to view this page.  
  
> [!NOTE]  
>  The following features are not available in every edition of SQL Server: report history, report execution, and shared schedules. For a list of features that are supported by the editions of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], see [Features Supported by the Editions of SQL Server 2016](../../Topics/TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md).  
  
## Navigation  
 Use the following procedure to navigate to this location in the user interface (UI).  
  
### To open the Site Settings page  
  
1.  Open Report Manager.  
  
2.  At the top of the page, click **Site Settings**. This opens the General Properties page of the site.  
  
     **Note:** If you do not see the **Site Settings** option in the menu, you do not have the required permissions, For more information see the “site settings” section of [Configure a Native Mode Report Server for Local Administration (SSRS)](../../Topics/TopicNameContainA/Configure-a-Native-Mode-Report-Server-for-Local-Administration--SSRS-.md).  
  
## Options  
 **Name**  
 Specify the title to use for this instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Report Manager. By default, the title is "[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)][!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)]".  
  
 **Select the default settings for report history**  
 Select a default value for the number of copies of report history to retain. The default value provides an initial setting that establishes report history limits. You can vary these settings at the report level. For more information, see [Snapshot Options Properties Page (Report Manager)](../../Topics/TopicNameNotContainA/Snapshot-Options-Properties-Page--Report-Manager-.md).  
  
 If you limit report history later, when the existing report history exceeds the limit you specify, the report server reduces the existing report history to the new limit. The oldest report snapshots are deleted first. If report history is empty or below the limit, new report snapshots are added. When the limit is reached, the oldest snapshot is deleted when a new report snapshot is added.  
  
 **Report Execution Timeout**  
 Specify whether report processing times out after a certain number of seconds.  
  
 This value applies to report processing on a report server. It does not affect data processing on the database server that provides the data for your report.  
  
 The report processing timer clock begins when the report is selected and ends when the report opens. When you set this value, specify enough time to complete both data processing and report processing.  
  
 **Custom Report Builder launch URL**  
 Specify a custom URL when the report server does not use the default Report Builder URL. This setting is optional. If you do not specify a value, the default URL will be used, which launches Report Builder as a ClickOnce application. The default URL is one of the following:  
  
 **Native mode report server:** In a native mode installation, the default URL will take the form of http://<*computername*>/reportserver/ReportBuilder/ReportBuilder_3_0_0_0.application.  
  
 SharePoint integrated mode: The default URL will take the form of http://<*SharePoint_site*>/_vti_bin/ReportBuilder/ReportBuilder_3_0_0_0.application.”  
  
 **Apply**  
 Click to save your changes to the report server.  
  
 **Security**  
 Click this link to open the System Role Assignments page, on which you can assign user and group accounts to predefined system roles.  
  
 **Schedules**  
 Click this link to open the Schedules page, on which you can predefine shared schedules that users can select for their reports and subscriptions.  
  
## See Also  
 [Report Manager  (SSRS Native Mode)](../../Topics/TopicNameNotContainA/Report-Manager---SSRS-Native-Mode-.md)   
 [Granting Permissions on a Native Mode Report Server](../../Topics/TopicNameContainA/Granting-Permissions-on-a-Native-Mode-Report-Server.md)   
 [Predefined Roles](../../Topics/TopicNameNotContainA/Predefined-Roles.md)   
 [Report Manager F1 Help](../../Topics/TopicNameNotContainA/Report-Manager-F1-Help.md)