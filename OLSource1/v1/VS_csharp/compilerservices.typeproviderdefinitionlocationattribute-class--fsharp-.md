---
title: "CompilerServices.TypeProviderDefinitionLocationAttribute Class (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TypeProviderDefinitionLocationAttribute [F#]"
ms.assetid: ca51668f-8f81-43b5-95d7-aeeeb342ffc7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.TypeProviderDefinitionLocationAttribute Class (F#)
Specifies the source location of a type provider definition, for use in error messages.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(32767, AllowMultiple = false)>]  
type TypeProviderDefinitionLocationAttribute =  
 class  
  new TypeProviderDefinitionLocationAttribute : unit -> TypeProviderDefinitionLocationAttribute  
  member this.Column : int with get, set  
  member this.FilePath : string with get, set  
  member this.Line : int with get, set  
  member this.FilePath : string with get, set  
  member this.Line  : int with get, set  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, TypeProviderDefinitionLocation.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../VS_csharp/compilerservices.typeproviderdefinitionlocationattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Column](../VS_csharp/typeproviderdefinitionlocationattribute.column-property--fsharp-.md) : [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)|Specifies the column of the type provider definition.|  
|[FilePath](../VS_csharp/typeproviderdefinitionlocationattribute.filepath-property--fsharp-.md) : [string](../VS_csharp/core.string-type-abbreviation--fsharp-.md)|Specifies the file and path of the type provider definition.|  
|[Line](../VS_csharp/typeproviderdefinitionlocationattribute.line-property--fsharp-.md) : [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)|Specifies the line number of the type provider definition.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../VS_csharp/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)