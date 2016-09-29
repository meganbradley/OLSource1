---
title: "AsyncBuilder.For&lt;&#39;T&gt; Method (F#)"
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
  - "AsyncBuilder.For<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.For``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder.For method [F#]"
  - "For method [F#]"
ms.assetid: e49389df-b5d0-46ab-ba9c-58aa51a2bfdd
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.For&lt;&#39;T&gt; Method (F#)
Implements the `for` expression in asynchronous computations. Creates an asynchronous computation that enumerates the sequence on demand and runs a function representing the body of a `for` expression for each element.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.For : seq<'T> * ('T -> Async<unit>) -> Async<unit>  
  
// Usage:  
asyncBuilder.For (sequence, body)  
```  
  
#### Parameters  
 `sequence`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The sequence to enumerate.  
  
 `body`  
 Type: `'T ->` [Async](../vs140/control.async--t--type--fsharp-.md)`<`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)`>`  
  
 A function to take an item from the sequence and create an asynchronous computation. Can be seen as the body of the `for` expression.  
  
## Return Value  
 An asynchronous computation that will enumerate the sequence and run `body` for each element.  
  
## Remarks  
 A cancellation check is performed on each iteration of the loop. The existence of this method permits the use of `for` in the `async { ... }` computation expression syntax.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)