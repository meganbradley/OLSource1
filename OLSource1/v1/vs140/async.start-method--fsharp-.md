---
title: "Async.Start Method (F#)"
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
  - "Async.Start"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.Start"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Start method [F#]"
  - "Async.Start method [F#]"
ms.assetid: 338aa756-beac-4dc1-95ca-613822679347
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.Start Method (F#)
Starts the asynchronous computation in the thread pool. Do not await its result.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Start : Async<unit> * ?CancellationToken -> unit  
  
// Usage:  
Async.Start (computation)  
Async.Start (computation, cancellationToken = cancellationToken)  
```  
  
#### Parameters  
 `computation`  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)`<`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)`>`  
  
 The computation to run asynchronously.  
  
 `cancellationToken`  
 Type: [CancellationToken](../vs140/threading.cancellationtoken-structure--fsharp-.md)  
  
 The cancellation token to be associated with the computation. If one is not supplied, the default cancellation token is used.  
  
## Remarks  
 If no cancellation token is provided then the default cancellation token is used.  
  
## Example  
 The following code example shows how to start an asynchronous computation on the thread pool.  
  
 [!code[FsAsyncAPIs#31](../vs140/codesnippet/FSharp/async.start-method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)