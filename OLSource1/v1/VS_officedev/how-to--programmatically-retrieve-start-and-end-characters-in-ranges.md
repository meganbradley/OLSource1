---
title: "How to: Programmatically Retrieve Start and End Characters in Ranges"
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
  - "ranges, retrieving start and end characters"
  - "end characters"
  - "start characters"
  - "documents [Office development in Visual Studio], retrieving ranges"
ms.assetid: 734c630c-abc9-491d-94b6-429d1fc7a4cc
caps.latest.revision: 37
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
# How to: Programmatically Retrieve Start and End Characters in Ranges
  This example demonstrates how you can retrieve the character positions of the start and end positions of a range.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To retrieve start and end characters of a range in a document-level customization  
  
1.  Get the values of the \<xref:Microsoft.Office.Interop.Word.Range.Start*> and \<xref:Microsoft.Office.Interop.Word.Range.End*> properties of the \<xref:Microsoft.Office.Interop.Word.Range> object. The following code example gets the start and end position of the second sentence in the document. To use this code example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#25](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-retrieve-start-and-end-characters-in-ranges_1.vb)]
[!code[Trin_VstcoreWordAutomation#25](../VS_officedev/codesnippet/CSharp/how-to--programmatically-retrieve-start-and-end-characters-in-ranges_1.cs)]  
  
### To retrieve start and end characters of a range by using an VSTO Add-in  
  
1.  Get the values of the \<xref:Microsoft.Office.Interop.Word.Range.Start*> and \<xref:Microsoft.Office.Interop.Word.Range.End*> properties of the \<xref:Microsoft.Office.Interop.Word.Range> object. The following code example gets the start and end position of the second sentence in the active document. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#25](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-retrieve-start-and-end-characters-in-ranges_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#25](../VS_officedev/codesnippet/CSharp/how-to--programmatically-retrieve-start-and-end-characters-in-ranges_2.cs)]  
  
## See Also  
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Extend Ranges in Documents](../VS_officedev/how-to--programmatically-extend-ranges-in-documents.md)   
 [How to: Programmatically Reset Ranges in Word Documents](../VS_officedev/how-to--programmatically-reset-ranges-in-word-documents.md)   
 [How to: Programmatically Collapse Ranges or Selections in Documents](../VS_officedev/how-to--programmatically-collapse-ranges-or-selections-in-documents.md)   
 [How to: Programmatically Exclude Paragraph Marks When Creating Ranges](../VS_officedev/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges.md)   
 [How to: Programmatically Count Characters in Documents](../VS_officedev/how-to--programmatically-count-characters-in-documents.md)  
  
  