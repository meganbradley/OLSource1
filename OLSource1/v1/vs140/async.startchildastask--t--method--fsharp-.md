---
title: "Async.StartChildAsTask&lt;&#39;T&gt; Method (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Control.FSharpAsync.StartChildAsTask``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Async.StartChildAsTask method [F#]
ms.assetid: f4363517-4430-466e-bb72-7a51e9ffef28
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Async.StartChildAsTask&lt;&#39;T&gt; Method (F#)
Creates an asynchronous computation which starts the given computation as a <xref:System.Threading.Tasks.Task?qualifyHint=False>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member StartChildAsTask : Async<'T> * ?TaskCreationOptions -> Async<Task<'T>>  
  
// Usage:  
Async.StartChildAsTask (computation)  
Async.StartChildAsTask (computation, taskCreationOptions = taskCreationOptions)  
```  
  
#### Parameters  
 `computation`  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)`<'T>`  
  
 The computation to execute.  
  
 `taskCreationOptions`  
 Type: <xref:System.Threading.Tasks.TaskCreationOptions?qualifyHint=False>  
  
 Optional task creation options.  
  
## Return Value  
 The task wrapped as an asynchronous computation.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)