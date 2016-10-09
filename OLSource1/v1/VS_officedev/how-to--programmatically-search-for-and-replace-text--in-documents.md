---
title: "How to: Programmatically Search for and Replace Text  in Documents"
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
  - "documents [Office development in Visual Studio], searching"
  - "text searches, replacing text"
  - "text searches, documents"
  - "text [Office development in Visual Studio], searching in documents"
  - "text [Office development in Visual Studio], text searches"
ms.assetid: a66962f5-eeb9-4dc6-a70f-9039ab437a63
caps.latest.revision: 51
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
# How to: Programmatically Search for and Replace Text  in Documents
  The \<xref:Microsoft.Office.Interop.Word.Find> object is a member of both the \<xref:Microsoft.Office.Interop.Word.Selection> and the \<xref:Microsoft.Office.Interop.Word.Range> objects, and you can use either one to search for text in Microsoft Office Word documents. The replace command is an extension of the find command.  
  
 Use a \<xref:Microsoft.Office.Interop.Word.Find> object to loop through a Microsoft Office Word document and search for specific text, formatting, or style, and use the \<xref:Microsoft.Office.Interop.Word.Find.Replacement*> property to replace any of the items found.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Using a Selection Object  
 When you use a \<xref:Microsoft.Office.Interop.Word.Selection> object to find text, any search criteria you specify are applied only against currently selected text. If the \<xref:Microsoft.Office.Interop.Word.Selection> is an insertion point, then the document is searched. When the item is found that matches the search criteria, it is automatically selected.  
  
 It is important to note that the \<xref:Microsoft.Office.Interop.Word.Find> criteria are cumulative, which means that criteria are added to previous search criteria. Clear formatting from previous searches by using the \<xref:Microsoft.Office.Interop.Word.Find.ClearFormatting*> method prior to the search.  
  
#### To find text using a Selection object  
  
1.  Assign a search string to a variable.  
  
     [!code[Trin_VstcoreWordAutomation#68](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#68](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_1.cs)]  
  
2.  Clear formatting from previous searches.  
  
     [!code[Trin_VstcoreWordAutomation#69](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#69](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_2.cs)]  
  
3.  Execute the search and display a message box with the results.  
  
     [!code[Trin_VstcoreWordAutomation#70](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#70](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_3.cs)]  
  
 The following example shows the complete method.  
  
 [!code[Trin_VstcoreWordAutomation#67](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_4.vb)]
[!code[Trin_VstcoreWordAutomation#67](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_4.cs)]  
  
## Using a Range Object  
 Using a \<xref:Microsoft.Office.Interop.Word.Range> object enables you to search for text without displaying anything in the user interface. The \<xref:Microsoft.Office.Interop.Word.Find> object returns **True** if text is found that matches the search criteria, and **False** if it does not. It also redefines the \<xref:Microsoft.Office.Interop.Word.Range> object to match the search criteria if the text is found.  
  
#### To find text using a Range object  
  
1.  Define a \<xref:Microsoft.Office.Interop.Word.Range> object that consists of the second paragraph in the document.  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#72](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_5.vb)]
[!code[Trin_VstcoreWordAutomation#72](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_5.cs)]  
  
     The following code example can be used in a VSTO Add-in. This example uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#72](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_6.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#72](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_6.cs)]  
  
2.  Using the \<xref:Microsoft.Office.Interop.Word.Range.Find*> property of the \<xref:Microsoft.Office.Interop.Word.Range> object, first clear any existing formatting options, and then search for the string **find me**.  
  
     [!code[Trin_VstcoreWordAutomation#73](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_7.vb)]
[!code[Trin_VstcoreWordAutomation#73](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_7.cs)]  
  
3.  Display the results of the search in a message box, and select the \<xref:Microsoft.Office.Interop.Word.Range> to make it visible.  
  
     [!code[Trin_VstcoreWordAutomation#74](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_8.vb)]
[!code[Trin_VstcoreWordAutomation#74](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_8.cs)]  
  
     If the search fails, the second paragraph is selected; if it succeeds, the search criteria are displayed.  
  
 The following example shows the complete code for a document-level customization. To use this example, run the code from the `ThisDocument` class in your project.  
  
 [!code[Trin_VstcoreWordAutomation#71](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_9.vb)]
[!code[Trin_VstcoreWordAutomation#71](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_9.cs)]  
  
 The following example shows the complete code for a VSTO Add-in. To use this example, run the code from the `ThisAddIn` class in your project.  
  
 [!code[Trin_VstcoreWordAutomationAddIn#71](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_10.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#71](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_10.cs)]  
  
## Searching For and Replacing Text in Documents  
 The following code searches the current selection and replaces all of the occurrences of the string **find me** with the string **Found**.  
  
#### To search for and replace text in documents  
  
1.  Add the following example code to the `ThisDocument` or `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#75](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-and-replace-text--in-documents_11.vb)]
[!code[Trin_VstcoreWordAutomation#75](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-and-replace-text--in-documents_11.cs)]  
  
     The \<xref:Microsoft.Office.Interop.Word.Find> class has a \<xref:Microsoft.Office.Interop.Word.Find.ClearFormatting*> method, and the \<xref:Microsoft.Office.Interop.Word.Replacement> class also has its own \<xref:Microsoft.Office.Interop.Word.Replacement.ClearFormatting*> method. When you are performing find-and-replace operations, you must use the ClearFormatting method of both objects. If you use it only on the \<xref:Microsoft.Office.Interop.Word.Find> object, you might get unanticipated results in the replacement text.  
  
2.  Use the \<xref:Microsoft.Office.Interop.Word.Find.Execute*> method of the \<xref:Microsoft.Office.Interop.Word.Find> object to replace each found item. To specify which items to replace, use the *Replace* parameter. This parameter can be one of the following \<xref:Microsoft.Office.Interop.Word.WdReplace> values:  
  
    -   \<xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll> replaces all found items.  
  
    -   \<xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceNone> replaces none of the found items.  
  
    -   \<xref:Microsoft.Office.Interop.Word.WdReplace.wdReplaceOne> replaces the first found item.  
  
## See Also  
 [How to: Programmatically Set Search Options in Word](../VS_officedev/how-to--programmatically-set-search-options-in-word.md)   
 [How to: Programmatically Loop Through Found Items in Documents](../VS_officedev/how-to--programmatically-loop-through-found-items-in-documents.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Restore Selections After Searches](../VS_officedev/how-to--programmatically-restore-selections-after-searches.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  