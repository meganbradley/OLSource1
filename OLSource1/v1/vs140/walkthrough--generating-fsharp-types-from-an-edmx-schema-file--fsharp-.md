---
title: "Walkthrough: Generating F# Types from an EDMX Schema File (F#)"
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
  - "EDMX, accessing with F# type providers"
  - "type providers [F#], accessing EDMX data"
ms.assetid: c732d374-a780-459a-ad4d-b13b348c19cf
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Generating F# Types from an EDMX Schema File (F#)
This walkthrough for F# 3.0 shows you how to create types for data that is represented by the Entity Data Model (EDM), the schema for which is specified in an .edmx file. This walkthrough also shows how to use the EdmxFile type provider. Before you begin, consider whether a SqlEntityConnection type provider is a more appropriate type provider option. The SqlEntityConnection type provider works best for scenarios where you have a live database that you can connect to during the development phase of your project, and you do not mind specifying the connection string at compile time. However, this type provider is also limited in that it doesn't expose as much database functionality as the EdmxFile type provider. Also, if you don't have a live database connection for a database project that uses the Entity Data Model, you can use the .edmx file to code against the database. When you use the EdmxFile type provider, the F# compiler runs EdmGen.exe to generate the types that it provides.  
  
 This walkthrough illustrates the following tasks, which you must perform in this order for the walkthrough to succeed:  
  
-   [Creating an EDMX file](#BKMK_CreateEDMXfile)  
  
-   [Creating the project](#BKMK_CreateSetUpFSProj)  
  
-   [Finding or creating the entity data model connection string](#BKMK_FindEntDatModstring)  
  
-   [Configuring the type provider](#BKMK_ConfigTypeProv)  
  
-   [Querying the data](#BKMK_QueryData)  
  
-   [Calling a stored procedure](#BKMK_StoredProc)  
  
## Prerequisites  
  
##  <a name="BKMK_CreateEDMXfile"></a> Creating an EDMX file  
 If you already have an EDMX file, you can skip this step.  
  
#### To create an EDMX file  
  
-   If you don't already have an EDMX file, you can follow the instructions at the end of this walkthrough in the step [To configure the Entity Data Model](#BKMK_ConfigEDM).  
  
##  <a name="BKMK_CreateSetUpFSProj"></a> Creating the project  
 In this step, you create a project and add appropriate references to it to use the EDMX type provider.  
  
#### To create and set up an F# project  
  
1.  Close the previous project, create another project, and name it SchoolEDM.  
  
2.  In **Solution Explorer**, open the shortcut menu for **References**, and then choose **Add Reference**.  
  
3.  In the **Assemblies** area, choose the **Framework** node.  
  
4.  In the list of available assemblies, choose the `System.Data.Entity` and `System.Data.Linq` assemblies, and then choose the **Add** button to add references to these assemblies to your project.  
  
5.  In the **Assemblies** area, select the **Extensions** node.  
  
6.  In the  list of available extensions, add a reference to the FSharp.Data.TypeProviders assembly.  
  
7.  Add the following code to open the appropriate namespaces.  
  
    ```  
    open System.Data.Linq  
    open System.Data.Entity  
    open Microsoft.FSharp.Data.TypeProviders  
    ```  
  
##  <a name="BKMK_FindEntDatModstring"></a> Finding or creating the connection string for the Entity Data Model  
 The connection string for the Entity Data Model (EDMX connection string) includes not only the connection string for the database provider but also additional information. For example, EDMX connection string for a simple SQL Server database resembles the following code.  
  
```f#  
let edmConnectionString = "metadata=res://*/;provider=System.Data.SqlClient;Provider Connection String='Server=SERVER\Instance;Initial Catalog=DatabaseName;Integrated Security=SSPI;'"  
```  
  
 For more information about EDMX connection strings, see [Connection Strings](assetId:///78d516bc-c99f-4865-8ff1-d856bc1a01c0).  
  
#### To find or create the connection string for the Entity Data Model  
  
1.  EDMX connection strings can be difficult to generate by hand, so you can save time by generating it programmatically. If you know your EDMX connection string, you can bypass this step and simply use that string in the next step. If not, use the following code to generate the EDMX connection string from a database connection string that you provide.  
  
    ```  
    open System  
    open System.Data  
    open System.Data.SqlClient  
    open System.Data.EntityClient  
    open System.Data.Metadata.Edm  
  
    let getEDMConnectionString(dbConnectionString) =  
        let dbConnection = new SqlConnection(connectionString)  
        let resourceArray = [| "res://*/" |]  
        let assemblyList = [| System.Reflection.Assembly.GetCallingAssembly() |]  
        let metaData = MetadataWorkspace(resourceArray, assemblyList)  
        new EntityConnection(metaData, dbConnection)  
  
    ```  
  
##  <a name="BKMK_ConfigTypeProv"></a> Configuring the type provider  
 In this step, you create and configure the type provider with the EDMX connection string, and you generate types for the schema that's defined in the .edmx file.  
  
#### To configure the type provider and generate types  
  
1.  Copy the .edmx file that you generated in the first step of this walkthrough to your project folder.  
  
2.  Open the shortcut menu for the project node in your F# project, choose **Add Existing Item**, and then choose the .edmx file to add it to your project.  
  
3.  Enter the following code to activate the type provider for your .edmx file. Replace *Server*\\*Instance* with the name of your server that's running SQL Server and the name of your instance, and use the name of your .edmx file from the first step in this walkthrough.  
  
    ```  
    type edmx = EdmxFile<"Model1.edmx", ResolutionFolder = @"<folder that contains your .edmx file>>  
  
    let edmConnectionString =  
        getEDMConnectionString("Data Source=SERVER\instance;Initial Catalog=School;Integrated Security=true;")  
    let context = new edmx.SchoolModel.SchoolEntities(edmConnectionString)  
    ```  
  
##  <a name="BKMK_QueryData"></a> Querying the data  
 In this step, you use F# query expressions to query the database.  
  
#### To query the data  
  
-   Enter the following code to query the data in the entity data model.  
  
    ```f#  
  
    query { for course in context.Courses do  
            select course }  
    |> Seq.iter (fun course -> printfn "%s" course.Title)  
  
    query { for person in context.Person do  
            select person }  
    |> Seq.iter (fun person -> printfn "%s %s" person.FirstName person.LastName)  
  
    // Add a where clause to filter results  
    query { for course in context.Courses do  
            where (course.DepartmentID = 1)  
            select course)  
    |> Seq.iter (fun course -> printfn "%s" course.Title)  
  
    // Join two tables  
    query { for course in context.Courses do  
            join (for dept in context.Departments -> course.DepartmentID = dept.DepartmentID)  
            select (course, dept.Name) }  
    |> Seq.iter (fun (course, deptName) -> printfn "%s %s" course.Title deptName)  
  
    ```  
  
##  <a name="BKMK_StoredProc"></a> Calling a stored procedure  
 You can call stored procedures by using the EDMX type provider. In the following procedure, the School database contains a stored procedure, `UpdatePerson`, which updates a record, given new values for the columns. You can use this stored procedure because it's exposed as a method on the DataContext type.  
  
###  <a name="BKMK_CallStoredProc"></a> To call a stored procedure  
  
-   Add the following code to update records.  
  
    ```f#  
    // Call a stored procedure.  
    let nullable value = new System.Nullable<_>(value)  
  
    // Assume now that you must correct someone's hire date.  
    // Throw an exception if more than one matching person is found.  
    let changeHireDate(lastName, firstName, hireDate) =  
  
        query { for person in context.People do  
                where (person.LastName = lastName &&  
                       person.FirstName = firstName)  
                exactlyOne }  
        |> (fun person ->  
                context.UpdatePerson(nullable person.PersonID, person.LastName,  
                    person.FirstName, nullable hireDate, person.EnrollmentDate))  
  
    changeHireDate("Abercrombie", "Kim", DateTime.Parse("1/12/1998"))  
    |> printfn "Result: %d"  
  
    ```  
  
     The result is 1 if you succeed. Notice that `exactlyOne` is used in the query expression to ensure that only one result is returned; otherwise, an exception is thrown. Also, to work with nullable values more easily, you can use the simple `nullable` function that's defined in this code to create a nullable value out of an ordinary value.  
  
##  <a name="BKMK_ConfigEDM"></a> Configuring the Entity Data Model  
 You should complete this procedure only if you want to know how to generate a full Entity Data Model from a database and you don't have a database with which to test.  
  
#### To configure the Entity Data Model  
  
1.  On the menu bar, choose **SQL**, **Transact-SQL Editor**, **New Query** to create a database. If prompted, specify your database server and instance.  
  
2.  Copy and paste the contents of the database script that creates the Student database, as described in the [Entity Framework documentation](http://msdn.microsoft.com/data/JJ614587.aspx) in the Data Developer Center.  
  
3.  Run the SQL script by choosing the toolbar button with the triangle symbol or choosing the Ctrl+Q keys.  
  
4.  In **Server Explorer**, open the shortcut menu for **Data Connections**, choose **Add Connection**, and then enter the name of the database server, the name of the instance name, and the School database.  
  
5.  Create a C# or Visual Basic Console Application project, open its shortcut menu, choose **Add New Item**, and then choose **ADO.NET Entity Data Model**.  
  
     The Entity Data Model Wizard opens. By using this wizard, you can choose how you want to create the Entity Data Model.  
  
6.  Under **Choose Model Contents**, select the **Generate from database** check box.  
  
7.  On the next page, choose your newly created School database as the data connection.  
  
     This connection should resemble `<servername>.<instancename>.School.dbo`.  
  
8.  Copy your entity connection string to the Clipboard because that string might be important later.  
  
9. Make sure the check box to save the entity connection string to the `App.Config` file is selected, and make note of the string value in the text box, which should help you locate the connection string later, if needed.  
  
10. On the next pagechoose **Tables** and **Stored Procedures and Functions**.  
  
     By choosing these top-level nodes, you choose all tables, stored procedures, and functions. You can also choose these individually, if you want.  
  
11. Make sure that the check boxes for the other settings are selected.  
  
     The first **Pluralize or singularize generated object names** check box indicates whether to change singular forms to plural to match conventions in naming objects that represent database tables. The **Include foreign key columns in the model** check box determines whether to include fields for which the purpose is to join to other fields in the object types that are generated for the database schema. The third check box indicates whether to include stored procedures and functions in the model.  
  
12. Select the **Finish** button to generate an .edmx file that contains an Entity Data Model that's based on the School database.  
  
     A file, `Model1.edmx`, is added to your project, and a database diagram appears.  
  
13. On the menu bar, choose **View**, **Other Windows**, **Entity Data Model Browser** to view all the details of the model or **Entity Data Model Mapping Details** to open a window that shows how the generated object model maps onto database tables and columns.  
  
## Next Steps  
 Explore other queries by looking at the available query operators as listed in [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md).  
  
## See Also  
 [Type Providers](../vs140/type-providers.md)   
 [EdmxFile Type Provider (F#)](../vs140/edmxfile-type-provider--fsharp-.md)   
 [How To: Access Typed Data from the Entity Data Model (F#)](../vs140/walkthrough--accessing-a-sql-database-by-using-type-providers-and-entities--fsharp-.md)   
 [Entity Framework](http://msdn.microsoft.com/data/ef)   
 [.edmx File Overview](assetId:///f4c8e7ce-1db6-417e-9759-15f8b55155d4)   
 [Edm Generator (EdmGen.exe)](assetId:///fe8297a1-1fc3-48ce-8eeb-f70f63f857aa)