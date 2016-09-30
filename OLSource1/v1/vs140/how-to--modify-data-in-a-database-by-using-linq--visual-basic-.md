---
title: "How to: Modify Data in a Database by Using LINQ (Visual Basic)"
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
  - "inserting rows [LINQ to SQL]"
  - "deleting rows [LINQ to SQL]"
  - "updating rows [LINQ to SQL]"
  - "inserting data [Visual Basic]"
  - "deleting data"
  - "data [Visual Basic], updating"
  - "updating data [LINQ]"
  - "queries [LINQ in Visual Basic], data changes in database"
  - "queries [LINQ in Visual Basic], how-to topics"
ms.assetid: cf52635f-0c1b-46c3-aff1-bdf181cf19b1
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Modify Data in a Database by Using LINQ (Visual Basic)
Language-Integrated Query (LINQ) queries make it easy to access database information and modify values in the database.  
  
 The following example shows how to create a new application that retrieves and updates information in a SQL Server database.  
  
 The examples in this topic use the Northwind sample database. If you do not have the Northwind sample database on your development computer, you can download it from the [Microsoft Download Center](http://go.microsoft.com/fwlink/?LinkID=98088) Web site. For instructions, see [Downloading Sample Databases (LINQ to SQL)](assetId:///ef9d69a1-9461-43fe-94bb-7c836754bcb5).  
  
### To create a connection to a database  
  
1.  In Visual Studio, open **Server Explorer**/**Database Explorer** by clicking the **View** menu, and then select **Server Explorer**/**Database Explorer**.  
  
2.  Right-click **Data Connections** in **Server Explorer**/**Database Explorer**, and click **Add Connection**.  
  
3.  Specify a valid connection to the Northwind sample database.  
  
### To add a Project with a LINQ to SQL file  
  
1.  In Visual Studio, on the **File** menu, point to **New** and then click **Project**. Select Visual Basic **Windows Forms Application** as the project type.  
  
2.  On the **Project** menu, click **Add New Item**. Select the **LINQ to SQL Classes** item template.  
  
3.  Name the file <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Click **Add**. The Object Relational Designer (O/R Designer) is opened for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> file.  
  
### To add tables to query and modify to the designer  
  
1.  In **Server Explorer**/**Database Explorer**, expand the connection to the Northwind database. Expand the **Tables** folder.  
  
     If you have closed the O/R Designer, you can reopen it by double-clicking the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> file that you added earlier.  
  
2.  Click the Customers table and drag it to the left pane of the designer.  
  
     The designer creates a new Customer object for your project.  
  
3.  Save your changes and close the designer.  
  
4.  Save your project.  
  
### To add code to modify the database and display the results  
  
1.  From the **Toolbox**, drag a \<xref:System.Windows.Forms.DataGridView*> control onto the default Windows Form for your project, Form1.  
  
2.  When you added tables to the O/R Designer, the designer added a \<xref:System.Data.Linq.DataContext*> object to your project. This object contains code that you can use to access the Customers table. It also contains code that defines  a local Customer object and a Customers collection for the table. The \<xref:System.Data.Linq.DataContext*> object for your project is named based on the name of your .dbml file. For this project, the \<xref:System.Data.Linq.DataContext*> object is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
     You can create an instance of the \<xref:System.Data.Linq.DataContext*> object in your code and query and modify the Customers collection specified by the O/R Designer. Changes that you make to the Customers collection are not reflected in the database until you submit them by calling the \<xref:System.Data.Linq.DataContext.SubmitChanges*> method of the \<xref:System.Data.Linq.DataContext*> object.  
  
     Double-click the Windows Form, Form1, to add code to the \<xref:System.Windows.Forms.Form.Load*> event to query the Customers table that is exposed as a property of your \<xref:System.Data.Linq.DataContext*>. Add the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  From the **Toolbox**, drag three \<xref:System.Windows.Forms.Button*> controls onto the form. Select the first <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> control. In the **Properties** window, set the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> control to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Select the second button and set the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Select the third button and set the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
4.  Double-click the **Add** button to add code to its <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> event. Add the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Double-click the **Update** button to add code to its <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> event. Add the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
6.  Double-click the **Delete** button to add code to its <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> event. Add the following code:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
7.  Press F5 to run your project. Click **Add** to add a new record. Click **Update** to modify the new record. Click **Delete** to delete the new record.  
  
## See Also  
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)   
 [DataContext Methods (O/R Designer)](assetId:///c149f4e5-3b61-4c33-892e-3e26d47f3eeb)   
 [How to: Assign Stored Procedures to Perform Updates, Inserts, and Deletes (O/R Designer)](assetId:///e88224ab-ff61-4a3a-b6b8-6f3694546cac)   
 [Walkthrough: Creating LINQ to SQL Classes (O/R Designer)](assetId:///35aad4a4-2e8a-46e2-ae09-5fbfd333c233)