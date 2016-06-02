---
title: Execution Account  - Reporting Services Native mode (Configuration Manager)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 440b5a09-5fd4-4c3a-b510-f3c33cbf1c82
robots: noindex,nofollow
---
# Execution Account  - Reporting Services Native mode (Configuration Manager)
  Use this page to configure an account to use for unattended processing. This account is used under special circumstances when other sources of credentials are not available:  
  
-   When the report server connects to a data source that does not require credentials. Examples of data sources that might not require credentials include XML documents and some client\-side database applications.  
  
-   When the report server connects to another server to retrieve external image files or other resources that are referenced in a report.  
  
 [!INCLUDE[applies](../../Token\Other/applies_md.md)] [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] Native mode.  
  
 Setting this account is optional, but not setting it limits your use of external images and connections to some data sources. When retrieving external image files, the report server checks to see if an anonymous connection can be made. If the connection is password protected, the report server uses the unattended report processing account to connect to the remote server. When retrieving data for a report, the report server either impersonates the current user, prompts the user to provide credentials, uses stored credentials, or uses the unattended processing account if the data source connection specifies **None** as the credential type. The report server does not allow its service account credentials to be delegated or impersonated when connecting to other computers, so it must use the unattended processing account if no other credentials are available.  
  
 The account you specify should be different from the one used to run the service account. If you configure this account, it is stored in the RSReportServer.config file as an encrypted value. If you are running the report server in a scale\-out deployment, you must configure this account the same way on each report server.  
  
 You can use any Windows user account. For best results, choose an account that has read permissions and network logon permissions to support connections to other computers. It must have read permissions on any external image or data file that you want to use in a report. Do not specify a local account unless all report data sources and external images are stored on the report server computer. Use the account only for unattended report processing.  
  
> [!NOTE]  
>  If you are using [!INCLUDE[ssExpCurrentA](../../Token\Other/ssExpCurrentA_md.md)], you only need to configure this account if you are referencing external images in a report and permission is required to access the image file. SQL Server Express does not support a data source connection to a remote server. For a list of features that are supported by the editions of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], see [Features Supported by the Editions of SQL Server 2016](../../Topics\TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md).  
  
 To open this page, start the [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] Configuration Manager and select **Execution Account** in the navigation pane. For more information, see [Reporting Services Configuration Manager &#40;Native Mode&#41;](../Topic/Reporting%20Services%20Configuration%20Manager%20\(Native%20Mode\).md).  
  
## Options  
 **Specify an execution account**  
 Select to specify an account.  
  
 **Account**  
 Enter a Windows domain user account. Use this format: *\<domain\>\\\<user account\>*.  
  
 **Password**  
 Type the password.  
  
 **Confirm password**  
 Retype the password.  
  
## See Also  
 [Reporting Services Configuration Manager Help Topics](../../Topics\TopicNameNotContainA/Reporting-Services-Configuration-Manager-Help-Topics.md)   
 [Store Encrypted Report Server Data &#40;SSRS Configuration Manager&#41;](../Topic/Store%20Encrypted%20Report%20Server%20Data%20\(SSRS%20Configuration%20Manager\).md)   
 [Configure the Unattended Execution Account &#40;SSRS Configuration Manager&#41;](../Topic/Configure%20the%20Unattended%20Execution%20Account%20\(SSRS%20Configuration%20Manager\).md)  
  
  