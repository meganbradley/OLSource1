---
title: "How to: Programmatically Print Worksheets"
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
  - "printing [Office development in Visual Studio], worksheets"
  - "worksheets, printing"
  - "print preview, worksheets"
ms.assetid: 312bfcd7-0a74-421c-b42e-df71a06b7bdf
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
# How to: Programmatically Print Worksheets
  You can print any worksheet in a workbook.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Printing a Worksheet in a Document-Level Customization  
  
#### To print a worksheet  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Worksheet.PrintOut*> method of `Sheet1`, request two copies, and preview the document before printing.  
  
     [!code[Trin_VstcoreExcelAutomation#22](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#22](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-worksheets_1.vb)]  
  
 The \<xref:Microsoft.Office.Tools.Excel.Worksheet.PrintPreview*> method enables you to display the specified object in the **Print Preview** window. The following code assumes you have a \<xref:Microsoft.Office.Tools.Excel.Worksheet> host item named `Sheet1`.  
  
#### To preview a page before printing  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Worksheet.PrintPreview*> method of the worksheet.  
  
     [!code[Trin_VstcoreExcelAutomation#23](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-worksheets_2.cs)]
[!code[Trin_VstcoreExcelAutomation#23](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-worksheets_2.vb)]  
  
## Printing a Worksheet in a VSTO Add-in  
  
#### To print a worksheet  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Worksheet.PrintOut*> method of the active worksheet, request two copies, and preview the document before printing.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#14](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-worksheets_3.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#14](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-worksheets_3.vb)]  
  
 The \<xref:Microsoft.Office.Interop.Excel._Worksheet.PrintPreview*> method enables you to display the specified object in the **Print Preview** window.  
  
#### To preview a page before printing  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Worksheet.PrintPreview*> method of the active worksheet.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#15](../VS_officedev/codesnippet/CSharp/how-to--programmatically-print-worksheets_4.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#15](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-print-worksheets_4.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Check Spelling in Worksheets](../VS_officedev/how-to--programmatically-check-spelling-in-worksheets.md)   
 [Worksheet Host Item](../VS_officedev/worksheet-host-item.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  