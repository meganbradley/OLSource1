---
title: "How to: Programmatically Loop Through Found Items in Documents"
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
  - "loops, through found items in documents"
  - "documents [Office development in Visual Studio], searching"
  - "text [Office development in Visual Studio], searching in documents"
ms.assetid: 68dc41b1-eb96-4697-ac93-1a88c862ebad
caps.latest.revision: 44
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
# How to: Programmatically Loop Through Found Items in Documents
  The \<xref:Microsoft.Office.Interop.Word.Find> class has a \<xref:Microsoft.Office.Interop.Word.Find.Found*> property, which returns **true** whenever a searched-for item is found. You can loop through all instances found in a \<xref:Microsoft.Office.Interop.Word.Range> using the \<xref:Microsoft.Office.Interop.Word.Find.Execute*> method.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To loop through found items  
  
1.  Declare a \<xref:Microsoft.Office.Interop.Word.Range> object.  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#79](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-loop-through-found-items-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#79](../VS_officedev/codesnippet/CSharp/how-to--programmatically-loop-through-found-items-in-documents_1.cs)]  
  
     The following code example can be used in an VSTO Add-in. This example uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#79](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-loop-through-found-items-in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#79](../VS_officedev/codesnippet/CSharp/how-to--programmatically-loop-through-found-items-in-documents_2.cs)]  
  
2.  Use the \<xref:Microsoft.Office.Interop.Word.Find.Found*> property in a loop to search for all occurrences of the string in the document, and increment an integer variable by 1 each time the string is found.  
  
     [!code[Trin_VstcoreWordAutomation#80](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-loop-through-found-items-in-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#80](../VS_officedev/codesnippet/CSharp/how-to--programmatically-loop-through-found-items-in-documents_3.cs)]  
  
3.  Display the number of times the string was found in a message box.  
  
     [!code[Trin_VstcoreWordAutomation#81](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-loop-through-found-items-in-documents_4.vb)]
[!code[Trin_VstcoreWordAutomation#81](../VS_officedev/codesnippet/CSharp/how-to--programmatically-loop-through-found-items-in-documents_4.cs)]  
  
 The following examples show the complete method.  
  
## Document-Level Customization Example  
  
#### To loop through items in a document-level customization  
  
1.  The following example shows the complete code for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#78](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-loop-through-found-items-in-documents_5.vb)]
[!code[Trin_VstcoreWordAutomation#78](../VS_officedev/codesnippet/CSharp/how-to--programmatically-loop-through-found-items-in-documents_5.cs)]  
  
## VSTO Add-in Example  
  
#### To loop through items in an VSTO Add-in  
  
1.  The following example shows the complete code for an VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#78](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-loop-through-found-items-in-documents_6.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#78](../VS_officedev/codesnippet/CSharp/how-to--programmatically-loop-through-found-items-in-documents_6.cs)]  
  
## See Also  
 [How to: Programmatically Search for and Replace Text  in Documents](../VS_officedev/how-to--programmatically-search-for-and-replace-text--in-documents.md)   
 [How to: Programmatically Set Search Options in Word](../VS_officedev/how-to--programmatically-set-search-options-in-word.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Restore Selections After Searches](../VS_officedev/how-to--programmatically-restore-selections-after-searches.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  