---
title: "How to: Target the Office Multilingual User Interface"
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
  - "globalization [Office development in Visual Studio], user interface targeting"
  - "MUI [Office development in Visual Studio]"
  - "Office applications [Office development in Visual Studio], localization"
  - "Multilingual User Interface [Office development in Visual Studio]"
  - "localization [Office development in Visual Studio], user interface targeting"
  - "Office applications [Office development in Visual Studio], globalization"
ms.assetid: b1f03164-f0cf-42e3-942b-8cf90c242ffb
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
# How to: Target the Office Multilingual User Interface
  The Multilingual User Interface (MUI) is a Microsoft Office feature that gives the end user the ability to change the language of the user interface (UI). For example, an end user working with an English UI can change the language of the UI to Spanish.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 If your application will be used by people who use multiple languages of Office, you can add code to automatically change the language of your UI strings to match the language being used by Office on the user's computer (if the user has the correct resources installed).  
  
### To check the current Office UI setting  
  
1.  Use the \<xref:System.Threading.Thread.CurrentUICulture*> property of the current thread. Set the language of your UI strings to match the language being used by the version of Office currently running on the user's computer.  
  
     [!code[Trin_VstcoreCreatingExcel#10](../VS_officedev/codesnippet/VisualBasic/how-to--target-the-office-multilingual-user-interface_1.vb)]
[!code[Trin_VstcoreCreatingExcel#10](../VS_officedev/codesnippet/CSharp/how-to--target-the-office-multilingual-user-interface_1.cs)]  
  
## See Also  
 [How to: Target Office Applications Through Primary Interop Assemblies](../VS_officedev/how-to--target-office-applications-through-primary-interop-assemblies.md)   
 [Late Binding in Office Solutions](../VS_officedev/late-binding-in-office-solutions.md)  
  
  