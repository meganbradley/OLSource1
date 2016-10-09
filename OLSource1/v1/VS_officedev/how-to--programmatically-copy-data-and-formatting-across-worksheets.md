---
title: "How to: Programmatically Copy Data and Formatting across Worksheets"
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
  - "worksheets, copying data"
  - "formatting [Office development in Visual Studio]"
  - "data [Office development in Visual Studio], copying across worksheets"
  - "copying data, Office development in Visual Studio"
ms.assetid: eed7dbaf-bdb5-4330-ba2e-5f3d50817eca
caps.latest.revision: 37
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
# How to: Programmatically Copy Data and Formatting across Worksheets
  You can copy data from a range on one sheet to all the other sheets in a workbook by using the \<xref:Microsoft.Office.Interop.Excel.Worksheets.FillAcrossSheets*> method. Specify a range, and whether you want to copy data, formatting, or both.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Example  
 [!code[Trin_VstcoreExcelAutomation#44](../VS_officedev/codesnippet/CSharp/how-to--programmatically-copy-data-and-formatting-across-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#44](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-copy-data-and-formatting-across-worksheets_1.vb)]  
  
## Compiling the Code  
 This example requires a range named `rangeData` in a worksheet.  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Add New Worksheets to Workbooks](../VS_officedev/how-to--programmatically-add-new-worksheets-to-workbooks.md)   
 [How to: Programmatically Change Formatting in Worksheet Rows Containing Selected Cells](../VS_officedev/how-to--programmatically-change-formatting-in-worksheet-rows-containing-selected-cells.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  