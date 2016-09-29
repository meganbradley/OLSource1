---
title: "Async.OnCancel Method (F#)"
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
  - "Async.OnCancel"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.OnCancel"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "OnCancel method [F#]"
  - "Async.OnCancel method [F#]"
ms.assetid: 917fde0f-2177-40db-8af4-eee96aa87b7a
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.OnCancel Method (F#)
Generates a scoped, cooperative cancellation handler for use within an asynchronous workflow.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member OnCancel : (unit -> unit) -> Async<IDisposable>  
  
// Usage:  
Async.OnCancel (interruption)  
```  
  
#### Parameters  
 `interruption`  
 Type: [unit](../vs140/core.unit-type-abbreviation--fsharp-.md) `->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function that is executed on the thread performing the cancellation.  
  
## Return Value  
 An asynchronous computation that triggers the interruption if it is cancelled before being disposed.  
  
## Remarks  
 For example, the following code generates an asynchronous computation where, if a cancellation happens any time during the execution of the asynchronous computation in the scope of `holder`, then action `interruption` is executed on the thread that is performing the cancellation. This can be used to arrange for a computation to be asynchronously notified that a cancellation has occurred, for example, by setting a flag, or deregistering a pending I/O action.  
  
```f#  
async { use! holder = Async.OnCancel interruption ... }  
```  
  
## Example  
 The following code example demonstrates the use of `Async.OnCancel`.  
  
 [!code[FsAsyncAPIs#8](../vs140/codesnippet/FSharp/async.oncancel-method--fsharp-_1.fs)]  
  
 **Output**  
  
 **Started computations.**  
**Sending cancellation signal.**  
**Canceling operation.**  
**Canceling operation.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)