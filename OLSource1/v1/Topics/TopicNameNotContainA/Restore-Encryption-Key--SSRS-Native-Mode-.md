---
title: "Restore Encryption Key (SSRS Native Mode)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 11ce51e5-f5d4-40b6-88d8-9360fb50e66c
caps.latest.revision: 8
manager: mblythe
robots: noindex,nofollow
---
# Restore Encryption Key (SSRS Native Mode)
[!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] uses an encryption key to secure sensitive data that is stored in the report server database. To ensure that you have continued access to encrypted data, it is important that you create a backup of the encryption key in case you need to restore it later due to changes in the service account or as part of a planned migration. This topic is an overview of how to use the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Configuration Manager to restore keys.  
  
 [!INCLUDE[applies](../../Topics/TopicNameContainA/includes/applies_md.md)] [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Native mode.  
  
 To restore the key, you must have previously saved a backup copy of the key to a password protected file. During key restoration, the report server will replace an existing key with the key that is found in the password protected file. The key that is inside the file must be identical to the key that is used to encrypt and decrypt data.  
  
 To verify whether you restored a valid key, use Report Manager to view subscriptions or any report that has a data source that uses stored credentials. If you receive "The report server is unable to access encrypted data" error when attempting to open a subscription definition page, or if you are prompted to enter credentials when opening a report that previously used stored credentials for the report data source, you restored an invalid key.  
  
 If you restore an invalid key that is different from the one used to encrypt the data, it will be impossible to decrypt data that is currently stored in the report server database. If you restore an invalid key, you should immediately restore a backup copy of the correct key if it is available. If you do not have a backup copy of the key that was used to encrypt data, you must delete all encrypted data. Click the **Delete** button on the [Encryption Keys](../../Topics/TopicNameNotContainA/Encryption-Keys---Reporting-Services-Native-mode--Configuration-Manager-.md) page to perform this step. After you delete the encrypted content, you must manually update all subscriptions and re-specify all stored credentials defined for reports and data-driven subscriptions on the report server.  
  
## Restore Encryption Key Dialog  
 For information on where to find the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Configuration Manager, see [Reporting Services Configuration Manager (Native Mode)](../../Topics/TopicNameNotContainA/Reporting-Services-Configuration-Manager--Native-Mode-.md).  
  
 To open the Restore Encryption Key dialog box, click **Encryption Keys** in the navigation pane of the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Configuration Manager, and then click **Restore**. This dialog box also appears when you update the service account using the Service Account page in the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] Configuration Manager. For more information on the  
  
## Options  
 **File Location**  
 Select the password-protected file that contains a copy of the symmetric key. The default file extension is .snk.  
  
 **Password**  
 Enter the password that unlocks the file. Only users who know the password can restore the key. [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] enforces a strong password policy. The password must contain at least 8 characters and include a combination of uppercase and lowercase alphanumeric characters and at least one symbol character.  
  
## See Also  
 [Reporting Services Configuration Manager Help Topics](../../Topics/TopicNameNotContainA/Reporting-Services-Configuration-Manager-Help-Topics.md)   
 [Back Up and Restore Reporting Services Encryption Keys](../../Topics/TopicNameNotContainA/Back-Up-and-Restore-Reporting-Services-Encryption-Keys.md)   
 [Delete and Re-create Encryption Keys  (SSRS Configuration Manager)](../../Topics/TopicNameNotContainA/Delete-and-Re-create-Encryption-Keys---SSRS-Configuration-Manager-.md)   
 [Initialize a Report Server (SSRS Configuration Manager)](../../Topics/TopicNameContainA/Initialize-a-Report-Server--SSRS-Configuration-Manager-.md)   
 [Store Encrypted Report Server Data (SSRS Configuration Manager)](../../Topics/TopicNameNotContainA/Store-Encrypted-Report-Server-Data--SSRS-Configuration-Manager-.md)   
 [Encryption Keys - Reporting Services Native mode (Configuration Manager)](../../Topics/TopicNameNotContainA/Encryption-Keys---Reporting-Services-Native-mode--Configuration-Manager-.md)