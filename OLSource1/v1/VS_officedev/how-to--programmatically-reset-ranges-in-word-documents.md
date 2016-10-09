---
title: "How to: Programmatically Reset Ranges in Word Documents"
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
  - "documents [Office development in Visual Studio], resetting ranges"
  - "ranges, resetting in documents"
ms.assetid: 45ea9434-e548-4d24-938f-4f1ffa5010d0
caps.latest.revision: 39
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
# How to: Programmatically Reset Ranges in Word Documents
  Use the \<xref:Microsoft.Office.Interop.Word.Range.SetRange*> method to resize an existing range in a Microsoft Office Word document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To reset an existing range  
  
1.  Set an initial range starting with the first seven characters in the document.  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#43](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-reset-ranges-in-word-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#43](../VS_officedev/codesnippet/CSharp/how-to--programmatically-reset-ranges-in-word-documents_1.cs)]  
  
     The following code example can be used in an VSTO Add-in. This code uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#43](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-reset-ranges-in-word-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#43](../VS_officedev/codesnippet/CSharp/how-to--programmatically-reset-ranges-in-word-documents_2.cs)]  
  
2.  Use \<xref:Microsoft.Office.Interop.Word.Range.SetRange*> to start the range at the second sentence and end it at the end of the fifth sentence.  
  
     [!code[Trin_VstcoreWordAutomation#44](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-reset-ranges-in-word-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#44](../VS_officedev/codesnippet/CSharp/how-to--programmatically-reset-ranges-in-word-documents_3.cs)]  
  
## Document-Level Customization Example  
  
#### To reset an existing range in a document-level customization  
  
1.  The following example shows the complete example for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#42](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-reset-ranges-in-word-documents_4.vb)]
[!code[Trin_VstcoreWordAutomation#42](../VS_officedev/codesnippet/CSharp/how-to--programmatically-reset-ranges-in-word-documents_4.cs)]  
  
## VSTO Add-in Example  
  
#### To reset an existing range in an VSTO Add-in  
  
1.  The following example shows the complete example for an VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#42](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-reset-ranges-in-word-documents_5.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#42](../VS_officedev/codesnippet/CSharp/how-to--programmatically-reset-ranges-in-word-documents_5.cs)]  
  
## See Also  
 [How to: Programmatically Extend Ranges in Documents](../VS_officedev/how-to--programmatically-extend-ranges-in-documents.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Retrieve Start and End Characters in Ranges](../VS_officedev/how-to--programmatically-retrieve-start-and-end-characters-in-ranges.md)   
 [How to: Programmatically Collapse Ranges or Selections in Documents](../VS_officedev/how-to--programmatically-collapse-ranges-or-selections-in-documents.md)  
  
  