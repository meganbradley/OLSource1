---
title: "How to: Programmatically Print Documents"
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
  - "Word [Office development in Visual Studio], printing documents"
  - "documents [Office development in Visual Studio], printing"
ms.assetid: 99285d98-1bb7-4ccb-83d9-e917b0a9ea42
caps.latest.revision: 53
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
# How to: Programmatically Print Documents
  You can print an entire Microsoft Office Word document, or part of a document, to your default printer.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Printing a Document That Is Part of a Document-Level Customization  
  
#### To print the entire document  
  
1.  Call the \<xref:Microsoft.Office.Tools.Word.Document.PrintOut*> method of the `ThisDocument` class in your project to print the entire document. To use this example, run the code from the `ThisDocument` class.  
  
     [!code[Trin_VstcoreWordAutomation#11](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#11](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-documents_1.cs)]  
  
#### To print the current page of the document  
  
1.  Call the \<xref:Microsoft.Office.Tools.Word.Document.PrintOut*> method of the `ThisDocument` class in your project and specify that one copy of the current page be printed. To use this example, run the code from the `ThisDocument` class.  
  
     [!code[Trin_VstcoreWordAutomation#12](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#12](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-documents_2.cs)]  
  
## Printing a Document By Using an VSTO Add-in  
  
#### To print an entire document  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word._Document.PrintOut*> method of the \<xref:Microsoft.Office.Interop.Word.Document> object that you want to print. The following code example prints the active document. To use this example, run the code from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#11](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-documents_3.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#11](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-documents_3.cs)]  
  
#### To print the current page of a document  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word._Document.PrintOut*> method of the \<xref:Microsoft.Office.Interop.Word.Document> object that you want to print, and specify that one copy of the current page be printed. The following code example prints the active document. To use this example, run the code from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#12](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-documents_4.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#12](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-documents_4.cs)]  
  
## See Also  
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  