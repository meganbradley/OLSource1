---
title: "How to: Programmatically Close Visio Documents"
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
  - "documents [Office development in Visual Studio], closing Visio documents"
  - "Visio [Office development in Visual Studio], closing Visio documents"
ms.assetid: 59c0e215-a4c1-4b39-a491-37534f172705
caps.latest.revision: 13
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Programmatically Close Visio Documents
  You can close the active Microsoft Office Visio document by using the Microsoft.Office.Interop.Visio.Document.Close method.  
  
 For details about this method, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Document.Close](HV10070225) method.  
  
## Closing the Active Document  
  
#### To close the active document  
  
-   Call the Microsoft.Office.Interop.Visio.Document.Close method to close the active document.  
  
     To use the following code example, run it in the `ThisAddIn` class in an VSTO Add-in project for Visio.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#7](../VS_officedev/codesnippet/CSharp/how-to--programmatically-close-visio-documents_1.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#7](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-close-visio-documents_1.vb)]  
  
## See Also  
 [Visio Solutions](../VS_officedev/visio-solutions.md)   
 [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)   
 [How to: Programmatically Create New Visio Documents](../VS_officedev/how-to--programmatically-create-new-visio-documents.md)   
 [How to: Programmatically Open Visio Documents](../VS_officedev/how-to--programmatically-open-visio-documents.md)   
 [How to: Programmatically Save Visio Documents](../VS_officedev/how-to--programmatically-save-visio-documents.md)   
 [How to: Programmatically Print Visio Documents](../VS_officedev/how-to--programmatically-print-visio-documents.md)  
  
  