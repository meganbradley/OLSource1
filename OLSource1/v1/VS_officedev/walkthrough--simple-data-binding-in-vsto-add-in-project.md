---
title: "Walkthrough: Simple Data Binding in VSTO add-in Project"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "data [Office development in Visual Studio], binding data"
  - "data binding [Office development in Visual Studio], Word"
  - "data [Office development in Visual Studio], simple binding data"
ms.assetid: b248d194-a8b1-4f87-94c4-24e940eea1fd
caps.latest.revision: 39
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
# Walkthrough: Simple Data Binding in VSTO add-in Project
  You can bind data to host controls and Windows Forms controls in VSTO Add-in projects. This walkthrough demonstrates how to add controls to a Microsoft Office Word document and bind the controls to data at run time.  
  
 [!INCLUDE[appliesto_wdallapp](../VS_officedev/includes/appliesto_wdallapp_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Adding a \<xref:Microsoft.Office.Tools.Word.ContentControl> to a document at run time.  
  
-   Creating a \<xref:System.Windows.Forms.BindingSource> that connects the control to an instance of a dataset.  
  
-   Enabling the user to scroll through the records and view them in the control.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   [!INCLUDE[Word_15_short](../VS_officedev/includes/word_15_short_md.md)] or [!INCLUDE[Word_14_short](../VS_officedev/includes/word_14_short_md.md)].  
  
-   Access to a running instance of SQL Server 2005 or SQL Server 2005 Express that has the `AdventureWorksLT` sample database attached to it. You can download the `AdventureWorksLT` database from the [CodePlex Web site](http://go.microsoft.com/fwlink/?LinkId=115611). For more information about attaching a database, see the following topics:  
  
    -   To attach a database by using SQL Server Management Studio or SQL Server Management Studio Express, see [How to: Attach a Database (SQL Server Management Studio)](assetId:///b4efb0ae-cfe6-4d81-a4b4-6e4916885caa).  
  
    -   To attach a database by using the command line, see [How to: Attach a Database File to SQL Server Express](assetId:///0f8e42b5-7a8c-4c30-8c98-7d2bdc8dcc68).  
  
## Creating a New Project  
 The first step is to create a Word VSTO Add-in project.  
  
#### To create a new project  
  
1.  Create a Word VSTO Add-in project with the name **Populating Documents from a Database**, using either Visual Basic or C#.  
  
     For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the ThisAddIn.vb or ThisAddIn.cs file and adds the **Populating Documents from a Database** project to **Solution Explorer**.  
  
2.  If your project targets the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or the [!INCLUDE[net_v45](../VS_officedev/includes/net_v45_md.md)], add a reference to the Microsoft.Office.Tools.Word.v4.0.Utilities.dll assembly. This reference is required to programmatically add Windows Forms controls to the document later in this walkthrough.  
  
## Creating a Data Source  
 Use the **Data Sources** window to add a typed dataset to your project.  
  
#### To add a typed dataset to the project  
  
1.  If the **Data Sources** window is not visible, display it by, on the menu bar, choosing **View**, **Other Windows**, **Data Sources**.  
  
2.  Choose **Add New Data Source** to start the **Data Source Configuration Wizard**.  
  
3.  Click **Database**, and then click **Next**.  
  
4.  If you have an existing connection to the `AdventureWorksLT` database, choose this connection and click **Next**.  
  
     Otherwise, click **New Connection**, and use the **Add Connection** dialog box to create the new connection. For more information, see [How to: Connect to Data in a Database](../Topic/How%20to:%20Connect%20to%20Data%20in%20a%20Database.md).  
  
5.  In the **Save the Connection String to the Application Configuration File** page, click **Next**.  
  
6.  In the **Choose Your Database Objects** page, expand **Tables** and select **Customer (SalesLT)**.  
  
7.  Click **Finish**.  
  
     The AdventureWorksLTDataSet.xsd file is added to **Solution Explorer**. This file defines the following items:  
  
    -   A typed dataset named `AdventureWorksLTDataSet`. This dataset represents the contents of the **Customer (SalesLT)** table in the AdventureWorksLT database.  
  
    -   A TableAdapter named `CustomerTableAdapter`. This TableAdapter can be used to read and write data in the `AdventureWorksLTDataSet`. For more information, see [TableAdapter Overview](../Topic/TableAdapter%20Overview.md).  
  
     You will use both of these objects later in this walkthrough.  
  
## Creating Controls and Binding Controls to Data  
 The interface for viewing database records in this walkthrough is very basic, and it is created right inside the document. One \<xref:Microsoft.Office.Tools.Word.ContentControl> displays a single database record at a time, and two \<xref:Microsoft.Office.Tools.Word.Controls.Button> controls enable you to scroll back and forth through the records. The content control uses a \<xref:System.Windows.Forms.BindingSource> to connect to the database.  
  
 For more information about binding controls to data, see [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md).  
  
#### To create the interface in the document  
  
1.  In the `ThisAddIn` class, declare the following controls to display and scroll through the `Customer` table of the `AdventureWorksLTDataSet` database.  
  
     [!code[Trin_WordAddInDatabase#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--simple-data-binding-in-vsto-add-in-project_1.vb)]
[!code[Trin_WordAddInDatabase#1](../VS_officedev/codesnippet/CSharp/walkthrough--simple-data-binding-in-vsto-add-in-project_1.cs)]  
  
2.  In the `ThisAddIn_Startup` method, add the following code to initialize the dataset, fill the dataset with information from the `AdventureWorksLTDataSet` database.  
  
     [!code[Trin_WordAddInDatabase#2](../VS_officedev/codesnippet/VisualBasic/walkthrough--simple-data-binding-in-vsto-add-in-project_2.vb)]
[!code[Trin_WordAddInDatabase#2](../VS_officedev/codesnippet/CSharp/walkthrough--simple-data-binding-in-vsto-add-in-project_2.cs)]  
  
3.  Add the following code to the `ThisAddIn_Startup` method. This generates a host item that extends the document. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
     [!code[Trin_WordAddInDatabase#3](../VS_officedev/codesnippet/VisualBasic/walkthrough--simple-data-binding-in-vsto-add-in-project_3.vb)]
[!code[Trin_WordAddInDatabase#3](../VS_officedev/codesnippet/CSharp/walkthrough--simple-data-binding-in-vsto-add-in-project_3.cs)]  
  
4.  Define several ranges at the beginning of the document. These ranges identify where to insert text and place controls.  
  
     [!code[Trin_WordAddInDatabase#4](../VS_officedev/codesnippet/VisualBasic/walkthrough--simple-data-binding-in-vsto-add-in-project_4.vb)]
[!code[Trin_WordAddInDatabase#4](../VS_officedev/codesnippet/CSharp/walkthrough--simple-data-binding-in-vsto-add-in-project_4.cs)]  
  
5.  Add the interface controls to the previously defined ranges.  
  
     [!code[Trin_WordAddInDatabase#5](../VS_officedev/codesnippet/VisualBasic/walkthrough--simple-data-binding-in-vsto-add-in-project_5.vb)]
[!code[Trin_WordAddInDatabase#5](../VS_officedev/codesnippet/CSharp/walkthrough--simple-data-binding-in-vsto-add-in-project_5.cs)]  
  
6.  Bind the content control to `AdventureWorksLTDataSet` by using the \<xref:System.Windows.Forms.BindingSource>. For C# developers, add two event handlers for the \<xref:Microsoft.Office.Tools.Word.Controls.Button> controls.  
  
     [!code[Trin_WordAddInDatabase#6](../VS_officedev/codesnippet/VisualBasic/walkthrough--simple-data-binding-in-vsto-add-in-project_6.vb)]
[!code[Trin_WordAddInDatabase#6](../VS_officedev/codesnippet/CSharp/walkthrough--simple-data-binding-in-vsto-add-in-project_6.cs)]  
  
7.  Add the following code to navigate through the database records.  
  
     [!code[Trin_WordAddInDatabase#7](../VS_officedev/codesnippet/VisualBasic/walkthrough--simple-data-binding-in-vsto-add-in-project_7.vb)]
[!code[Trin_WordAddInDatabase#7](../VS_officedev/codesnippet/CSharp/walkthrough--simple-data-binding-in-vsto-add-in-project_7.cs)]  
  
## Testing the Add-In  
 When you open Word, the content control displays data from the `AdventureWorksLTDataSet` dataset. Scroll through the database records by clicking the **Next** and **Previous** buttons.  
  
#### To test the VSTO Add-in  
  
1.  Press **F5**.  
  
     A content control named `customerContentControl` is created and populated with data. At the same time, a dataset object named `adventureWorksLTDataSet` and a \<xref:System.Windows.Forms.BindingSource> named `customerBindingSource` are added to the project. The \<xref:Microsoft.Office.Tools.Word.ContentControl> is bound to the \<xref:System.Windows.Forms.BindingSource>, which in turn is bound to the dataset object.  
  
2.  Click the **Next** and **Previous** buttons to scroll through the database records.  
  
## See Also  
 [Data in Office Solutions](../VS_officedev/data-in-office-solutions.md)   
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)   
 [How to: Populate Worksheets with Data from a Database](../VS_officedev/how-to--populate-worksheets-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from a Database](../VS_officedev/how-to--populate-documents-with-data-from-a-database.md)   
 [How to: Populate Documents with Data from Services](../VS_officedev/how-to--populate-documents-with-data-from-services.md)   
 [How to: Populate Documents with Data from Objects](../VS_officedev/how-to--populate-documents-with-data-from-objects.md)   
 [How to: Scroll Through Database Records in a Worksheet](../VS_officedev/how-to--scroll-through-database-records-in-a-worksheet.md)   
 [How to: Update a Data Source with Data from a Host Control](../VS_officedev/how-to--update-a-data-source-with-data-from-a-host-control.md)   
 [Walkthrough: Simple Data Binding in a Document-Level Project](../VS_officedev/walkthrough--simple-data-binding-in-a-document-level-project.md)   
 [Walkthrough: Complex Data Binding in a Document-Level Project](../VS_officedev/walkthrough--complex-data-binding-in-a-document-level-project.md)   
 [Using Local Database Files in Office Solutions Overview](../VS_officedev/using-local-database-files-in-office-solutions-overview.md)   
 [Add new data sources](../Topic/Add%20new%20data%20sources.md)   
 [Binding Windows Forms controls to data in Visual Studio](../Topic/Binding%20Windows%20Forms%20controls%20to%20data%20in%20Visual%20Studio.md)   
 [How to: Populate Documents with Data from Objects](../VS_officedev/how-to--populate-documents-with-data-from-objects.md)   
 [How to: Update a Data Source with Data from a Host Control](../VS_officedev/how-to--update-a-data-source-with-data-from-a-host-control.md)   
 [Using Local Database Files in Office Solutions Overview](../VS_officedev/using-local-database-files-in-office-solutions-overview.md)   
 [Connecting to Data in Windows Forms Applications](../Topic/Connecting%20to%20Data%20in%20Windows%20Forms%20Applications.md)   
 [BindingSource Component Overview](../Topic/BindingSource%20Component%20Overview.md)  
  
  