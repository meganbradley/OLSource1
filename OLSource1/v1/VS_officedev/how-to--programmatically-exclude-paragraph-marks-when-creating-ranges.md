---
title: "How to: Programmatically Exclude Paragraph Marks When Creating Ranges"
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
  - "documents [Office development in Visual Studio], excluding paragraphs"
  - "ranges, excluding paragraph marks in Word"
  - "documents [Office development in Visual Studio], paragraph marks"
  - "paragraphs, controlling structure"
ms.assetid: 6d563834-34bd-4462-a556-4339d9277eee
caps.latest.revision: 50
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
# How to: Programmatically Exclude Paragraph Marks When Creating Ranges
  Whenever you create a \<xref:Microsoft.Office.Interop.Word.Range> object based on a paragraph, all non-printing characters, such as paragraph marks, are included in the range. You may want to insert the text from a source paragraph into a destination paragraph. If you do not want to split the destination paragraph into separate paragraphs, then you must first remove the paragraph mark from the source paragraph. Additionally, since paragraph formatting information is stored within the paragraph mark, you might not want to include this when you insert the range into an existing paragraph.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 The following example procedure declares two string variables, retrieves the contents of the first and second paragraphs in the active document, and then exchanges their contents. The example then demonstrates removing the paragraph marker from the range by using the \<xref:Microsoft.Office.Interop.Word.Range.MoveEnd*> method and inserting text inside the paragraph.  
  
### To control paragraph structure when inserting text  
  
1.  Create two range variables for the first and second paragraphs, and retrieve their contents using the \<xref:Microsoft.Office.Interop.Word.Range.Text*> property.  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#27](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_1.vb)]
[!code[Trin_VstcoreWordAutomation#27](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_1.cs)]  
  
     The following code example can be used in an application-level VSTO Add-in. This code uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#27](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#27](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_2.cs)]  
  
2.  Assign the \<xref:Microsoft.Office.Interop.Word.Range.Text*> property, swapping the text between the two paragraphs.  
  
     [!code[Trin_VstcoreWordAutomation#28](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_3.vb)]
[!code[Trin_VstcoreWordAutomation#28](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_3.cs)]  
  
3.  Select each range in turn and pause to display the results in a message box.  
  
     [!code[Trin_VstcoreWordAutomation#29](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_4.vb)]
[!code[Trin_VstcoreWordAutomation#29](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_4.cs)]  
  
4.  Adjust `firstRange` using the \<xref:Microsoft.Office.Interop.Word.Range.MoveEnd*> method so that the paragraph marker is no longer a part of `firstRange`.  
  
     [!code[Trin_VstcoreWordAutomation#30](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_5.vb)]
[!code[Trin_VstcoreWordAutomation#30](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_5.cs)]  
  
5.  Replace the rest of the text in the first paragraph, assigning a new string to the \<xref:Microsoft.Office.Interop.Word.Range.Text*> property of the range.  
  
     [!code[Trin_VstcoreWordAutomation#31](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_6.vb)]
[!code[Trin_VstcoreWordAutomation#31](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_6.cs)]  
  
6.  Replace the text in `secondRange`, including the paragraph mark.  
  
     [!code[Trin_VstcoreWordAutomation#32](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_7.vb)]
[!code[Trin_VstcoreWordAutomation#32](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_7.cs)]  
  
7.  Select `firstRange` and pause to display the results in a message box, and then do the same with `secondRange`.  
  
     Since `firstRange` was redefined to exclude the paragraph mark, the original formatting of the paragraph is preserved. However, a sentence was inserted over the paragraph mark in `secondRange`, removing the separate paragraph.  
  
     [!code[Trin_VstcoreWordAutomation#33](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_8.vb)]
[!code[Trin_VstcoreWordAutomation#33](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_8.cs)]  
  
     The original contents of both ranges were saved as strings, so you can restore the document to its original condition.  
  
8.  Readjust `firstRange` to include the paragraph mark by using the \<xref:Microsoft.Office.Interop.Word.Range.MoveEnd*> method for one character position.  
  
     [!code[Trin_VstcoreWordAutomation#34](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_9.vb)]
[!code[Trin_VstcoreWordAutomation#34](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_9.cs)]  
  
9. Delete `secondRange`. This restores paragraph three to its original position.  
  
     [!code[Trin_VstcoreWordAutomation#35](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_10.vb)]
[!code[Trin_VstcoreWordAutomation#35](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_10.cs)]  
  
10. Restore the original paragraph text in `firstRange`.  
  
     [!code[Trin_VstcoreWordAutomation#36](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_11.vb)]
[!code[Trin_VstcoreWordAutomation#36](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_11.cs)]  
  
11. Use the \<xref:Microsoft.Office.Interop.Word.Range.InsertAfter*> method of the \<xref:Microsoft.Office.Interop.Word.Range> object to insert the original paragraph-two content after `firstRange`, and then select `firstRange`.  
  
     [!code[Trin_VstcoreWordAutomation#37](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_12.vb)]
[!code[Trin_VstcoreWordAutomation#37](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_12.cs)]  
  
## Document-Level Customization Example  
  
#### To control paragraph structure when inserting text in document-level customizations  
  
1.  The following example shows the complete method for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#26](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_13.vb)]
[!code[Trin_VstcoreWordAutomation#26](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_13.cs)]  
  
## VSTO Add-in Example  
  
#### To control paragraph structure when inserting text in an VSTO Add-in  
  
1.  The following example shows the complete method for an VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#26](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_14.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#26](../VS_officedev/codesnippet/CSharp/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges_14.cs)]  
  
## See Also  
 [How to: Programmatically Extend Ranges in Documents](../VS_officedev/how-to--programmatically-extend-ranges-in-documents.md)   
 [How to: Programmatically Collapse Ranges or Selections in Documents](../VS_officedev/how-to--programmatically-collapse-ranges-or-selections-in-documents.md)   
 [How to: Programmatically Insert Text into Word Documents](../VS_officedev/how-to--programmatically-insert-text-into-word-documents.md)   
 [How to: Programmatically Reset Ranges in Word Documents](../VS_officedev/how-to--programmatically-reset-ranges-in-word-documents.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  