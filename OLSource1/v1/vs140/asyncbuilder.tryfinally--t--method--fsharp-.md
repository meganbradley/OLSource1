---
title: "AsyncBuilder.TryFinally&lt;&#39;T&gt; Method (F#)"
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
  - "AsyncBuilder.TryFinally<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.TryFinally``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder.TryFinally method [F#]"
  - "TryFinally method [F#]"
ms.assetid: e82a1256-35e8-4d57-9dda-6e4e5a6f4445
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.TryFinally&lt;&#39;T&gt; Method (F#)
Implements `try...finally` in asynchronous computations.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.TryFinally : Async<'T> * (unit -> unit) -> Async<'T>  
  
// Usage:  
asyncBuilder.TryFinally (computation, compensation)  
```  
  
#### Parameters  
 `computation`  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)`<'T>`  
  
 The input computation.  
  
 `compensation`  
 Type: [unit](../vs140/core.unit-type-abbreviation--fsharp-.md) `->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The action to be run after `computation` completes or raises an exception (including cancellation).  
  
## Return Value  
 An asynchronous computation that executes computation and compensation aftewards or when an exception is raised.  
  
## Remarks  
 Creates an asynchronous computation that runs `computation`. The action `compensation` is executed after `computation` completes, whether `computation` exits normally or by an exception. If `compensation` raises an exception itself the original exception is discarded and the new exception becomes the overall result of the computation.  
  
 A cancellation check is performed when the computation is executed. The existence of this method permits the use of `try...finally` in the `async { ... }` computation expression syntax.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)