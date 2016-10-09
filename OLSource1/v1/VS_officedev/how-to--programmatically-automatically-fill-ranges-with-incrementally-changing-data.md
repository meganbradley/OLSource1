---
title: "How to: Programmatically Automatically Fill Ranges with Incrementally Changing Data"
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
  - "Autofill method [Excel]"
  - "filling ranges automatically"
  - "ranges, automatically filling"
  - "workbooks, filling ranges"
ms.assetid: 27639d55-8ab5-483c-8907-2ea50dfd2188
caps.latest.revision: 40
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
# How to: Programmatically Automatically Fill Ranges with Incrementally Changing Data
  The \<xref:Microsoft.Office.Interop.Excel.Range.AutoFill*> method of the \<xref:Microsoft.Office.Interop.Excel.Range> object enables you to fill a range in a worksheet with values automatically. Most often, the \<xref:Microsoft.Office.Interop.Excel.Range.AutoFill*> method is used to store incrementally increasing or decreasing values in a range. You can specify the behavior by supplying an optional constant from the \<xref:Microsoft.Office.Interop.Excel.XlAutoFillType> enumeration.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 You must specify two ranges when using \<xref:Microsoft.Office.Interop.Excel.Range.AutoFill*>:  
  
-   The range that calls the \<xref:Microsoft.Office.Interop.Excel.Range.AutoFill*> method, which specifies the starting point of the fill and contains an initial value.  
  
-   The range that you want to fill, passed as a parameter to the \<xref:Microsoft.Office.Interop.Excel.Range.AutoFill*> method. This destination range must include the range that contains the initial value.  
  
    > [!NOTE]  
    >  You cannot pass a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control in place of the \<xref:Microsoft.Office.Interop.Excel.Range>. For more information, see [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md).  
  
## Example  
 [!code[Trin_VstcoreExcelAutomation#49](../VS_officedev/codesnippet/CSharp/how-to--programmatically-automatically-fill-ranges-with-incrementally-changing-data_1.cs)]
[!code[Trin_VstcoreExcelAutomation#49](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-automatically-fill-ranges-with-incrementally-changing-data_1.vb)]  
  
## Compiling the Code  
 The first cell of the range that you want to fill must contain an initial value.  
  
 The example requires that you fill three regions:  
  
-   Column B is to include five weekdays. For the initial value, type **Monday** in cell B1.  
  
-   Column C is to include five months. For the initial value, type **January** in cell C1.  
  
-   Column D is to include a series of numbers, incrementing by two for each row. For the initial values, type **4** in cell D1 and **6** in cell D2.  
  
## See Also  
 [Working with Ranges](../VS_officedev/working-with-ranges.md)   
 [How to: Programmatically Refer to Worksheet Ranges in Code](../VS_officedev/how-to--programmatically-refer-to-worksheet-ranges-in-code.md)   
 [How to: Programmatically Apply Styles to Ranges in Workbooks](../VS_officedev/how-to--programmatically-apply-styles-to-ranges-in-workbooks.md)   
 [How to: Programmatically Run Excel Calculations Programmatically](../VS_officedev/how-to--programmatically-run-excel-calculations-programmatically.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  