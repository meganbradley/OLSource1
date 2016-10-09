---
title: "How to: Programmatically Display Worksheet Comments"
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
  - "worksheets, comments"
  - "comments, worksheets"
ms.assetid: f5ce5e7f-bae4-40b7-951c-0f15b140aaf2
caps.latest.revision: 43
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
# How to: Programmatically Display Worksheet Comments
  You can programmatically show and hide comments in Microsoft Office Excel worksheets.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
### To display all comments on a worksheet in a document-level customization  
  
1.  Set the \<xref:Microsoft.Office.Interop.Excel.Comment.Visible*> property to **true** if you want to show comments; otherwise **false**. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
     [!code[Trin_VstcoreExcelAutomation#31](../VS_officedev/codesnippet/CSharp/how-to--programmatically-display-worksheet-comments_1.cs)]
[!code[Trin_VstcoreExcelAutomation#31](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-display-worksheet-comments_1.vb)]  
  
### To display all comments on a worksheet in an application-level VSTO Add-in  
  
1.  Set the \<xref:Microsoft.Office.Interop.Excel.Comment.Visible*> property to **true** if you want to show comments; otherwise **false**.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#21](../VS_officedev/codesnippet/CSharp/how-to--programmatically-display-worksheet-comments_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#21](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-display-worksheet-comments_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Add and Delete Worksheet Comments](../VS_officedev/how-to--programmatically-add-and-delete-worksheet-comments.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)  
  
  