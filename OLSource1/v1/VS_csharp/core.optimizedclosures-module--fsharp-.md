---
title: "Core.OptimizedClosures Module (F#)"
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
  - "Core.OptimizedClosures"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptimizedClosures"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "OptimizedClosures module [F#]"
ms.assetid: 8f1e5ba0-9ae6-45d5-949a-150fda7eeedb
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.OptimizedClosures Module (F#)
An implementation module used to hold some private implementations of function value invocation.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module OptimizedClosures  
```  
  
## Remarks  
  
## Type Definitions  
  
|Type|Description|  
|----------|-----------------|  
|type [FSharpFunc<'T1,'T2,'U>](../VS_csharp/optimizedclosures.fsharpfunc--t1--t2--u--class--fsharp-.md)|The .NET Framework type used to represent F# function values that accept two iterated (curried) arguments without intervening execution. This type should not typically used directly from either F# code or from other .NET Framework languages.|  
|type [FSharpFunc<'T1,'T2,'T3,'U>](../VS_csharp/optimizedclosures.fsharpfunc--t1--t2--t3--u--class--fsharp-.md)|The .NET Framework type used to represent F# function values that accept three iterated (curried) arguments without intervening execution. This type should not typically used directly from either F# code or from other .NET Framework languages.|  
|type [FSharpFunc<'T1,'T2,'T3,'T4,'U>](../VS_csharp/optimizedclosures.fsharpfunc--t1--t2--t3--t4--u--class--fsharp-.md)|The .NET Framework type used to represent F# function values that accept four curried arguments without intervening execution. This type should not typically used directly from either F# code or from other .NET Framework languages.|  
|type [FSharpFunc<'T1,'T2,'T3,'T4,'T5,'U>](../VS_csharp/optimizedclosures.fsharpfunc--t1--t2--t3--t4--t5--u--class--fsharp-.md)|The .NET Framework type used to represent F# function values that accept five curried arguments without intervening execution. This type should not typically used directly from either F# code or from other .NET Framework languages.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)