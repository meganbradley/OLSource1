---
title: "How to: Programmatically Change Formatting in Worksheet Rows Containing Selected Cells"
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
  - "rows [Office development in Visual Studio]"
  - "formatting [Office development in Visual Studio]"
  - "worksheets, changing formatting"
ms.assetid: c55cd488-98d1-46c6-9715-0e9212d178de
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
# How to: Programmatically Change Formatting in Worksheet Rows Containing Selected Cells
  You can change the font of an entire row that contains a selected cell so that the text is bold.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
### To make the current row bold and the previously bolded row normal  
  
1.  Declare a static variable to keep track of the previously selected row.  
  
     [!code[Trin_VstcoreExcelAutomation#37](../VS_officedev/codesnippet/CSharp/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_1.cs)]
[!code[Trin_VstcoreExcelAutomation#37](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_1.vb)]  
  
2.  Retrieve a reference to the current cell using the \<xref:Microsoft.Office.Interop.Excel._Application.ActiveCell*> property.  
  
     [!code[Trin_VstcoreExcelAutomation#38](../VS_officedev/codesnippet/CSharp/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_2.cs)]
[!code[Trin_VstcoreExcelAutomation#38](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_2.vb)]  
  
3.  Style the current row bold using the \<xref:Microsoft.Office.Interop.Excel.Range.EntireRow*> property of the active cell.  
  
     [!code[Trin_VstcoreExcelAutomation#39](../VS_officedev/codesnippet/CSharp/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_3.cs)]
[!code[Trin_VstcoreExcelAutomation#39](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_3.vb)]  
  
4.  Ensure that the current value of `previousRow` is not 0. A 0 (zero) indicates that this is the first time through this code.  
  
     [!code[Trin_VstcoreExcelAutomation#40](../VS_officedev/codesnippet/CSharp/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_4.cs)]
[!code[Trin_VstcoreExcelAutomation#40](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_4.vb)]  
  
5.  Ensure that the current row is different from the previous row.  
  
     [!code[Trin_VstcoreExcelAutomation#41](../VS_officedev/codesnippet/CSharp/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_5.cs)]
[!code[Trin_VstcoreExcelAutomation#41](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_5.vb)]  
  
6.  Retrieve a reference to a range that represents the row that was previously selected, and set that row to not be bold.  
  
     [!code[Trin_VstcoreExcelAutomation#42](../VS_officedev/codesnippet/CSharp/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_6.cs)]
[!code[Trin_VstcoreExcelAutomation#42](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_6.vb)]  
  
7.  Store the current row so that it can become the previous row on the next pass.  
  
     [!code[Trin_VstcoreExcelAutomation#43](../VS_officedev/codesnippet/CSharp/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_7.cs)]
[!code[Trin_VstcoreExcelAutomation#43](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_7.vb)]  
  
 The following example shows the complete method.  
  
## Example  
 [!code[Trin_VstcoreExcelAutomation#36](../VS_officedev/codesnippet/CSharp/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_8.cs)]
[!code[Trin_VstcoreExcelAutomation#36](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells_8.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Apply Styles to Ranges in Workbooks](../VS_officedev/how-to--programmatically-apply-styles-to-ranges-in-workbooks.md)   
 [How to: Programmatically Copy Data and Formatting across Worksheets](../VS_officedev/how-to--programmatically-copy-data-and-formatting-across-worksheets.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  