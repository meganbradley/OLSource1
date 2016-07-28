---
title: "Comparing Azure Rights Management and AD RMS"
ms.custom: na
ms.date: 2015-10-01
ms.reviewer: na
ms.service: rights-management
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8123bd62-1814-4d79-b306-e20c1a00e264
caps.latest.revision: 9
author: karthikaraman
manager: jeffgilb
translation.priority.ht: 
  - bg-bg
  - el-gr
  - es-es
  - et-ee
  - fi-fi
  - fr-fr
  - hr-hr
  - it-it
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
  - de-de
  - hu-hu
  - ja-jp
  - nb-no
  - nl-nl
  - pl-pl
  - pt-pt
  - sv-se
---
# Comparing Azure Rights Management and AD RMS
If you know or have previously deployed Active Directory Rights Management Services (AD RMS), you might be wondering how [!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)] (Azure RMS) compares in terms of functionality and requirements. Use the following table for a side-by-side comparison of the features and benefits of Azure RMS and AD RMS. If you have security-specific comparison questions, see the [Cryptographic controls for signing and encryption](../../ems/AADRightsMgmt/Comparing-Azure-Rights-Management-and-AD-RMS.md#BKMK_CryptographicControls) section in this topic.

> [!NOTE]
> To make this comparison easier, some information here is repeated from [Requirements for Azure Rights Management](../../ems/AADRightsMgmt/Requirements-for-Azure-Rights-Management.md). Use that topic for more specific support and version information for [!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)].

|[!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)](Azure RMS) <br /> <br />|Active Directory Rights Management Services (AD RMS) <br /> <br />|
|--------------------------------------------------------------------------------------|--------------------------------------------------------|
|Supports information rights management (IRM) capabilities in Microsoft Online services such as Exchange Online and SharePoint Online, as well as Office 365. <br /> <br />Also supports on-premises Microsoft server products, such as Exchange Server, SharePoint Server, and file servers that run Windows Server and File Classification Infrastructure (FCI). <br /> <br />|Supports on-premises Microsoft server products such as Exchange Server, SharePoint Server, and file servers that run Windows Server and File Classification Infrastructure (FCI). <br /> <br />|
|Enables implicit trust between organizations and users in any organization. This means that protected content can be shared between users within the same organization or across organizations when users have [!INCLUDE[o365_1](../../ems/AADRightsMgmt/includes/o365_1_md.md)], or [!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)], or users sign up for RMS for individuals. <br /> <br />|Trusts must be explicitly defined in a direct point-to-point relationship between two organizations by using either trusted user domains (TUDs) or federated trusts that you create by using Active Directory Federation Services (AD FS). <br /> <br />|
|Provides two default rights policy templates that restrict access of the content to your own organization; one that provides read-only viewing of protected content and another template that provides write or modify permissions for the protected content. <br /> <br />You can also create your own custom templates, which includes departmental templates that are visible to only a subset of users. For more information, see [Configuring Custom Templates for Azure Rights Management](../../ems/AADRightsMgmt/Configuring-Custom-Templates-for-Azure-Rights-Management.md). <br /> <br />In addition, users can define their own set of permissions if the templates are not sufficient. <br /> <br />|There are no default rights policy templates; you must create and then distribute these. For more information, see [AD RMS Policy Template Considerations](http://go.microsoft.com/fwlink/?LinkId=154765). <br /> <br />In addition, users can define their own set of permissions if the templates are not sufficient. <br /> <br />|
|Minimum supported version of Microsoft Office is Office 2010, which requires the [RMS sharing application](http://technet.microsoft.com/library/dn339006.aspx).Microsoft Office for Mac:<ul><li>Microsoft Office for Mac 2016: Supported </li><li>Microsoft Office for Mac 2011: Not supported </li> </ul>|Minimum supported version of Microsoft Office is Office 2007.Microsoft Office for Mac:<ul><li>Microsoft Office for Mac 2016: Supported </li><li>Microsoft Office for Mac 2011: Supported </li> </ul>|
|Supports the [RMS sharing application](https://technet.microsoft.com/library/dn919648%28v=ws.10%29.aspx) for Windows, Mac computers, and mobile devices.In addition, the RMS sharing application supports the following:<ul><li>Sharing with people in another organization. </li><li>Email notification, which lets the sender know when somebody tries to open a protected attachment. </li><li>A document tracking site for users, which includes the ability to revoke a document. </li> </ul>|Supports the [RMS sharing application](https://technet.microsoft.com/library/dn919648%28v=ws.10%29.aspx) for Windows, Mac computers, and mobile devices. However, sharing does not support sharing with people in another organization, email notification, or the document tracking site and the ability for users to revoke documents. <br /> <br />|
|All file types can be protected with [native or generic protection when you use the RMS sharing application](https://technet.microsoft.com/library/dn339003%28v=ws.10%29.aspx). <br /> <br />For other applications, check the [client capabilities table](https://technet.microsoft.com/library/dn655136.aspx#BKMK_ClientCapabilities). <br /> <br />|All file types can be protected with [native or generic protection when you use the RMS sharing application](https://technet.microsoft.com/library/dn339003%28v=ws.10%29.aspx). <br /> <br />For other applications, check the [client capabilities table](https://technet.microsoft.com/library/dn655136.aspx#BKMK_ClientCapabilities). <br /> <br />|
|Minimum supported version of the Windows client is Windows 7. <br /> <br />|Minimum supported version of the Windows client is Windows Vista Service Pack 2. <br /> <br />|
|Mobile device support includes Windows Phone, Android, iOS, and Windows RT. <br /> <br />Email support by using Exchange ActiveSync IRM is also supported on all mobile device platforms that support this protocol. <br /> <br />|Mobile device support includes Windows Phone, Android, iOS, and Windows RT, and requires the [Active Directory Rights Management Services Mobile Device Extension](http://technet.microsoft.com/library/a69ead9d-7dd3-4b38-9830-4728e9757341). <br /> <br />Email support by using Exchange ActiveSync IRM is supported on all mobile device platforms that support this protocol. <br /> <br />|
|Supports multi-factor authentication (MFA) for computers and mobile devices. <br /> <br />For more information, see the [Multi-factor authentication (MFA) and Azure RMS](../../ems/AADRightsMgmt/Requirements-for-Azure-Rights-Management.md#BKMK_MFA) section in the [Requirements for Azure Rights Management](../../ems/AADRightsMgmt/Requirements-for-Azure-Rights-Management.md) topic. <br /> <br />|Supports smart card authentication if IIS is configured to request certificates. <br /> <br />|
|Supports Cryptographic Mode 2 without additional configuration, which provides stronger security for key lengths and encryption algorithms. <br /> <br />For more information, see the [Cryptographic controls for signing and encryption](../../ems/AADRightsMgmt/Comparing-Azure-Rights-Management-and-AD-RMS.md#BKMK_CryptographicControls) section in this topic, and [AD RMS Cryptographic Modes](http://go.microsoft.com/fwlink/?LinkId=266659). <br /> <br />|Supports Cryptographic Mode 1 by default and requires additional configuration to support Cryptographic Mode 2 for stronger security. <br /> <br />For more information, see the [Cryptographic controls for signing and encryption](../../ems/AADRightsMgmt/Comparing-Azure-Rights-Management-and-AD-RMS.md#BKMK_CryptographicControls) section in this topic, and [AD RMS Cryptographic Modes](http://go.microsoft.com/fwlink/?LinkId=266659). <br /> <br />|
|Supports migration from AD RMS and if required, to AD RMS:<ul><li>[Migrating from AD RMS to Azure Rights Management](../../ems/AADRightsMgmt/Migrating-from-AD-RMS-to-Azure-Rights-Management.md) </li><li>[Decommissioning and Deactivating Azure Rights Management](../../ems/AADRightsMgmt/Decommissioning-and-Deactivating-Azure-Rights-Management.md) </li> </ul>|Supports migration from Azure RMS and to Azure RMS:<ul><li>[Decommissioning and Deactivating Azure Rights Management](../../ems/AADRightsMgmt/Decommissioning-and-Deactivating-Azure-Rights-Management.md) </li><li>[Migrating from AD RMS to Azure Rights Management](../../ems/AADRightsMgmt/Migrating-from-AD-RMS-to-Azure-Rights-Management.md) </li> </ul>|
|Requires an RMS license to protect content. No RMS license is required to consume content that has been protected by Azure RMS (includes users from another organization). <br /> <br />For more information, see the [Cloud subscriptions that support Azure RMS](../../ems/AADRightsMgmt/Requirements-for-Azure-Rights-Management.md#BKMK_SupportedSubscriptions) section from    [Requirements for Azure Rights Management](../../ems/AADRightsMgmt/Requirements-for-Azure-Rights-Management.md). <br /> <br />|Requires an RMS license to protect content, and to consume  content that has been protected by AD RMS. <br /> <br />For more information about licensing for AD RMS, see [Client Access Licenses and Management Licenses](https://www.microsoft.com/en-us/Licensing/product-licensing/client-access-license.aspx) for general information, but contact your Microsoft partner or Microsoft representative for specific information. <br /> <br />|

## <a name="BKMK_CryptographicControls"></a>Cryptographic controls for signing and encryption
[!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)] always uses RSA 2048 for all public key cryptography and SHA 256 for signing operations. In comparison, AD RMS supports RSA 1024 and RSA 2048, and SHA 1 or SHA 256 for signing operations.

Both [!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)] and AD RMS use AES 128 for symmetric encryption.

[!INCLUDE[aad_rightsmanagement_1](../../ems/AADRightsMgmt/includes/aad_rightsmanagement_1_md.md)]is compliant with FIPS 140-2 when your tenant key is created and managed by Microsoft (the default), or if you manage your own tenant key (known as BYOK). For more information about managing your tenant key, see [Planning and Implementing Your Azure Rights Management Tenant Key](../../ems/AADRightsMgmt/Planning-and-Implementing-Your-Azure-Rights-Management-Tenant-Key.md).

## See Also
[Getting Started with Azure Rights Management](../../ems/AADRightsMgmt/Getting-Started-with-Azure-Rights-Management.md)

