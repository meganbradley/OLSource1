---
title: "How to: Programmatically Create Word Tables"
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
  - "documents [Office development in Visual Studio], adding tables"
  - "tables [Office development in Visual Studio], adding to documents"
ms.assetid: fe1f9143-9622-45e8-b0a5-511336d99ad1
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
# How to: Programmatically Create Word Tables
  The \<xref:Microsoft.Office.Interop.Word.Tables> collection is a member of the \<xref:Microsoft.Office.Interop.Word.Document>, \<xref:Microsoft.Office.Tools.Word.Document>, \<xref:Microsoft.Office.Interop.Word.Selection>, and \<xref:Microsoft.Office.Interop.Word.Range> classes, which means that you can create a table in any of those contexts. You use the \<xref:Microsoft.Office.Interop.Word.Tables.Add*> method of the \<xref:Microsoft.Office.Interop.Word.Tables> collection to add a table at the specified range.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Creating Tables in Document-Level Customizations  
  
#### To add a simple table to a document  
  
-   Use the \<xref:Microsoft.Office.Interop.Word.Tables.Add*> method to add a table consisting of three rows and four columns at the beginning of the document.  
  
     To use the following code example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#86](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-word-tables_1.vb)]
[!code[Trin_VstcoreWordAutomation#86](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-word-tables_1.cs)]  
  
 When you create a table, it is automatically added to the \<xref:Microsoft.Office.Interop.Word.Tables> collection of the \<xref:Microsoft.Office.Tools.Word.Document> host item. You can then refer to the table by its item number by using the \<xref:Microsoft.Office.Interop.Word.Tables.Item*> property, as shown in the following code.  
  
#### To refer to a table by item number  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Tables.Item*> property and supply the item number of the table that you want to refer to.  
  
     To use the following code example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#87](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-word-tables_2.vb)]
[!code[Trin_VstcoreWordAutomation#87](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-word-tables_2.cs)]  
  
 Each \<xref:Microsoft.Office.Interop.Word.Table> object also has a \<xref:Microsoft.Office.Interop.Word.Table.Range*> property that enables you to set formatting attributes.  
  
#### To apply a style to a table  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Table.Style*> property to apply one of the Word built-in styles to a table.  
  
     To use the following code example, run it from the `ThisDocument` class in your project.  
  
     [!code[Trin_VstcoreWordAutomation#88](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-word-tables_3.vb)]
[!code[Trin_VstcoreWordAutomation#88](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-word-tables_3.cs)]  
  
## Creating Tables in VSTO Add-ins  
  
#### To add a simple table to a document  
  
-   Use the \<xref:Microsoft.Office.Interop.Word.Tables.Add*> method to add a table consisting of three rows and four columns at the beginning of the document.  
  
     The following code example adds a table to the active document. To use this example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#86](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-word-tables_4.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#86](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-word-tables_4.cs)]  
  
 When you create a table, it is automatically added to the \<xref:Microsoft.Office.Interop.Word.Tables> collection of the \<xref:Microsoft.Office.Interop.Word.Document>. You can then refer to the table by its item number by using the \<xref:Microsoft.Office.Interop.Word.Tables.Item*> property, as shown in the following code.  
  
#### To refer to a table by item number  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Tables.Item*> property and supply the item number of the table that you want to refer to.  
  
     The following code example uses the active document. To use this example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#87](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-word-tables_5.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#87](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-word-tables_5.cs)]  
  
 Each \<xref:Microsoft.Office.Interop.Word.Table> object also has a \<xref:Microsoft.Office.Interop.Word.Table.Range*> property that enables you to set formatting attributes.  
  
#### To apply a style to a table  
  
1.  Use the \<xref:Microsoft.Office.Interop.Word.Table.Style*> property to apply one of the Word built-in styles to a table.  
  
     The following code example uses the active document. To use this example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#88](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-word-tables_6.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#88](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-word-tables_6.cs)]  
  
## See Also  
 [How to: Programmatically Add Text and Formatting to Cells in Word Tables](../VS_officedev/how-to--programmatically-add-text-and-formatting-to-cells-in-word-tables.md)   
 [How to: Programmatically Add Rows and Columns to Word Tables](../VS_officedev/how-to--programmatically-add-rows-and-columns-to-word-tables.md)   
 [How to: Programmatically Populate Word Tables with Document Properties](../VS_officedev/how-to--programmatically-populate-word-tables-with-document-properties.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  