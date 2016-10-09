---
title: "How to: Programmatically List Recently Used Workbook Files"
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
  - "workbooks, listing recently used"
  - "RecentFiles property"
  - "Excel [Office development in Visual Studio], recently used files listing"
  - "recent file list, Excel"
ms.assetid: 210a3753-4845-4875-b34a-a30d3a1299b3
caps.latest.revision: 42
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
# How to: Programmatically List Recently Used Workbook Files
  The \<xref:Microsoft.Office.Interop.Excel._Application.RecentFiles*> property returns a collection that contains the names of all the files that appear in the Microsoft Office Excel list of recently used files. The length of the list varies depending on the number of files the user has selected to retain. You can display the results in a range.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
### To list recently used workbooks in a range object  
  
1.  Loop through the list of recent files and display the names in cells relative to a \<xref:Microsoft.Office.Interop.Excel.Range> object.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#9](../VS_officedev/codesnippet/CSharp/how-to--programmatically-list-recently-used-workbook-files_1.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#9](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-list-recently-used-workbook-files_1.vb)]  
  
## See Also  
 [Working with Workbooks](../VS_officedev/working-with-workbooks.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  