---
title: "Async.CancelDefaultToken Method (F#)"
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
  - "Async.CancelDefaultToken"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.CancelDefaultToken"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async.CancelDefaultToken method [F#]"
  - "CancelDefaultToken method [F#]"
ms.assetid: 95289172-8711-4479-b9c1-05c616e26472
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.CancelDefaultToken Method (F#)
Raises the cancellation condition for the most recent set of asynchronous computations started without any specific cancellation token. Replaces the global <xref:System.Threading.CancellationTokenSource*> object with a new global token source for any asynchronous computations created after this point without any specific cancellation token.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member CancelDefaultToken : unit -> unit  
  
// Usage:  
Async.CancelDefaultToken ()  
```  
  
## Remarks  
  
## Example  
 The following example shows how to create a cancellable asynchronous operation in a Windows Forms application. It also shows how to use `Async.CancelDefaultToken` to cancel the operation.  
  
 [!code[FsAsyncAPIs#5](../VS_csharp/codesnippet/FSharp/async.canceldefaulttoken-method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 <xref:System.Threading.CancellationToken*>   
 [Control.Async Class (F#)](../VS_csharp/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)