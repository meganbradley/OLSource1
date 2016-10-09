---
title: "How to: Programmatically Populate Word Tables with Document Properties"
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
  - "document properties, inserting in Word tables"
  - "documents [Office development in Visual Studio], document properties"
ms.assetid: 7ed65a3d-58ed-43b3-92d6-dc10a2c331db
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
# How to: Programmatically Populate Word Tables with Document Properties
  The following example creates a Microsoft Office Word table at the top of the document and populates it with the properties of the host document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Populating Tables in a Document-Level Customization  
  
#### To create a table and populate it with document properties  
  
1.  Set the range to the top of the document.  
  
     [!code[Trin_VstcoreWordAutomation#90](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_1.vb)]
[!code[Trin_VstcoreWordAutomation#90](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_1.cs)]  
  
2.  Insert a title for the table and include paragraph marks.  
  
     [!code[Trin_VstcoreWordAutomation#91](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_2.vb)]
[!code[Trin_VstcoreWordAutomation#91](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_2.cs)]  
  
3.  Add the table to the document at the range.  
  
     [!code[Trin_VstcoreWordAutomation#92](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_3.vb)]
[!code[Trin_VstcoreWordAutomation#92](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_3.cs)]  
  
4.  Format the table and apply a style.  
  
     [!code[Trin_VstcoreWordAutomation#93](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_4.vb)]
[!code[Trin_VstcoreWordAutomation#93](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_4.cs)]  
  
5.  Insert the document properties into cells.  
  
     [!code[Trin_VstcoreWordAutomation#94](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_5.vb)]
[!code[Trin_VstcoreWordAutomation#94](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_5.cs)]  
  
 The following example shows the complete procedure. To use this code, run it from the `ThisDocument` class in your project.  
  
 [!code[Trin_VstcoreWordAutomation#89](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_6.vb)]
[!code[Trin_VstcoreWordAutomation#89](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_6.cs)]  
  
## Populating Tables in a VSTO Add-in  
  
#### To create a table and populate it with document properties  
  
1.  Set the range to the top of the document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#90](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_7.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#90](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_7.cs)]  
  
2.  Insert a title for the table and include paragraph marks.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#91](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_8.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#91](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_8.cs)]  
  
3.  Add the table to the document at the range.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#92](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_9.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#92](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_9.cs)]  
  
4.  Format the table and apply a style.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#93](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_10.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#93](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_10.cs)]  
  
5.  Insert the document properties into cells.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#94](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_11.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#94](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_11.cs)]  
  
 The following example shows the complete procedure. To use this code, run it from the `ThisAddIn` class in your project.  
  
 [!code[Trin_VstcoreWordAutomationAddIn#89](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-populate-word-tables-with-document-properties_12.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#89](../VS_officedev/codesnippet/CSharp/how-to--programmatically-populate-word-tables-with-document-properties_12.cs)]  
  
## See Also  
 [How to: Programmatically Create Word Tables](../VS_officedev/how-to--programmatically-create-word-tables.md)   
 [How to: Programmatically Add Text and Formatting to Cells in Word Tables](../VS_officedev/how-to--programmatically-add-text-and-formatting-to-cells-in-word-tables.md)   
 [How to: Programmatically Add Rows and Columns to Word Tables](../VS_officedev/how-to--programmatically-add-rows-and-columns-to-word-tables.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  