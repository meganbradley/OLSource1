---
title: "EdmxFile Type Provider (F#)"
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
  - "Microsoft.FSharp.Data.TypeProviders.EdmxFile"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "EdmxFile type provider [F#]"
ms.assetid: 01396f6b-efb0-4a32-92ad-84bdce9ec447
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EdmxFile Type Provider (F#)
Provides the types to access a database with the schema in an .edmx file by using a LINQ to Entities mapping.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Data.TypeProviders  
  
 **Assembly:** FSharp.Data.TypeProviders (in FSharp.Data.TypeProviders.dll)  
  
## Syntax  
  
```  
type EdmxFile<File : string,                                   ?ResolutionFolder : string>  
```  
  
## Static Type Parameters  
  
|Type Parameter|Description|  
|--------------------|-----------------|  
|File : string|The path to an .edmx file that contains the schema. This file is written by the type provider.|  
|?ResolutionFolder : string|A folder to be used to resolve relative file paths at compile time. The default value is the folder that contains the project or script.|  
  
## Remarks  
 The EdmxFile type provider doesn't support the SQL data types `hierarchyid` and `sql_variant`.  
  
 For a walkthrough that shows how to use the EdmxFile type provider, see [Walkthrough: Generating F# Types from an EDMX Schema File (F#)](../vs140/walkthrough--generating-fsharp-types-from-an-edmx-schema-file--fsharp-.md).  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)