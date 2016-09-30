---
title: "Async.StartImmediate Method (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.Async.StartImmediate"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "StartImmediate method [F#]"
ms.assetid: 2f71d1cc-187f-48cf-ac66-e7fda41c46e3
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.StartImmediate Method (F#)
Runs an asynchronous computation, starting immediately on the current operating system thread.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The asynchronous computation to execute.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [CancellationToken](../vs140/threading.cancellationtoken-structure--fsharp-.md)  
  
 The optional cancellation token to associate with the computation. The default is used if this parameter is not provided.  
  
## Remarks  
 If no cancellation token is provided then the default cancellation token is used.  
  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to start an asynchronous computation on the current thread. Often, an asynchronous operation needs to update UI, which should always be done on the UI thread. When your asynchronous operation needs to begin by updating UI, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a better choice than [Async.Start](../vs140/async.start-method--fsharp-.md), which starts the asynchronous operation on a thread pool thread.  
  
 [!code[FsAsyncAPIs#320](../vs140/codesnippet/FSharp/async.startimmediate-method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)