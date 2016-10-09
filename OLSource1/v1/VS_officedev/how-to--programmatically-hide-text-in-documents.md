---
title: "How to: Programmatically Hide Text in Documents"
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
  - "documents [Office development in Visual Studio], hiding text"
  - "text [Office development in Visual Studio], hiding in documents"
ms.assetid: f5ced4ec-22ca-463b-b963-d34ce631b486
caps.latest.revision: 28
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
# How to: Programmatically Hide Text in Documents
  You can hide text in a document by setting the \<xref:Microsoft.Office.Interop.Word._Font.Hidden*> property of the \<xref:Microsoft.Office.Interop.Word.Range.Font*> for a particular range of text.  
  
 For example, you can temporarily hide the text within a \<xref:Microsoft.Office.Tools.Word.Bookmark> (in a document-level customization) or a \<xref:Microsoft.Office.Interop.Word.Bookmark> (in an VSTO Add-in) before sending a document to a printer.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To hide text in a Bookmark control while printing the document  
  
1.  Create a procedure that hides all text that is in a specified range.  
  
     [!code[Trin_VstcoreWordAutomation#105](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-hide-text-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#105](../VS_officedev/codesnippet/CSharp/how-to--programmatically-hide-text-in-documents_1.cs)]  
  
2.  Create a procedure that unhides all text that is in a specified range.  
  
     [!code[Trin_VstcoreWordAutomation#106](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-hide-text-in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#106](../VS_officedev/codesnippet/CSharp/how-to--programmatically-hide-text-in-documents_2.cs)]  
  
3.  Pass the range of a bookmark to the `HideText` method, print the document, and then pass the same range to the `UnhideText` method.  
  
     The following code example can be used in a document-level customization. To use this example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#107](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-hide-text-in-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#107](../VS_officedev/codesnippet/CSharp/how-to--programmatically-hide-text-in-documents_3.cs)]  
  
     The following code example can be used in an VSTO Add-in. This example uses the active document. To use the example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#107](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-hide-text-in-documents_4.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#107](../VS_officedev/codesnippet/CSharp/how-to--programmatically-hide-text-in-documents_4.cs)]  
  
## Compiling the Code  
 This code example assumes that the document contains a \<xref:Microsoft.Office.Tools.Word.Bookmark> control (in a document-level customization) or \<xref:Microsoft.Office.Interop.Word.Bookmark> control (in an VSTO Add-in) that is named `bookmark1`.  
  
## See Also  
 [How to: Programmatically Print Documents](../VS_officedev/how-to--programmatically-print-documents.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Reset Ranges in Word Documents](../VS_officedev/how-to--programmatically-reset-ranges-in-word-documents.md)   
 [How to: Programmatically Update Bookmark Text](../VS_officedev/how-to--programmatically-update-bookmark-text.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  