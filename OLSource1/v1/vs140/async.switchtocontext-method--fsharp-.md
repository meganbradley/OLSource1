---
title: "Async.SwitchToContext Method (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Async.SwitchToGuiThread
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Control.FSharpAsync.SwitchToContext
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - SwitchToGuiThread method [F#]
  - Async.SwitchToGuiThread method [F#]
ms.assetid: c36395ac-adeb-4c9b-af0a-47471cccc0ea
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Async.SwitchToContext Method (F#)
Creates an asynchronous computation that runs its continuation using the <xref:System.Threading.SynchronizationContext.Post?qualifyHint=False> method on the synchronization context object.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member SwitchToContext : SynchronizationContext -> Async<unit>  
  
// Usage:  
Async.SwitchToContext (syncContext)  
```  
  
#### Parameters  
 `syncContext`  
 Type: <xref:System.Threading.SynchronizationContext?qualifyHint=False>  
  
 The synchronization context to accept the posted computation.  
  
## Return Value  
 An asynchronous computation that uses the `syncContext` context to execute.  
  
## Remarks  
 If `syncContext` is null then the asynchronous computation is equivalent to [Async.SwitchToThreadPool](../vs140/async.switchtothreadpool-method--fsharp-.md).  
  
## Example  
 The following code example illustrates how to use `Async.SwitchToContext` to switch to the UI thread to update the UI. In this, case a progress bar that indicates the state of completion of a computation is updated.  
  
 [!code[FsAsyncAPIs#25](../vs140/codesnippet/FSharp/async.switchtocontext-method--fsharp-_1.fs)]
  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)