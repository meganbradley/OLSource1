---
title: "AsyncBuilder.Delay&lt;&#39;T&gt; Method (F#)"
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
  - "AsyncBuilder.Delay<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.Delay``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Delay method [F#]"
  - "AsyncBuilder.Delay method [F#]"
ms.assetid: 71097cf1-ce79-46f3-9756-bd153d3d44ea
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.Delay&lt;&#39;T&gt; Method (F#)
Creates an asynchronous computation that runs a function.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Delay : (unit -> Async<'T>) -> Async<'T>  
  
// Usage:  
asyncBuilder.Delay (generator)  
```  
  
#### Parameters  
 `generator`  
 Type: [unit](../vs140/core.unit-type-abbreviation--fsharp-.md) `->` [Async](../vs140/control.async--t--type--fsharp-.md)`<'T>`  
  
 The function to run.  
  
## Return Value  
 An asynchronous computation that runs `generator`.  
  
## Remarks  
 A cancellation check is performed when the computation is executed.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)