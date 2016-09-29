---
title: "Async.StartWithContinuations&lt;&#39;T&gt; Method (F#)"
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
  - "Async.StartWithContinuations<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.StartWithContinuations``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async.StartWithContinuations method [F#]"
  - "StartWithContinuations method [F#]"
ms.assetid: dbca7cda-02d1-4a91-bbd0-23aef7050a5c
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.StartWithContinuations&lt;&#39;T&gt; Method (F#)
Runs an asynchronous computation, starting immediately on the current operating system thread. Call one of the three continuations when the operation completes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member StartWithContinuations : Async<'T> * ('T -> unit) * (exn -> unit) * (OperationCanceledException -> unit) * ?CancellationToken -> unit  
  
// Usage:  
Async.StartWithContinuations (computation, continuation, exceptionContinuation, cancellationContinuation)  
Async.StartWithContinuations (computation, continuation, exceptionContinuation, cancellationContinuation, cancellationToken = cancellationToken)  
```  
  
#### Parameters  
 `computation`  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)`<'T>`  
  
 The asynchronous computation to execute.  
  
 `continuation`  
 Type: `'T ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function called on success.  
  
 `exceptionContinuation`  
 Type: [exn](../vs140/core.exn-type-abbreviation--fsharp-.md) `->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function called on exception.  
  
 `cancellationContinuation`  
 Type: <xref:System.OperationCanceledException*> `->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function called on cancellation.  
  
 `cancellationToken`  
 Type: [CancellationToken](../vs140/threading.cancellationtoken-structure--fsharp-.md)  
  
 The optional cancellation token to associate with the computation. The default is used if this parameter is not provided.  
  
## Remarks  
 If no cancellation token is provided, the default cancellation token is used.  
  
## Example  
 The following code example illustrates the use of `Async.StartWithContinuations`.  
  
 [!code[FsAsyncAPIs#5](../vs140/codesnippet/FSharp/async.startwithcontinuations--t--method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)