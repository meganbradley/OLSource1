---
title: "How to: Programmatically Hide Worksheets"
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
  - "hidden worksheets"
  - "worksheets, hiding"
ms.assetid: 3208f633-137f-47f9-9c9c-2cf8e3c72096
caps.latest.revision: 44
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Programmatically Hide Worksheets
  You can show or hide any worksheet in a workbook. To hide a worksheet, use the worksheet host item or access the worksheet by using the sheets collection of the workbook.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Using the Worksheet Host Item  
 If the worksheet was added at design-time in a document-level customization, use the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Visible*> property to hide the specified worksheet.  
  
#### To hide a worksheet using a worksheet host item  
  
1.  Set the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Visible*> property of the `Sheet1` host item to the \<xref:Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetHidden> enumeration value.  
  
     [!code[Trin_VstcoreExcelAutomation#25](../VS_officedev/codesnippet/CSharp/how-to--programmatically-hide-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#25](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-hide-worksheets_1.vb)]  
  
## Using the Sheets Collection of the Excel Workbook  
 Access worksheets through the Microsoft Office Excel \<xref:Microsoft.Office.Interop.Excel.Sheets> collection in the following cases:  
  
-   You want to hide a worksheet in an VSTO Add-in.  
  
-   The worksheet that you want to hide was created at run time in a document-level customization.  
  
#### To hide a worksheet using the Sheets collection of the Excel workbook  
  
1.  Set the \<xref:Microsoft.Office.Interop.Excel.Worksheets.Visible*> property of the worksheet to the \<xref:Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetHidden> enumeration value.  
  
     [!code[Trin_VstcoreExcelAutomation#26](../VS_officedev/codesnippet/CSharp/how-to--programmatically-hide-worksheets_2.cs)]
[!code[Trin_VstcoreExcelAutomation#26](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-hide-worksheets_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Delete Worksheets from Workbooks](../VS_officedev/how-to--programmatically-delete-worksheets-from-workbooks.md)   
 [How to: Programmatically Move Worksheets Within Workbooks](../VS_officedev/how-to--programmatically-move-worksheets-within-workbooks.md)   
 [How to: Programmatically Protect Worksheets](../VS_officedev/how-to--programmatically-protect-worksheets.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)  
  
  