---
title: "Core.CompilationArgumentCountsAttribute Class (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Core.CompilationArgumentCountsAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilationArgumentCountsAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CompilationArgumentCounts attribute [F#]"
  - "CompilationArgumentCountsAttribute class [F#]"
ms.assetid: b774bd57-b7e8-40a2-9f4b-d2b8079723b6
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.CompilationArgumentCountsAttribute Class (F#)
Used internally by the compiler to indicate that a functions or member accepts a partial application of some of its arguments and returns a residual function.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Method, AllowMultiple = false)>]  
[<Sealed>]  
type CompilationArgumentCountsAttribute =  
 class  
  new CompilationArgumentCountsAttribute : int [] -> CompilationArgumentCountsAttribute  
  member this.Counts :  IEnumerable<int>  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `CompilationArgumentCounts`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.compilationargumentcountsattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Counts](../vs140/compilationargumentcountsattribute.counts-property--fsharp-.md)|Indicates the number of arguments in each argument group|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)