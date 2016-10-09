---
title: "How to: Programmatically Display Documents in Print Preview"
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
  - "Word [Office development in Visual Studio], displaying documents in print preview"
  - "documents [Office development in Visual Studio], displaying in print preview"
ms.assetid: 96c7faea-9c5c-42b4-a009-08894a6d15c9
caps.latest.revision: 39
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
# How to: Programmatically Display Documents in Print Preview
  If your solution generates a report, you might want to display the report to the user in Print Preview mode.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Procedures for Document-Level Customizations  
  
#### To display a document in Print Preview by calling the PrintPreview method  
  
1.  Call the \<xref:Microsoft.Office.Tools.Word.Document.PrintPreview*> method of the \<xref:Microsoft.Office.Tools.Word.Document> class. To use this code example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#13](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-display-documents-in-print-preview_1.vb)]
[!code[Trin_VstcoreWordAutomation#13](../VS_officedev/codesnippet/CSharp/how-to--programmatically-display-documents-in-print-preview_1.cs)]  
  
#### To display a document in Print Preview by setting the PrintPreview property  
  
1.  Set the \<xref:Microsoft.Office.Interop.Word._Application.PrintPreview*> property of the \<xref:Microsoft.Office.Interop.Word.Application> object to **true**.  
  
     [!code[Trin_VstcoreWordAutomation#14](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-display-documents-in-print-preview_2.vb)]
[!code[Trin_VstcoreWordAutomation#14](../VS_officedev/codesnippet/CSharp/how-to--programmatically-display-documents-in-print-preview_2.cs)]  
  
## Procedures for VSTO Add-ins  
  
#### To display a document in Print Preview by calling the PrintPreview method  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word._Document.PrintPreview*> method of the \<xref:Microsoft.Office.Interop.Word.Document> that you want to preview. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#13](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-display-documents-in-print-preview_3.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#13](../VS_officedev/codesnippet/CSharp/how-to--programmatically-display-documents-in-print-preview_3.cs)]  
  
#### To display a document in Print Preview by setting the PrintPreview property  
  
1.  Set the \<xref:Microsoft.Office.Interop.Word._Application.PrintPreview*> property of the \<xref:Microsoft.Office.Interop.Word.Application> object to **true**.  
  
     [!code[Trin_VstcoreWordAutomation#14](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-display-documents-in-print-preview_2.vb)]
[!code[Trin_VstcoreWordAutomation#14](../VS_officedev/codesnippet/CSharp/how-to--programmatically-display-documents-in-print-preview_2.cs)]  
  
## See Also  
 [How to: Programmatically Print Documents](../VS_officedev/how-to--programmatically-print-documents.md)   
 [How to: Programmatically Open Existing Documents](../VS_officedev/how-to--programmatically-open-existing-documents.md)   
 [How to: Programmatically Create New Documents](../VS_officedev/how-to--programmatically-create-new-documents.md)  
  
  