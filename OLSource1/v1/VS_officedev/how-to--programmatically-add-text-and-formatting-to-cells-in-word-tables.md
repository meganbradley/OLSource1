---
title: "How to: Programmatically Add Text and Formatting to Cells in Word Tables"
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
  - "cells, adding text and formatting"
  - "text [Office development in Visual Studio], adding to Word tables"
  - "formatting [Office development in Visual Studio]"
  - "tables [Office development in Visual Studio], adding text and formatting"
ms.assetid: 3df6492a-dc9c-43ac-8fc3-0f944edd88b2
caps.latest.revision: 40
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
# How to: Programmatically Add Text and Formatting to Cells in Word Tables
  Each table consists of a collection of cells. Each individual \<xref:Microsoft.Office.Interop.Word.Cell> object represents one cell in the table. You refer to each cell by its location in the table. This example refers to the cell located in the first row and the first column of the table; adds text to the cell; and applies formatting.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To add text and formatting to cells  
  
1.  Refer to the cell by its location in the table, add text to the cell, and apply the formatting.  
  
     The following code example can be used in a document-level customization. To use this example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#97](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-text-and-formatting-to-cells-in-word-tables_1.vb)]
[!code[Trin_VstcoreWordAutomation#97](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-text-and-formatting-to-cells-in-word-tables_1.cs)]  
  
     The following code example can be used in a VSTO Add-in. This example uses the active document. To use the example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#97](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-text-and-formatting-to-cells-in-word-tables_2.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#97](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-text-and-formatting-to-cells-in-word-tables_2.cs)]  
  
## See Also  
 [How to: Programmatically Create Word Tables](../VS_officedev/how-to--programmatically-create-word-tables.md)   
 [How to: Programmatically Add Rows and Columns to Word Tables](../VS_officedev/how-to--programmatically-add-rows-and-columns-to-word-tables.md)   
 [How to: Programmatically Populate Word Tables with Document Properties](../VS_officedev/how-to--programmatically-populate-word-tables-with-document-properties.md)  
  
  