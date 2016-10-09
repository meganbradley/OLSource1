---
title: "How to: Programmatically Delete Worksheets from Workbooks"
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
  - "workbooks, deleting worksheets"
  - "worksheets, deleting"
ms.assetid: c5ae99f0-806d-4320-a29c-75ad444fb996
caps.latest.revision: 48
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
# How to: Programmatically Delete Worksheets from Workbooks
  You can delete any worksheet in a workbook. To delete a worksheet, use the worksheet host item or access the worksheet by using the sheets collection of the workbook.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Using the Worksheet Host Item  
 If the worksheet was added at design-time in a document-level customization, use the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Delete*> method to delete a specified worksheet. The following code deletes a worksheet from a workbook by referencing the worksheet host item directly.  
  
> [!IMPORTANT]  
>  This code runs only in projects that you create by using any of the following project templates:  
>   
>  -   Excel 2013 Workbook  
> -   Excel 2013 Template  
> -   Excel 2010 Workbook  
> -   Excel 2010 Template  
>   
>  If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Excel** assembly, and then you must use classes from that assembly to open a workbook and delete a worksheet. For more information, see [How to: Target Office Applications Through Primary Interop Assemblies](../VS_officedev/how-to--target-office-applications-through-primary-interop-assemblies.md) and [Excel 2010 Primary Interop Assembly Reference](http://go.microsoft.com/fwlink/?LinkId=189585).  
  
#### To delete a worksheet by using a worksheet host item  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Delete*> method of `Sheet1`.  
  
     [!code[Trin_VstcoreExcelAutomation#17](../VS_officedev/codesnippet/CSharp/how-to--programmatically-delete-worksheets-from-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#17](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-delete-worksheets-from-workbooks_1.vb)]  
  
## Using the Sheets Collection of the Excel Workbook  
 Access worksheets through the Microsoft Office Excel \<xref:Microsoft.Office.Interop.Excel.Sheets> collection in the following cases:  
  
-   You want to delete a worksheet in a VSTO Add-in.  
  
-   The worksheet that you want to delete was created at run time in a document-level customization.  
  
 The following code deletes a worksheet from a workbook by referencing the sheet through the index number of the **Sheets** collection. This code assumes that a new worksheet was created programmatically.  
  
> [!IMPORTANT]  
>  If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Excel** assembly, and then you must use classes from that assembly to open a workbook and delete a worksheet. For more information, see [How to: Target Office Applications Through Primary Interop Assemblies](../VS_officedev/how-to--target-office-applications-through-primary-interop-assemblies.md) and [Excel 2010 Primary Interop Assembly Reference](http://go.microsoft.com/fwlink/?LinkId=189585).  
  
#### To delete a worksheet by using the Sheets collection of the Excel workbook  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Worksheet.Delete*> method of the \<xref:Microsoft.Office.Interop.Excel.Sheets> collection.  
  
     [!code[Trin_VstcoreExcelAutomation#18](../VS_officedev/codesnippet/CSharp/how-to--programmatically-delete-worksheets-from-workbooks_2.cs)]
[!code[Trin_VstcoreExcelAutomation#18](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-delete-worksheets-from-workbooks_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Hide Worksheets](../VS_officedev/how-to--programmatically-hide-worksheets.md)   
 [How to: Programmatically Move Worksheets Within Workbooks](../VS_officedev/how-to--programmatically-move-worksheets-within-workbooks.md)   
 [How to: Programmatically Select Worksheets](../VS_officedev/how-to--programmatically-select-worksheets.md)   
 [How to: Programmatically Add New Worksheets to Workbooks](../VS_officedev/how-to--programmatically-add-new-worksheets-to-workbooks.md)   
 [Worksheet Host Item](../VS_officedev/worksheet-host-item.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  