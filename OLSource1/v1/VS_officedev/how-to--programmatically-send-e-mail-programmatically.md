---
title: "How to: Programmatically Send E-Mail Programmatically"
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
  - "mail items [Office development in Visual Studio], sending e-mail"
  - "Outlook [Office development in Visual Studio], creating e-mail"
  - "Outlook [Office development in Visual Studio], sending e-mail"
  - "e-mail [Office development in Visual Studio], sending"
ms.assetid: 4fa0e1b5-2caf-4a11-8626-df643b23f5f0
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
# How to: Programmatically Send E-Mail Programmatically
  This example sends an e-mail message to contacts that have the domain name **example.com** in their e-mail addresses.  
  
 [!INCLUDE[appliesto_olkallapp](../VS_officedev/includes/appliesto_olkallapp_md.md)]  
  
## Example  
 [!code[Trin_OL_ProgramEmail#1](../VS_officedev/codesnippet/CSharp/how-to--programmatically-send-e-mail-programmatically_1.cs)]  
  
## Compiling the Code  
 This example requires:  
  
-   Contacts that have the domain name **example.com** in their e-mail addresses.  
  
## Robust Programming  
 Do not remove the filter code that searches for the domain name **example.com**. Your solution will send e-mail messages to all of your contacts if you remove the filter.  
  
## See Also  
 [Working with Mail Items](../VS_officedev/working-with-mail-items.md)   
 [How to: Programmatically Create an E-Mail Item](../VS_officedev/how-to--programmatically-create-an-e-mail-item.md)   
 [How to: Programmatically Access Outlook Contacts](../VS_officedev/how-to--programmatically-access-outlook-contacts.md)   
 [How to: Programmatically Perform Actions When an E-Mail Message Is Received](../VS_officedev/how-to--programmatically-perform-actions-when-an-e-mail-message-is-received.md)  
  
  