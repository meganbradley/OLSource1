---
title: "How to: Update a Data Source with Data from a Host Control"
ms.custom: na
ms.date: "09/16/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documents [Office development in Visual Studio], data source updates"
  - "data [Office development in Visual Studio], updating a data source from a document"
  - "host controls [Office development in Visual Studio], data source updates"
  - "Office documents [Office development in Visual Studio, data sources"
ms.assetid: b91025af-1eaa-44ee-88f2-71ecaa7a0440
caps.latest.revision: 53
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
# How to: Update a Data Source with Data from a Host Control
  You can bind a host control to a data source and update the data source with the changes that are made to the data in the control. There are two main steps in this process:  
  
1.  Update the in-memory data source with the modified data in the control. Typically, the in-memory data source is a \<xref:System.Data.DataSet>, a \<xref:System.Data.DataTable>, or some other data object.  
  
2.  Update the database with the changed data in the in-memory data source. This is applicable only if the data source is connected to a back-end database, such as a SQL Server or Microsoft Office Access database.  
  
 For more information about host controls and data binding, see [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md) and [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md).  
  
 [!INCLUDE[appliesto_controls](../VS_officedev/includes/appliesto_controls_md.md)]  
  
## Updating the In-Memory Data Source  
 By default, host controls that enable simple data binding (such as content controls on a Word document or a named range control on an Excel worksheet) do not save data changes to the in-memory data source. That is, when an end user changes a value in a host control and then navigates away from the control, the new value in the control is not automatically saved to the data source.  
  
 To save the data to the data source, you can write code that updates the data source in response to a specific event at run time, or you can configure the control to automatically update the data source when the value in the control changes.  
  
 You do not need to save \<xref:Microsoft.Office.Tools.Excel.ListObject> changes to the in-memory data source. When you bind a \<xref:Microsoft.Office.Tools.Excel.ListObject> control to data, the \<xref:Microsoft.Office.Tools.Excel.ListObject> control automatically saves changes to the in-memory data source without requiring additional code.  
  
#### To update the in-memory data source at run time  
  
-   Call the \<xref:System.Windows.Forms.Binding.WriteValue*> method of the \<xref:System.Windows.Forms.Binding> object that binds the control to the data source.  
  
     The following example saves changes made to a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control on an Excel worksheet to the data source. This example assumes that you have a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control named `namedRange1` with its \<xref:Microsoft.Office.Tools.Excel.NamedRange.Value2*> property bound to a field in a data source.  
  
     [!code[Trin_VstcoreDataExcel#1](../VS_officedev/codesnippet/CSharp/how-to--update-a-data-source-with-data-from-a-host-control_1.cs)]
[!code[Trin_VstcoreDataExcel#1](../VS_officedev/codesnippet/VisualBasic/how-to--update-a-data-source-with-data-from-a-host-control_1.vb)]  
  
### Automatically Updating the In-Memory Data Source  
 You can also configure a control so that it automatically updates the in-memory data source. In a document-level project, you can do this by using code or the designer. In an VSTO Add-in project, you must use code.  
  
##### To set a control to automatically update the in-memory data source by using code  
  
1.  Use the System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged mode of the \<xref:System.Windows.Forms.Binding> object that binds the control to the data source. There are two options for updating the data source:  
  
    -   To update the data source when the control is validated, set this property to System.Windows.Forms.DataSourceUpdateMode.OnValidation.  
  
    -   To update the data source when the value of the data-bound property of the control changes, set this property to System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged.  
  
        > [!NOTE]  
        >  The System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged option does not apply to Word host controls, because Word does not offer document-change or control-change notifications. However, this option can be used for Windows Forms controls on Word documents.  
  
     The following example configures a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control to automatically update the data source when the value in the control changes. This example assumes that you have a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control named `namedRange1` with its \<xref:Microsoft.Office.Tools.Excel.NamedRange.Value2*> property bound to a field in a data source.  
  
     [!code[Trin_VstcoreDataExcel#19](../VS_officedev/codesnippet/CSharp/how-to--update-a-data-source-with-data-from-a-host-control_2.cs)]
[!code[Trin_VstcoreDataExcel#19](../VS_officedev/codesnippet/VisualBasic/how-to--update-a-data-source-with-data-from-a-host-control_2.vb)]  
  
##### To set a control to automatically update the in-memory data source by using the designer  
  
1.  In Visual Studio, open the Word document or Excel workbook in the designer.  
  
2.  Click the control that you want to automatically update the data source.  
  
3.  In the **Properties** window, expand the **(DataBindings)** property.  
  
4.  Next to the **(Advanced)** property, click the ellipsis button (![VisualStudioEllipsesButton screenshot](../VS_officedev/media/vbellipsesbutton.png "vbEllipsesButton")).  
  
5.  In the **Formatting and Advanced Binding** dialog box, click the **Data Source Update Mode** drop-down list and select one of the following values:  
  
    -   To update the data source when the control is validated, select **OnValidation**.  
  
    -   To update the data source when the value of the data-bound property of the control changes, select **OnPropertyChanged**.  
  
        > [!NOTE]  
        >  The **OnPropertyChanged** option does not apply to Word host controls, because Word does not offer document-change or control-change notifications. However, this option can be used for Windows Forms controls on Word documents.  
  
6.  Close the **Formatting and Advanced Binding** dialog box.  
  
## Updating the Database  
 If the in-memory data source is associated with a database, you must update the database with the changes to the data source. For more information about updating a database, see [Saving data back to the database](../Topic/Saving%20data%20back%20to%20the%20database.md) and [How to: Update Data by Using a TableAdapter](../Topic/How%20to:%20Update%20Data%20by%20Using%20a%20TableAdapter.md).  
  
#### To update the database  
  
1.  Call the \<xref:System.Windows.Forms.BindingSource.EndEdit*> method of the \<xref:System.Windows.Forms.BindingSource> for the control.  
  
     The \<xref:System.Windows.Forms.BindingSource> is automatically generated when you add a data-bound control to a document or workbook at design time. The \<xref:System.Windows.Forms.BindingSource> connects the control to the typed dataset in your project. For more information, see [BindingSource Component Overview](../Topic/BindingSource%20Component%20Overview.md).  
  
     The following code example assumes that your project contains a \<xref:System.Windows.Forms.BindingSource> named `customersBindingSource`.  
  
     [!code[Trin_VstcoreDataExcel#20](../VS_officedev/codesnippet/CSharp/how-to--update-a-data-source-with-data-from-a-host-control_3.cs)]
[!code[Trin_VstcoreDataExcel#20](../VS_officedev/codesnippet/VisualBasic/how-to--update-a-data-source-with-data-from-a-host-control_3.vb)]  
  
2.  Call the `Update` method of the generated TableAdapter in your project.  
  
     The TableAdapter is automatically generated when you add a data-bound control to a document or workbook at design time. The TableAdapter connects the typed dataset in your project to the database. For more information, see [TableAdapter Overview](../Topic/TableAdapter%20Overview.md).  
  
     The following code example assumes that you have a connection to the Customers table in the Northwind database, and that your project contains a TableAdapter named `customersTableAdapter` and a typed dataset named `northwindDataSet`.  
  
     [!code[Trin_VstcoreDataExcel#21](../VS_officedev/codesnippet/CSharp/how-to--update-a-data-source-with-data-from-a-host-control_4.cs)]
[!code[Trin_VstcoreDataExcel#21](../VS_officedev/codesnippet/VisualBasic/how-to--update-a-data-source-with-data-from-a-host-control_4.vb)]  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)   
 [Saving data back to the database](../Topic/Saving%20data%20back%20to%20the%20database.md)   
 [How to: Update Data by Using a TableAdapter](../Topic/How%20to:%20Update%20Data%20by%20Using%20a%20TableAdapter.md)   
 [How to: Scroll Through Database Records in a Worksheet](../VS_officedev/how-to--scroll-through-database-records-in-a-worksheet.md)   
 [How to: Populate Worksheets with Data from a Database](../VS_officedev/how-to--populate-worksheets-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Objects](../VS_officedev/how-to--populate-documents-with-data-from-objects.md)   
 [How to: Populate Documents with Data from a Database](../VS_officedev/how-to--populate-documents-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Services](../VS_officedev/how-to--populate-documents-with-data-from-services.md)  
  
  