---
title: "How to: Programmatically Move Items in Outlook"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Outlook folders [Office development in Visual Studio], moving items"
ms.assetid: ac524f2e-a3e8-496d-bd5a-714799be44ab
caps.latest.revision: 18
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Programmatically Move Items in Outlook
  This example moves unread e-mail messages from the **Inbox** to a folder named **Test**. The example only moves messages that have the word **Test** in the `Subject` field.  
  
 [!INCLUDE[appliesto_olkallapp](../VS_officedev/includes/appliesto_olkallapp_md.md)]  
  
## Example  
 [!code[Trin_OL_MoveItems#1](../VS_officedev/codesnippet/CSharp/how-to--programmatically-move-items-in-outlook_1.cs)]  
  
## Compiling the Code  
 This example requires:  
  
-   An Outlook mail folder named **Test**.  
  
-   An e-mail message that arrives with the word **Test** in the `Subject` field.  
  
## See Also  
 [Working with Folders](../VS_officedev/working-with-folders.md)   
 [How to: Programmatically Retrieve a Folder by Name](../VS_officedev/how-to--programmatically-retrieve-a-folder-by-name.md)   
 [How to: Programmatically Search Within a Specific Folder](../VS_officedev/how-to--programmatically-search-within-a-specific-folder.md)   
 [How to: Programmatically Perform Actions When an E-Mail Message Is Received](../VS_officedev/how-to--programmatically-perform-actions-when-an-e-mail-message-is-received.md)  
  
  