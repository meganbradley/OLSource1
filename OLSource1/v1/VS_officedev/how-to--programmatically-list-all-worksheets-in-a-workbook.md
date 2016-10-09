---
title: "How to: Programmatically List All Worksheets in a Workbook"
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
  - "workbooks, listing worksheets"
  - "worksheets, listing"
ms.assetid: 38b63d1d-6047-44e8-b089-c576c6179e4a
caps.latest.revision: 46
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
# How to: Programmatically List All Worksheets in a Workbook
  The \<xref:Microsoft.Office.Interop.Excel.Workbook> class provides a \<xref:Microsoft.Office.Interop.Excel.Worksheets> object. This object contains a collection of all the \<xref:Microsoft.Office.Interop.Excel.Worksheet> objects in the workbook.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
### To list all existing worksheets in a workbook in a document-level customization  
  
1.  Iterate through the \<xref:Microsoft.Office.Interop.Excel.Worksheets> collection and send the name of each sheet to a cell offset from a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control.  
  
     [!code[Trin_VstcoreExcelAutomation#21](../VS_officedev/codesnippet/CSharp/how-to--programmatically-list-all-worksheets-in-a-workbook_1.cs)]
[!code[Trin_VstcoreExcelAutomation#21](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-list-all-worksheets-in-a-workbook_1.vb)]  
  
### To list all existing worksheets in a workbook in a VSTO Add-in  
  
1.  Iterate through the \<xref:Microsoft.Office.Interop.Excel.Worksheets> collection and send the name of each sheet to a cell offset from a \<xref:Microsoft.Office.Interop.Excel.Range> object.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#13](../VS_officedev/codesnippet/CSharp/how-to--programmatically-list-all-worksheets-in-a-workbook_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#13](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-list-all-worksheets-in-a-workbook_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Add New Worksheets to Workbooks](../VS_officedev/how-to--programmatically-add-new-worksheets-to-workbooks.md)   
 [How to: Programmatically Move Worksheets Within Workbooks](../VS_officedev/how-to--programmatically-move-worksheets-within-workbooks.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)  
  
  