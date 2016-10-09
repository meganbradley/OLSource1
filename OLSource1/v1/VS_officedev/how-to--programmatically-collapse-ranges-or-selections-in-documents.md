---
title: "How to: Programmatically Collapse Ranges or Selections in Documents"
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
  - "selections, collapsing"
  - "documents [Office development in Visual Studio], collapsing ranges"
  - "collapsing selections"
  - "ranges, collapsing"
  - "collapsing ranges"
ms.assetid: 0bd059dd-8606-42ae-a8a9-97f8f3bd5cc5
caps.latest.revision: 42
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
# How to: Programmatically Collapse Ranges or Selections in Documents
  If you are working with a \<xref:Microsoft.Office.Interop.Word.Range> or \<xref:Microsoft.Office.Interop.Word.Selection> object, you might want to change the selection to an insertion point before inserting text, to avoid overwriting existing text. Both the \<xref:Microsoft.Office.Interop.Word.Range> and \<xref:Microsoft.Office.Interop.Word.Selection> objects have a Collapse method, which makes use of the \<xref:Microsoft.Office.Interop.Word.WdCollapseDirection> enumeration values:  
  
-   \<xref:Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseStart> collapses the selection to the beginning of the selection. This is the default if you do not specify an enumeration value.  
  
-   \<xref:Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseEnd> collapses the selection to the end of the selection.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To collapse a range and insert new text  
  
1.  Create a \<xref:Microsoft.Office.Interop.Word.Range> object that consists of the first paragraph in the document.  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#46](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-collapse-ranges-or-selections-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#46](../VS_officedev/codesnippet/CSharp/how-to--programmatically-collapse-ranges-or-selections-in-documents_1.cs)]  
  
     The following code example can be used in an VSTO Add-in. This code uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#46](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-collapse-ranges-or-selections-in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#46](../VS_officedev/codesnippet/CSharp/how-to--programmatically-collapse-ranges-or-selections-in-documents_2.cs)]  
  
2.  Use the \<xref:Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseStart> enumeration value to collapse the range.  
  
     [!code[Trin_VstcoreWordAutomation#47](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-collapse-ranges-or-selections-in-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#47](../VS_officedev/codesnippet/CSharp/how-to--programmatically-collapse-ranges-or-selections-in-documents_3.cs)]  
  
3.  Insert the new text.  
  
     [!code[Trin_VstcoreWordAutomation#48](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-collapse-ranges-or-selections-in-documents_4.vb)]
[!code[Trin_VstcoreWordAutomation#48](../VS_officedev/codesnippet/CSharp/how-to--programmatically-collapse-ranges-or-selections-in-documents_4.cs)]  
  
4.  Select the \<xref:Microsoft.Office.Interop.Word.Range>.  
  
     [!code[Trin_VstcoreWordAutomation#49](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-collapse-ranges-or-selections-in-documents_5.vb)]
[!code[Trin_VstcoreWordAutomation#49](../VS_officedev/codesnippet/CSharp/how-to--programmatically-collapse-ranges-or-selections-in-documents_5.cs)]  
  
 If you use the \<xref:Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseEnd> enumeration value, the text is inserted at the beginning of the following paragraph.  
  
 [!code[Trin_VstcoreWordAutomation#50](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-collapse-ranges-or-selections-in-documents_6.vb)]
[!code[Trin_VstcoreWordAutomation#50](../VS_officedev/codesnippet/CSharp/how-to--programmatically-collapse-ranges-or-selections-in-documents_6.cs)]  
  
 You might expect that inserting a new sentence would insert it before the paragraph marker, but that is not the case because the original range includes the paragraph marker. For more information, see [How to: Programmatically Exclude Paragraph Marks When Creating Ranges](../VS_officedev/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges.md).  
  
## Document-Level Customization Example  
  
#### To collapse a range in a document-level customization  
  
1.  The following example shows the complete method for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#45](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-collapse-ranges-or-selections-in-documents_7.vb)]
[!code[Trin_VstcoreWordAutomation#45](../VS_officedev/codesnippet/CSharp/how-to--programmatically-collapse-ranges-or-selections-in-documents_7.cs)]  
  
## VSTO Add-in Example  
  
#### To collapse a range in an VSTO Add-in  
  
1.  The following example shows the complete method for an VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#45](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-collapse-ranges-or-selections-in-documents_8.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#45](../VS_officedev/codesnippet/CSharp/how-to--programmatically-collapse-ranges-or-selections-in-documents_8.cs)]  
  
## See Also  
 [How to: Programmatically Insert Text into Word Documents](../VS_officedev/how-to--programmatically-insert-text-into-word-documents.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Retrieve Start and End Characters in Ranges](../VS_officedev/how-to--programmatically-retrieve-start-and-end-characters-in-ranges.md)   
 [How to: Programmatically Exclude Paragraph Marks When Creating Ranges](../VS_officedev/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges.md)   
 [How to: Programmatically Extend Ranges in Documents](../VS_officedev/how-to--programmatically-extend-ranges-in-documents.md)   
 [How to: Programmatically Reset Ranges in Word Documents](../VS_officedev/how-to--programmatically-reset-ranges-in-word-documents.md)  
  
  