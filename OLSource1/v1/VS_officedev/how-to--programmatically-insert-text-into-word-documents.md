---
title: "How to: Programmatically Insert Text into Word Documents"
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
  - "ranges, inserting text in documents"
  - "text [Office development in Visual Studio], inserting in documents"
  - "ranges, replacing text in documents"
  - "documents [Office development in Visual Studio], inserting text"
  - "text [Office development in Visual Studio], replacing"
ms.assetid: 405d7442-8ba3-4fcc-b17e-7b289ffd3967
caps.latest.revision: 41
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
# How to: Programmatically Insert Text into Word Documents
  There are three primary ways to insert text into Microsoft Office Word documents:  
  
-   Insert text in a range.  
  
-   Replace text in a range with new text.  
  
-   Use the \<xref:Microsoft.Office.Interop.Word.Selection.TypeText*> method of a \<xref:Microsoft.Office.Interop.Word.Selection> object to insert text at the cursor or selection.  
  
> [!NOTE]  
>  You can also insert text into content controls and bookmarks. For more information, see [Content Controls](../VS_officedev/content-controls.md) and [Bookmark Control](../VS_officedev/bookmark-control.md).  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Inserting Text in a Range  
 Use the \<xref:Microsoft.Office.Interop.Word.Range.Text*> property of a \<xref:Microsoft.Office.Interop.Word.Range> object to insert text in a document.  
  
#### To insert text in a range  
  
1.  Specify a range at the beginning of a document and insert the text **New Text**.  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#51](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#51](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_1.cs)]  
  
     The following code example can be used in a VSTO Add-in. This code uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#51](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#51](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_2.cs)]  
  
2.  Select the \<xref:Microsoft.Office.Interop.Word.Range> object, which has expanded from one character to the length of the inserted text.  
  
     [!code[Trin_VstcoreWordAutomation#52](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#52](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_3.cs)]  
  
## Replacing Text in a Range  
 If the specified range contains text, all text in the range is replaced with the inserted text.  
  
#### To replace text in a range  
  
1.  Create a \<xref:Microsoft.Office.Interop.Word.Range> object that consists of the first 12 characters in the document.  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#53](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_4.vb)]
[!code[Trin_VstcoreWordAutomation#53](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_4.cs)]  
  
     The following code example can be used in a VSTO Add-in. This code uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#53](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_5.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#53](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_5.cs)]  
  
2.  Replace those characters with the string **New Text**.  
  
     [!code[Trin_VstcoreWordAutomation#54](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_6.vb)]
[!code[Trin_VstcoreWordAutomation#54](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_6.cs)]  
  
3.  Select the range.  
  
     [!code[Trin_VstcoreWordAutomation#55](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_7.vb)]
[!code[Trin_VstcoreWordAutomation#55](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_7.cs)]  
  
## Inserting Text Using TypeText  
 The \<xref:Microsoft.Office.Interop.Word.Selection.TypeText*> method inserts text at the selection. \<xref:Microsoft.Office.Interop.Word.Selection.TypeText*> behaves differently depending on the options set on the user's computer. The code in the following procedure declares a \<xref:Microsoft.Office.Interop.Word.Selection> object variable, and turns off the **Overtype** option if it is turned on. If the **Overtype** option is activated, then any text next to the cursor is overwritten.  
  
#### To insert text using the TypeText method  
  
1.  Declare a \<xref:Microsoft.Office.Interop.Word.Selection> object variable.  
  
     [!code[Trin_VstcoreWordAutomation#57](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_8.vb)]
[!code[Trin_VstcoreWordAutomation#57](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_8.cs)]  
  
2.  Turn off the **Overtype** option if it is turned on.  
  
     [!code[Trin_VstcoreWordAutomation#58](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_9.vb)]
[!code[Trin_VstcoreWordAutomation#58](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_9.cs)]  
  
3.  Test to see whether the current selection is an insertion point.  
  
     If it is, the code inserts a sentence using \<xref:Microsoft.Office.Interop.Word.Selection.TypeText*>, and then a paragraph mark using the \<xref:Microsoft.Office.Interop.Word.Selection.TypeParagraph*> method.  
  
     [!code[Trin_VstcoreWordAutomation#59](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_10.vb)]
[!code[Trin_VstcoreWordAutomation#59](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_10.cs)]  
  
4.  The code in the **ElseIf** block tests to see whether the selection is a normal selection. If it is, then another **If** block tests to see whether the **ReplaceSelection** option is turned on. If it is, the code uses the \<xref:Microsoft.Office.Interop.Word.Selection.Collapse*> method of the selection to collapse the selection to an insertion point at the start of the selected block of text. Insert the text and a paragraph mark.  
  
     [!code[Trin_VstcoreWordAutomation#60](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_11.vb)]
[!code[Trin_VstcoreWordAutomation#60](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_11.cs)]  
  
5.  If the selection is not an insertion point or a block of selected text, then the code in the **Else** block does nothing.  
  
     [!code[Trin_VstcoreWordAutomation#61](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_12.vb)]
[!code[Trin_VstcoreWordAutomation#61](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_12.cs)]  
  
 You can also use the \<xref:Microsoft.Office.Interop.Word.Selection.TypeBackspace*> method of the \<xref:Microsoft.Office.Interop.Word.Selection> object, which mimics the functionality of the BACKSPACE key on your keyboard. However, when it comes to inserting and manipulating text, the \<xref:Microsoft.Office.Interop.Word.Range> object offers you more control.  
  
 The following example shows the complete code. To use this example, run the code from the `ThisDocument` or `ThisAddIn` class in your project.  
  
 [!code[Trin_VstcoreWordAutomation#56](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-insert-text-into-word-documents_13.vb)]
[!code[Trin_VstcoreWordAutomation#56](../VS_officedev/codesnippet/CSharp/how-to--programmatically-insert-text-into-word-documents_13.cs)]  
  
## See Also  
 [How to: Programmatically Format Text in Documents](../VS_officedev/how-to--programmatically-format-text-in-documents.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Extend Ranges in Documents](../VS_officedev/how-to--programmatically-extend-ranges-in-documents.md)  
  
  