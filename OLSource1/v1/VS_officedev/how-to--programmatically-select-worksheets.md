---
title: "How to: Programmatically Select Worksheets"
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
  - "worksheets, selecting"
  - "Excel projects, selecting worksheets"
ms.assetid: 9e7cdb11-e825-4c9f-abcd-d46fd20dc5e0
caps.latest.revision: 44
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
# How to: Programmatically Select Worksheets
  The \<xref:Microsoft.Office.Tools.Excel.Worksheet.Select*> method selects the specified object, which moves the user's selection to the new object. Use the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Activate*> method if you want to bring focus to the object without changing the user's selection.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 If you want to select an existing worksheet in a VSTO Add-in or if the worksheet was created at run time in a document-level customization, you must access it by using the Excel \<xref:Microsoft.Office.Interop.Excel.Sheets> collection of the Excel workbook; otherwise, you can access the \<xref:Microsoft.Office.Tools.Excel.Worksheet> host item directly.  
  
## Using the Worksheet Host Item  
 In a document-level customization, add the following code to **Sheet1.vb** or **Sheet1.cs**.  
  
#### To select the first worksheet in a workbook using a host item  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Select*> method of `Sheet1`.  
  
     [!code[Trin_VstcoreExcelAutomation#19](../VS_officedev/codesnippet/CSharp/how-to--programmatically-select-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#19](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-select-worksheets_1.vb)]  
  
## Using the Sheets Collection of the Excel Workbook  
 Access the worksheet by using the Excel \<xref:Microsoft.Office.Interop.Excel.Sheets> collection.  
  
#### To select the first worksheet in a workbook using the Sheets collection of the Excel workbook  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel.Sheets.Select*> method of the \<xref:Microsoft.Office.Interop.Excel.Sheets> collection to select the first worksheet of the active workbook.  
  
     [!code[Trin_VstcoreExcelAutomation#20](../VS_officedev/codesnippet/CSharp/how-to--programmatically-select-worksheets_2.cs)]
[!code[Trin_VstcoreExcelAutomation#20](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-select-worksheets_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Print Worksheets](../VS_officedev/how-to--programmatically-print-worksheets.md)   
 [How to: Programmatically Delete Worksheets from Workbooks](../VS_officedev/how-to--programmatically-delete-worksheets-from-workbooks.md)   
 [How to: Programmatically Hide Worksheets](../VS_officedev/how-to--programmatically-hide-worksheets.md)   
 [How to: Programmatically Protect Worksheets](../VS_officedev/how-to--programmatically-protect-worksheets.md)   
 [Worksheet Host Item](../VS_officedev/worksheet-host-item.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)  
  
  