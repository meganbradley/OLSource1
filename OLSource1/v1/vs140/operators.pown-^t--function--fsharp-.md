---
title: "Operators.pown&lt;^T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Operators.pown<^T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.PowInteger``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Operators.PowInteger function [F#]
  - PowInteger function [F#]
  - pown function [F#]
  - Operators.pown function [F#]
ms.assetid: c6163b1d-a8f9-4a87-8704-f34d8b2918ff
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators.pown&lt;^T&gt; Function (F#)
Overloaded power operator. If `n > 0` then equivalent to `x*...*x` for `n` occurrences of `x`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
pown : ^T -> int -> ^T (requires ^T with static member One and ^T with static member op_Multiply and ^T with static member (/))  
  
// Usage:  
pown x n  
```  
  
#### Parameters  
 `x`  
 Type: `^T`  
  
 The input base.  
  
 `n`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The input exponent.  
  
## Return Value  
 The base raised to the exponent.  
  
## Remarks  
 This function is named `PowInteger` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)