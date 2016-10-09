---
title: "How to: Programmatically Save Workbooks"
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
  - "workbooks, saving in XML format"
  - "workbooks, saving"
  - "workbooks, saving backup copies"
ms.assetid: 991ccf9b-5213-4094-9030-284ec167bdcc
caps.latest.revision: 50
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
# How to: Programmatically Save Workbooks
  There are several ways to save a workbook. You can save a workbook without changing the path. If the workbook has not been saved before, you should save the workbook by specifying a path. Without an explicit path, Microsoft Office Excel saves the file in the current folder with the name it was given when it was created. You can also save a copy of the workbook without modifying the open workbook in memory.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Saving a Workbook Without Changing the Path  
  
#### To save a workbook associated with a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Workbook.Save*> method of the ThisWorkbook class.  
  
     [!code[Trin_VstcoreExcelAutomation#4](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#4](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-workbooks_1.vb)]  
  
#### To save the active workbook in a VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Workbook.Save*> method to save the active workbook. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#3](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-workbooks_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#3](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-workbooks_2.vb)]  
  
## Saving a Workbook with a New Path  
 You can save the specified workbook to a new location or with a new name, optionally specifying a file format, a password, an access mode, and more.  
  
> [!NOTE]  
>  You might want to set the \<xref:Microsoft.Office.Interop.Excel._Application.DisplayAlerts*> property to **False** before saving the workbook with a new path because saving in some formats requires interaction. Setting this property to **False** causes Excel to use all defaults.  
  
#### To save a workbook associated with a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Workbook.SaveAs*> method of the `ThisWorkbook` class. To use the following code example, run it in the `ThisWorkbook` class.  
  
     [!code[Trin_VstcoreExcelAutomation#5](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-workbooks_3.cs)]
[!code[Trin_VstcoreExcelAutomation#5](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-workbooks_3.vb)]  
  
#### To save the active workbook in a VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Workbook.SaveAs*> method to save the active workbook to a new path. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#4](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-workbooks_4.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#4](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-workbooks_4.vb)]  
  
## Saving a Copy of the Workbook  
 You can save a copy of the workbook to a file without modifying the open workbook in memory. This is useful when you want to create a backup copy without modifying the location of the workbook.  
  
#### To save a workbook associated with a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Workbook.SaveCopyAs*> method of the `ThisWorkbook` class. To use the following code example, run it in the `ThisWorkbook` class.  
  
     [!code[Trin_VstcoreExcelAutomation#6](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-workbooks_5.cs)]
[!code[Trin_VstcoreExcelAutomation#6](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-workbooks_5.vb)]  
  
#### To save the active workbook in a VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Workbook.SaveCopyAs*> method to save a copy of the active workbook. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#5](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-workbooks_6.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#5](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-workbooks_6.vb)]  
  
## Robust Programming  
 Interactively canceling any of the methods that save or copy the workbook raises a run-time error in your code. For example, if your procedure calls the \<xref:Microsoft.Office.Tools.Excel.Workbook.SaveAs*> method but does not disable prompts from Excel, and your user clicks **Cancel** when prompted, Excel raises a run-time error.  
  
## See Also  
 [Working with Workbooks](../VS_officedev/working-with-workbooks.md)   
 [Workbook Host Item](../VS_officedev/workbook-host-item.md)   
 [How to: Programmatically Close Workbooks](../VS_officedev/how-to--programmatically-close-workbooks.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)  
  
  