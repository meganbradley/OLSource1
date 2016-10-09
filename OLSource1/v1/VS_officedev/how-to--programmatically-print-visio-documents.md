---
title: "How to: Programmatically Print Visio Documents"
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
  - "Visio [Office development in Visual Studio], printing Visio documents"
  - "documents [Office development in Visual Studio], printing Visio documents"
ms.assetid: 606a2678-5eb8-40b2-a50a-305cecb1b3d4
caps.latest.revision: 17
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
# How to: Programmatically Print Visio Documents
  You can print a complete Microsoft Office Visio document or only a specific page.  
  
 For details about the print methods, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Document.Print](HV10070345) method and [Microsoft.Office.Interop.Visio.Page.Print](HV10070404) method.  
  
## Printing a Visio Document  
  
#### To print a complete document  
  
-   Call the Microsoft.Office.Interop.Visio.Document.Print method of the Microsoft.Office.Interop.Visio.Document object that you want to print.  
  
     The following code example prints the active document. To use this example, run the code from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#8](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-visio-documents_1.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#8](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-visio-documents_1.vb)]  
  
## Printing a Page of a Visio Document  
  
#### To print a page of a document  
  
-   Call the Microsoft.Office.Interop.Visio.Pages.Print method of the Microsoft.Office.Interop.Visio.Pages object that you want to print.  
  
     The following code example prints the first page of the active document. To use this example, run the code from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#9](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-visio-documents_2.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#9](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-visio-documents_2.vb)]  
  
## See Also  
 [Visio Solutions](../VS_officedev/visio-solutions.md)   
 [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)   
 [How to: Programmatically Create New Visio Documents](../VS_officedev/how-to--programmatically-create-new-visio-documents.md)   
 [How to: Programmatically Open Visio Documents](../VS_officedev/how-to--programmatically-open-visio-documents.md)   
 [How to: Programmatically Close Visio Documents](../VS_officedev/how-to--programmatically-close-visio-documents.md)   
 [How to: Programmatically Save Visio Documents](../VS_officedev/how-to--programmatically-save-visio-documents.md)  
  
  