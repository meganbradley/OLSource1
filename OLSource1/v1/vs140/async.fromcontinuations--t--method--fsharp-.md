---
title: "Async.FromContinuations&lt;&#39;T&gt; Method (F#)"
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
  - "Async.FromContinuations<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.FromContinuations``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async.FromContinuations method [F#]"
  - "FromContinuations method [F#]"
ms.assetid: 76fb99a4-e92f-4e68-affc-546c46b6a9b2
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.FromContinuations&lt;&#39;T&gt; Method (F#)
Creates an asynchronous computation that captures the current success, exception and cancellation continuations. The callback must eventually call exactly one of the given continuations.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member FromContinuations : (('T -> unit) * (exn -> unit) * (OperationCanceledException -> unit) -> unit) -> Async<'T>  
  
// Usage:  
Async.FromContinuations (callback)  
```  
  
#### Parameters  
 `callback`  
 Type: `('T ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)`) * (`[exn](../vs140/core.exn-type-abbreviation--fsharp-.md) `->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)`) * (`<xref:System.OperationCanceledException*> `->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)`) ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function that accepts the current success, exception, and cancellation continuations.  
  
## Return Value  
 An asynchronous computation that provides the callback with the current continuations.  
  
## Remarks  
 The argument for this method is a lambda expression that takes three continuation functions, which are typically called `cont` (the success continuation), `ccont` (the cancel continuation) and `econt` (the error continuation), as the following code shows:  
  
```  
Async.FromContinuations (fun (cont, ccont, econt) -> ...)  
```  
  
> [!WARNING]
>  If you use this method, you must call exactly one of the continuation functions or else throw an exception, in which case F# calls `econt` with the exception on your behalf. If you call more than one continuation, call any continuation more than once, or both call a continuation and throw an exception, any subsequent use of the resulting async object may have undefined behavior.  
  
## Example  
 The following example illustrates how to use `Async.FromContinuations` to wrap an event-based asynchronous computation as an F# async.  
  
 [!code[FsAsyncAPIs#23](../vs140/codesnippet/FSharp/async.fromcontinuations--t--method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)