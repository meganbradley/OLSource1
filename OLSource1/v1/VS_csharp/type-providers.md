---
title: "Type Providers"
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
  - "type providers [F#]"
ms.assetid: ee83de0a-f7a7-4ddd-b292-53c1684a8e9e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type Providers
An F# type provider is a component that provides types, properties, and methods for use in your program. Type providers are a significant part of F# 3.0 support for information-rich programming. The key to information-rich programming is to eliminate barriers to working with diverse information sources found on the Internet and in modern enterprise environments. One significant barrier to including a source of information into a program is the need to represent that information as types, properties, and methods for use in a programming language environment. Writing these types manually is very time-consuming and difficult to maintain. A common alternative is to use a code generator which adds files to your project; however, the conventional types of code generation do not integrate well into exploratory modes of programming supported by F# because the generated code must be replaced each time a service reference is adjusted.  
  
 The types provided by F# type providers are usually based on external information sources. For example, an F# type provider for SQL will provide the types, properties, and methods you need to work directly with the tables of any SQL database you have access to. Similarly, a type provider for WSDL web services will provide the types, properties, and methods you need to work directly with any WSDL web service.  
  
 The set of types, properties, and methods provided by an F# type provider can depend on parameters given in program code. For example, a type provider can provide different types depending on a connection string or a service URL. In this way, the information space available by means of a connection string or URL is directly integrated into your program. A type provider can also ensure that groups of types are only expanded on demand; that is, they are expanded if the types are actually referenced by your program. This allows for the direct, on-demand integration of large-scale information spaces such as online data markets in a strongly typed way.  
  
 F# contains several built-in type providers for commonly used Internet and enterprise data services. These type providers give simple and regular access to SQL relational databases and network-based OData and WSDL services and support the use of F# LINQ queries against these data sources.  
  
 Where necessary, you can create your own custom type providers, or reference type providers that have been created by others. For example, assume your organization has a data service providing a large and growing number of named data sets, each with its own stable data schema. You may choose to create a type provider that reads the schemas and presents the latest available data sets to the programmer in a strongly typed way.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Walkthrough: Accessing a SQL Database by Using Type Providers (F#)](../VS_csharp/walkthrough--accessing-a-sql-database-by-using-type-providers--fsharp-.md)|Explains how to use the SqlDataConnection type provider to access the tables and stored procedures of a SQL database based on a connection string for a direct connection to a database. The access uses a LINQ to SQL mapping.|  
|[Walkthrough: Accessing a Database by Using Type Providers and Entities (F#)](../VS_csharp/walkthrough--accessing-a-sql-database-by-using-type-providers-and-entities--fsharp-.md)|Explains how to use the SqlEntityConnection type provider to access the tables and stored procedures of a SQL database, based on a connection string for a direct connection to a database. The access uses a LINQ to Entities mapping. This method works with any database but the example demonstrated is SQL Server.|  
|[Walkthrough: Accessing an OData Service by Using Type Providers (F#)](../VS_csharp/walkthrough--accessing-an-odata-service-by-using-type-providers--fsharp-.md)|Explains how to use the ODataService type provider to access an OData service in a strongly typed way based on a service URL.|  
|[Walkthrough: Accessing a Web Service by Using Type Providers (F#)](../VS_csharp/walkthrough--accessing-a-web-service-by-using-type-providers--fsharp-.md)|Explains how to use the WsdlService type provider to access a WSDL web service in a strongly typed way based on a service URL.|  
|[Walkthrough: Generating F# Types from a DBML File (F#)](../VS_csharp/walkthrough--generating-fsharp-types-from-a-dbml-file--fsharp-.md)|Explains how to use the DbmlFile type provider to access the tables and stored procedures of a SQLdatabase, based on a DBML file giving a Linq to SQL database schema specification.|  
|[Walkthrough: Generating F# Types from an EDMX Schema File (F#)](../VS_csharp/walkthrough--generating-fsharp-types-from-an-edmx-schema-file--fsharp-.md)|Explains how to use the EdmxFile type provider to access the tables and stored procedures of a SQL database, based on an EDMX file giving an Entity Framework schema specification.|  
|[Tutorial: Creating a Type Provider (F#)](../VS_csharp/tutorial--creating-a-type-provider--fsharp-.md)|Provides information on writing your own custom type providers.|  
|[Type Provider Security](../VS_csharp/type-provider-security.md)|Provides information about security considerations when developing type providers.|  
|[Troubleshooting Type Providers](../VS_csharp/troubleshooting-type-providers.md)|Provides information about common problems that can arise when working with type providers and includes suggestions for solutions.|  
  
## See Also  
 [F# Language Reference](../VS_csharp/fsharp-language-reference.md)   
 [Visual F#](../VS_csharp/visual-fsharp.md)   
 [What's New in Visual Studio](../VS_csharp/what-s-new-in-visual-studio-2015.md)