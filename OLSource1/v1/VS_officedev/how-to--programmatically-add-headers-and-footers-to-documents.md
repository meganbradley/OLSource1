---
title: "How to: Programmatically Add Headers and Footers to Documents"
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
  - "headers, adding to Office documents"
  - "documents [Office development in Visual Studio], adding headers"
  - "documents [Office development in Visual Studio], adding footers"
  - "footers, adding to documents"
ms.assetid: c7a5cc8a-d8c0-48e9-81d3-108aa6bfbb74
caps.latest.revision: 24
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
# How to: Programmatically Add Headers and Footers to Documents
  You can add text to headers and footers in your document by using the \<xref:Microsoft.Office.Interop.Word.Section.Headers*> property and \<xref:Microsoft.Office.Interop.Word.Section.Footers*> property of the \<xref:Microsoft.Office.Interop.Word.Section>. Each section of a document contains three headers and footers:  
  
-   \<xref:Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterEvenPages>  
  
-   \<xref:Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterFirstPage>  
  
 The procedures are different for document-level customizations and VSTO Add-ins.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Document-Level Customizations  
 To use the following code examples, run them from the `ThisDocument` class in your project.  
  
#### To add text to footers in the document  
  
1.  The following code example sets the font of the text to be inserted into the primary footer of each section of the document, and then inserts text into the footer.  
  
     [!code[Trin_VstcoreWordAutomation#114](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-headers-and-footers-to-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#114](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-headers-and-footers-to-documents_1.cs)]  
  
#### To add text to headers in the document  
  
1.  The following code example adds a field to show the page number in each header in the document, and then sets the paragraph alignment so that the text aligns to the right of the header.  
  
     [!code[Trin_VstcoreWordAutomation#116](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-headers-and-footers-to-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#116](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-headers-and-footers-to-documents_2.cs)]  
  
## VSTO Add-Ins  
 To use the following code examples, run them from the `ThisAddIn` class in your project.  
  
#### To add text to footers in a document  
  
1.  The following code example sets the font of the text to be inserted into the primary footer of each section of the document, and then inserts text into the footer. This code example uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#114](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-headers-and-footers-to-documents_3.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#114](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-headers-and-footers-to-documents_3.cs)]  
  
#### To add text to headers in the document  
  
1.  The following code example adds a field to show the page number in each header in the document, and then sets the paragraph alignment so that the text aligns to the right of the header. This code example uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#116](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-headers-and-footers-to-documents_4.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#116](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-headers-and-footers-to-documents_4.cs)]  
  
## See Also  
 [How to: Programmatically Create New Documents](../VS_officedev/how-to--programmatically-create-new-documents.md)   
 [How to: Programmatically Extend Ranges in Documents](../VS_officedev/how-to--programmatically-extend-ranges-in-documents.md)   
 [How to: Programmatically Loop Through Found Items in Documents](../VS_officedev/how-to--programmatically-loop-through-found-items-in-documents.md)  
  
  