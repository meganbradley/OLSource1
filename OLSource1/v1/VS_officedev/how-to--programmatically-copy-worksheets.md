---
title: "How to: Programmatically Copy Worksheets"
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
  - "worksheets, copying"
  - "Excel [Office development in Visual Studio], copying worksheets"
ms.assetid: e49e03f5-7b2f-416b-b5fe-0965336c47e1
caps.latest.revision: 31
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
# How to: Programmatically Copy Worksheets
  You can create a copy of a worksheet, and insert that worksheet before or after an existing worksheet in the workbook. If you do not specify where to insert the worksheet, Excel creates a new workbook to contain the new worksheet.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
> [!NOTE]  
>  Whether you copy the worksheet programmatically, or the end user copies the worksheet manually, there is no code behind the new worksheet and controls on the new worksheet do not function. This is because the newly copied worksheet is a \<xref:Microsoft.Office.Interop.Excel.Worksheet> object and not a \<xref:Microsoft.Office.Tools.Excel.Worksheet> host item. Windows Forms controls and host controls can only be added to host items. For more information, see [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md).  
  
### To add a copied worksheet to a workbook in a document-level customization  
  
1.  Use the \<xref:Microsoft.Office.Interop.Excel.Worksheets.Copy*> method to copy the first worksheet in the current workbook and place the copy after the third sheet.  
  
     [!code[Trin_VstcoreExcelAutomation#16](../VS_officedev/codesnippet/CSharp/how-to--programmatically-copy-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#16](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-copy-worksheets_1.vb)]  
  
### To add a copied worksheet to a workbook in a VSTO Add-in  
  
1.  Use the \<xref:Microsoft.Office.Interop.Excel.Worksheets.Copy*> method to copy the first worksheet in the current workbook and place the copy after the third sheet.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#12](../VS_officedev/codesnippet/CSharp/how-to--programmatically-copy-worksheets_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#12](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-copy-worksheets_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [How to: Programmatically Add New Worksheets to Workbooks](../VS_officedev/how-to--programmatically-add-new-worksheets-to-workbooks.md)   
 [How to: Programmatically Delete Worksheets from Workbooks](../VS_officedev/how-to--programmatically-delete-worksheets-from-workbooks.md)   
 [How to: Programmatically Select Worksheets](../VS_officedev/how-to--programmatically-select-worksheets.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  