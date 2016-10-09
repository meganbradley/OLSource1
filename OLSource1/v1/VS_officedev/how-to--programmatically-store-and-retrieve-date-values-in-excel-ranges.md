---
title: "How to: Programmatically Store and Retrieve Date Values in Excel Ranges"
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
  - "Excel [Office development in Visual Studio], retrieving date values from ranges"
  - "ranges, retrieving data values"
  - "dates, retrieving from Excel ranges"
  - "Excel [Office development in Visual Studio], storing date values in ranges"
  - "date values, storing in Excel ranges"
  - "dates, storing in Excel ranges"
  - "ranges, storing date values"
  - "date values"
ms.assetid: e1cdd262-0356-4499-8bc5-e730f74235a2
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
# How to: Programmatically Store and Retrieve Date Values in Excel Ranges
  You can store and retrieve values in a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 If you store a date value that falls on or after 1/1/1900 in a range using Office development tools in Visual Studio, it is stored in OLE Automation (OA) format. You must use the \<xref:System.DateTime.FromOADate*> method to retrieve the value of OLE Automation (OA) dates. If the date is earlier than 1/1/1900, it is stored as a string.  
  
> [!NOTE]  
>  Excel dates differ from OLE Automation dates for the first two months of 1900. There are also differences if the **1904 date system** option is checked. The code examples below do not address these differences.  
  
## Using a NamedRange Control  
  
-   This example is for document-level customizations. The following code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
#### To store a date value in a named range  
  
1.  Create a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control at cell **A1**.  
  
     [!code[Trin_VstcoreExcelAutomation#50](../VS_officedev/codesnippet/CSharp/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_1.cs)]
[!code[Trin_VstcoreExcelAutomation#50](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_1.vb)]  
  
2.  Set today's date as the value for `NamedRange1`.  
  
     [!code[Trin_VstcoreExcelAutomation#51](../VS_officedev/codesnippet/CSharp/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_2.cs)]
[!code[Trin_VstcoreExcelAutomation#51](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_2.vb)]  
  
#### To retrieve a date value from a named range  
  
1.  Retrieve the date value from `NamedRange1`.  
  
     [!code[Trin_VstcoreExcelAutomation#52](../VS_officedev/codesnippet/CSharp/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_3.cs)]
[!code[Trin_VstcoreExcelAutomation#52](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_3.vb)]  
  
## Using Native Excel Ranges  
  
#### To store a date value in a native Excel range object  
  
1.  Create a \<xref:Microsoft.Office.Interop.Excel.Range> that represents cell **A1**.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#25](../VS_officedev/codesnippet/CSharp/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_4.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#25](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_4.vb)]  
  
2.  Set today's date as the value for `rng`.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#26](../VS_officedev/codesnippet/CSharp/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_5.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#26](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_5.vb)]  
  
#### To retrieve a date value from a native Excel range object  
  
1.  Retrieve the date value from `rng`.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#27](../VS_officedev/codesnippet/CSharp/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_6.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#27](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-store-and-retrieve-date-values-in-excel-ranges_6.vb)]  
  
## See Also  
 [Working with Ranges](../VS_officedev/working-with-ranges.md)   
 [Excel Object Model Overview](../VS_officedev/excel-object-model-overview.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [How to: Programmatically Refer to Worksheet Ranges in Code](../VS_officedev/how-to--programmatically-refer-to-worksheet-ranges-in-code.md)   
 [How to: Add NamedRange Controls to Worksheets](../VS_officedev/how-to--add-namedrange-controls-to-worksheets.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  