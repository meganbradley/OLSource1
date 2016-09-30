---
title: "Walkthrough: Accessing a SQL Database by Using Type Providers (F#)"
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
  - "SqlDataConnection type provider [F#]"
  - "type providers [F#], accessing SQL databases"
ms.assetid: 284a8d36-231d-4e6d-911d-956ffd8eeab3
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Accessing a SQL Database by Using Type Providers (F#)
This walkthrough explains how to use the SqlDataConnection (LINQ to SQL) type provider that is available in F# 3.0 to generate types for data in a SQL database when you have a live connection to a database. If you do not have a live connection to a database, but you do have a LINQ to SQL schema file (DBML file), see [How To: Generate F# Types from a DBML File (F#)](../vs140/walkthrough--generating-fsharp-types-from-a-dbml-file--fsharp-.md).  
  
 This walkthrough illustrates the following tasks. These tasks must be performed in this order for the walkthrough to succeed:  
  
-   [Preparing a test database](#BKMK_PrepareTestDB)  
  
-   [Creating the project](#BKMK_CreateSetUpProj)  
  
-   [Setting up a type provider](#BKMK_SetUpTypeProv)  
  
-   [Querying the data](#BKMK_QueryData)  
  
-   [Working with nullable fields](#BKMK_WorkwithNullableFields)  
  
-   [Calling a stored procedure](#BKMK_CallStoredProc)  
  
-   [Updating the database](#BKMK_UpdateDB)  
  
-   [Executing Transact-SQL code](#BKMK_CustomSQL)  
  
-   [Using the full data context](#BKMK_UseFullDataContext)  
  
-   [Deleting data](#BKMK_DeleteRows)  
  
-   [Create a test database (as needed)](#BKMK_MyDBCreateScript)  
  
##  \<a name="BKMK_PrepareTestDB">\</a> Preparing a Test Database  
 On a server that's running SQL Server, create a database for testing purposes. You can use the database create script at the bottom of this page in the section [MyDatabase Create Script](#BKMK_MyDBCreateScript) to do this.  
  
#### To prepare a test database  
  
-   To run the [MyDatabase Create Script](#BKMK_MyDBCreateScript), open the **View** menu, and then choose **SQL Server Object Explorer** or choose the Ctrl+\\, Ctrl+S keys. In **SQL Server Object Explorer** window, open the shortcut menu for the appropriate instance, choose **New Query**, copy the script at the bottom of this page, and then paste the script into the editor. To run the SQL script, choose the toolbar icon with the triangular symbol, or choose the Ctrl+Q keys. For more information about **SQL Server Object Explorer**, see [Connected Database Development](http://go.microsoft.com/fwlink/?LinkId=237128).  
  
##  \<a name="BKMK_CreateSetUpProj">\</a> Creating the project  
 Next, you create an F# application project.  
  
#### To create and set up the project  
  
1.  Create a new F# Application project.  
  
2.  Add references to [.FSharp.Data.TypeProviders](../vs140/microsoft.fsharp.data.typeproviders-namespace--fsharp-.md), as well as \<xref:System.Data*>, and \<xref:System.Data.Linq*>.  
  
3.  Open the appropriate namespaces by adding the following lines of code to the top of your F# code file Program.fs.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  As with most F# programs, you can execute the code in this walkthrough as a compiled program, or you can run it interactively as a script. If you prefer to use scripts, open the shortcut menu for the project node, select **Add New Item**, add an F# script file, and add the code in each step to the script. You will need to add the following lines at the top of the file to load the assembly references.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     You can then select each block of code as you add it and press Alt+Enter to run it in F# Interactive.  
  
##  \<a name="BKMK_SetUpTypeProv">\</a> Setting up a type provider  
 In this step, you create a type provider for your database schema.  
  
#### To set up the type provider from a direct database connection  
  
-   There are two critical lines of code that you need in order to create the types that you can use to query a SQL database using the type provider. First, you instantiate the type provider. To do this, create what looks like a type abbreviation for a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with a static generic parameter. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a SQL type provider, and should not be confused with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type that is used in ADO.NET programming. If you have a database that you want to connect to, and have a connection string, use the following code to invoke the type provider. Substitute your own connection string for the example string given. For example, if your server is MYSERVER and the database instance is INSTANCE, the database name is MyDatabase, and you want to use Windows Authentication to access the database, then the connection string would be as given in the following example code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Now you have a type, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, which is a parent type that contains all the generated types that represent database tables. You also have an object, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, which has as its members all the tables in the database. The table names are properties, and the type of these properties is generated by the F# compiler. The types themselves appear as nested types under <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Therefore, any data retrieved for rows of these tables is an instance of the appropriate type that was generated for that table. The name of the type is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
     To familiarize yourself with how the F# language interprets queries into SQL queries, review the line that sets the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> property on the data context.  
  
     To further explore the types created by the type provider, add the following code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Hover over <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to see its type. Its type is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and the generic argument implies that the type of each row is the generated type, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. The compiler creates a similar type for each table in the database.  
  
##  \<a name="BKMK_QueryData">\</a> Querying the data  
 In this step, you write a query using F# query expressions.  
  
#### To query the data  
  
1.  Now create a query for that table in the database. Add the following code.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     The appearance of the word <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> indicates that this is a query expression, a type of computation expression that generates a collection of results similar of a typical database query. If you hover over query, you will see that it is an instance of [Linq.QueryBuilder Class (F#)](../vs140/linq.querybuilder-class--fsharp-.md), a type that defines the query computation expression. If you hover over <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, you will see that it is an instance of <xref:System.Linq.IQueryable<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>1*> represents data that may be queried, not the result of a query. A query is subject to lazy evaluation, which means that the database is only queried when the query is evaluated. The final line passes the query through <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. Queries are enumerable and may be iterated like sequences. For more information, see [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md).  
  
2.  Now add a query operator to the query. There are a number of query operators available that you can use to construct more complex queries. This example also shows that you can eliminate the query variable and use a pipeline operator instead.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  Add a more complex query with a join of two tables.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
4.  In real-world code, the parameters in your query are usually values or variables, not compile-time constants. Add the following code that wraps a query in a function that takes a parameter, and then calls that function with the value 10.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="BKMK_WorkwithNullableFields">\</a> Working with nullable fields  
 In databases, fields often allow null values. In the .NET type system, you cannot use the ordinary numerical data types for data that allows nulls because those types do not have null as a possible value. Therefore, these values are represented by instances of <xref:System.Nullable<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>1.Value*> property to access the underlying value of a nullable type. The <xref:System.Nullable<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>1.HasValue*> Boolean method to determine if a value exists, or use <xref:System.Nullable<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>1.GetValueOrDefault*> and there is a null in the database, then it is replaced with a value such as an empty string for string types, 0 for integral types or 0.0 for floating point types.  
  
 When you need to perform equality tests or comparisons on nullable values in a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> clause in a query, you can use the nullable operators found in the [Linq.NullableOperators Module (F#)](../vs140/linq.nullableoperators-module--fsharp-.md). These are like the regular comparison operators <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, and so on, except that a question mark appears on the left or right of the operator where the nullable values are. For example, the operator <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is a greater-than operator with a nullable value on the right. The way these operators work is that if either side of the expression is null, the expression evaluates to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. In a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> clause, this generally means that the rows that contain null fields are not selected and not returned in the query results.  
  
#### To work with nullable fields  
  
1.  The following code shows working with nullable values; assume that <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is an integer field that allows nulls.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="BKMK_CallStoredProc">\</a> Calling a stored procedure  
 Any stored procedures on the database can be called from F#. You must set the static parameter <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> in the type provider instantiation. The type provider <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> contains several static methods that you can use to configure the types that are generated. For a complete description of these, see [SqlDataConnection Type Provider (F#)](../vs140/sqldataconnection-type-provider--fsharp-.md). A method on the data context type is generated for each stored procedure.  
  
#### To call a stored procedure  
  
-   If the stored procedures takes parameters that are nullable, you need to pass an appropriate <xref:System.Nullable<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>1*>, which contains properties that enable you to access the returned data. The type argument for <xref:System.Data.Linq.ISingleResult<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>Procedure1<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>Procedure1Result<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>Procedure1Result<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>Procedure1<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>TestData1<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>1.InsertOnSubmit*> to specify the new row to add. If you are inserting multiple rows, you should put them into a collection and call <xref:System.Data.Linq.Table<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>DataContext<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>GetDataContext<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>ServiceTypes<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>DataContext<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>Connection<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>1*> class. Then write a query to find all the rows that you want to delete, and pipe the results of the query into the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> function. This code takes advantage of the ability to provide partial application of function arguments.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="BKMK_MyDBCreateScript">\</a> Creating a test database  
 This section shows you how to set up the test database to use in this walkthrough.  
  
 Note that if you alter the database in some way, you will have to reset the type provider. To reset the type provider, rebuild or clean the project that contains the type provider.  
  
#### To create the test database  
  
1.  In **Server Explorer**, open the shortcut menu for the **Data Connections** node, and choose **Add Connection**. The **Add Connection** dialog box appears.  
  
2.  In the **Server name** box, specify the name of an instance of SQL Server that you have administrative access to, or if you do not have access to a server, specify (localdb\v11.0). SQL Express LocalDB provides a lightweight database server for development and testing on your machine. A new node is created in **Server Explorer** under **Data Connections**. For more information about LocalDB, see [Walkthrough: Creating a SQL Server Express LocalDB Database](assetId:///99c2b06f-47aa-414e-8057-a3453712fd23).  
  
3.  Open the shortcut menu for the new connection node, and select **New Query**.  
  
4.  
  
5.  Copy the following SQL script, paste it into the query editor, and then choose the **Execute** button on the toolbar or choose the Ctrl+Shift+E keys.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
## Compiling the Code  
  
-  
  
## Robust Programming  
  
## .NET Framework Security  
  
## See Also  
 [Type Providers](../vs140/type-providers.md)   
 [SqlDataConnection Type Provider (F#)](../vs140/sqldataconnection-type-provider--fsharp-.md)   
 [How To: Generate F# Types from a DBML File (F#)](../vs140/walkthrough--generating-fsharp-types-from-a-dbml-file--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)   
 [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)   
 [SqlMetal.exe (Code Generation Tool)](assetId:///819e5a96-7646-4fdb-b14b-fe31221b0614)