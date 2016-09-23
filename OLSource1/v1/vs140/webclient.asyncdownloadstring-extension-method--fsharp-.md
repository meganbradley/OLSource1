---
title: "WebClient.AsyncDownloadString Extension Method (F#)"
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
  - WebClient.AsyncDownloadString
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - System.Net.WebExtensions.AsyncDownloadString
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - AsyncDownloadString extension method [F#]
  - WebExtensions.AsyncDownloadString extension method [F#]
ms.assetid: 8a85a9b7-f712-4cac-a0ce-0a797f8ea32a
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# WebClient.AsyncDownloadString Extension Method (F#)
Returns an asynchronous computation that, when run, will wait for the download of the given URI.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.WebExtensions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
type System.Net.WebClient with  
  member AsyncDownloadString : Uri -> Async<string>  
  
// Usage:  
webClient.AsyncDownloadString (address)  
```  
  
#### Parameters  
 `address`  
 Type: <xref:System.Uri?qualifyHint=False>  
  
 The URI to retrieve.  
  
## Return Value  
 An asynchronous computation ([Async](../vs140/control.async-class--fsharp-.md) object) that will wait for the return of the URI.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 <xref:System.Net.WebClient?qualifyHint=False>   
 [Control.WebExtensions Module (F#)](../vs140/control.webextensions-module--fsharp-.md)