---
title: "How to: Programmatically Remove All Comments from Documents"
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
  - "documents [Office development in Visual Studio], removing comments"
  - "comments, removing from documents"
ms.assetid: 920de39a-3b6d-4682-bca6-f4b4dedda1ac
caps.latest.revision: 24
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
# How to: Programmatically Remove All Comments from Documents
  Use the DeleteAllComments method to remove all comments from a Microsoft Office Word document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To remove all comments from a document that is part of a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Word.Document.DeleteAllComments*> method of the `ThisDocument` class in your project. To use this code example, run it from the `ThisDocument` class.  
  
     [!code[Trin_VstcoreWordAutomation#119](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-remove-all-comments-from-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#119](../VS_officedev/codesnippet/CSharp/how-to--programmatically-remove-all-comments-from-documents_1.cs)]  
  
### To remove all comments from a document by using an VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word._Document.DeleteAllComments*> method of the \<xref:Microsoft.Office.Interop.Word.Document> from which you want to remove comments.  
  
     The following code example removes all comments from the active document. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#119](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-remove-all-comments-from-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#119](../VS_officedev/codesnippet/CSharp/how-to--programmatically-remove-all-comments-from-documents_2.cs)]  
  
## See Also  
 [How to: Programmatically Add Comments to Text in Documents](../VS_officedev/how-to--programmatically-add-comments-to-text-in-documents.md)   
 [Document Host Item](../VS_officedev/document-host-item.md)  
  
  