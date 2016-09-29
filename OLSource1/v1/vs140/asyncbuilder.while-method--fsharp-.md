---
title: "AsyncBuilder.While Method (F#)"
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
  - "AsyncBuilder.While"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.While"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder.While method [F#]"
  - "While method [F#]"
ms.assetid: d47c0775-5a40-4e74-a9ae-f96c5385efe7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.While Method (F#)
Implements the `while` keyword in asynchronous computation expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.While : (unit -> bool) * Async<unit> -> Async<unit>  
  
// Usage:  
asyncBuilder.While (guard, computation)  
```  
  
#### Parameters  
 `guard`  
 Type: [unit](../vs140/core.unit-type-abbreviation--fsharp-.md) `->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to determine when to stop executing `computation`.  
  
 `computation`  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)`<`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)`>`  
  
 The function to be executed. Equivalent to the body of a `while` expression.  
  
## Return Value  
 An asynchronous computation that behaves similarly to a while loop when run.  
  
## Remarks  
 Creates an asynchronous computation that runs `computation` repeatedly until `guard` evaluates to false.  
  
 A cancellation check is performed whenever the computation is executed. The existence of this method permits the use of `while` in the `async { ... }` computation expression syntax.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)