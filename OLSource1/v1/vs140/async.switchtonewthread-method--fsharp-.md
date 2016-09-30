---
title: "Async.SwitchToNewThread Method (F#)"
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
  - "Async.SwitchToNewThread"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.SwitchToNewThread"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async.SwitchToNewThread method [F#]"
  - "SwitchToNewThread method [F#]"
ms.assetid: 1f0b78f7-8621-47da-89e8-5040ead1004c
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.SwitchToNewThread Method (F#)
Creates an asynchronous computation that creates a new thread and runs its continuation in that thread.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A computation that will execute on a new thread.  
  
## Remarks  
  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and [Async.SwitchToThreadPool](../vs140/async.switchtothreadpool-method--fsharp-.md) to wrap a synchronous method call as an asynchronous method.  
  
 [!code[FsAsyncAPIs#28](../vs140/codesnippet/FSharp/async.switchtonewthread-method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)