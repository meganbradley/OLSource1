---
title: "DbmlFile Type Provider (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Data.TypeProviders.DbmlFile"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "DbmlFile type provider [F#]"
ms.assetid: bd0311cc-89ef-4b98-b69f-8bcd30d36637
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DbmlFile Type Provider (F#)
Provides the types for a database schema encoded in a .dbml file, the database schema format used by LINQ to SQL. .dbml files contain a schema for a database.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Data.TypeProviders  
  
 **Assembly:** FSharp.Data.TypeProviders (in FSharp.Data.TypeProviders.dll)  
  
## Syntax  
  
```  
type DbmlFile<File : string,              ?ResolutionFolder : string,              ?ContextTypeName : string,              ?Serializable : bool>  
```  
  
## Static Type Parameters  
  
|Type Parameter|Description|  
|--------------------|-----------------|  
|File : string|The path to the DBML file for the database mapping.|  
|?ResolutionFolder : string|A folder to be used to resolve relative file paths at compile time. The default value is the folder that contains the project or script.|  
|?ContextTypeName : string|The name of the container type that you use to access all the generated types.|  
|?Serializable : bool|`true` if you want the generated types to be serializable. The default is `false`.|  
  
## Remarks  
 The .dbml file is an XML file that contains the full description or schema for a relational database. DBML stands for Database Modeling Language and is the database schema format that LINQ to SQL uses. You can generate a .dbml file by using the command-line tool, `SQLMetal.exe`. For more information on `SQLMetal.exe`, see [SqlMetal.exe (Code Generation Tool)](assetId:///819e5a96-7646-4fdb-b14b-fe31221b0614). For more information on LINQ to SQL, see [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655).  
  
 For a walkthrough on how to use the `DbmlFile` type provider, see [Walkthrough: Generating F# Types from a DBML File (F#)](../vs140/walkthrough--generating-fsharp-types-from-a-dbml-file--fsharp-.md).  
  
## Platforms  
 [!INCLUDE[win8](../vs140/includes/win8_md.md)], Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)