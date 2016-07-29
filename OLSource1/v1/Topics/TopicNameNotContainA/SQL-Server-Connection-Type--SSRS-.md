---
title: "SQL Server Connection Type (SSRS)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 957e7091-e08f-48d2-9506-872227ae8b20
caps.latest.revision: 9
manager: mblythe
---
# SQL Server Connection Type (SSRS)
To include data from a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] database in your report, you must have a dataset that is based on a report data source of type [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. This built-in data source type is based on the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] data extension. Use this data source type to connect to and retrieve data from the current version and earlier versions of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] databases.  
  
 This data extension supports multivalue parameters, server aggregates, and credentials managed separately from the connection string.  
  
 Use the information in this topic to build a data source. For step-by-step instructions, see [Add and Verify a Data Connection (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-and-Verify-a-Data-Connection--Report-Builder-and-SSRS-.md).  
  
##  <a name="Connection"></a> Connection String  
 When you connect to a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] database, you are connecting to the database object in an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] on a server. The database might have multiple schemas that have multiple tables, views, and stored procedures. You specify the database object to use in the query designer. If you do not specify a database in the connection string, you connect to the default database that the database administrator assigned to you.  
  
 Contact your database administrator for connection information and for the credentials to use to connect to the data source. The following connection string example specifies a sample database on the local client:  
  
```  
Data Source=<server>;Initial Catalog=AdventureWorks  
```  
  
 For more information about connection string examples, see [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md).  
  
##  <a name="Credentials"></a> Credentials  
 Credentials are required to run queries, to preview the report locally, and to preview the report from the report server.  
  
 After you publish your report, you may need to change the credentials for the data source so that when the report runs on the report server, the permissions to retrieve the data are valid.  
  
 From a report authoring client, the following options are available to specify credentials:  
  
-   Current Windows user (also known as integrated security).  
  
-   Use a stored user name and password.  
  
-   Prompt the user for credentials. This option supports Windows integrated security only.  
  
-   No credentials are required. To use this option, you must have the unattended execution account configured on the report server. For more information, see [Configure the Unattended Execution Account (SSRS Configuration Manager)](../../Topics/TopicNameNotContainA/Configure-the-Unattended-Execution-Account--SSRS-Configuration-Manager-.md) in the [Reporting Services documentation](http://go.microsoft.com/fwlink/?linkid=121312) in on msdn.microsoft.com.  
  
 For more information, see [Data Connections, Data Sources, and Connection Strings (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings--Report-Builder-and-SSRS-.md) or [Specify Credentials in Report Builder](../../Topics/TopicNameNotContainA/Specify-Credentials-in-Report-Builder.md).  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="Query"></a> Queries  
 A query specifies which data to retrieve for a report dataset. The columns in the result set for a query populate the field collection for a dataset. A report processes only the first result set that a query retrieves.  
  
 By default, if you create a new query or open an existing query that can be represented in the graphical query designer, the relational query designer is available. You can specify a query in the following ways:  
  
-   Build a query interactively. Use the relational query designer that displays a hierarchical view of tables, views, stored procedures, and other database items, organized by database schema. Select columns from tables or views, or specify stored procedures or table-valued functions. Limit the number of rows of data to retrieve by specifying filter criteria. Customize the filter when the report runs by setting the parameter option.  
  
-   Type or paste a query. Use the text-based query designer to enter [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] text directly, to paste query text from another source, to enter complex queries that cannot be built by using the relational query designer, or to enter query-based expressions.  
  
-   Import an existing query from a file or report. Use the **Import** query button from either query designer to browse to a .sql file or .rdl file and import a query.  
  
 For more information, see [Relational Query Designer User Interface (Report Builder)](../../Topics/TopicNameNotContainA/Relational-Query-Designer-User-Interface--Report-Builder-.md) and [Text-based Query Designer User Interface (Report Builder)](../../Topics/TopicNameNotContainA/Text-based-Query-Designer-User-Interface--Report-Builder-.md).  
  
 The following query modes are supported:  
  
-   [Text](#QueryText) Type in [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] commands.  
  
-   [Stored Procedure](#QueryStoredProcedure) Choose from a list of stored procedures.  
  
###  <a name="QueryText"></a> Using Query Type Text  
 In the text-based query designer, you can type [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] commands to define the data in a dataset. For example, the following [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] query selects the names of all employees who are marketing assistants:  
  
```  
SELECT  
  HumanResources.Employee.BusinessEntityID  
  ,HumanResources.Employee.JobTitle  
  ,Person.Person.FirstName  
  ,Person.Person.LastName  
FROM  
  Person.Person  
  INNER JOIN HumanResources.Employee  
    ON Person.Person.BusinessEntityID = HumanResources.Employee.BusinessEntityID  
WHERE HumanResources.Employee.JobTitle = 'Marketing Assistant'   
```  
  
 Click the **Run** button (**!**) on the toolbar to run the query and display a result set.  
  
 To parameterize this query, add a query parameter. For example, change the WHERE clause to the following:  
  
 `WHERE HumanResources.Employee.JobTitle = (@JobTitle)`  
  
 When you run the query, report parameters that correspond to query parameters are automatically created. For more information, see [Query Parameters](#Parameters) later in this topic.  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
###  <a name="QueryStoredProcedure"></a> Using Query Type StoredProcedure  
 You can specify a stored procedure for a dataset query in one of the following ways:  
  
-   In the **Dataset Properties** dialog box, set the **Stored Procedure** option. Choose from the drop-down list of stored procedures and table-valued functions.  
  
-   In the relational query designer, in the Database view pane, select a stored procedure or table-valued function.  
  
-   In the text-based query designer, select **StoredProcedure** from the toolbar.  
  
 After you select a stored procedure or table-valued function, you can run the query. You will be prompted for input parameter values. When you run the query, report parameters that correspond to input parameters are automatically created. For more information, see [Query Parameters](#Parameters) later in this topic.  
  
 Only the first result set that is retrieved for a stored procedure is supported. If a stored procedure returns multiple result sets, only the first one is used.  
  
 If a stored procedure has a parameter that has a default value, you can access that value by using the DEFAULT keyword as a value for the parameter. If the query parameter is linked to a report parameter, the user can type or select the word DEFAULT in the input box for the report parameter.  
  
 For more information, see "Stored Procedures (Database Engine)" in [SQL Server Books Online](http://go.microsoft.com/fwlink/?linkid=98335) on msdn.microsoft.com.  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="Parameters"></a> Parameters  
 When query text contains query variables or stored procedures that have input parameters, the corresponding query parameters for the dataset and report parameters for the report are automatically generated. The query text must not include the DECLARE statement for each query variable.  
  
 For example, the following SQL query creates a report parameter named **EmpID**:  
  
```  
SELECT FirstName, LastName FROM HumanResources.Employee E INNER JOIN  
       Person.Contact C ON  E.ContactID=C.ContactID   
WHERE EmployeeID = (@EmpID)  
```  
  
 Report parameters are created with default property values that you might need to modify. For example:  
  
-   By default, each report parameter is data type **Text**. If the underlying data is a different data type, you must change the parameter data type.  
  
-   If you select the option for multivalued parameters, you must manually change the query to test whether values are part of a set by using the **IN** operator, for example, `WHERE EmployeeID IN (@EmpID)`.  
  
 For more information, see [Report Parameters (Report Builder and Report Designer)](../../Topics/TopicNameNotContainA/Report-Parameters--Report-Builder-and-Report-Designer-.md).  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="Remarks"></a> Remarks  
 You can also retrieve data from a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] database by using an OLE DB or ODBC data source type. For more information, see [OLE DB Connection Type (SSRS)](../../Topics/TopicNameNotContainA/OLE-DB-Connection-Type--SSRS-.md) or [ODBC Connection Type (SSRS)](../../Topics/TopicNameNotContainA/ODBC-Connection-Type--SSRS-.md).  
  
###### Platform and Version Information  
 For more information about platform and version support, see [Data Sources Supported by Reporting Services (SSRS)](../../Topics/TopicNameNotContainA/Data-Sources-Supported-by-Reporting-Services--SSRS-.md) in the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] documentation in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [Books Online](http://go.microsoft.com/fwlink/?linkid=121312).  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="HowTo"></a> How-To Topics  
 This section contains step-by-step instructions for working with data connections, data sources, and datasets.  
  
 [Add and Verify a Data Connection (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-and-Verify-a-Data-Connection--Report-Builder-and-SSRS-.md)  
  
 [Create a Shared Dataset or Embedded Dataset (Report Builder and SSRS)](../../Topics/TopicNameContainA/Create-a-Shared-Dataset-or-Embedded-Dataset--Report-Builder-and-SSRS-.md)  
  
 [Add a Filter to a Dataset (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Filter-to-a-Dataset--Report-Builder-and-SSRS-.md)  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="Related"></a> Related Sections  
 These sections of the documentation provide in-depth conceptual information about report data, and procedural information about how to define, customize, and use parts of a report that are related to data.  
  
 [Report Datasets (SSRS)](../../Topics/TopicNameNotContainA/Report-Datasets--SSRS-.md)  
 Provides an overview of accessing data for your report.  
  
 [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md)  
 Provides information about data connections and data sources.  
  
 [Report Embedded Datasets and Shared Datasets (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Embedded-Datasets-and-Shared-Datasets--Report-Builder-and-SSRS-.md)  
 Provides information about embedded and shared datasets.  
  
 [Dataset Fields Collection (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Dataset-Fields-Collection--Report-Builder-and-SSRS-.md)  
 Provides information about the dataset field collection generated by the query.  
  
 [Data Sources Supported by Reporting Services (SSRS)](../../Topics/TopicNameNotContainA/Data-Sources-Supported-by-Reporting-Services--SSRS-.md) in the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] documentation in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [Books Online](http://go.microsoft.com/fwlink/?linkid=121312).  
 Provides in-depth information about platform and version support for each data extension.  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
## See Also  
 [Report Parameters (Report Builder and Report Designer)](../../Topics/TopicNameNotContainA/Report-Parameters--Report-Builder-and-Report-Designer-.md)   
 [Filter, Group, and Sort Data (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Filter--Group--and-Sort-Data--Report-Builder-and-SSRS-.md)   
 [Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expressions--Report-Builder-and-SSRS-.md)