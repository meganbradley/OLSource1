---
title: "How to: Programmatically Move Worksheets Within Workbooks"
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
  - "worksheets, moving"
  - "workbooks, moving worksheets in"
ms.assetid: a010a633-412e-4299-9587-cacb035842c1
caps.latest.revision: 44
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
# How to: Programmatically Move Worksheets Within Workbooks
  You can programmatically change the position of worksheets relative to other worksheets in a workbook. If you do not specify a location for the moved sheet, Excel creates a new workbook to contain it.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
### To move a worksheet in a document-level customization  
  
1.  Assign the total number of sheets in the workbook to a variable and then move the first worksheet so that it becomes the last one.  
  
     [!code[Trin_VstcoreExcelAutomation#24](../VS_officedev/codesnippet/CSharp/how-to--programmatically-move-worksheets-within-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#24](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-move-worksheets-within-workbooks_1.vb)]  
  
### To move a worksheet in an VSTO Add-in  
  
1.  Assign the total number of sheets in the workbook to a variable and then move the first worksheet so that it becomes the last one.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#16](../VS_officedev/codesnippet/CSharp/how-to--programmatically-move-worksheets-within-workbooks_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#16](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-move-worksheets-within-workbooks_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Hide Worksheets](../VS_officedev/how-to--programmatically-hide-worksheets.md)   
 [How to: Programmatically Delete Worksheets from Workbooks](../VS_officedev/how-to--programmatically-delete-worksheets-from-workbooks.md)   
 [How to: Programmatically Protect Worksheets](../VS_officedev/how-to--programmatically-protect-worksheets.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)  
  
  