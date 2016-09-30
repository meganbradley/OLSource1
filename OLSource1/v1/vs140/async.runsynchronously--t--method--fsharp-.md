---
title: "Async.RunSynchronously&lt;&#39;T&gt; Method (F#)"
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
  - "Async.RunSynchronously<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.RunSynchronously``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RunSynchronously method [F#]"
  - "Async.RunSynchronously method [F#]"
ms.assetid: 0a6663a9-50f2-4d38-8bf3-cefd1a51fd6b
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.RunSynchronously&lt;&#39;T&gt; Method (F#)
Runs the provided asynchronous computation and awaits its result.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The computation to run.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The amount of time in milliseconds to wait for the result of the computation before raising a \<xref:System.TimeoutException*>. If no value is provided for timeout then a default of -1 is used to correspond to \<xref:System.Threading.Timeout.Infinite*>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [CancellationToken](../vs140/threading.cancellationtoken-structure--fsharp-.md)  
  
 The cancellation token to be associated with the computation. If one is not supplied, the default cancellation token is used.  
  
## Return Value  
 The result of the computation.  
  
## Remarks  
 If an exception occurs in the asynchronous computation then an exception is re-raised by this function. If no cancellation token is provided then the default cancellation token is used. The timeout parameter is given in milliseconds. A value of -1 is equivalent to \<xref:System.Threading.Timeout.Infinite*>.  
  
 If you provide a cancelable cancellation token, the timeout is ignored. Instead, you can implement your own timeout by canceling the operation. A cancellation token is cancelable if its \<xref:System.Threading.CancellationToken.CanBeCanceled*> property is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> should not be used on the main thread in asynchronous programming environments, such as in Silverlight-based applications.  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to run an asynchronous computation created by using [Async.Parallel](../vs140/async.parallel--t--method--fsharp-.md), with no timeout.  
  
 [!code[FsAsyncAPIs#1](../vs140/codesnippet/FSharp/async.runsynchronously--t--method--fsharp-_1.fs)]  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with a timeout.  
  
 [!code[FsAsyncAPIs#2](../vs140/codesnippet/FSharp/async.runsynchronously--t--method--fsharp-_2.fs)]  
  
 **Sample Output**  
  
 **The operation has timed out.420 write operations completed successfully.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)