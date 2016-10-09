---
title: "How to: Fill ListObject Controls with Data"
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
  - "disconnecting from data sources"
  - "ListObject control, disconnecting from a data source"
  - "ListObject control, filling with data"
  - "data [Office development in Visual Studio], adding to worksheets"
  - "data binding, ListObject controls"
  - "worksheets, populating with data"
ms.assetid: bf692c77-f5cc-456a-9a5c-84ed3067d7eb
caps.latest.revision: 27
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Fill ListObject Controls with Data
  You can use data binding as a way to quickly add data to your document. After binding data to a list object, you can disconnect the list object so it displays the data but is no longer bound to the data source.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Create a List in Excel that is Connected to a SharePoint List?](http://go.microsoft.com/fwlink/?LinkID=130263).  
  
### To bind data to a ListObject control  
  
1.  Create a \<xref:System.Data.DataTable> at the class level.  
  
     [!code[Trin_VstcoreHostControlsExcel#20](../VS_officedev/codesnippet/CSharp/how-to--fill-listobject-controls-with-data_1.cs)]
[!code[Trin_VstcoreHostControlsExcel#20](../VS_officedev/codesnippet/VisualBasic/how-to--fill-listobject-controls-with-data_1.vb)]  
  
2.  Add sample columns and data in the `Startup` event handler of the `Sheet1` class (in a document-level project) or `ThisAddIn` class (in an application-level project).  
  
     [!code[Trin_VstcoreHostControlsExcel#21](../VS_officedev/codesnippet/CSharp/how-to--fill-listobject-controls-with-data_2.cs)]
[!code[Trin_VstcoreHostControlsExcel#21](../VS_officedev/codesnippet/VisualBasic/how-to--fill-listobject-controls-with-data_2.vb)]  
  
3.  Call the \<xref:Microsoft.Office.Tools.Excel.ListObject.SetDataBinding*> method and pass in the column names in the order they should appear. The order of the columns in the list object can differ from the order in which they appear in the \<xref:System.Data.DataTable>.  
  
     [!code[Trin_VstcoreHostControlsExcel#22](../VS_officedev/codesnippet/CSharp/how-to--fill-listobject-controls-with-data_3.cs)]
[!code[Trin_VstcoreHostControlsExcel#22](../VS_officedev/codesnippet/VisualBasic/how-to--fill-listobject-controls-with-data_3.vb)]  
  
### To disconnect the ListObject control from the data source  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.ListObject.Disconnect*> method of `List1`.  
  
     [!code[Trin_VstcoreHostControlsExcel#23](../VS_officedev/codesnippet/CSharp/how-to--fill-listobject-controls-with-data_4.cs)]
[!code[Trin_VstcoreHostControlsExcel#23](../VS_officedev/codesnippet/VisualBasic/how-to--fill-listobject-controls-with-data_4.vb)]  
  
## Compiling the Code  
 This code example assumes you have an existing \<xref:Microsoft.Office.Tools.Excel.ListObject> named `list1` on the worksheet in which this code appears.  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [How to: Map ListObject Columns to Data](../VS_officedev/how-to--map-listobject-columns-to-data.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [ListObject Control](../VS_officedev/listobject-control.md)   
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)   
 [How to: Populate Worksheets with Data from a Database](../VS_officedev/how-to--populate-worksheets-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Services](../VS_officedev/how-to--populate-documents-with-data-from-services.md)  
  
  