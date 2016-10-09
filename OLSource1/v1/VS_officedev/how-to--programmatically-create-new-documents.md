---
title: "How to: Programmatically Create New Documents"
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
  - "templates [Office development in Visual Studio], custom document"
  - "Word [Office development in Visual Studio], creating documents"
  - "documents [Office development in Visual Studio], creating"
ms.assetid: c24bb8a3-1303-438e-9b33-ba8b00b29c3b
caps.latest.revision: 49
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
# How to: Programmatically Create New Documents
  When you create a document programmatically, the new document is a native \<xref:Microsoft.Office.Interop.Word.Document> object. This object does not have the additional events and data binding capabilities of a \<xref:Microsoft.Office.Tools.Word.Document> host item. For more information, see [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md).  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 When you develop a document-level project, you cannot programmatically add \<xref:Microsoft.Office.Tools.Word.Document> host items to your project. In a VSTO Add-in project, you can convert any \<xref:Microsoft.Office.Interop.Word.Document> object to a \<xref:Microsoft.Office.Tools.Word.Document> host item at run time. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
### To create a new document based on the Normal template  
  
-   Use the \<xref:Microsoft.Office.Interop.Word.Documents.Add*> method of the \<xref:Microsoft.Office.Interop.Word.Documents> collection to create a new document based on the Normal template. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#1](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-new-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#1](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-new-documents_1.cs)]  
  
## Using Custom Templates  
 The \<xref:Microsoft.Office.Interop.Word.Documents.Add*> method has an optional *Template* argument to create a new document based on a template other than the Normal template. You must supply the file name and fully qualified path of the template.  
  
#### To create a new document based on a custom template  
  
-   Call the \<xref:Microsoft.Office.Interop.Word.Documents.Add*> method of the \<xref:Microsoft.Office.Interop.Word.Documents> collection and specify the path to the template. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#2](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-new-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#2](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-new-documents_2.cs)]  
  
## See Also  
 [How to: Programmatically Open Existing Documents](../VS_officedev/how-to--programmatically-open-existing-documents.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  