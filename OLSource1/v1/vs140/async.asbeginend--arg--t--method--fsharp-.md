---
title: "Async.AsBeginEnd&lt;&#39;Arg,&#39;T&gt; Method (F#)"
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
  - "Async.AsBeginEnd<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.AsBeginEnd``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsBeginEnd method [F#]"
  - "Async.AsBeginEnd method [F#]"
ms.assetid: a38a0e75-7717-4791-b2ec-0fc9977b4e6e
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.AsBeginEnd&lt;&#39;Arg,&#39;T&gt; Method (F#)
Creates three functions that can be used to implement the .NET Framework Asynchronous Programming Model (APM) for the supplied asynchronous computation.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member AsBeginEnd : ('Arg -> Async<'T>) -> ('Arg * AsyncCallback * obj -> IAsyncResult) * (IAsyncResult -> 'T) * (IAsyncResult -> unit)  
  
// Usage:  
Async.AsBeginEnd (computation)  
```  
  
#### Parameters  
 `computation`  
 Type: `'Arg ->`[Async](../vs140/control.async--t--type--fsharp-.md)`<'T>`  
  
 A function that generates the asynchronous computation to split into the traditional .NET Framework Asynchronous Programming Model.  
  
## Return Value  
 A tuple of the begin, end, and cancel members.  
  
## Remarks  
 For more information about the .NET Framework Asynchronous Programming Model, see [Asynchronous Programming Overview](assetId:///c9b3501e-6bc6-40f9-8efd-4b6d9e39ccf0).  
  
 The begin, end, and cancel functions should normally be published as members that are prefixed with `Begin`, `End`, and `Cancel`, and that can be used within a type definition as follows.  
  
```f#  
let beginAction,endAction,cancelAction =  
    Async.AsBeginEnd (fun arg -> computation)  
member x.BeginSomeOperation(arg, callback ,state:obj) =  
    beginAction(arg, callback, state)  
member x.EndSomeOperation(iar) = endAction(iar)  
member x.CancelSomeOperation(iar) = cancelAction(iar)  
```  
  
 If the asynchronous computation takes no arguments, `AsBeginEnd` is used as follows.  
  
```f#  
let beginAction,endAction,cancelAction =  
    Async.AsBeginEnd (fun () -> computation)  
member x.BeginSomeOperation(callback, state:obj) =  
    beginAction((), callback, state)  
member x.EndSomeOperation(iar) = endAction(iar)  
member x.CancelSomeOperation(iar) = cancelAction(iar)  
```  
  
 If the asynchronous computation takes two arguments, `AsBeginEnd` is used as follows.  
  
```f#  
let beginAction,endAction,cancelAction =  
    Async.AsBeginEnd (fun arg1 arg2 -> computation)  
member x.BeginSomeOperation(arg1, arg2, callback, state:obj) =  
    beginAction((), callback, state)  
member x.EndSomeOperation(iar) = endAction(iar)  
member x.CancelSomeOperation(iar) = cancelAction(iar)  
```  
  
 In each case, the resulting API resembles that used in other .NET Framework languages and is a useful way to publish asynchronous computations in components that are intended to be used from other .NET Framework languages.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 <xref:System.AsyncCallback*>   
 <xref:System.IAsyncResult*>   
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)