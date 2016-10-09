---
title: "How to: Programmatically Extend Ranges in Documents"
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
  - "ranges, extending"
  - "documents [Office development in Visual Studio], extending ranges"
ms.assetid: 055af7a4-13d5-4236-b5fb-a112721482c5
caps.latest.revision: 41
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
# How to: Programmatically Extend Ranges in Documents
  After you define a \<xref:Microsoft.Office.Interop.Word.Range> object in a Microsoft Office Word document, you change its start and end points by using the \<xref:Microsoft.Office.Interop.Word.Range.MoveStart*> and \<xref:Microsoft.Office.Interop.Word.Range.MoveEnd*> methods. The \<xref:Microsoft.Office.Interop.Word.Range.MoveStart*> and \<xref:Microsoft.Office.Interop.Word.Range.MoveEnd*> methods take the same two arguments, *Unit* and *Count*. The *Count* argument is the number of units to move, and the *Unit* argument can be one of the following \<xref:Microsoft.Office.Interop.Word.WdUnits> values:  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdCharacter>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdWord>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdSentence>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdParagraph>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdSection>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdStory>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdCell>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdColumn>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdRow>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdUnits.wdTable>  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 The following example defines a seven-character range. It then moves the start position of the range seven characters after the original start position. Because the end position of the range was also seven characters after the start position, the result is a range that consists of zero characters. The code then moves the end position seven characters after the current end position.  
  
### To extend a range  
  
1.  Define a range of characters. For more information, see [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md).  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#39](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-extend-ranges-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#39](../VS_officedev/codesnippet/CSharp/how-to--programmatically-extend-ranges-in-documents_1.cs)]  
  
     The following code example can be used in an VSTO Add-in. This example uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#39](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-extend-ranges-in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#39](../VS_officedev/codesnippet/CSharp/how-to--programmatically-extend-ranges-in-documents_2.cs)]  
  
2.  Use the \<xref:Microsoft.Office.Interop.Word.Range.MoveStart*> method of the \<xref:Microsoft.Office.Interop.Word.Range> object to move the start position of the range.  
  
     [!code[Trin_VstcoreWordAutomation#40](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-extend-ranges-in-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#40](../VS_officedev/codesnippet/CSharp/how-to--programmatically-extend-ranges-in-documents_3.cs)]  
  
3.  Use the \<xref:Microsoft.Office.Interop.Word.Range.MoveEnd*> method of the \<xref:Microsoft.Office.Interop.Word.Range> object to move the end position of the range.  
  
     [!code[Trin_VstcoreWordAutomation#41](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-extend-ranges-in-documents_4.vb)]
[!code[Trin_VstcoreWordAutomation#41](../VS_officedev/codesnippet/CSharp/how-to--programmatically-extend-ranges-in-documents_4.cs)]  
  
## Document-Level Customization Code  
  
#### To extend a range in a document-level customization  
  
1.  The following example shows the complete code for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#38](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-extend-ranges-in-documents_5.vb)]
[!code[Trin_VstcoreWordAutomation#38](../VS_officedev/codesnippet/CSharp/how-to--programmatically-extend-ranges-in-documents_5.cs)]  
  
## VSTO Add-in Code  
  
#### To extend a range in an application-level VSTO Add-in  
  
1.  The following example shows the complete code for an VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#38](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-extend-ranges-in-documents_6.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#38](../VS_officedev/codesnippet/CSharp/how-to--programmatically-extend-ranges-in-documents_6.cs)]  
  
## See Also  
 [How to: Programmatically Reset Ranges in Word Documents](../VS_officedev/how-to--programmatically-reset-ranges-in-word-documents.md)   
 [How to: Programmatically Collapse Ranges or Selections in Documents](../VS_officedev/how-to--programmatically-collapse-ranges-or-selections-in-documents.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Retrieve Start and End Characters in Ranges](../VS_officedev/how-to--programmatically-retrieve-start-and-end-characters-in-ranges.md)   
 [How to: Programmatically Exclude Paragraph Marks When Creating Ranges](../VS_officedev/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges.md)  
  
  