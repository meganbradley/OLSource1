---
title: "How to: Programmatically Check Spelling in Worksheets"
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
  - "spellchecking"
  - "spelling checker, worksheets"
  - "worksheets, checking spelling"
  - "spelling, checking in worksheets"
ms.assetid: 16367c5d-2075-4174-bb87-dfc59f02c84c
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
# How to: Programmatically Check Spelling in Worksheets
  You can programmatically check the spelling of words in a worksheet. The **Spelling** dialog box automatically appears if there are any incorrectly spelled words in the worksheet.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
### To check spelling in a worksheet in a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Worksheet.CheckSpelling*> method of the worksheet.  
  
     [!code[Trin_VstcoreExcelAutomation#45](../VS_officedev/codesnippet/CSharp/how-to--programmatically-check-spelling-in-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#45](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-check-spelling-in-worksheets_1.vb)]  
  
### To check spelling in a worksheet in an VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Worksheet.CheckSpelling*> method of the active worksheet.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#22](../VS_officedev/codesnippet/CSharp/how-to--programmatically-check-spelling-in-worksheets_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#22](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-check-spelling-in-worksheets_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Run Excel Calculations Programmatically](../VS_officedev/how-to--programmatically-run-excel-calculations-programmatically.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  