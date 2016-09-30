---
title: "Walkthrough: Using Stored Procedures"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 574afeac-6998-4ed8-9db6-95b0bbbb2985
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Using Stored Procedures
You can’t call a stored procedure in a SQL Server database directly from LightSwitch, but you can create a local table in your LightSwitch app that contains the parameters for the stored procedure, then call the stored procedure from a server tier event. This walkthrough shows how to insert customer records in a SQL database by using stored procedures.  
  
 Many database administrators don’t allow direct access to tables, instead exposing read-only views and providing stored procedures to insert, update, and delete records. LightSwitch doesn’t recognize stored procedures, so any database that relies on stored procedures to update records might at first appear to be unusable. If you do a little extra work, you can indeed use these databases from LightSwitch.  
  
## Prerequisites  
 This walkthrough uses the Northwind sample database.  
  
## Create a stored procedure  
 In most cases, you’ll access stored procedures that already exist in a database. The Northwind database doesn’t have the necessary stored procedure to insert customer records, so you must add it.  
  
#### To add a stored procedure  
  
1.  On the menu bar, choose **View**, **SQL Server Object Explorer**.  
  
2.  In the **SQL Server Object Explorer** window, expand the **NORTHWIND** database node, and then choose **Programmability**.  
  
3.  Expand the **Programmability** node, and then choose **Stored Procedures**.  
  
4.  Open the shortcut menu for **Stored Procedures**, and then choose **Add New Stored Procedure**.  
  
5.  In the **Code Editor**, replace the contents with the following Transact-SQL code, and then choose the **Update** button.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
6.  In the **Preview Database Updates** dialog box, choose the **Update Database** button.  
  
     The **InsertCustomer** stored procedure is added to the database.  
  
## Create a LightSwitch App  
 In this step you’ll create an app to call the stored procedure and add new customers to the Northwind database.  
  
#### To create the app  
  
1.  On the menu bar choose **File**, **New**, **Project**.  
  
2.  In the **New Project** dialog box, expand the **Visual Basic** or **Visual C#** node, and then choose the **LightSwitch HTML Application** template.  
  
3.  In the **Name** textbox, enter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and then choose the **OK** button  
  
#### To add a data source  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Data Sources** node and choose **Add Data Source**.  
  
2.  In the **Attach Data Source Wizard**, choose **Database**, and then choose the **Next** button.  
  
3.  In the **Connection Properties** dialog box, enter the connection details for your Northwind database and then choose the **OK** button.  
  
4.  On the **Choose your database objects** page, expand the **Tables** node and select the **Customers** checkbox, and then choose the **Finish** button.  
  
#### To add a local table  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Data Sources** node and choose **Add Table**.  
  
2.  In the **Properties** window, choose the **Name** property and enter **NewCustomer**.  
  
3.  In the entity designer, add the following fields:  
  
    |Name|Type|Required|  
    |----------|----------|--------------|  
    |CustomerID|String|Yes|  
    |CompanyName|String|Yes|  
    |ContactName|String|Yes|  
    |ContactTitle|String|Yes|  
    |Address|String|Yes|  
    |City|String|Yes|  
    |Region|String|Yes|  
    |PostalCode|String|Yes|  
    |Country|String|Yes|  
    |Phone|Phone Number|Yes|  
    |Fax|Phone Number|Yes|  
  
     Notice that all fields are required. That’s because all of the parameters for the stored procedure require values. Also notice that the data type for the **Phone** and **Fax** fields are <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Even though these are stored in the database as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you can take advantage of LightSwitch custom business types on the client tier.  
  
#### To add a screen  
  
1.  In the entity designer, on the **Perspective** bar, choose **HTMLClient**.  
  
2.  On the **Toolbar**, choose the Screen button.  
  
3.  In the **Add New Screen** dialog box, choose the **Common Screen Set** template, in the **Screen Set Name** text box enter <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and in the **Screen Data** list choose **NewCustomer**, and then choose the **OK** button.  
  
#### To call the stored procedure  
  
1.  In **Solution Explorer**, open the shortcut menu for the **NorthwindSP.Server** node and choose **Add**, **Reference**.  
  
2.  In the **Add Reference** dialog box, select the **System.Configuration** checkbox, and then choose the **OK** button.  
  
3.  In **Solution Explorer**, open the shortcut menu for the **NewCustomer.lsml** node and choose **Open**.  
  
4.  In the entity designer, on the **Perspective** bar, choose **Server**.  
  
5.  On the **Toolbar**, expand the **Write Code** list and choose **NewCustomers_Inserting**.  
  
6.  In the Code Editor, replace the existing code with the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     When a new record is inserted into the NewCustomers table, this code runs, opening a connection to the Northwind database and running the InsertCustomer stored procedures, providing the values in the **NewCustomer** entity as parameters to the stored procedure.  
  
#### To test the app  
  
1.  In the Code Editor, set a breakpoint in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method.  
  
2.  Run the app and on the **CustomersSet** screen, choose the **Add** button.  
  
3.  On the **Customers** screen, fill in all of the fields and choose the **Save** button.  
  
     Notice that the breakpoint is hit, demonstrating that the code is working, and press F5 to continue. If you open the Customers table in the Northwind database, you’ll see your new customer record.  
  
## Next Steps  
 You can create your LightSwitch screens and business logic as usual and quickly and easily make a functioning application by using stored procedures.  
  
## See Also  
 [How to: Call a Stored Procedure](../vs140/how-to--execute-a-stored-procedure-in-lightswitch.md)   
 [Data: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)