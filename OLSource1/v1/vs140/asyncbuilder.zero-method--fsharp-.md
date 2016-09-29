---
title: "AsyncBuilder.Zero Method (F#)"
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
  - "AsyncBuilder.Zero"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder.Zero"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Zero method [F#]"
  - "AsyncBuilder.Zero method [F#]"
ms.assetid: 8379ba80-9693-4f51-ae93-1d7c4e3e878b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBuilder.Zero Method (F#)
Creates an asynchronous computation that does nothing and returns `()`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Zero : unit -> Async<unit>  
  
// Usage:  
asyncBuilder.Zero ()  
```  
  
## Return Value  
 An asynchronous computation ([Async](../vs140/control.async-class--fsharp-.md) object) that returns `()`.  
  
## Remarks  
 A cancellation check is performed when the computation is executed. The existence of this method permits the use of empty `else` branches in the `async { ... }` computation expression syntax.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.AsyncBuilder Class (F#)](../vs140/control.asyncbuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)