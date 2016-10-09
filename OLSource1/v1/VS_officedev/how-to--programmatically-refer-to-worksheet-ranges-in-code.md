---
title: "How to: Programmatically Refer to Worksheet Ranges in Code"
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
  - "ranges, referring to"
  - "worksheets, referring to ranges"
  - "referring to worksheet ranges"
  - "Excel [Office development in Visual Studio], referring to worksheet ranges"
ms.assetid: 113633b8-426a-4d02-b6b8-d459d1f110ea
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
# How to: Programmatically Refer to Worksheet Ranges in Code
  You use a similar process to refer to the contents of a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Using a NamedRange Control  
 The following example adds a \<xref:Microsoft.Office.Tools.Excel.NamedRange> to a worksheet and then adds text to the cell in the range.  
  
#### To refer to a NamedRange control  
  
1.  Assign a string to the \<xref:Microsoft.Office.Tools.Excel.NamedRange.Value2*> property of the \<xref:Microsoft.Office.Tools.Excel.NamedRange> control. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
     [!code[Trin_VstcoreExcelAutomation#46](../VS_officedev/codesnippet/CSharp/how-to--programmatically-refer-to-worksheet-ranges-in-code_1.cs)]
[!code[Trin_VstcoreExcelAutomation#46](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-refer-to-worksheet-ranges-in-code_1.vb)]  
  
## Using Native Excel Ranges  
 The following example adds a native Excel range to a worksheet and then adds text to the cell in the range.  
  
#### To refer to a native range object  
  
1.  Assign a string to the \<xref:Microsoft.Office.Interop.Excel.Range.Value2*> property of the range.  
  
     [!code[Trin_VstcoreExcelAutomation#47](../VS_officedev/codesnippet/CSharp/how-to--programmatically-refer-to-worksheet-ranges-in-code_2.cs)]
[!code[Trin_VstcoreExcelAutomation#47](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-refer-to-worksheet-ranges-in-code_2.vb)]  
  
## See Also  
 [Working with Ranges](../VS_officedev/working-with-ranges.md)   
 [How to: Programmatically Check Spelling in Worksheets](../VS_officedev/how-to--programmatically-check-spelling-in-worksheets.md)   
 [How to: Programmatically Apply Styles to Ranges in Workbooks](../VS_officedev/how-to--programmatically-apply-styles-to-ranges-in-workbooks.md)   
 [How to: Programmatically Automatically Fill Ranges with Incrementally Changing Data](../VS_officedev/how-to--programmatically-automatically-fill-ranges-with-incrementally-changing-data.md)   
 [How to: Programmatically Search for Text in Worksheet Ranges](../VS_officedev/how-to--programmatically-search-for-text-in-worksheet-ranges.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  