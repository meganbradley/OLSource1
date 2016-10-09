---
title: "How to: Programmatically Add Comments to Text in Documents"
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
  - "comments, adding to documents"
  - "documents [Office development in Visual Studio], adding comments"
ms.assetid: 4e396e31-01bf-424c-be6b-9a1806bcd572
caps.latest.revision: 26
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
# How to: Programmatically Add Comments to Text in Documents
  The Comments property of the Document class adds a comment to a range of text in a Microsoft Office Word document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 The following example adds a comment to the first paragraph in the document.  
  
### To add a new comment to text in a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word.Comments.Add*> method of the \<xref:Microsoft.Office.Tools.Word.Document.Comments*> property and supply a range and the comment text. To use the following code example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#118](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-comments-to-text-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#118](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-comments-to-text-in-documents_1.cs)]  
  
### To add a new comment to text in an VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word.Comments.Add*> method of the \<xref:Microsoft.Office.Interop.Word._Document.Comments*> property and supply a range and the comment text.  
  
     The following code example adds a comment to the active document. To use this example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#118](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-comments-to-text-in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#118](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-comments-to-text-in-documents_2.cs)]  
  
## Robust Programming  
 To change the user initials that Word adds to comments, use the \<xref:Microsoft.Office.Interop.Word._Application.UserInitials*> property.  
  
## See Also  
 [How to: Programmatically Remove All Comments from Documents](../VS_officedev/how-to--programmatically-remove-all-comments-from-documents.md)   
 [Document Host Item](../VS_officedev/document-host-item.md)  
  
  