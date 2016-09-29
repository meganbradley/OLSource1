---
title: "How to: Find the Minimum or Maximum Value in a Query Result by Using LINQ (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "max operator [LINQ in Visual Basic]"
  - "aggregate operator [LINQ in Visual Basic]"
  - "aggregate queries"
  - "minimum values [LINQ in Visual Basic]"
  - "min operator [LINQ in Visual Basic]"
  - "queries [LINQ in Visual Basic], minimum and maximum values"
  - "Max property"
  - "maximum values [LINQ in Visual Basic]"
  - "Aggregate clause"
  - "queries [LINQ in Visual Basic], aggregate queries"
  - "queries [LINQ in Visual Basic], how-to topics"
ms.assetid: 238b763b-7dcd-4b14-8050-b65500a4f71c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Find the Minimum or Maximum Value in a Query Result by Using LINQ (Visual Basic)
Language-Integrated Query (LINQ) makes it easy to access database information and execute queries.  
  
 The following example shows how to create a new application that performs queries against a SQL Server database. The sample determines the minimum and maximum values for the results by using the `Aggregate` and `Group By` clauses. For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md) and [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md).  
  
 The examples in this topic use the Northwind sample database. If you do not have the Northwind sample database on your development computer, you can download it from the [Microsoft Download Center](http://go.microsoft.com/fwlink/?LinkID=98088) Web site. For instructions, see [Downloading Sample Databases (LINQ to SQL)](assetId:///ef9d69a1-9461-43fe-94bb-7c836754bcb5).  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To create a connection to a database  
  
1.  In Visual Studio, open **Server Explorer**/**Database Explorer** by clicking **Server Explorer**/**Database Explorer** on the **View** menu.  
  
2.  Right-click **Data Connections** in **Server Explorer**/**Database Explorer** and then click **Add Connection**.  
  
3.  Specify a valid connection to the Northwind sample database.  
  
### To add a project that contains a LINQ to SQL file  
  
1.  In Visual Studio, on the **File** menu, point to **New** and then click **Project**. Select Visual Basic **Windows Forms Application** as the project type.  
  
2.  On the **Project** menu, click **Add New Item**. Select the **LINQ to SQL Classes** item template.  
  
3.  Name the file `northwind.dbml`. Click **Add**. The Object Relational Designer (O/R Designer) is opened for the northwind.dbml file.  
  
### To add tables to query to the O/R Designer  
  
1.  In **Server Explorer**/**Database Explorer**, expand the connection to the Northwind database. Expand the **Tables** folder.  
  
     If you have closed the O/R Designer, you can reopen it by double-clicking the northwind.dbml file that you added earlier.  
  
2.  Click the Customers table and drag it to the left pane of the designer. Click the Orders table and drag it to the left pane of the designer.  
  
     The designer creates new `Customer` and `Order` objects for your project. Notice that the designer automatically detects relationships between the tables and creates child properties for related objects. For example, IntelliSense will show that the `Customer` object has an `Orders` property for all orders related to that customer.  
  
3.  Save your changes and close the designer.  
  
4.  Save your project.  
  
### To add code to query the database and display the results  
  
1.  From the **Toolbox**, drag a <xref:System.Windows.Forms.DataGridView*> control onto the default Windows Form for your project, Form1.  
  
2.  Double-click Form1 to add code to the `Load` event of the form.  
  
3.  When you added tables to the O/R Designer, the designer added a <xref:System.Data.Linq.DataContext*> object for your project. This object contains the code that you must have to access those tables, in addition to individual objects and collections for each table. The <xref:System.Data.Linq.DataContext*> object for your project is named based on the name of your .dbml file. For this project, the <xref:System.Data.Linq.DataContext*> object is named `northwindDataContext`.  
  
     You can create an instance of the <xref:System.Data.Linq.DataContext*> in your code and query the tables specified by the O/R Designer.  
  
     Add the following code to the `Load` event. This code queries the tables that are exposed as properties of your data context and determines the minimum and maximum values for the results. The sample uses he `Aggregate` clause to query for a single result, and the `Group By` clause to show an average for grouped results.  
  
     [!code[VbLINQToSQLHowTos#14](../vs140/codesnippet/VisualBasic/how-to--find-the-minimum-or-maximum-value-in-a-query-result-by-using-linq--visual-basic-_1.vb)]  
  
4.  Press F5 to run your project and view the results.  
  
## See Also  
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)   
 [DataContext Methods (O/R Designer)](assetId:///c149f4e5-3b61-4c33-892e-3e26d47f3eeb)   
 [Walkthrough: Creating LINQ to SQL Classes (O/R Designer)](assetId:///35aad4a4-2e8a-46e2-ae09-5fbfd333c233)