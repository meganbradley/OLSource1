---
title: "How to: Programmatically Display a String in a Worksheet Cell"
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
  - "text [Office development in Visual Studio], adding to worksheets"
  - "worksheets, displaying text in cells"
ms.assetid: b19870ad-e132-49fd-994e-0a91710fa4c9
caps.latest.revision: 45
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
# How to: Programmatically Display a String in a Worksheet Cell
  This example demonstrates how to display text in a cell programmatically. To display text in cell, use either a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Using a NamedRange Control  
 This example uses a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control named `message`. The control must be added to a document-level customization at design time. The following code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
#### To display text in a NamedRange control  
  
1.  Set the value of the \<xref:Microsoft.Office.Tools.Excel.NamedRange> control to **Hello World**.  
  
     [!code[Trin_VstcoreExcelAutomation#68](../VS_officedev/codesnippet/CSharp/how-to--programmatically-display-a-string-in-a-worksheet-cell_1.cs)]
[!code[Trin_VstcoreExcelAutomation#68](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-display-a-string-in-a-worksheet-cell_1.vb)]  
  
## Using a Native Excel Range  
 The following code creates a new range programmatically and then assigns a value to it.  
  
#### To display text in an Excel range  
  
1.  Retrieve the range at cell **A1** on `Sheet1` and set the value to **Hello World**.  
  
     [!code[Trin_VstcoreExcelAutomation#69](../VS_officedev/codesnippet/CSharp/how-to--programmatically-display-a-string-in-a-worksheet-cell_2.cs)]
[!code[Trin_VstcoreExcelAutomation#69](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-display-a-string-in-a-worksheet-cell_2.vb)]  
  
## See Also  
 [Walkthrough: Collecting Data Using a Windows Form](../VS_officedev/walkthrough--collecting-data-using-a-windows-form.md)   
 [Troubleshooting Office Solutions](../VS_officedev/troubleshooting-office-solutions.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  