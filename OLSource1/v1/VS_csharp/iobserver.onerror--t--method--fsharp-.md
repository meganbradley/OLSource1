---
title: "IObserver.OnError&lt;&#39;T&gt; Method (F#)"
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
  - "IObserver.OnError<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.IObserver`1.OnError"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IObserver.OnError method [F#]"
  - "OnError method [F#]"
ms.assetid: fc34d34d-9fed-4eb0-99f3-667cb85929c1
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IObserver.OnError&lt;&#39;T&gt; Method (F#)
Notify an observer of an error  
  
 **Namespace/Module Path**: System  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.OnError : exn -> unit  
  
// Usage:  
iObserver.OnError (error)  
```  
  
#### Parameters  
 `error`  
 Type: [exn](../VS_csharp/core.exn-type-abbreviation--fsharp-.md)  
  
 The exception to notify observers.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.IObserver`1.OnError*>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System.IObserver<'T> Interface (F#)](../VS_csharp/system.iobserver--t--interface--fsharp-.md)   
 [System Namespace (F#)](../VS_csharp/system-namespace--fsharp-.md)