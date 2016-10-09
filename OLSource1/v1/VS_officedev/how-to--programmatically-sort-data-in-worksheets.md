---
title: "How to: Programmatically Sort Data in Worksheets"
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
  - "data sorting, worksheets"
  - "data [Office development in Visual Studio], sorting in worksheets"
  - "worksheets, sorting data"
  - "sorting data, in worksheets"
ms.assetid: 2fbc6e63-02ea-4624-8d6f-bed60e06c61e
caps.latest.revision: 56
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
# How to: Programmatically Sort Data in Worksheets
  You can sort data that is contained in worksheet ranges and lists at run time. The following code sorts a multi-column range named `Fruits` by the data in the first column, and then by the data in the second column.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Sorting Data in a Document-Level Customization  
  
#### To sort data in a NamedRange control  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.NamedRange.Sort*> method of the \<xref:Microsoft.Office.Tools.Excel.NamedRange> control. The following example requires a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control named `Fruits` on a worksheet. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
     [!code[Trin_VstcoreExcelAutomation#78](../VS_officedev/codesnippet/CSharp/how-to--programmatically-sort-data-in-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#78](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-sort-data-in-worksheets_1.vb)]  
  
 Place the following code in Sheet1.vb or Sheet1.cs to sort data in a \<xref:Microsoft.Office.Tools.Excel.ListObject> control. The code assumes that you have a \<xref:Microsoft.Office.Tools.Excel.ListObject> control named `fruitList` in a worksheet named `Sheet1`.  
  
#### To sort data in a ListObject control  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel.Range.Sort*> method of the \<xref:Microsoft.Office.Tools.Excel.ListObject.Range*> property of the \<xref:Microsoft.Office.Tools.Excel.ListObject> host control.  
  
     [!code[Trin_VstcoreExcelAutomation#79](../VS_officedev/codesnippet/CSharp/how-to--programmatically-sort-data-in-worksheets_2.cs)]
[!code[Trin_VstcoreExcelAutomation#79](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-sort-data-in-worksheets_2.vb)]  
  
## Sorting Data in a VSTO Add-in  
  
#### To sort data in a native range  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel.Range.Sort*> method of the native Excel \<xref:Microsoft.Office.Interop.Excel.Range> control. The following example requires a native Excel control named `Fruits` on a worksheet.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#23](../VS_officedev/codesnippet/CSharp/how-to--programmatically-sort-data-in-worksheets_3.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#23](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-sort-data-in-worksheets_3.vb)]  
  
#### To sort data in a ListObject control  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel.Range.Sort*> method of the \<xref:Microsoft.Office.Tools.Excel.ListObject.Range*> property of the native Excel \<xref:Microsoft.Office.Interop.Excel.ListObject> control. The following example assumes that you have a native Excel \<xref:Microsoft.Office.Interop.Excel.ListObject> control named `fruitList` in the active worksheet.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#24](../VS_officedev/codesnippet/CSharp/how-to--programmatically-sort-data-in-worksheets_4.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#24](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-sort-data-in-worksheets_4.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Automatically Fill Ranges with Incrementally Changing Data](../VS_officedev/how-to--programmatically-automatically-fill-ranges-with-incrementally-changing-data.md)   
 [How to: Programmatically Refer to Worksheet Ranges in Code](../VS_officedev/how-to--programmatically-refer-to-worksheet-ranges-in-code.md)   
 [How to: Programmatically Apply Styles to Ranges in Workbooks](../VS_officedev/how-to--programmatically-apply-styles-to-ranges-in-workbooks.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [ListObject Control](../VS_officedev/listobject-control.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  