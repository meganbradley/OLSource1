---
title: "How to: Programmatically Define and Select Ranges in Documents"
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
  - "documents [Office development in Visual Studio], selecting sentences"
  - "documents [Office development in Visual Studio], ranges"
  - "sentences, selecting in documents"
  - "ranges, selecting in documents"
  - "ranges, defining in documents"
ms.assetid: 0727c1cb-d44c-4f1c-a699-4365dd13be5d
caps.latest.revision: 46
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
# How to: Programmatically Define and Select Ranges in Documents
  You can define a range in a Microsoft Office Word document by using a \<xref:Microsoft.Office.Interop.Word.Range> object. You can select the entire document in a number of ways, for example, by using the \<xref:Microsoft.Office.Interop.Word.Range.Select*> method of the \<xref:Microsoft.Office.Interop.Word.Range> object, or by using the Content property of the \<xref:Microsoft.Office.Tools.Word.Document> class (in a document-level customization) or the \<xref:Microsoft.Office.Interop.Word.Document> class (in a VSTO Add-in).  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Defining a Range  
 The following example shows how to create a new \<xref:Microsoft.Office.Interop.Word.Range> object that includes the first seven characters in the active document, including non-printing characters. It then selects the text within the range.  
  
#### To define a range in a document-level customization  
  
1.  Add the range to the document by passing a start and end character to the \<xref:Microsoft.Office.Tools.Word.Document.Range*> method of the \<xref:Microsoft.Office.Tools.Word.Document> class. To use this code example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#18](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#18](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_1.cs)]  
  
#### To define a range by using a VSTO Add-in  
  
1.  Add the range to the document by passing a start and end character to the \<xref:Microsoft.Office.Interop.Word._Document.Range*> method of the \<xref:Microsoft.Office.Interop.Word.Document> class. The following code example adds a range to the active document. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#18](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#18](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_2.cs)]  
  
## Selecting a Range in a Document-Level Customization  
 The following examples show how to select the entire document by using the \<xref:Microsoft.Office.Interop.Word.Range.Select*> method of a \<xref:Microsoft.Office.Interop.Word.Range> object, or by using the \<xref:Microsoft.Office.Tools.Word.Document.Content*> property of the \<xref:Microsoft.Office.Tools.Word.Document> class.  
  
#### To select the entire document as a range by using the Select method  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Range.Select*> method of a \<xref:Microsoft.Office.Interop.Word.Range> that contains the entire document. To use the following code example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#19](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#19](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_3.cs)]  
  
#### To select the entire document as a range by using the Content property  
  
1.  Use the \<xref:Microsoft.Office.Tools.Word.Document.Content*> property to define a range that encompasses the entire document.  
  
     [!code[Trin_VstcoreWordAutomation#20](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_4.vb)]
[!code[Trin_VstcoreWordAutomation#20](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_4.cs)]  
  
 You can also use the methods and properties of other objects to define a range.  
  
#### To select a sentence in the active document  
  
1.  Set the range by using the \<xref:Microsoft.Office.Interop.Word.Sentences> collection. Use the index of the sentence you want to select.  
  
     [!code[Trin_VstcoreWordAutomation#21](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_5.vb)]
[!code[Trin_VstcoreWordAutomation#21](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_5.cs)]  
  
 Another way to select a sentence is to manually set the start and end values for the range.  
  
#### To select a sentence by manually setting the start and end values  
  
1.  Create a range variable.  
  
     [!code[Trin_VstcoreWordAutomation#23](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_6.vb)]
[!code[Trin_VstcoreWordAutomation#23](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_6.cs)]  
  
2.  Check to see if there are at least two sentences in the document, set the *Start* and *End* arguments of the range, and then select the range.  
  
     [!code[Trin_VstcoreWordAutomation#24](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_7.vb)]
[!code[Trin_VstcoreWordAutomation#24](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_7.cs)]  
  
## Selecting a Range by Using a VSTO Add-in  
 The following examples show how to select the entire document by using the \<xref:Microsoft.Office.Interop.Word.Range.Select*> method of a \<xref:Microsoft.Office.Interop.Word.Range> object, or by using the \<xref:Microsoft.Office.Interop.Word._Document.Content*> property of the \<xref:Microsoft.Office.Interop.Word.Document> class.  
  
#### To select the entire document as a range by using the Select method  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Range.Select*> method of a \<xref:Microsoft.Office.Interop.Word.Range> that contains the entire document. The following code example selects the contents of the active document. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#19](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_8.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#19](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_8.cs)]  
  
#### To select the entire document as a range by using the Content property  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word._Document.Content*> property to define a range that encompasses the entire document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#20](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_9.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#20](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_9.cs)]  
  
 You can also use the methods and properties of other objects to define a range.  
  
#### To select a sentence in the active document  
  
1.  Set the range by using the \<xref:Microsoft.Office.Interop.Word.Sentences> collection. Use the index of the sentence you want to select.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#21](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_10.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#21](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_10.cs)]  
  
 Another way to select a sentence is to manually set the start and end values for the range.  
  
#### To select a sentence by manually setting the start and end values  
  
1.  Create a range variable.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#23](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_11.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#23](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_11.cs)]  
  
2.  Check to see if there are at least two sentences in the document, set the *Start* and *End* arguments of the range, and then select the range.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#24](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-define-and-select-ranges-in-documents_12.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#24](../VS_officedev/codesnippet/CSharp/how-to--programmatically-define-and-select-ranges-in-documents_12.cs)]  
  
## See Also  
 [Word Object Model Overview](../VS_officedev/word-object-model-overview.md)   
 [How to: Programmatically Extend Ranges in Documents](../VS_officedev/how-to--programmatically-extend-ranges-in-documents.md)   
 [How to: Programmatically Retrieve Start and End Characters in Ranges](../VS_officedev/how-to--programmatically-retrieve-start-and-end-characters-in-ranges.md)   
 [How to: Programmatically Extend Ranges in Documents](../VS_officedev/how-to--programmatically-extend-ranges-in-documents.md)   
 [How to: Programmatically Reset Ranges in Word Documents](../VS_officedev/how-to--programmatically-reset-ranges-in-word-documents.md)   
 [How to: Programmatically Collapse Ranges or Selections in Documents](../VS_officedev/how-to--programmatically-collapse-ranges-or-selections-in-documents.md)   
 [How to: Programmatically Exclude Paragraph Marks When Creating Ranges](../VS_officedev/how-to--programmatically-exclude-paragraph-marks-when-creating-ranges.md)  
  
  