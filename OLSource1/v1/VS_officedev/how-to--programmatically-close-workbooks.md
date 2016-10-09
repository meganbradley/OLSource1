---
title: "How to: Programmatically Close Workbooks"
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
  - "workbooks, closing"
  - "Excel [Office development in Visual Studio], closing workbooks"
ms.assetid: 50709caf-2ad8-4843-987c-9a34c8c1e4fe
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
# How to: Programmatically Close Workbooks
  You can close the active workbook or you can specify a workbook to close.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Closing the Active Workbook  
 There are two procedures for closing the active workbook: one for document-level customizations and one for VSTO Add-ins.  
  
#### To close the active workbook in a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Workbook.Close*> method to close the workbook associated with the customization. To use the following code example, run it in the `Sheet1` class in a document-level project for Excel.  
  
     [!code[Trin_VstcoreExcelAutomation#3](../VS_officedev/codesnippet/CSharp/how-to--programmatically-close-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#3](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-close-workbooks_1.vb)]  
  
#### To close the active workbook in a VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Workbook.Close*> method to close the active workbook. To use the following code example, run it in the `ThisAddIn` class in an VSTO Add-in project for Excel.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#1](../VS_officedev/codesnippet/CSharp/how-to--programmatically-close-workbooks_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#1](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-close-workbooks_2.vb)]  
  
## Closing a Workbook That You Specify By Name  
 The way that you close a workbook that you specify by name is the same for VSTO Add-ins and document-level customizations.  
  
#### To close a workbook that you specify by name  
  
1.  Specify the workbook name as an argument to the \<xref:Microsoft.Office.Interop.Excel.Workbooks> collection. The following code example assumes that a workbook named **NewWorkbook** is open in Excel.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#2](../VS_officedev/codesnippet/CSharp/how-to--programmatically-close-workbooks_3.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#2](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-close-workbooks_3.vb)]  
  
## See Also  
 [Working with Workbooks](../VS_officedev/working-with-workbooks.md)   
 [How to: Programmatically Save Workbooks](../VS_officedev/how-to--programmatically-save-workbooks.md)   
 [How to: Programmatically Open Workbooks](../VS_officedev/how-to--programmatically-open-workbooks.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)  
  
  