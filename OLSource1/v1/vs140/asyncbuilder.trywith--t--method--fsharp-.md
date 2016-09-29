---
title: "AsyncBuilder.TryWith&lt;&#39;T&gt; Method (F#)"
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
  - "AsyncBuilder.TryWith<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.TryWith``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder.TryWith method [F#]"
  - "TryWith method [F#]"
ms.assetid: 47fa979f-0790-40ca-bf32-96628c83f763
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.TryWith&lt;&#39;T&gt; Method (F#)
Implements `try...with` in asynchronous computations.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.TryWith : Async<'T> * (exn -> Async<'T>) -> Async<'T>  
  
// Usage:  
asyncBuilder.TryWith (computation, catchHandler)  
```  
  
#### Parameters  
 `computation`  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)`<'T>`  
  
 The input computation.  
  
 `catchHandler`  
 Type: [exn](../vs140/core.exn-type-abbreviation--fsharp-.md) `->` [Async](../vs140/control.async--t--type--fsharp-.md)`<'T>`  
  
 The function to run when `computation` throws an exception.  
  
## Return Value  
 An asynchronous computation that executes `computation` and calls `catchHandler` if an exception is thrown.  
  
## Remarks  
 This function creates an asynchronous computation that runs `computation` and returns its result. If an exception happens then `catchHandler(exn)` is called and the resulting computation executed instead.  
  
 A cancellation check is performed when the computation is executed. The existence of this method permits the use of `try...with` in the `async { ... }` computation expression syntax.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)