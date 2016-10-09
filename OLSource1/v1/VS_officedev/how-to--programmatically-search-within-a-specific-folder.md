---
title: "How to: Programmatically Search Within a Specific Folder"
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
  - "Outlook folders [Office development in Visual Studio], searching"
ms.assetid: 8f2cdc8b-f757-412c-aa2b-ebd5bc52f697
caps.latest.revision: 30
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
# How to: Programmatically Search Within a Specific Folder
  This code example uses the `Find` and `FindNext` methods to search for text in the subject field of e-mail messages that are in the **Inbox**. This method uses a string filter to check for the letter T as the starting letter of the `Subject` text.  
  
 [!INCLUDE[appliesto_olkallapp](../VS_officedev/includes/appliesto_olkallapp_md.md)]  
  
## Example  
 [!code[Trin_OL_SearchFolder#1](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-within-a-specific-folder_1.cs)]  
  
## See Also  
 [Working with Folders](../VS_officedev/working-with-folders.md)   
 [Outlook Object Model Overview](../VS_officedev/outlook-object-model-overview.md)   
 [How to: Programmatically Retrieve a Folder by Name](../VS_officedev/how-to--programmatically-retrieve-a-folder-by-name.md)  
  
  