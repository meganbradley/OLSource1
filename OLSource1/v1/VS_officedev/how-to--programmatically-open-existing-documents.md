---
title: "How to: Programmatically Open Existing Documents"
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
  - "documents [Office development in Visual Studio], opening"
  - "Word [Office development in Visual Studio], opening documents"
ms.assetid: 08f7fe4b-d96d-4a0c-b32a-aa7fd7992316
caps.latest.revision: 44
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
# How to: Programmatically Open Existing Documents
  The \<xref:Microsoft.Office.Interop.Word.Documents.Open*> method opens the existing Microsoft Office Word document specified by a fully qualified path and file name. This method returns a \<xref:Microsoft.Office.Interop.Word.Document> that represents the opened document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To open a document  
  
-   Call the \<xref:Microsoft.Office.Interop.Word.Documents.Open*> method of the \<xref:Microsoft.Office.Interop.Word.Documents> collection and supply a path to the document.  
  
     [!code[Trin_VstcoreWordAutomation#5](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-open-existing-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#5](../VS_officedev/codesnippet/CSharp/how-to--programmatically-open-existing-documents_1.cs)]  
  
### To open a document as read-only  
  
-   Call the \<xref:Microsoft.Office.Interop.Word.Documents.Open*> method, supply a path to the document, and set the *ReadOnly* argument to **True** in the method call.  
  
     [!code[Trin_VstcoreWordAutomation#6](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-open-existing-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#6](../VS_officedev/codesnippet/CSharp/how-to--programmatically-open-existing-documents_2.cs)]  
  
## Compiling the Code  
 This code example requires the following:  
  
-   A document named NewDocument.doc must exist in a directory named Test on drive C.  
  
## See Also  
 [How to: Programmatically Create New Documents](../VS_officedev/how-to--programmatically-create-new-documents.md)   
 [How to: Programmatically Close Documents](../VS_officedev/how-to--programmatically-close-documents.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  