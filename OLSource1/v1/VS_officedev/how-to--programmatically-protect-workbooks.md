---
title: "How to: Programmatically Protect Workbooks"
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
  - "workbooks, passwords"
  - "documents [Office development in Visual Studio], document protection"
  - "workbooks, unprotecting"
  - "document protection, removing from workbooks"
  - "document protection, adding to workbooks"
  - "workbooks, protecting"
ms.assetid: 553c67b9-e2a4-46b6-878c-5b4b4efa4589
caps.latest.revision: 43
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
# How to: Programmatically Protect Workbooks
  You can protect a Microsoft Office Excel workbook so that users cannot add or delete worksheets, and also unprotect the workbook programmatically. You can optionally specify a password, indicate whether you want the structure protected (so users cannot move sheets around), and indicate whether you want the workbook's windows protected.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 Protecting a workbook does not stop users from editing cells. To protect the data, you must protect the worksheets. For more information, see [How to: Programmatically Protect Worksheets](../VS_officedev/how-to--programmatically-protect-worksheets.md).  
  
 The following code examples use a variable to contain a password that is obtained from the user.  
  
## Protecting a Workbook That Is Part of a Document-Level Customization  
  
#### To protect a workbook  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Workbook.Protect*> method of the workbook and include a password. To use the following code example, run it in the `ThisWorkbook` class, not in a sheet class.  
  
     [!code[Trin_VstcoreExcelAutomation#10](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#10](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-workbooks_1.vb)]  
  
#### To unprotect a workbook  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Workbook.Unprotect*> method, passing a password if it is required. To use the following code example, run it in the `ThisWorkbook` class, not in a sheet class.  
  
     [!code[Trin_VstcoreExcelAutomation#11](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-workbooks_2.cs)]
[!code[Trin_VstcoreExcelAutomation#11](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-workbooks_2.vb)]  
  
## Protecting a Workbook by Using an Application-Level Add-In  
  
#### To protect a workbook  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Workbook.Protect*> method of the workbook and include a password. This code example uses the active workbook. To use this example, run the code from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#6](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-workbooks_3.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#6](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-workbooks_3.vb)]  
  
#### To unprotect a workbook  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Workbook.Unprotect*> method of the active workbook, passing a password if it is required. To use this example, run the code from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#7](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-workbooks_4.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#7](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-workbooks_4.vb)]  
  
## See Also  
 [Working with Workbooks](../VS_officedev/working-with-workbooks.md)   
 [How to: Programmatically Protect Worksheets](../VS_officedev/how-to--programmatically-protect-worksheets.md)   
 [How to: Programmatically Hide Worksheets](../VS_officedev/how-to--programmatically-hide-worksheets.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  