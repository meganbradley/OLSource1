---
title: "Control.CommonExtensions Module (F#)"
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
  - "Control.CommonExtensions"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.CommonExtensions"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CommonExtensions module [F#]"
ms.assetid: 2edb67cb-6814-4a30-849f-b6dbdd042396
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.CommonExtensions Module (F#)
A module of extension members providing asynchronous operations for some basic CLI types related to concurrency and I/O.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AutoOpen>]  
module CommonExtensions  
```  
  
## Remarks  
  
## Extension Members  
  
|Extension Member|Description|  
|----------------------|-----------------|  
|[Add](../VS_csharp/iobservable.add--t--extension-method--fsharp-.md)  `: ('T -> unit) -> unit`|Permanently connects a listener function to the observable. The listener will be invoked for each observation.|  
|[Subscribe](../VS_csharp/iobservable.add--t--extension-method--fsharp-.md)  `: ('T -> unit) -> IDisposable`|Connects a listener function to the observable. The listener will be invoked for each observation. You can remove the listener by calling <xref:System.IDisposable.Dispose*> on the returned <xref:System.IDisposable*> object.|  
|[AsyncRead](../VS_csharp/stream.asyncread-extension-method--fsharp-.md)  `: byte [] * ?int * ?int -> Async<int>`|Returns an asynchronous computation that will read from the stream into the given buffer.|  
|[AsyncWrite](../VS_csharp/stream.asyncwrite-extension-method--fsharp-.md)  `: byte[] * ?int * ?int -> Async<unit>`|Returns an asynchronous computation that will write the given bytes to the stream.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)