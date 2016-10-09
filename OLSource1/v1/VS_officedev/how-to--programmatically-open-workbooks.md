---
title: "How to: Programmatically Open Workbooks"
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
  - "workbooks, opening"
  - "Excel [Office development in Visual Studio], opening workbooks"
ms.assetid: 06c0ac87-a2c6-4cc1-87be-39be0cb81c71
caps.latest.revision: 36
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
# How to: Programmatically Open Workbooks
  The \<xref:Microsoft.Office.Interop.Excel.Workbooks> collection in Microsoft Office Excel makes it possible to work with all open workbooks and to open workbooks.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
### To open an existing workbook  
  
1.  Use the \<xref:Microsoft.Office.Interop.Excel.Workbooks.Open*> method of the \<xref:Microsoft.Office.Interop.Excel.Workbooks> collection, passing in the path to the workbook.  
  
     [!code[Trin_VstcoreExcelAutomation#2](../VS_officedev/codesnippet/CSharp/how-to--programmatically-open-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#2](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-open-workbooks_1.vb)]  
  
## Compiling the Code  
 This code example requires the following:  
  
-   A workbook named `YourWorkbook.xls` must exist in a directory named `Test` on drive C.  
  
## See Also  
 [Working with Workbooks](../VS_officedev/working-with-workbooks.md)   
 [How to: Programmatically Open Text Files as Workbooks](../VS_officedev/how-to--programmatically-open-text-files-as-workbooks.md)   
 [How to: Programmatically Create New Workbooks](../VS_officedev/how-to--programmatically-create-new-workbooks.md)   
 [How to: Programmatically Save Workbooks](../VS_officedev/how-to--programmatically-save-workbooks.md)   
 [How to: Programmatically Close Workbooks](../VS_officedev/how-to--programmatically-close-workbooks.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)  
  
  