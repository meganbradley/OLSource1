---
title: "How to: Call a Stored Procedure by Using LINQ (Visual Basic)"
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
  - "queries [LINQ in Visual Basic], stored procedure calls"
  - "stored procedures sample [Visual Basic]"
  - "stored procedures [LINQ to SQL]"
  - "queries [LINQ in Visual Basic], how-to topics"
ms.assetid: 6436d384-d1e0-40aa-8afd-451007477260
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Call a Stored Procedure by Using LINQ (Visual Basic)
Language-Integrated Query (LINQ) makes it easy to access database information, including database objects such as stored procedures.  
  
 The following example shows how to create an application that calls a stored procedure in a SQL Server database. The sample shows how to call two different stored procedures in the database. Each procedure returns the results of a query. One procedure takes input parameters, and the other procedure does not take parameters.  
  
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
  
### To add stored procedures to the O/R Designer  
  
1.  In **Server Explorer**/**Database Explorer**, expand the connection to the Northwind database. Expand the **Stored Procedures** folder.  
  
     If you have closed the O/R Designer, you can reopen it by double-clicking the northwind.dbml file that you added earlier.  
  
2.  Click the **Sales by Year** stored procedure and drag it to the right pane of the designer. Click the **Ten Most Expensive Products** stored procedure drag it to the right pane of the designer.  
  
3.  Save your changes and close the designer.  
  
4.  Save your project.  
  
### To add code to display the results of the stored procedures  
  
1.  From the **Toolbox**, drag a \<xref:System.Windows.Forms.DataGridView*> control onto the default Windows Form for your project, Form1.  
  
2.  Double-click Form1 to add code to its `Load` event.  
  
3.  When you added stored procedures to the O/R Designer, the designer added a \<xref:System.Data.Linq.DataContext*> object for your project. This object contains the code that you must have to access those procedures. The \<xref:System.Data.Linq.DataContext*> object for the project is named based on the name of the .dbml file. For this project, the \<xref:System.Data.Linq.DataContext*> object is named `northwindDataContext`.  
  
     You can create an instance of the \<xref:System.Data.Linq.DataContext*> in your code and call the stored procedure methods specified by the O/R Designer. To bind to the \<xref:System.Windows.Forms.DataGridView*> object, you may have to force the query to execute immediately by calling the \<xref:System.Linq.Enumerable.ToList*> method on the results of the stored procedure.  
  
     Add the following code to the `Load` event to call either of the stored procedures exposed as methods for your data context.  
  
     [!code[VbLINQtoSQLHowTos#1](../vs140/codesnippet/VisualBasic/how-to--call-a-stored-procedure-by-using-linq--visual-basic-_1.vb)]  
    [!code[VbLINQtoSQLHowTos#2](../vs140/codesnippet/VisualBasic/how-to--call-a-stored-procedure-by-using-linq--visual-basic-_2.vb)]  
  
4.  Press F5 to run your project and view the results.  
  
## See Also  
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)   
 [DataContext Methods (O/R Designer)](assetId:///c149f4e5-3b61-4c33-892e-3e26d47f3eeb)   
 [How to: Assign Stored Procedures to Perform Updates, Inserts, and Deletes (O/R Designer)](assetId:///e88224ab-ff61-4a3a-b6b8-6f3694546cac)   
 [Walkthrough: Creating LINQ to SQL Classes (O/R Designer)](assetId:///35aad4a4-2e8a-46e2-ae09-5fbfd333c233)