---
title: "How to: Programmatically Apply Color to Excel Ranges"
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
  - "formatting [Office development in Visual Studio]"
  - "color, Excel ranges"
  - "ranges, applying color"
ms.assetid: a9c40229-5308-459a-9216-7e13d82c7cb5
caps.latest.revision: 47
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
# How to: Programmatically Apply Color to Excel Ranges
  To apply a color to text within a range of cells, use a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Using a NamedRange Control  
 This example is for document-level customizations.  
  
#### To apply color to a NamedRange control  
  
1.  Create a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control at cell A1.  
  
     [!code[Trin_VstcoreExcelAutomation#65](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-color-to-excel-ranges_1.cs)]
[!code[Trin_VstcoreExcelAutomation#65](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-color-to-excel-ranges_1.vb)]  
  
2.  Set the color of the text in the \<xref:Microsoft.Office.Tools.Excel.NamedRange> control.  
  
     [!code[Trin_VstcoreExcelAutomation#66](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-color-to-excel-ranges_2.cs)]
[!code[Trin_VstcoreExcelAutomation#66](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-color-to-excel-ranges_2.vb)]  
  
## Using Native Excel Ranges  
  
#### To apply color to a native Excel range object  
  
1.  Create a range at cell A1 and then set the color of the text.  
  
     [!code[Trin_VstcoreExcelAutomation#67](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-color-to-excel-ranges_3.cs)]
[!code[Trin_VstcoreExcelAutomation#67](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-color-to-excel-ranges_3.vb)]  
  
## See Also  
 [Working with Ranges](../VS_officedev/working-with-ranges.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [How to: Programmatically Apply Styles to Ranges in Workbooks](../VS_officedev/how-to--programmatically-apply-styles-to-ranges-in-workbooks.md)   
 [How to: Programmatically Refer to Worksheet Ranges in Code](../VS_officedev/how-to--programmatically-refer-to-worksheet-ranges-in-code.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  