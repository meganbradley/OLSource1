---
title: "How to: Programmatically Protect Documents and Parts of Documents"
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
  - "document protection"
  - "documents [Office development in Visual Studio], document protection"
  - "Word documents, protection"
ms.assetid: af8390fc-c4c7-48c7-94b8-4fedbaac0757
caps.latest.revision: 25
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
# How to: Programmatically Protect Documents and Parts of Documents
  You can add protection to Microsoft Office Word documents to prevent users from making any edits to the document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 You can also mark certain areas of the document as exceptions so that specified users can edit only those areas of the document. For example, you might want to protect an entire document except for a particular bookmark. You can optionally add a password so that users cannot remove the document protection unless they know the password.  
  
> [!NOTE]  
>  The following example does not use password protection; however, you might want to consider using a password when adding document protection. For more information, see the Document Protector Sample at [Office Development Samples and Walkthroughs](../VS_officedev/office-development-samples-and-walkthroughs.md).  
  
 You can also use content controls to protect parts of documents. For more information, see [How to: Protect Parts of Documents by Using Content Controls](../VS_officedev/how-to--protect-parts-of-documents-by-using-content-controls.md).  
  
## Protecting a Document That Is Part of a Document-Level Customization  
  
#### To protect a document that is part of a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Word.Document.Protect*> method of the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#111](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-documents-and-parts-of-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#111](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-documents-and-parts-of-documents_1.cs)]  
  
#### To exclude a bookmark control from document protection  
  
1.  Protect the entire document using the \<xref:Microsoft.Office.Tools.Word.Document.Protect*> method.  
  
     [!code[Trin_VstcoreWordAutomation#111](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-documents-and-parts-of-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#111](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-documents-and-parts-of-documents_1.cs)]  
  
2.  Exclude `Bookmark1` from the document protection.  
  
     [!code[Trin_VstcoreWordAutomation#112](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-documents-and-parts-of-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#112](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-documents-and-parts-of-documents_2.cs)]  
  
### Compiling the Code  
 To use these code examples, run them from the `ThisDocument` class in your project. These code examples assume you have an existing \<xref:Microsoft.Office.Tools.Word.Bookmark> control named `Bookmark1` on the document in which this code appears.  
  
## Protecting a Document by Using an VSTO Add-in  
  
#### To protect a document by using an application-level VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word._Document.Protect*> method of the \<xref:Microsoft.Office.Interop.Word.Document> that you want to protect.  
  
     The following code example protects the active document. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#111](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-documents-and-parts-of-documents_3.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#111](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-documents-and-parts-of-documents_3.cs)]  
  
## See Also  
 [Document Protection in Document-Level Solutions](../VS_officedev/document-protection-in-document-level-solutions.md)   
 [Password Protection on Office Documents](../VS_officedev/password-protection-on-office-documents.md)   
 [How to: Permit Code to Run Behind Documents with Restricted Permissions](../VS_officedev/how-to--permit-code-to-run-behind-documents-with-restricted-permissions.md)   
 [How to: Add Bookmark Controls to Word Documents](../VS_officedev/how-to--add-bookmark-controls-to-word-documents.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)  
  
  