---
title: "How to: Programmatically Add Rows and Columns to Word Tables"
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
  - "rows [Office development in Visual Studio], adding to Word tables"
  - "tables [Office development in Visual Studio], adding rows and columns"
  - "columns [Office development in Visual Studio], adding to Word tables"
ms.assetid: 01a9b6ca-1373-4a6e-b9e6-2225a1321daf
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
# How to: Programmatically Add Rows and Columns to Word Tables
  In a Microsoft Office Word table, the cells are organized into rows and columns. You can use the \<xref:Microsoft.Office.Interop.Word.Rows.Add*> method of the \<xref:Microsoft.Office.Interop.Word.Rows> object to add rows to the table and the \<xref:Microsoft.Office.Interop.Word.Columns.Add*> method of the \<xref:Microsoft.Office.Interop.Word.Columns> object to add columns.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Document-Level Customization Examples  
 The following code examples can be used in a document-level customization. To use these examples, run them from the `ThisDocument` class in your project. These examples assume that the document associated with your customization already has at least one table.  
  
> [!IMPORTANT]  
>  This code runs only in projects that you create by using any of the following project templates:  
>   
>  -   Word 2013 Document  
> -   Word 2013 Template  
> -   Word 2010 Document  
> -   Word 2010 Template  
>   
>  If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Word** assembly, and then you must use classes from that assembly to add rows and columns to tables. For more information, see [How to: Target Office Applications Through Primary Interop Assemblies](../VS_officedev/how-to--target-office-applications-through-primary-interop-assemblies.md) and [Word 2010 Primary Interop Assembly Reference](http://go.microsoft.com/fwlink/?LinkId=189588).  
  
#### To add a row to a table  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Rows.Add*> method to add a row to the table.  
  
     [!code[Trin_VstcoreWordAutomation#95](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-rows-and-columns-to-word-tables_1.vb)]
[!code[Trin_VstcoreWordAutomation#95](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-rows-and-columns-to-word-tables_1.cs)]  
  
#### To add a column to a table  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Columns.Add*> method, and then use the \<xref:Microsoft.Office.Interop.Word.Columns.DistributeWidth*> method to make all the columns the same width.  
  
     [!code[Trin_VstcoreWordAutomation#96](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-rows-and-columns-to-word-tables_2.vb)]
[!code[Trin_VstcoreWordAutomation#96](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-rows-and-columns-to-word-tables_2.cs)]  
  
## VSTO Add-in Examples  
 The following code examples can be used in a VSTO Add-in. To use the examples, run them from the `ThisAddIn` class in your project. These examples assume that the active document already has at least one table.  
  
> [!IMPORTANT]  
>  This code runs only in projects that you create by using Word VSTO Add-in templates.  
>   
>  If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Word** assembly, and then you must use classes from that assembly to add rows and columns to tables. For more information, see [How to: Target Office Applications Through Primary Interop Assemblies](../VS_officedev/how-to--target-office-applications-through-primary-interop-assemblies.md) and [Word 2010 Primary Interop Assembly Reference](http://go.microsoft.com/fwlink/?LinkId=189588).  
  
#### To add a row to a table  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Rows.Add*> method to add a row to the table.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#95](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-rows-and-columns-to-word-tables_3.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#95](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-rows-and-columns-to-word-tables_3.cs)]  
  
#### To add a column to a table  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Columns.Add*> method, and then use the \<xref:Microsoft.Office.Interop.Word.Columns.DistributeWidth*> method to make all the columns the same width.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#96](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-rows-and-columns-to-word-tables_4.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#96](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-rows-and-columns-to-word-tables_4.cs)]  
  
## See Also  
 [How to: Programmatically Create Word Tables](../VS_officedev/how-to--programmatically-create-word-tables.md)   
 [How to: Programmatically Add Text and Formatting to Cells in Word Tables](../VS_officedev/how-to--programmatically-add-text-and-formatting-to-cells-in-word-tables.md)   
 [How to: Programmatically Populate Word Tables with Document Properties](../VS_officedev/how-to--programmatically-populate-word-tables-with-document-properties.md)  
  
  