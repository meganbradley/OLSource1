---
title: "Async.AwaitIAsyncResult Method (F#)"
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
  - "Async.AwaitIAsyncResult"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.AwaitIAsyncResult"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AwaitIAsyncResult method [F#]"
  - "Async.AwaitIAsyncResult method [F#]"
ms.assetid: 62c03ef2-a95e-499d-a614-67ad0719dde0
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.AwaitIAsyncResult Method (F#)
Creates an asynchronous computation that will wait on the \<xref:System.IAsyncResult*>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: \<xref:System.IAsyncResult*>  
  
 The IAsyncResult to wait on.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The timeout value in milliseconds. If one is not provided then the default value of -1 corresponding to \<xref:System.Threading.Timeout.Infinite*>.  
  
## Return Value  
 An asynchronous computation that waits on the given \<xref:System.IAsyncResult*>.  
  
## Remarks  
 The computation returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the handle indicated a result within the given timeout.  
  
## Example  
 The following code example illustrates how to use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to set up and execute a computation that is triggered when a previous .NET Framework asynchronous operation that produces an \<xref:System.IAsyncResult*> finishes. In this case, the call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> causes the operation to wait for a file write operation to be completed before opening the file for reading.  
  
 [!code[FsAsyncAPIs#15](../vs140/codesnippet/FSharp/async.awaitiasyncresult-method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 \<xref:System.IAsyncResult*>   
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)