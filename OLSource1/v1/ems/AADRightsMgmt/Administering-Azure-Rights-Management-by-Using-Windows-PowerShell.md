---
title: "Administering Azure Rights Management by Using Windows PowerShell"
ms.custom: na
ms.date: 2015-09-01
ms.reviewer: na
ms.service: rights-management
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a890e04a-4b70-41b5-8d5f-3c210a669faa
caps.latest.revision: 25
author: karthikaraman
manager: jeffgilb
translation.priority.ht: 
  - bg-bg
  - de-de
  - el-gr
  - es-es
  - et-ee
  - fi-fi
  - fr-fr
  - hr-hr
  - it-it
  - ja-jp
  - kk-kz
  - ko-kr
  - lt-lt
  - lv-lv
  - pt-br
  - ro-ro
  - ru-ru
  - sk-sk
  - sl-si
  - sr-latn-cs
  - th-th
  - tr-tr
  - uk-ua
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - da-dk
  - hu-hu
  - nb-no
  - nl-nl
  - pl-pl
  - pt-pt
  - sv-se
---
# Administering Azure Rights Management by Using Windows PowerShell
Although you can activate Microsoft [!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)] (Azure RMS) by using the [!INCLUDE[o365_2](../../ems/AADRightsMgmt/includes/o365_2_md.md)] admin center or the Azure portal, you can also use the Windows PowerShell module for [!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)] (AADRM) to do this.

After you have activated [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)], further administration for the service might not be required. However, some advanced configuration scenarios might require you to use the Windows PowerShell module for [!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)]. The following table lists some of the advanced configuration scenarios that use Windows PowerShell. For a complete list of the available cmdlets with more information about each one, see [Azure Rights Management Cmdlets](http://msdn.microsoft.com/library/azure/dn629398.aspx).

> [!NOTE]
> If you need to install the Windows PowerShell module for [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)], see [Installing Windows PowerShell for Azure Rights Management](../../ems/AADRightsMgmt/Installing-Windows-PowerShell-for-Azure-Rights-Management.md).

There is also a supplemental Windows PowerShell module, **RMSProtection**, which supports both Azure RMS and AD RMS. This module supports protecting and removing protection from multiple files so that, for example, you can bulk-protect all files in a folder. For more information, see the [Scripting options for super users](../../ems/AADRightsMgmt/Configuring-Super-Users-for-Azure-Rights-Management-and-Discovery-Services-or-Data-Recovery.md#BKMK_RMSProtectionModule) section in the [Configuring Super Users for Azure Rights Management and Discovery Services or Data Recovery](../../ems/AADRightsMgmt/Configuring-Super-Users-for-Azure-Rights-Management-and-Discovery-Services-or-Data-Recovery.md) topic.

|If you need to…|…use the following cmdlets|
|-------------------|------------------------------|
|Migrate from on-premises Rights Management (AD RMS or Windows RMS) to [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)].|[Import-AadrmTpd](http://msdn.microsoft.com/library/azure/dn857523.aspx)|
|Connect to or disconnect from the [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)] service for your organization.|[Connect-AadrmService](http://msdn.microsoft.com/library/azure/dn629415.aspx)<br /><br />[Disconnect-AadrmService](http://msdn.microsoft.com/library/azure/dn629416.aspx)|
|Generate and manage your own tenant key – the bring your own key (BYOK) scenario.|[Add-AadrmKey](http://msdn.microsoft.com/library/azure/dn629418.aspx)<br /><br />[Get-AadrmKeys](http://msdn.microsoft.com/library/azure/dn629420.aspx)|
|Activate or deactivate the [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)] service for your organization.|[Enable-Aadrm](http://msdn.microsoft.com/library/azure/dn629412.aspx)<br /><br />[Disable-Aadrm](http://msdn.microsoft.com/library/azure/dn629422.aspx)|
|Disable or enable the document tracking site for Azure Rights Management.|[Disable-AadrmDocumentTrackingFeature](https://msdn.microsoft.com/library/azure/mt548471.aspx)<br /><br />[Enable-AadrmDocumentTrackingFeature](https://msdn.microsoft.com/library/azure/mt548469.aspx)<br /><br />[Get-AadrmDocumentTrackingFeature](https://msdn.microsoft.com/library/azure/mt548470.aspx)|
|Configure onboarding controls for a phased deployment of Azure Rights Management.|[Get-AadrmOnboardingControlPolicy](http://msdn.microsoft.com/library/azure/dn857522.aspx)<br /><br />[Set-AadrmOnboardingControlPolicy](http://msdn.microsoft.com/library/azure/dn857521.aspx)|
|Create and manage rights policy templates for your organization.|[Add-AadrmTemplate](http://msdn.microsoft.com/library/azure/dn727075.aspx)<br /><br />[Export-AadrmTemplate](http://msdn.microsoft.com/library/azure/dn727078.aspx)<br /><br />[Get-AadrmTemplate](http://msdn.microsoft.com/library/azure/dn727079.aspx)<br /><br />[Get-AadrmTemplateProperty](http://msdn.microsoft.com/library/azure/dn727081.aspx)<br /><br />[Import-AadrmTemplate](http://msdn.microsoft.com/library/azure/dn727077.aspx)<br /><br />[New-AadrmRightsDefinition](http://msdn.microsoft.com/library/azure/dn727080.aspx)<br /><br />[Remove-AadrmTemplate](http://msdn.microsoft.com/library/azure/dn727082.aspx)<br /><br />[Set-AadrmTemplateProperty](http://msdn.microsoft.com/library/azure/dn727076.aspx)|
|Configure the maximum number of days that content that your organization protects can be accessed without an Internet connection (the use license validity period).|[Get-AadrmMaxUseLicenseValidityTime](https://msdn.microsoft.com/library/azure/dn932062.aspx)<br /><br />[Set-AadrmMaxUseLicenseValidityTime](https://msdn.microsoft.com/library/azure/dn932063.aspx)|
|Manage the super user feature of [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)] for your organization.|[Enable-AadrmSuperUserFeature](http://msdn.microsoft.com/library/azure/dn629400.aspx)<br /><br />[Disable-AadrmSuperUserFeature](http://msdn.microsoft.com/library/azure/dn629428.aspx)<br /><br />[Add-AadrmSuperUser](http://msdn.microsoft.com/library/azure/dn629411.aspx)<br /><br />[Get-AadrmSuperUser](http://msdn.microsoft.com/library/azure/dn629408.aspx)<br /><br />[Remove-AadrmSuperUser](http://msdn.microsoft.com/library/azure/dn629405.aspx)|
|Manage users and groups who are authorized to administer the [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)] service for your organization.|[Add-AadrmRoleBasedAdministrator](http://msdn.microsoft.com/library/azure/dn629417.aspx)<br /><br />[Get-AadrmRoleBasedAdministrator](http://msdn.microsoft.com/library/azure/dn629407.aspx)<br /><br />[Remove-AadrmRoleBasedAdministrator](http://msdn.microsoft.com/library/azure/dn629424.aspx)|
|Get a log of [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)] administrative tasks for your organization.|[Get-AadrmAdminLog](http://msdn.microsoft.com/library/azure/dn629430.aspx)|
|Log and analyze usage logging for [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)].|[Enable-AadrmUsageLogFeature](http://msdn.microsoft.com/library/azure/dn629421.aspx)<br /><br />[Get-AadrmUsageLog](http://msdn.microsoft.com/library/azure/dn629401.aspx)<br /><br />[Get-AadrmUsageLogFeature](http://msdn.microsoft.com/library/azure/dn629425.aspx)<br /><br />[Get-AadrmUsageLogLastCounterValue](http://msdn.microsoft.com/library/azure/dn629423.aspx)<br /><br />[Get-AadrmUsageLogStorageAccount](http://msdn.microsoft.com/library/azure/dn629419.aspx)<br /><br />[Set-AadrmUsageLogStorageAccount](http://msdn.microsoft.com/library/azure/dn629426.aspx)<br /><br />[Disable-AadrmUsageLogFeature](http://msdn.microsoft.com/library/azure/dn629404.aspx)|
|Display the current [!INCLUDE[aad_rightsmanagement_2](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_2_md.md)] service configuration for your organization.|[Get-AadrmConfiguration](http://msdn.microsoft.com/library/azure/dn629410.aspx)|
|Migrate your organization from [!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)] to an on-premises AD RMS deployment.|[Set-AadrmMigrationUrl](http://msdn.microsoft.com/library/azure/dn629429.aspx)<br /><br />[Get-AadrmMigrationUrl](http://msdn.microsoft.com/library/azure/dn629403.aspx)|

## See Also
[Azure Rights Management](../../ems/AADRightsMgmt/Azure-Rights-Management.md)

