---
title: "Async.AwaitWaitHandle Method (F#)"
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
  - "Async.AwaitWaitHandle"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.AwaitWaitHandle"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async.AwaitWaitHandle method [F#]"
  - "AwaitWaitHandle method [F#]"
ms.assetid: 0f3ee86d-5fb6-4ff9-9917-94f272923715
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.AwaitWaitHandle Method (F#)
Creates an asynchronous computation that will wait for the supplied <xref:System.Threading.WaitHandle*>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member AwaitWaitHandle : WaitHandle * ?int -> Async<bool>  
  
// Usage:  
Async.AwaitWaitHandle (waitHandle)  
Async.AwaitWaitHandle (waitHandle, millisecondsTimeout = millisecondsTimeout)  
```  
  
#### Parameters  
 `waitHandle`  
 Type: <xref:System.Threading.WaitHandle*>  
  
 The wait handle that can be signaled.  
  
 `millisecondsTimeout`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)  
  
 The timeout value in milliseconds. If no timeout value is provided, the default value is -1, which corresponds to ystem.Threading.Timeout.Infinite.  
  
## Return Value  
 An asynchronous computation that waits on the given <xref:System.Threading.WaitHandle*> object.  
  
## Remarks  
 The computation returns true if the handle indicated a result within the given timeout.  
  
## Example  
 The following code example illustrates how to use `Async.AwaitWaitHandle` to set up a computation to run when another asynchronous operation is completed, as indicated by a wait handle.  
  
 [!code[FsAsyncAPIs#17](../VS_csharp/codesnippet/FSharp/async.awaitwaithandle-method--fsharp-_1.fs)]  
  
 **Output**  
  
 **Writing to file BigFile.dat.**  
**Reading from file BigFile.dat.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../VS_csharp/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)