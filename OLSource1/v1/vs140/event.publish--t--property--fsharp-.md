---
title: "Event.Publish&lt;&#39;T&gt; Property (F#)"
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
  - FSharpEvent.Publish<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Control.FSharpEvent`1.Publish
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Event.Publish property [F#]
  - Publish property [F#]
ms.assetid: b0fdaad5-25e5-43d0-9c0c-ce37c4aeb68e
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Event.Publish&lt;&#39;T&gt; Property (F#)
Publishes an observation as a first class value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Publish :  IEvent<'T>  
  
// Usage:  
event.Publish  
```  
  
## Return Value  
 An object that implements [IEvent](../vs140/control.ievent--t--type-abbreviation--fsharp-.md) for this event.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Event<'T> Class (F#)](../vs140/control.event--t--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)