---
title: "Control.WebExtensions Module (F#)"
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
  - Control.WebExtensions
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Control.WebExtensions
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - WebExtensions module [F#]
ms.assetid: 95ef17bc-ee3f-44ba-8a11-c90fcf4cf003
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Control.WebExtensions Module (F#)
A module of extension members providing asynchronous operations for some basic Web operations.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AutoOpen>]  
module WebExtensions  
```  
  
## Remarks  
  
## Extension Members  
  
|Extension Member|Description|  
|----------------------|-----------------|  
|[AsyncDownloadString](../vs140/webclient.asyncdownloadstring-extension-method--fsharp-.md)  `: Uri -> Async<string>`|Returns an asynchronous computation that, when run, will wait for the download of the given URI.|  
|[AsyncGetResponse](../vs140/webrequest.asyncgetresponse-extension-method--fsharp-.md)  `: unit -> Async<WebResponse>`|Returns an asynchronous computation that, when run, will wait for a response to the given web request.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)