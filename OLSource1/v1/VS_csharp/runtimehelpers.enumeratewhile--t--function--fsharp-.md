---
title: "RuntimeHelpers.EnumerateWhile&lt;&#39;T&gt; Function (F#)"
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
  - "RuntimeHelpers.EnumerateWhile<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.EnumerateWhile``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "EnumerateWhile function [F#]"
  - "RuntimeHelpers.EnumerateWhile function [F#]"
ms.assetid: 9f48435f-2754-42e2-8d1a-9d002b7e60b5
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeHelpers.EnumerateWhile&lt;&#39;T&gt; Function (F#)
The F# compiler emits calls to this function to implement the `while` keyword for F# sequence expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
RuntimeHelpers.EnumerateWhile : (unit -> bool) -> seq<'T> -> seq<'T>  
  
// Usage:  
RuntimeHelpers.EnumerateWhile guard source  
```  
  
#### Parameters  
 `guard`  
 Type: [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md) `->` [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 A function that indicates whether iteration should continue.  
  
 `source`  
 Type: [seq](../VS_csharp/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Return Value  
 The result sequence.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [CompilerServices.RuntimeHelpers Module (F#)](../VS_csharp/compilerservices.runtimehelpers-module--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../VS_csharp/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)