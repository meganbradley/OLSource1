---
title: "Async.Ignore&lt;&#39;T&gt; Method (F#)"
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
  - "Async.Ignore<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.Ignore``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Ignore method [F#]"
  - "Async.Ignore method [F#]"
ms.assetid: 2cb37887-d5f3-4530-b8ec-08f4ac0ae7df
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.Ignore&lt;&#39;T&gt; Method (F#)
Creates an asynchronous computation that runs the given computation and ignores its result.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Ignore : Async<'T> -> Async<unit>  
  
// Usage:  
Async.Ignore (computation)  
```  
  
#### Parameters  
 `computation`  
 Type: [Async](../VS_csharp/control.async--t--type--fsharp-.md)`<'T>`  
  
 The input computation.  
  
## Return Value  
 A computation that is equivalent to the input computation, but disregards the result.  
  
## Remarks  
  
## Example  
 The following code example illustrates the use of `Async.Ignore`.  
  
 [!code[FsAsyncAPIs#34](../VS_csharp/codesnippet/FSharp/async.ignore--t--method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../VS_csharp/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)