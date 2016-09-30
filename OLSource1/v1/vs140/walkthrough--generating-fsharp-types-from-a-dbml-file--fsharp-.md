---
title: "Walkthrough: Generating F# Types from a DBML File (F#)"
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
  - "DBML, accessing with F# type providers"
  - "F# type providers, accessing DBML data"
ms.assetid: c9457374-bf60-4687-8af0-d3faa1af030d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Generating F# Types from a DBML File (F#)
This walkthrough for F# 3.0 describes how to create types for data from a database when you have schema information encoded in a .dbml file. LINQ to SQL uses this file format to represent database schema. You can generate a LINQ to SQL schema file in Visual Studio by using the Object Relational (O/R) Designer. For more information, see [O/R Designer Overview](assetId:///a57e82d5-f7e4-4894-8add-3d9ba4fce186) and [Code Generation in LINQ to SQL](assetId:///ddcbdaa1-e7fa-4d85-a379-313b49965c07).  
  
 The Database Markup Language (DBML) type provider allows you to write code that uses types based on a database schema without requiring you to specify a static connection string at compile time. That can be useful if you need to allow for the possibility that the final application will use a different database, different credentials, or a different connection string than the one you use to develop the application. If you have a direct database connection that you can use at compile time and this is the same database and credentials that you will eventually use in your built application, you can also use the SQLDataConnection type provider. For more information, see [How To: Access a SQL Database by Using Type Providers (F#)](../vs140/walkthrough--accessing-a-sql-database-by-using-type-providers--fsharp-.md).  
  
 This walkthrough illustrates the following tasks. They should be completed in this order for the walkthrough to succeed:  
  
-   [Creating a .dbml file](#BKMK_CreateADBMLFile)  
  
-   [Creating and setting up an F# project](#BKMK_CreateSetUpFSproj)  
  
-   [Configuring the type provider and generating the types](#BKMK_ConfigTypeProv)  
  
-   [Querying the database](#BKMK_QueryData)  
  
## Prerequisites  
  
##  \<a name="BKMK_CreateADBMLFile">\</a> Creating a .dbml file  
 If you do not have a database to test on, create one by following the instructions at the bottom of [How To: Access a SQL Database by Using Type Providers (F#)](../vs140/walkthrough--accessing-a-sql-database-by-using-type-providers--fsharp-.md). If you follow these instructions, you will create a database called MyDatabase that contains a few simple tables and stored procedures on your SQL Server.  
  
 If you already have a .dbml file, you can skip to the section, [Create and Set Up an F# Project](#BKMK_CreateSetUpFSproj). Otherwise, you can create a .dbml file given an existing SQL database and by using the command-line tool SqlMetal.exe.  
  
#### To create a .dbml file by using SqlMetal.exe  
  
1.  Open a **Developer Command Prompt**.  
  
2.  Ensure that you have access to SqlMetal.exe by entering <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> at the command prompt. SqlMetal.exe is typically installed under the **Microsoft SDKs** folder in **Program Files** or **Program Files (x86)**.  
  
3.  Run SqlMetal.exe with the following command-line options. Substitute an appropriate path in place of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to create the .dbml file, and insert appropriate values for the database server, instance name, and database name.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  If SqlMetal.exe has trouble creating the file due to permissions issues, change the current directory to a folder that you have write access to.  
  
4.  You can also look at the other available command-line options. For example, there are options you can use if you want views and SQL functions included in the generated types. For more information, see [SqlMetal.exe (Code Generation Tool)](assetId:///819e5a96-7646-4fdb-b14b-fe31221b0614).  
  
##  \<a name="BKMK_CreateSetUpFSproj">\</a> Creating and setting up an F# project  
 In this step, you create a project and add appropriate references to use the DBML type provider.  
  
#### To create and set up an F# project  
  
1.  Add a new F# Console Application project to your solution.  
  
2.  In **Solution Explorer**, open the shortcut menu for **References**, and then choose **Add Reference**.  
  
3.  In the **Assemblies** area, choose the **Framework** node, and then, in the list of available assemblies, choose the \<xref:System.Data*> and \<xref:System.Data.Linq*> assemblies.  
  
4.  In the **Assemblies** area, choose **Extensions**, and then, in the list of available assemblies, choose <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
5.  Choose the **OK** button to add references to these assemblies to your project.  
  
6.  (Optional). Copy the .dbml file that you created in the previous step, and paste the file in the main folder for your project. This folder contains the project file (.fsproj) and code files. On the menu bar, choose **Project**, **Add Existing Item**, and then specify the .dbml file to add it to your project. If you complete these steps, you can omit the ResolutionFolder static parameter in the next step.  
  
##  \<a name="BKMK_ConfigTypeProv">\</a> Configuring the type provider  
 In this section, you create a type provider and generate types from the schema that’s described in the .dbml file.  
  
#### To configure the type provider and generate the types  
  
-   Add code that opens the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> namespace and instantiates the type provider for the .dbml file that you want to use. If you added the .dbml file to your project, you can omit the ResolutionFolder static parameter.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The DataContext type provides access to all the generated types and inherits from \<xref:System.Data.Linq.DataContext*>. The DbmlFile type provider has various static parameters that you can set. For example, you can use a different name for the DataContext type by specifying <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. In that case, your code resembles the following example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="BKMK_QueryData">\</a> Querying the database  
 In this section, you use F# query expressions to query the database.  
  
#### To query the data  
  
-   Add code to query the database.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Next Steps  
 You can proceed to use other query expressions, or get a database connection from the data context and perform normal ADO.NET data operations. For additional steps, see the sections after "Query the Data" in [How To: Access a SQL Database by Using Type Providers (F#)](../vs140/walkthrough--accessing-a-sql-database-by-using-type-providers--fsharp-.md).  
  
## See Also  
 [DbmlFile Type Provider (F#)](../vs140/dbmlfile-type-provider--fsharp-.md)   
 [Type Providers](../vs140/type-providers.md)   
 [How To: Access a SQL Database by Using Type Providers (F#)](../vs140/walkthrough--accessing-a-sql-database-by-using-type-providers--fsharp-.md)   
 [SqlMetal.exe (Code Generation Tool)](assetId:///819e5a96-7646-4fdb-b14b-fe31221b0614)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)