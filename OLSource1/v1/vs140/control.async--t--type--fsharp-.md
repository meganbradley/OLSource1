---
title: "Control.Async&lt;&#39;T&gt; Type (F#)"
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
  - "Control.Async<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async type [F#]"
  - "FSharpAsync type [F#]"
ms.assetid: e0b28ea2-dea5-4021-b2b9-d7d4761babde
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.Async&lt;&#39;T&gt; Type (F#)
A compositional asynchronous computation, which, when run, will eventually produce a value of type 'T, or else raises an exception. The functions for working with these objects are in the [Async](../vs140/control.async-class--fsharp-.md) class.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
[<NoEquality>]  
[<NoComparison>]  
type Async<'T> =  
 class  
 end  
```  
  
## Remarks  
 Asynchronous computations are normally specified using an F# computation expression. When run, asynchronous computations have two modes: as a work item (executing synchronous code), or as a wait item (waiting for an event or I/O completion). When run, asynchronous computations can be governed by <xref:System.Threading.CancellationToken*>. This can usually be specified when the asynchronous computation is started. The associated <xref:System.Threading.CancellationTokenSource*> may be used to cancel the asynchronous computation. Asynchronous computations built using computation expressions can check the cancellation condition regularly. Synchronous computations within an asynchronous computation do not automatically check this condition. For more information, see [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md).  
  
 This type is named `FSharpAsync` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)   
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md)