---
title: Parameters and Return Codes in the Execute SQL Task
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a3ca65e8-65cf-4272-9a81-765a706b8663
---
# Parameters and Return Codes in the Execute SQL Task
  SQL statements and stored procedures frequently use **input** parameters, **output** parameters, and return codes. In [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)], the Execute SQL task supports the **Input**, **Output**, and **ReturnValue** parameter types. You use the **Input** type for input parameters, **Output** for output parameters, and **ReturnValue** for return codes.  
  
> [!NOTE]  
>  You can use parameters in an Execute SQL task only if the data provider supports them.  
  
 Parameters in SQL commands, including queries and stored procedures, are mapped to user\-defined variables that are created within the scope of the Execute SQL task, a parent container, or within the scope of the package. The values of variables can be set at design time or populated dynamically at run time. You can also map parameters to system variables. For more information, see [Integration Services &#40;SSIS&#41; Variables](../Topic/Integration%20Services%20\(SSIS\)%20Variables.md) and [System Variables](../../Topics\TopicNameNotContainA/System-Variables.md).  
  
 However, working with parameters and return codes in an Execute SQL task is more than just knowing what parameter types the task supports and how these parameters will be mapped. There are additional usage requirements and guidelines to successfully use parameters and return codes in the Execute SQL task. The remainder of this topic covers these usage requirements and guidelines:  
  
-   [Using parameters names and markers](#Parameter_names_and_markers)  
  
-   [Using parameters with date and time data types](#Date_and_time_data_types)  
  
-   [Using parameters in WHERE clauses](#WHERE_clauses)  
  
-   [Using parameters with stored procedures](#Stored_procedures)  
  
-   [Getting values of return codes](#Return_codes)  
  
-   [Configuring parameters and return codes in the Execute SQL Task Editor](#Configure_parameters_and_return_codes)  
  
##  <a name="Parameter_names_and_markers"></a> Using Parameter Names and Markers  
 Depending on the connection type that the Execute SQL task uses, the syntax of the SQL command uses different parameter markers. For example, the [!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)] connection manager type requires that the SQL command uses a parameter marker in the format **@varParameter**, whereas OLE DB connection type requires the question mark \(?\) parameter marker.  
  
 The names that you can use as parameter names in the mappings between variables and parameters also vary by connection manager type. For example, the [!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)] connection manager type uses a user\-defined name with a @ prefix, whereas the OLE DB connection manager type requires that you use the numeric value of a 0\-based ordinal as the parameter name.  
  
 The following table summarizes the requirements for SQL commands for the connection manager types that the Execute SQL task can use.  
  
|Connection type|Parameter marker|Parameter name|Example SQL command|  
|---------------------|----------------------|--------------------|-------------------------|  
|ADO|?|Param1, Param2, …|SELECT FirstName, LastName, Title FROM Person.Contact WHERE ContactID \= ?|  
|[!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)]|@\<parameter name\>|@\<parameter name\>|SELECT FirstName, LastName, Title FROM Person.Contact WHERE ContactID \= @parmContactID|  
|ODBC|?|1, 2, 3, …|SELECT FirstName, LastName, Title FROM Person.Contact WHERE ContactID \= ?|  
|EXCEL and OLE DB|?|0, 1, 2, 3, …|SELECT FirstName, LastName, Title FROM Person.Contact WHERE ContactID \= ?|  
  
### Using Parameters with ADO.NET and ADO Connection Managers  
 [!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)] and ADO connection managers have specific requirements for SQL commands that use parameters:  
  
-   [!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)] connection managers require that the SQL command use parameter names as parameter markers. This means that variables can be mapped directly to parameters. For example, the variable `@varName` is mapped to the parameter named `@parName` and provides a value to the parameter `@parName`.  
  
-   ADO connection managers require that the SQL command use question marks \(?\) as parameter markers. However, you can use any user\-defined name, except for integer values, as parameter names.  
  
 To provide values to parameters, variables are mapped to parameter names. Then, the Execute SQL task uses the ordinal value of the parameter name in the parameter list to load values from variables to parameters.  
  
### Using Parameters with EXCEL, ODBC, and OLE DB Connection Managers  
 EXCEL, ODBC, and OLE DB connection managers require that the SQL command use question marks \(?\) as parameter markers and 0\-based or 1\-based numeric values as parameter names. If the Execute SQL task uses the ODBC connection manager, the parameter name that maps to the first parameter in the query is named 1; otherwise, the parameter is named 0. For subsequent parameters, the numeric value of the parameter name indicates the parameter in the SQL command that the parameter name maps to. For example, the parameter named 3 maps to the third parameter, which is represented by the third question mark \(?\) in the SQL command.  
  
 To provide values to parameters, variables are mapped to parameter names and the Execute SQL task uses the ordinal value of the parameter name to load values from variables to parameters.  
  
 Depending on the provider that the connection manager uses, some OLE DB data types may not be supported. For example, the Excel driver recognizes only a limited set of data types. For more information about the behavior of the Jet provider with the Excel driver, see [Excel Source](../../Topics\TopicNameNotContainA/Excel-Source.md).  
  
#### Using Parameters with OLE DB Connection Managers  
 When the Execute SQL task uses the OLE DB connection manager, the BypassPrepare property of the task is available. You should set this property to **true** if the Execute SQL task uses SQL statements with parameters.  
  
 When you use an OLE DB connection manager, you cannot use parameterized subqueries because the Execute SQL Task cannot derive parameter information through the OLE DB provider. However, you can use an expression to concatenate the parameter values into the query string and to set the SqlStatementSource property of the task.  
  
##  <a name="Date_and_time_data_types"></a> Using Parameters with Date and Time Data Types  
  
### Using Date and Time Parameters with ADO.NET and ADO Connection Managers  
 When reading data of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] types, **time** and **datetimeoffset**, an Execute SQL task that uses either an [!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)] or ADO connection manager has the following additional requirements:  
  
-   For **time** data, an [!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)] connection manager requires this data to be stored in a parameter whose parameter type is **Input** or **Output**, and whose data type is **string**.  
  
-   For **datetimeoffset** data, an [!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)] connection manager requires this data to be stored in one of the following parameters:  
  
    -   A parameter whose parameter type is **Input** and whose data type is **string**.  
  
    -   A parameter whose parameter type is **Output** or **ReturnValue**, and whose data type is **datetimeoffset**, **string**, or **datetime2**. If you select a parameter whose data type is either **string** or **datetime2**, [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] converts the data to either string or datetime2.  
  
-   An ADO connection manager requires that either **time** or **datetimeoffset** data be stored in a parameter whose parameter type is **Input** or **Output**, and whose data type is **adVarWchar**.  
  
 For more information about [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] data types and how they map to [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] data types, see [Data Types &#40;Transact-SQL&#41;](../Topic/Data%20Types%20\(Transact-SQL\).md) and [Integration Services Data Types](../../Topics\TopicNameNotContainA/Integration-Services-Data-Types.md).  
  
### Using Date and Time Parameters with OLE DB Connection Managers  
 When using an OLE DB connection manager, an Execute SQL task has specific storage requirements for data of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] data types, **date**, **time**, **datetime**, **datetime2**, and **datetimeoffset**. You must store this data in one of the following parameter types:  
  
-   An input parameter of the NVARCHAR data type.  
  
-   An output parameter of with the appropriate data type, as listed in the following table.  
  
    |**Output** parameter type|Date data type|  
    |-------------------------------|--------------------|  
    |DBDATE|**date**|  
    |DBTIME2|**time**|  
    |DBTIMESTAMP|**datetime**, **datetime2**|  
    |DBTIMESTAMPOFFSET|**datetimeoffset**|  
  
 If the data is not stored in the appropriate input or output parameter, the package fails.  
  
### Using Date and Time Parameters with ODBC Connection Managers  
 When using an ODBC connection manager, an Execute SQL task has specific storage requirements for data with one of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] data types, **date**, **time**, **datetime**, **datetime2**, or **datetimeoffset**. You must store this data in one of the following parameter types:  
  
-   An **input** parameter of the SQL\_WVARCHAR data type  
  
-   An **output** parameter with the appropriate data type, as listed in the following table.  
  
    |**Output** parameter type|Date data type|  
    |-------------------------------|--------------------|  
    |SQL\_DATE|**date**|  
    |SQL\_SS\_TIME2|**time**|  
    |SQL\_TYPE\_TIMESTAMP<br /><br /> \-or\-<br /><br /> SQL\_TIMESTAMP|**datetime**, **datetime2**|  
    |SQL\_SS\_TIMESTAMPOFFSET|**datetimeoffset**|  
  
 If the data is not stored in the appropriate input or output parameter, the package fails.  
  
##  <a name="WHERE_clauses"></a> Using Parameters in WHERE Clauses  
 SELECT, INSERT, UPDATE, and DELETE commands frequently include WHERE clauses to specify filters that define the conditions each row in the source tables must meet to qualify for an SQL command. Parameters provide the filter values in the WHERE clauses.  
  
 You can use parameter markers to dynamically provide parameter values. The rules for which parameter markers and parameter names can be used in the SQL statement depend on the type of connection manager that the Execute SQL uses.  
  
 The following table lists examples of the SELECT command by connection manager type. The INSERT, UPDATE, and DELETE statements are similar. The examples use SELECT to return products from the **Product** table in [!INCLUDE[ssSampleDBUserInputNonLocal](../../Token\Other/ssSampleDBUserInputNonLocal_md.md)] that have a **ProductID** greater than and less than the values specified by two parameters.  
  
|Connection type|SELECT syntax|  
|---------------------|-------------------|  
|EXCEL, ODBC, and OLEDB|`SELECT* FROM Production.Product WHERE ProductId > ? AND ProductID < ?`|  
|ADO|`SELECT* FROM Production.Product WHERE ProductId > ? AND ProductID < ?`|  
|[!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)]|`SELECT* FROM Production.Product WHERE ProductId > @parmMinProductID AND ProductID < @parmMaxProductID`|  
  
 The examples would require parameters that have the following names:  
  
-   The EXCEL and OLED DB connection managers use the parameter names 0 and 1. The ODBC connection type uses 1 and 2.  
  
-   The ADO connection type could use any two parameter names, such as Param1 and Param2, but the parameters must be mapped by their ordinal position in the parameter list.  
  
-   The [!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)] connection type uses the parameter names @parmMinProductID and @parmMaxProductID.  
  
##  <a name="Stored_procedures"></a> Using Parameters with Stored Procedures  
 SQL commands that run stored procedures can also use parameter mapping. The rules for how to use parameter markers and parameter names depends on the type of connection manager that the Execute SQL uses, just like the rules for parameterized queries.  
  
 The following table lists examples of the EXEC command by connection manager type. The examples run the **uspGetBillOfMaterials** stored procedure in [!INCLUDE[ssSampleDBUserInputNonLocal](../../Token\Other/ssSampleDBUserInputNonLocal_md.md)]. The stored procedure uses the `@StartProductID` and `@CheckDate` **input** parameters.  
  
|Connection type|EXEC syntax|  
|---------------------|-----------------|  
|EXCEL and OLEDB|`EXEC uspGetBillOfMaterials ?, ?`|  
|ODBC|`{call uspGetBillOfMaterials(?, ?)}`<br /><br /> For more information about ODBC call syntax, see the topic, [Procedure Parameters](http://go.microsoft.com/fwlink/?LinkId=89462), in the ODBC Programmer's Reference in the  MSDN Library.|  
|ADO|If IsQueryStoredProcedure is set to **False**, `EXEC uspGetBillOfMaterials ?, ?`<br /><br /> If IsQueryStoredProcedure is set to **True**, `uspGetBillOfMaterials`|  
|[!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)]|If IsQueryStoredProcedure is set to **False**, `EXEC uspGetBillOfMaterials @StartProductID, @CheckDate`<br /><br /> If IsQueryStoredProcedure is set to **True**, `uspGetBillOfMaterials`|  
  
 To use output parameters, the syntax requires that the OUTPUT keyword follow each parameter marker. For example, the following output parameter syntax is correct: `EXEC myStoredProcedure ? OUTPUT`.  
  
 For more information about using input and output parameters with Transact\-SQL stored procedures, see [EXECUTE &#40;Transact-SQL&#41;](../Topic/EXECUTE%20\(Transact-SQL\).md).  
  
##  <a name="Return_codes"></a> Getting Values of Return Codes  
 A stored procedure can return an integer value, called a return code, to indicate the execution status of a procedure. To implement return codes in the Execute SQL task, you use parameters of the **ReturnValue** type.  
  
 The following table lists by connection type some examples of EXEC commands that implement return codes. All examples use an **input** parameter. The rules for how to use parameter markers and parameter names are the same for all parameter types—**Input**, **Output**, and **ReturnValue**.  
  
 Some syntax does not support parameter literals. In that case, you must provide the parameter value by using a variable.  
  
|Connection type|EXEC syntax|  
|---------------------|-----------------|  
|EXCEL and OLEDB|`EXEC ? = myStoredProcedure 1`|  
|ODBC|`{? = call myStoredProcedure(1)}`<br /><br /> For more information about ODBC call syntax, see the topic, [Procedure Parameters](http://go.microsoft.com/fwlink/?LinkId=89462), in the ODBC Programmer's Reference in the  MSDN Library.|  
|ADO|If IsQueryStoreProcedure is set to **False**, `EXEC ? = myStoredProcedure 1`<br /><br /> If IsQueryStoreProcedure is set to **True**, `myStoredProcedure`|  
|[!INCLUDE[vstecado](../../Token\Other/vstecado_md.md)]|Set IsQueryStoreProcedure is set to **True**.<br /><br /> `myStoredProcedure`|  
  
 In the syntax shown in the previous table, the Execute SQL task uses the **Direct Input** source type to run the stored procedure. The Execute SQL task can also use the **File Connection** source type to run a stored procedure. Regardless of whether the Execute SQL task uses the **Direct Input** or **File Connection** source type, use a parameter of the **ReturnValue** type to implement the return code. For more information about how to configure the source type of the SQL statement that the Execute SQL task runs, see [Execute SQL Task Editor &#40;General Page&#41;](../Topic/Execute%20SQL%20Task%20Editor%20\(General%20Page\).md).  
  
 For more information about using return codes with Transact\-SQL stored procedures, see [RETURN &#40;Transact-SQL&#41;](../Topic/RETURN%20\(Transact-SQL\).md).  
  
##  <a name="Configure_parameters_and_return_codes"></a> Configuring Parameters and Return Codes in the Execute SQL Task  
 For more information about the properties of parameters and return codes that you can set in [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Designer, click the following topic:  
  
-   [Execute SQL Task Editor &#40;Parameter Mapping Page&#41;](../Topic/Execute%20SQL%20Task%20Editor%20\(Parameter%20Mapping%20Page\).md)  
  
 For more information about how to set these properties in [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Designer, click the following topic:  
  
-   [Set the Properties of a Task or Container](../../Topics\TopicNameContainA/Set-the-Properties-of-a-Task-or-Container.md)  
  
## Related Tasks  
 [Set the Properties of a Task or Container](../../Topics\TopicNameContainA/Set-the-Properties-of-a-Task-or-Container.md)  
  
## Related Content  
  
-   Blog entry, [Stored procedures with output parameters](http://go.microsoft.com/fwlink/?LinkId=157786), on blogs.msdn.com  
  
-   CodePlex sample, [Execute SQL Parameters and Result Sets](http://go.microsoft.com/fwlink/?LinkId=157863), on msftisprodsamples.codeplex.com  
  
## See Also  
 [Execute SQL Task](../../Topics\TopicNameNotContainA/Execute-SQL-Task.md)   
 [Result Sets in the Execute SQL Task](../../Topics\TopicNameNotContainA/Result-Sets-in-the-Execute-SQL-Task.md)  
  
  