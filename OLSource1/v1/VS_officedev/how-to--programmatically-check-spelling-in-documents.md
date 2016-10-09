---
title: "How to: Programmatically Check Spelling in Documents"
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
  - "documents [Office development in Visual Studio], checking spelling"
  - "spelling checker, documents"
ms.assetid: 5bbe3a8d-fc65-4f57-bd63-5bb549dbc4bd
caps.latest.revision: 24
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
# How to: Programmatically Check Spelling in Documents
  To check the spelling in a document, use the \<xref:Microsoft.Office.Interop.Word._Application.CheckSpelling*> method. This method returns a Boolean value that indicates whether the supplied parameter is spelled correctly.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To check spelling and display results in a message box  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word._Application.CheckSpelling*> method and pass it a range of text to check for spelling errors. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#113](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-check-spelling-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#113](../VS_officedev/codesnippet/CSharp/how-to--programmatically-check-spelling-in-documents_1.cs)]  
  
## See Also  
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  