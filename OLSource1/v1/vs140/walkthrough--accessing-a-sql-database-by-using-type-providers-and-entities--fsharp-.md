---
title: "Walkthrough: Accessing a SQL Database by Using Type Providers and Entities (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "SQLEntityConnection type provider [F#]"
  - "type providers [F#], accessing Entity Framework data"
ms.assetid: 844a136a-c951-44b1-84fc-2e415cd58fb8
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Accessing a SQL Database by Using Type Providers and Entities (F#)
This walkthrough for F# 3.0 shows you how to access typed data for a SQL database based on the ADO.NET Entity Data Model. This walkthrough shows you how to set up the F# <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type provider for use with a SQL database, how to write queries against the data, how to call stored procedures on the database, as well as how to use some of the ADO.NET Entity Framework types and methods to update the database.  
  
 This walkthrough illustrates the following tasks, which you should perform in this order for the walkthrough to succeed:  
  
-   [Create the School database](#BKMK_CreateDB).  
  
-   [Create and configure an F# project](#BKMK_CreateConfigFSProj).  
  
-   [Configure the type provider and connect to the Entity Data Model](#BKMK_ConfigTypeProv).  
  
-   [Query the database](#BKMK_QuerytheData).  
  
-   [Updating the database](#BKMK_UpdatetheDB)  
  
## Prerequisites  
 You must have access to a server that's running SQL Server where you can create a database to complete these steps.  
  
##  \<a name="BKMK_CreateDB">\</a> Create the School database  
 You can create the School database on any server that's running SQL Server to which you have administrative access, or you can use LocalDB.  
  
#### To create the School database  
  
1.  In **Server Explorer**, open the shortcut menu for the **Data Connections** node, and then choose **Add Connection**.  
  
     The **Add Connection** dialog box appears.  
  
2.  In the **Server name** box, specify the name of an instance of SQL Server to which you have administrative access, or specify (localdb\v11.0) if you don't have access to a server.  
  
     SQL Server Express LocalDB provides a lightweight database server for development and testing on your machine. For more information about LocalDB, see [Walkthrough: Creating a SQL Server Express LocalDB Database](assetId:///99c2b06f-47aa-414e-8057-a3453712fd23).  
  
     A new node is created in **Server Explorer** under **Data Connections**.  
  
3.  Open the shortcut menu for the new connection node, and then choose **New Query**.  
  
4.  Open [Creating the School Sample Database](http://go.microsoft.com/fwlink/?LinkID=237278) on the Microsoft website, and then copy and paste the database script that creates the Student database into the editor window.  
  
##  \<a name="BKMK_CreateConfigFSProj">\</a> Create and configure an F# project  
 In this step, you create a project and set it up to use a type provider.  
  
#### To create and configure an F# project  
  
1.  Close the previous project, create another project, and name it <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
2.  In **Solution Explorer**, open the shortcut menu for **References**, and then choose **Add Reference**.  
  
3.  Choose the **Framework** node, and then, in the **Framework** list, choose \<xref:System.Data*>, \<xref:System.Data.Entity*>,  and \<xref:System.Data.Linq*>.  
  
4.  Choose the **Extensions** node, add a reference to the [FSharp.Data.TypeProviders](../vs140/microsoft.fsharp.data.typeproviders-namespace--fsharp-.md) assembly, and then choose the **OK** button to dismiss the dialog box.  
  
5.  Add the following code to define an internal module and open appropriate namespaces. The type provider can inject types only into a private or internal namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
6.  To run the code in this walkthrough interactively as a script instead of as a compiled program, open the shortcut menu for the project node, choose **Add New Item**, add an F# script file, and then add the code in each step to the script. To load the assembly references, add the following lines.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
7.  Highlight each block of code as you add it, and choose the Alt + Enter keys to run it in F# Interactive.  
  
##  \<a name="BKMK_ConfigTypeProv">\</a> Configure the type provider, and connect to the Entity Data Model  
 In this step, you set up a type provider with a data connection and obtain a data context that allows you to work with data.  
  
#### To configure the type provider, and connect to the Entity Data Model  
  
1.  Enter the following code to configure the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type provider that generates F# types based on the Entity Data Model that you created previously. Instead of the full EDMX connection string, use only the SQL connection string.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     This action sets up a type provider with the database connection that you created earlier. The property <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is needed when you use the ADO.NET Entity Framework because this property allows multiple commands to execute asynchronously on the database in one connection, which can occur frequently in ADO.NET Entity Framework code. For more information, see [Multiple Active Result Sets (MARS)](http://go.microsoft.com/fwlink/?LinkId=236929).  
  
2.  Get the data context, which is an object that contains the database tables as properties and the database stored procedures and functions as methods.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="BKMK_QuerytheData">\</a> Querying the database  
 In this step, you use F# query expressions to execute various queries on the database.  
  
#### To query the data  
  
-   Enter the following code to query the data from the entity data model. Note the effect of Pluralize = true, which changes the database table Course to Courses and Person to People.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="BKMK_UpdatetheDB">\</a> Updating the database  
 To update the database, you use the Entity Framework classes and methods. You can use two types of data context with the SQLEntityConnection type provider. First, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the simplified data context, which includes only the provided properties that represent database tables and columns. Second, the full data context is an instance of the Entity Framework class \<xref:System.Data.Objects.ObjectContext*>, which contains the method \<xref:System.Data.Objects.ObjectContext.AddObject*> to add rows to the database. The Entity Framework recognizes the tables and the relationships between them, so it enforces database consistency.  
  
#### To update the database  
  
1.  Add the following code to your program. In this example, you add two objects with a relationship between them, and you add an instructor and an office assignment. The table <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> contains the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> column, which references the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> column in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> table.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     Nothing is changed in the database until you call \<xref:System.Data.Objects.ObjectContext.SaveChanges*>.  
  
2.  Now restore the database to its earlier state by deleting the objects that you added.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
    > [!WARNING]
    >  When you use a query expression, you must remember that the query is subject to lazy evaluation. Therefore, the database is still open for reading during any chained evaluations, such as in the lambda expression blocks after each query expression. Any database operation that explicitly or implicitly uses a transaction must occur after the read operations have completed.  
  
## Next Steps  
 Explore other query options by reviewing the query operators available in [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md), and also review the [ADO.NET Entity Framework](assetId:///a437041f-6899-4ae7-96ce-aabf528d7205) to understand what functionality is available to you when you use this type provider.  
  
## See Also  
 [Type Providers](../vs140/type-providers.md)   
 [SqlEntityConnection Type Provider (F#)](../vs140/sqlentityconnection-type-provider--fsharp-.md)   
 [How To: Generate F# Types from an EDMX Schema File (F#)](../vs140/walkthrough--generating-fsharp-types-from-an-edmx-schema-file--fsharp-.md)   
 [ADO.NET Entity Framework](assetId:///a437041f-6899-4ae7-96ce-aabf528d7205)   
 [.edmx File Overview](assetId:///f4c8e7ce-1db6-417e-9759-15f8b55155d4)   
 [Edm Generator (EdmGen.exe)](assetId:///fe8297a1-1fc3-48ce-8eeb-f70f63f857aa)