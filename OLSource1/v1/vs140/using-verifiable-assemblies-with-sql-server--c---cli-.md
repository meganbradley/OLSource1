---
title: "Using Verifiable Assemblies with SQL Server (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Using Verifiable Assemblies with SQL Server (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "verifiable assemblies [C++], with SQL Server"
ms.assetid: 5248a60d-aa88-4ff3-b30a-b791c3ea2de9
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Verifiable Assemblies with SQL Server (C++-CLI)
Extended stored procedures, packaged as dynamic-link libraries (DLLs), provide a way to extend SQL Server functionality through functions developed with [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)]. Extended stored procedures are implemented as functions inside DLLs. In addition to functions, extended stored procedures can also define [user-defined types](../vs140/classes-and-structs--c---.md) and [aggregate functions](assetId:///de255454-f45e-4281-81f9-bc61893ac5da) (such as SUM or AVG).  
  
 When a client executes an extended stored procedure, SQL Server searches for the DLL associated with the extended stored procedure and loads the DLL. SQL Server calls the requested extended stored procedure and executes it under a specified security context. The extended stored procedure then passes result sets and returns parameters back to the server.  
  
 [!INCLUDE[sqprsqlong](../vs140/includes/sqprsqlong_md.md)] provides extensions to Transact-SQL (T-SQL) to allow you to install verifiable assemblies into SQL Server. The SQL Server permission set specifies the security context, with the following levels of security:  
  
-   Unrestricted mode: Run code at your own risk; code does not have to be verifiably type-safe.  
  
-   Safe mode: Run verifiably typesafe code; compiled with /clr:safe.  
  
 Safe mode requires the executed assemblies to be verifiably typesafe.  
  
 To create and load a verifiable assembly into SQL Server, use the Transact-SQL commands CREATE ASSEMBLY and DROP ASSEMBLY as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The PERMISSION_SET command specifies the security context, and can have the values UNRESTRICTED, SAFE, or EXTENDED.  
  
 In addition, you can use the CREATE FUNCTION command to bind to method names in a class:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following SQL script (for example, named "MyScript.sql") loads an assembly into SQL Server and makes a method of a class available:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 SQL scripts can be executed interactively in SQL Query Analyzer or at the command line with the sqlcmd.exe utility. The following command line connects to MyServer, uses the default database, uses a trusted connection, inputs MyScript.sql, and outputs MyResult.txt.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [How to: Migrate to /clr:safe (C++/CLI)](../vs140/how-to--migrate-to--clr-safe--c---cli-.md)   
 [Classes and Structs](../vs140/classes-and-structs--c---.md)