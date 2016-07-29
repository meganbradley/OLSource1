---
title: "Multidimensional Model Data Access (Analysis Services - Multidimensional Data)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 46388efb-3c78-47a2-b5c9-5a69ff394d03
caps.latest.revision: 47
manager: mblythe
---
# Multidimensional Model Data Access (Analysis Services - Multidimensional Data)
Use the information in this topic to learn how to access [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] multidimensional data using programmatic methods, script, or client applications that include built-in support for connecting to an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] server on your network.  
  
 This topic contains the following sections:  
  
 [Client Applications](#bkmk_clientapps)  
  
 [Query Languages](#bkmk_querylang)  
  
 [Programmatic Interfaces](#bkmk_api)  
  
##  <a name="bkmk_clientapps"></a> Client Applications  
 Although Analysis Services provides interfaces that let you build or integrate multidimensional databases programmatically, a more common approach is to use existing client applications from Microsoft and other software vendors that have built-in data access to Analysis Services data.  
  
 The following Microsoft applications support native connections to multidimensional data.  
  
### Excel  
 Analysis Services multidimensional data is often presented using pivot tables and pivot chart controls in an Excel workbook. PivotTables are suited to multidimensional data because the hierarchies, aggregations, and navigational constructs in the model pair well with the data summary features of a PivotTable. An Analysis Services OLE DB data provider is included in an Excel installation to make setting up data connections easier. For more information, see [Connect to or import data from SQL Server Analysis Services](http://go.microsoft.com/fwlink/?linkID=215150).  
  
### Reporting Services Reports  
 You can use Report Builder or Report Designer to create reports that consume Analysis Services databases that contain analytical data. Both Report Builder and Report Designer include an MDX query designer that you can use to type or design MDX statements that retrieve data from an available data source. For more information, see [Data Sources Supported by Reporting Services (SSRS)](../../Topics/TopicNameNotContainA/Data-Sources-Supported-by-Reporting-Services--SSRS-.md) and [Analysis Services Connection Type for MDX (SSRS)](../../Topics/TopicNameNotContainA/Analysis-Services-Connection-Type-for-MDX--SSRS-.md).  
  
### PerformancePoint Dashboards  
 PerformancePoint Dashboards are used to create scorecards in SharePoint that communicate business performance against predefined measures. PerformancePoint includes support for data connections to Analysis Services multidimensional data. For more information, [Create an Analysis Services data connection (PerformancePoint Services)](http://go.microsoft.com/fwlink/?linkid=232471).  
  
### SQL Server Data Tools  
 Model and report designers use SQL Server Data Tools to build solutions that include multidimensional models. Deploying the solution to an Analysis Services instance is what creates the database that you subsequently connect to from Excel, Reporting Services, and other business intelligence client applications.  
  
 SQL Server Data Tools is built on a Visual Studio shell and uses projects to organize and contain the model. For more information, see [Creating Multidimensional Models Using SQL Server Data Tools (SSDT)](../../Topics/TopicNameNotContainA/Creating-Multidimensional-Models-Using-SQL-Server-Data-Tools--SSDT-.md).  
  
### SQL Server Management Studio  
 For database administrators, SQL Server Management Studio is an integrated environment for managing your SQL Server instances, including instances of Analysis Services and multidimensional databases. For more information, see [SQL Server Management Studio](assetId:///66a6b7b1-de6a-4161-82bd-98ded486947b) and [Connect to Analysis Services](../../Topics/TopicNameNotContainA/Connect-to-Analysis-Services.md).  
  
##  <a name="bkmk_querylang"></a> Query Languages  
 MDX is an industry standard query and calculation language used to retrieve data from OLAP databases. In Analysis Services, MDX is the query language used to retrieve data, but also supports data definition and data manipulation. MDX editors are built into SQL Server Management Studio, Reporting Services, and SQL Server Data Tools. You can use the MDX editors to create ad hoc queries or reusable script if the data operation is repeatable.  
  
 Some tools and applications, such as Excel, use MDX constructs internally to query an Analysis Services data source. You can also use MDX programmatically, by enclosing MDX statement in an XMLA Execute request.  
  
 The following links provide more information about MDX:  
  
 [Querying Multidimensional Data with MDX](../../Topics/TopicNameNotContainA/Querying-Multidimensional-Data-with-MDX.md)  
  
 [Key Concepts in MDX (Analysis Services)](../../Topics/TopicNameNotContainA/Key-Concepts-in-MDX--Analysis-Services-.md)  
  
 [MDX Query Fundamentals (Analysis Services)](../../Topics/TopicNameNotContainA/MDX-Query-Fundamentals--Analysis-Services-.md)  
  
 [MDX Scripting Fundamentals (Analysis Services)](../../Topics/TopicNameNotContainA/MDX-Scripting-Fundamentals--Analysis-Services-.md)  
  
##  <a name="bkmk_api"></a> Programmatic Interfaces  
 If you are building a custom application that uses multidimensional data, your approach for accessing the data will most likely fall into one of the following categories:  
  
-   **XMLA**. Use XMLA when you require compatibility with a wide variety of operating systems and protocols. XMLA offers the greatest flexibility, but often at the cost of improved performance and ease of programming.  
  
-   **Client libraries**. Use Analysis Services client libraries, such as ADOMD.NET, AMO, and OLE DB when you want to access data programmatically from client applications that run on a Microsoft Windows operating system. The client libraries wrap XMLA with an object model and optimizations that provide better performance.  
  
     ADOMD.NET and AMO client libraries are for applications written in managed code. Use OLE DB for Analysis Services if your application is written in native code.  
  
 The following table provides additional detail and links about the client libraries used for connecting Analysis Services to a custom application.  
  
|Interface|Description|  
|---------------|-----------------|  
|Analysis Services Management Objects (AMO)|AMO is the primary object model for administering Analysis Services instances and multidimensional databases in code. For example, SQL Server Management Studio uses AMO to support server and database administration. For more information, see [Developing with Analysis Management Objects (AMO)](assetId:///91354fc9-22da-4724-b97f-3b1e7b0e69d3).|  
|ADOMD.NET|ADOMD.NET is the primary object model creating and accessing multidimensional data in custom applications. You can use ADOMD.NET in a managed client application to retrieve [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] information using common Microsoft .NET Framework data access interfaces. For more information, see [ADOMD.NET](assetId:///abaf33aa-db55-43bf-8f30-15547559be1d) and [ADOMD.NET Client Programming](assetId:///55156115-ecd1-4ed9-876e-23406af9bbf9).|  
|Analysis Services OLE DB Provider (MSOLAP.dll)|You can use the native OLE DB provider to access [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] programmatically from a non-managed API. For more information, see [Analysis Services OLE DB Provider](assetId:///cdeecd50-1d91-4162-a4a2-01c7799b02a8).|  
|Schema Rowsets|Schema rowset tables are data structures that contain descriptive information about a multidimensional model that is deployed on the server, as well as information about current activity on the server. As a programmer, you can query schema rowset tables in client applications to examine metadata stored on, and retrieve support and monitoring information from, an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance. You can use schema rowsets with these programmatic interfaces: OLE DB, OLE DB for Analysis Services, OLE DB for Data Mining, or XMLA. For more information, see [Schema Rowsets](assetId:///820d4b59-d428-4616-b792-c848e5da407e).<br /><br /> The following list explains several approaches for using schema rowsets:<br /><br /> -Run DMV queries in SQL Server Management Studio or in custom reports to access schema rowsets using SQL syntax. For more information, see [Use Dynamic Management Views (DMVs) to Monitor Analysis Services](../../Topics/TopicNameNotContainA/Use-Dynamic-Management-Views--DMVs--to-Monitor-Analysis-Services.md).<br /><br /> -Write ADOMD.NET code that calls a schema rowset.<br /><br /> -Run the XMLA **Discover** method directly against an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance to retrieve schema rowset information. For more information, see [Discover Method (XMLA)](assetId:///0eb52d88-c081-416e-a229-610e4373b0b3).|  
|XMLA|XMLA is the lowest level API available to an Analysis Services programmer, and is the common denominator that underlies all Analysis Services data access methodologies. XMLA is an industry standard, SOAP based XML protocol that supports universal data access to any standard multidimensional data source available over an HTTP connection. It uses SOAP to formulate requests and responses for multidimensional data. If your application runs on a non-Windows platform, you can use XMLA to access a multidimensional database that is running on a Windows server on your network. For more information, see [Using XML for Analysis in Analysis Services (XMLA)](assetId:///54445ee7-720c-4683-99a6-e75b3dcca904).|  
|Analysis Services Scripting Language (ASSL)|ASSL is a descriptive term that applies to Analysis Services extensions of the XMLA protocol. Whereas the Execute and Discover methods are described by the XMLA protocol, ASSL adds the following capability:<br /><br /> -XMLA script<br /><br /> -XMLA object definitions<br /><br /> -XMLA commands<br /><br /> ASSL extensions enable Analysis Services to use XMLA constructs beyond the basic provisions of the protocol, adding data definition, data manipulation, and data control support. For more information, see [ASSL](assetId:///ce9aca4d-b7ad-451e-bb7f-20c2b0c03f29).|  
  
## See Also  
 [Connect to Analysis Services](../../Topics/TopicNameNotContainA/Connect-to-Analysis-Services.md)   
 [Developing with Analysis Services Scripting Language (ASSL)](assetId:///ce9aca4d-b7ad-451e-bb7f-20c2b0c03f29)   
 [Using XML for Analysis in Analysis Services (XMLA)](assetId:///54445ee7-720c-4683-99a6-e75b3dcca904)   
 [Tabular Model Data Access](../../Topics/TopicNameNotContainA/Tabular-Model-Data-Access.md)