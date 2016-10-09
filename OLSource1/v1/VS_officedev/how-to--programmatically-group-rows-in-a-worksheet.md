---
title: "How to: Programmatically Group Rows in a Worksheet"
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
  - "worksheets, creating groups"
  - "groups, creating in worksheets"
  - "ranges, creating groups"
  - "worksheets, clearing groups"
  - "groups"
  - "groups [Office development in Visual Studio], clearing in worksheets"
  - "worksheets, ungrouping rows and columns"
  - "rows [Office development in Visual Studio], ungrouping"
  - "columns [Office development in Visual Studio], ungrouping"
ms.assetid: 48037dca-35a2-4df2-918b-6a9f568fae91
caps.latest.revision: 46
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
# How to: Programmatically Group Rows in a Worksheet
  You can group one or more whole rows. To create a group in a worksheet, use a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Using a NamedRange Control  
 If you add a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control to a document-level project at design time, you can use the control to programmatically create a group. The following example assumes that there are three \<xref:Microsoft.Office.Tools.Excel.NamedRange> controls on the same worksheet: `data2001`, `data2002`, and `dataAll`. Each named range refers to a whole row in the worksheet.  
  
#### To create a group of NamedRange controls on a worksheet  
  
1.  Group three named ranges by calling the \<xref:Microsoft.Office.Tools.Excel.NamedRange.Group*> method of each range. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
     [!code[Trin_VstcoreExcelAutomation#32](../VS_officedev/codesnippet/CSharp/how-to--programmatically-group-rows-in-a-worksheet_1.cs)]
[!code[Trin_VstcoreExcelAutomation#32](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-group-rows-in-a-worksheet_1.vb)]  
  
    > [!NOTE]  
    >  To ungroup rows, call the \<xref:Microsoft.Office.Tools.Excel.NamedRange.Ungroup*> method.  
  
## Using Native Excel Ranges  
 The code assumes that you have three Excel ranges named `data2001`, `data2002`, and `dataAll` on a worksheet.  
  
#### To create a group of Excel ranges in a worksheet  
  
1.  Group three named ranges by calling the \<xref:Microsoft.Office.Interop.Excel.Range.Group*> method of each range. The following example assumes that there are three \<xref:Microsoft.Office.Interop.Excel.Range> controls named `data2001`, `data2002`, and `dataAll` on the same worksheet. Each named range refers to a whole row in the worksheet.  
  
     [!code[Trin_VstcoreExcelAutomation#33](../VS_officedev/codesnippet/CSharp/how-to--programmatically-group-rows-in-a-worksheet_2.cs)]
[!code[Trin_VstcoreExcelAutomation#33](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-group-rows-in-a-worksheet_2.vb)]  
  
    > [!NOTE]  
    >  To ungroup rows, call the \<xref:Microsoft.Office.Interop.Excel.Range.Ungroup*> method.  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [How to: Add NamedRange Controls to Worksheets](../VS_officedev/how-to--add-namedrange-controls-to-worksheets.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  