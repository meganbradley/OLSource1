---
title: Report Server Command Prompt Utilities (SSRS)
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
ms.assetid: 68f2f9f4-f894-40ff-a71c-f9756bf4b68c
manager: mblythe
---
# Report Server Command Prompt Utilities (SSRS)
[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] includes several command line utilities that you can use to administer a report server. These utilities are installed automatically when you install a report server.  
  
|Name|Command file|Supported Deployment mode|Description|  
|----------|------------------|-------------------------------|-----------------|  
|RSS utility|rs.exe|Native mode and SharePoint mode. The [!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)] release introduced SharePoint mode support.|The [rs utility](../../Topics/TopicNameNotContainA/RS.exe-Utility--SSRS-.md) is a script host that you can use to perform scripted operations. Use this tool to run [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)][!INCLUDE[vbprvb](../../Topics/TopicNameContainA/includes/vbprvb_md.md)] scripts that copy data between report server databases, publish reports, create items in a report server database, and more. To learn more about using scripts to administer a server, see [Script Deployment and Administrative Tasks](../../Topics/TopicNameNotContainA/Script-Deployment-and-Administrative-Tasks.md).|  
|Powershell cmdlets||SharePoint only|For a list of the of the powershell cmdlets, see [PowerShell cmdlets for Reporting Services SharePoint Mode](../../Topics/TopicNameNotContainA/PowerShell-cmdlets-for-Reporting-Services-SharePoint-Mode.md).|  
|Rsconfig utility|rsconfig.exe|Native only|The [rsconfig utility](../../Topics/TopicNameNotContainA/rsconfig-Utility--SSRS-.md) is used to configure and manage a report server connection to the report server database. You can also use it to specify a user account to use for unattended report processing. For more information, see [Reporting Services Report Server (Native Mode)](../../Topics/TopicNameNotContainA/Reporting-Services-Report-Server--Native-Mode-.md). To learn more about connection configuration, see [Configure a Report Server Database Connection  (SSRS Configuration Manager)](../../Topics/TopicNameContainA/Configure-a-Report-Server-Database-Connection---SSRS-Configuration-Manager-.md).|  
|Rskeymgmt Utility|rskeymgmt.exe|Native only|The [rskeymgmt utility](../../Topics/TopicNameNotContainA/rskeymgmt-Utility--SSRS-.md) is an encryption key management tool. You can use it to back up, apply, recreate, and delete symmetric keys. You can also use this tool to attach a report server instance to a shared report server database. Rskeymgmt can be used in database recovery operations. You can reuse an existing database in a new installation by applying a back up copy of the symmetric key. If the keys cannot be recovered, this tool provides a way to delete encrypted content that you no longer use. To learn more about key management and storage of sensitive data, see [Store Encrypted Report Server Data (SSRS Configuration Manager)](../../Topics/TopicNameNotContainA/Store-Encrypted-Report-Server-Data--SSRS-Configuration-Manager-.md) and [Configure and Manage Encryption Keys (SSRS Configuration Manager)](../../Topics/TopicNameNotContainA/Configure-and-Manage-Encryption-Keys--SSRS-Configuration-Manager-.md).|  
  
> [!NOTE]  
>  If you prefer to use a tool that has a graphical user interface, you can use the Reporting Services Configuration manager instead of **rsconfig** and **rskeymgmt**.  
  
## See Also  
 [Reporting Services Configuration Manager (Native Mode)](../../Topics/TopicNameNotContainA/Reporting-Services-Configuration-Manager--Native-Mode-.md)   
 [Reporting Services Tools](../../Topics/TopicNameNotContainA/Reporting-Services-Tools.md)   
 [Reporting Services Report Server (Native Mode)](../../Topics/TopicNameNotContainA/Reporting-Services-Report-Server--Native-Mode-.md)