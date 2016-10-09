---
title: "How to: Programmatically Format Text in Documents"
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
  - "formatting [Office development in Visual Studio]"
  - "documents [Office development in Visual Studio], formatting text"
  - "text [Office development in Visual Studio], formatting in documents"
ms.assetid: 0a84893b-5ccc-4515-a2dc-95773ee8eaba
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
# How to: Programmatically Format Text in Documents
  You can use the \<xref:Microsoft.Office.Interop.Word.Range> object to format text in a Microsoft Office Word document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 The following example selects the first paragraph in the document and changes the font size, the font name, and the alignment. It then selects the range and displays a message box to pause before executing the next section of code. The next section calls the Undo method of the \<xref:Microsoft.Office.Tools.Word.Document> host item (for a document-level customization) or the \<xref:Microsoft.Office.Interop.Word.Document> class (for a VSTO Add-in) three times. It applies the Normal Indent style and displays a message box to pause the code. Then the code calls the \<xref:Microsoft.Office.Tools.Word.Document.Undo*> method once, and displays a message box.  
  
## Document-Level Customization Example  
  
#### To format text using a document-level customization  
  
1.  The following example can be used in a document-level customization. To use this code, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#62](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-format-text-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#62](../VS_officedev/codesnippet/CSharp/how-to--programmatically-format-text-in-documents_1.cs)]  
  
## VSTO Add-in Example  
  
#### To format text using a VSTO Add-in  
  
1.  The following example can be used in a VSTO Add-in. This example uses the active document. To use this code, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#62](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-format-text-in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#62](../VS_officedev/codesnippet/CSharp/how-to--programmatically-format-text-in-documents_2.cs)]  
  
## See Also  
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Insert Text into Word Documents](../VS_officedev/how-to--programmatically-insert-text-into-word-documents.md)   
 [How to: Programmatically Search for and Replace Text  in Documents](../VS_officedev/how-to--programmatically-search-for-and-replace-text--in-documents.md)  
  
  