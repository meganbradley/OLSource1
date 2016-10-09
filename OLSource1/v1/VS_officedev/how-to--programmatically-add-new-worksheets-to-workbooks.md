---
title: "How to: Programmatically Add New Worksheets to Workbooks"
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
  - "workbooks, adding worksheets"
  - "workbooks, creating worksheets"
  - "worksheets, creating"
  - "worksheets, adding to workbooks"
ms.assetid: 19f0d815-51b2-406c-9f36-34aa0ec16b4a
caps.latest.revision: 52
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
# How to: Programmatically Add New Worksheets to Workbooks
  You can programmatically create a worksheet and then add the worksheet to the collection of worksheets in the workbook.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
### To add a new worksheet to a workbook in a document-level customization  
  
1.  Use the \<xref:Microsoft.Office.Interop.Excel.Worksheets.Add*> method of the \<xref:Microsoft.Office.Interop.Excel.Sheets> collection.  
  
     [!code[Trin_VstcoreExcelAutomation#15](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-new-worksheets-to-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#15](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-new-worksheets-to-workbooks_1.vb)]  
  
     The new worksheet is a native \<xref:Microsoft.Office.Interop.Excel.Worksheet> object and not a host item. If you want to add a \<xref:Microsoft.Office.Tools.Excel.Worksheet> host item, you should add the worksheet at design time.  
  
### To add a new worksheet to a workbook in a VSTO Add-in  
  
1.  Use the \<xref:Microsoft.Office.Interop.Excel.Worksheets.Add*> method of the \<xref:Microsoft.Office.Interop.Excel.Sheets> collection.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#11](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-new-worksheets-to-workbooks_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#11](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-new-worksheets-to-workbooks_2.vb)]  
  
     The new worksheet is a native \<xref:Microsoft.Office.Interop.Excel.Worksheet> object and not a host item. You can also generate a \<xref:Microsoft.Office.Tools.Excel.Worksheet> host item from the native \<xref:Microsoft.Office.Interop.Excel.Worksheet> object. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [How to: Programmatically Delete Worksheets from Workbooks](../VS_officedev/how-to--programmatically-delete-worksheets-from-workbooks.md)   
 [How to: Programmatically Select Worksheets](../VS_officedev/how-to--programmatically-select-worksheets.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  