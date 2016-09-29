---
title: "AsyncBuilder.Using&lt;&#39;T,&#39;U&gt; Method (F#)"
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
  - "AsyncBuilder.Using<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.Using``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder.Using method [F#]"
  - "Using method [F#]"
ms.assetid: 73b0269e-30b3-4ee6-9f38-a233809d2636
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.Using&lt;&#39;T,&#39;U&gt; Method (F#)
Implements the `use` and `use!` keywords in asynchronous computation expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Using : 'T * ('T -> Async<'U>) -> Async<'U> (requires 'T :> IDisposable)  
  
// Usage:  
asyncBuilder.Using (resource, binder)  
```  
  
#### Parameters  
 `resource`  
 Type: `'T`  
  
 The resource to be used and disposed.  
  
 `binder`  
 Type: `'T ->` [Async](../vs140/control.async--t--type--fsharp-.md)`<'U>`  
  
 The function that takes the resource and returns an asynchronous computation.  
  
## Return Value  
 An asynchronous computation that binds and eventually disposes `resource`.  
  
## Remarks  
 Creates an asynchronous computation that runs `binder(resource)`. The action `resource.Dispose()` is executed as this computation yields its result or if the asynchronous computation exits by an exception or by cancellation.  
  
 A cancellation check is performed when the computation is executed. The existence of this method permits the use of `use` and `use!` in the `async { ... }` computation expression syntax.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 <xref:System.IDisposable*>   
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)