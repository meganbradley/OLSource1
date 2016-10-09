---
title: "How to: Programmatically Close Documents"
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
  - "documents [Office development in Visual Studio], closing"
  - "Word [Office development in Visual Studio], closing documents"
ms.assetid: d5bee1dc-63d1-4307-828f-b7b077e20fb9
caps.latest.revision: 55
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
# How to: Programmatically Close Documents
  You can close the active document or you can specify a document to close.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Closing the Active Document  
 There are two procedures for closing the active document: one for document-level customizations and one for VSTO Add-ins.  
  
#### To close the active document in a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Word.Document.Close*> method of the `ThisDocument` class in your project to close the document associated with the customization. To use the following code example, run it from the `ThisDocument` class.  
  
    > [!NOTE]  
    >  This example passes the \<xref:Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges> value to the *SaveChanges* parameter to close without saving changes or prompting the user.  
  
     [!code[Trin_VstcoreWordAutomation#3](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-close-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#3](../VS_officedev/codesnippet/CSharp/how-to--programmatically-close-documents_1.cs)]  
  
#### To close the active document in a VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word._Document.Close*> method of the \<xref:Microsoft.Office.Interop.Word._Application.ActiveDocument*> property to close the active document. To use the following code example, run it from the `ThisAddIn` class in your project.  
  
    > [!NOTE]  
    >  This example passes the \<xref:Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges> value to the *SaveChanges* parameter to close without saving changes or prompting the user.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#3](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-close-documents_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#3](../VS_officedev/codesnippet/CSharp/how-to--programmatically-close-documents_2.cs)]  
  
## Closing a Document That You Specify By Name  
 The way that you close a document that you specify by name is the same for VSTO Add-ins and document-level customizations.  
  
#### To close a document that you specify by name  
  
1.  Specify the document name as an argument to the \<xref:Microsoft.Office.Interop.Word._Application.Documents*> collection, and then call the \<xref:Microsoft.Office.Interop.Word._Document.Close*> method. The following code example assumes that a document named **NewDocument** is open in Word.  
  
    > [!NOTE]  
    >  This example passes the \<xref:Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges> value to the *SaveChanges* parameter to close without saving changes or prompting the user.  
  
     [!code[Trin_VstcoreWordAutomation#4](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-close-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#4](../VS_officedev/codesnippet/CSharp/how-to--programmatically-close-documents_3.cs)]  
  
## See Also  
 [How to: Programmatically Open Existing Documents](../VS_officedev/how-to--programmatically-open-existing-documents.md)   
 [How to: Programmatically Save Documents](../VS_officedev/how-to--programmatically-save-documents.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  