---
title: "How to: Programmatically Add and Delete Worksheet Comments"
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
  - "ranges, comments"
  - "worksheets, comments"
  - "comments, worksheets"
ms.assetid: 3408ce22-a7b7-4e2b-bfc1-dc24d679ee73
caps.latest.revision: 53
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
# How to: Programmatically Add and Delete Worksheet Comments
  You can programmatically add and delete comments in Microsoft Office Excel worksheets. Comments can be added only to single cells, not to multi-cell ranges.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Adding and Deleting a Comment in a Document-Level Project  
 The following examples assume that there is a single-cell \<xref:Microsoft.Office.Tools.Excel.NamedRange> control named `dateComment` on a worksheet named `Sheet1`.  
  
#### To add a new comment to a named range  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.NamedRange.AddComment*> method of the \<xref:Microsoft.Office.Tools.Excel.NamedRange> control and supply the comment text. This code must be placed in the `Sheet1` class.  
  
     [!code[Trin_VstcoreExcelAutomation#30](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-and-delete-worksheet-comments_1.cs)]
[!code[Trin_VstcoreExcelAutomation#30](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-and-delete-worksheet-comments_1.vb)]  
  
#### To delete a comment from a named range  
  
1.  Verify that a comment exists on the range and delete it. This code must be placed in the `Sheet1` class.  
  
     [!code[Trin_VstcoreExcelAutomation#29](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-and-delete-worksheet-comments_2.cs)]
[!code[Trin_VstcoreExcelAutomation#29](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-and-delete-worksheet-comments_2.vb)]  
  
## Adding and Deleting a Comment in an VSTO Add-in Project  
 The following examples assume that there is a single-cell \<xref:Microsoft.Office.Interop.Excel.Range> named `dateComment` on the active worksheet.  
  
#### To add a new comment to an Excel range  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel.Range.AddComment*> method of the \<xref:Microsoft.Office.Interop.Excel.Range> and supply the comment text.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#20](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-and-delete-worksheet-comments_3.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#20](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-and-delete-worksheet-comments_3.vb)]  
  
#### To delete a comment from an Excel range  
  
1.  Verify that a comment exists on the range and delete it.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#19](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-and-delete-worksheet-comments_4.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#19](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-and-delete-worksheet-comments_4.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Display Worksheet Comments](../VS_officedev/how-to--programmatically-display-worksheet-comments.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)  
  
  