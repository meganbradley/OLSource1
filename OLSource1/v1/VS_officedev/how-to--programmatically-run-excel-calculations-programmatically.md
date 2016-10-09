---
title: "How to: Programmatically Run Excel Calculations Programmatically"
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
  - "ranges, running calculations"
  - "calculations, running in Excel"
  - "Excel [Office development in Visual Studio], running calculations programmatically"
  - "workbooks, running calculations"
ms.assetid: 0bf30d93-8620-43ad-bfb8-f45bf3b5461f
caps.latest.revision: 38
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
# How to: Programmatically Run Excel Calculations Programmatically
  You use a similar process to run calculations in a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Running Calculations in a NamedRange Control  
 The following example creates a \<xref:Microsoft.Office.Tools.Excel.NamedRange> at cell A1 and then calculates the cell. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
#### To run calculations in a NamedRange control  
  
1.  Create the named range.  
  
     [!code[Trin_VstcoreExcelAutomation#75](../VS_officedev/codesnippet/CSharp/how-to--programmatically-run-excel-calculations-programmatically_1.cs)]
[!code[Trin_VstcoreExcelAutomation#75](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-run-excel-calculations-programmatically_1.vb)]  
  
2.  Call the \<xref:Microsoft.Office.Tools.Excel.NamedRange.Calculate*> method of the specified range.  
  
     [!code[Trin_VstcoreExcelAutomation#76](../VS_officedev/codesnippet/CSharp/how-to--programmatically-run-excel-calculations-programmatically_2.cs)]
[!code[Trin_VstcoreExcelAutomation#76](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-run-excel-calculations-programmatically_2.vb)]  
  
## Running Calculations in a Native Excel Range  
  
#### To run calculations in a native Excel Range  
  
1.  Create the named range.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#30](../VS_officedev/codesnippet/CSharp/how-to--programmatically-run-excel-calculations-programmatically_3.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#30](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-run-excel-calculations-programmatically_3.vb)]  
  
2.  Call the \<xref:Microsoft.Office.Interop.Excel.Range.Calculate*> method of the specified range.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#31](../VS_officedev/codesnippet/CSharp/how-to--programmatically-run-excel-calculations-programmatically_4.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#31](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-run-excel-calculations-programmatically_4.vb)]  
  
## See Also  
 [Working with Ranges](../VS_officedev/working-with-ranges.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  