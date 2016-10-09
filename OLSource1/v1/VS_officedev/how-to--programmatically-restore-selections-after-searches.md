---
title: "How to: Programmatically Restore Selections After Searches"
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
  - "searches, restoring selection after"
  - "documents [Office development in Visual Studio], restoring selections"
  - "selections, restoring after a search"
ms.assetid: 1e6131ad-0e5b-4189-be67-5b2ed87d193d
caps.latest.revision: 35
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
# How to: Programmatically Restore Selections After Searches
  If you find and replace text in a document, you might want to restore the user's original selection after the search is completed.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 The code in the sample procedure makes use of two \<xref:Microsoft.Office.Interop.Word.Range> objects. One stores the current \<xref:Microsoft.Office.Interop.Word.Selection>, and one sets the entire document to use as a search range.  
  
### To restore the user's original selection after a search  
  
1.  Create the \<xref:Microsoft.Office.Interop.Word.Range> objects for the document and the current selection.  
  
     [!code[Trin_VstcoreWordAutomation#83](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-restore-selections-after-searches_1.vb)]
[!code[Trin_VstcoreWordAutomation#83](../VS_officedev/codesnippet/CSharp/how-to--programmatically-restore-selections-after-searches_1.cs)]  
  
2.  Perform the search and replace operation.  
  
     [!code[Trin_VstcoreWordAutomation#84](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-restore-selections-after-searches_2.vb)]
[!code[Trin_VstcoreWordAutomation#84](../VS_officedev/codesnippet/CSharp/how-to--programmatically-restore-selections-after-searches_2.cs)]  
  
3.  Select the start range to restore the user's original selection.  
  
     [!code[Trin_VstcoreWordAutomation#85](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-restore-selections-after-searches_3.vb)]
[!code[Trin_VstcoreWordAutomation#85](../VS_officedev/codesnippet/CSharp/how-to--programmatically-restore-selections-after-searches_3.cs)]  
  
 The following example shows the complete method.  
  
## Example  
 [!code[Trin_VstcoreWordAutomation#82](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-restore-selections-after-searches_4.vb)]
[!code[Trin_VstcoreWordAutomation#82](../VS_officedev/codesnippet/CSharp/how-to--programmatically-restore-selections-after-searches_4.cs)]  
  
## See Also  
 [How to: Programmatically Search for and Replace Text  in Documents](../VS_officedev/how-to--programmatically-search-for-and-replace-text--in-documents.md)   
 [How to: Programmatically Set Search Options in Word](../VS_officedev/how-to--programmatically-set-search-options-in-word.md)   
 [How to: Programmatically Loop Through Found Items in Documents](../VS_officedev/how-to--programmatically-loop-through-found-items-in-documents.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  