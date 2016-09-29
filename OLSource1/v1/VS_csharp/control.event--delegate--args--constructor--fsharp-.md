---
title: "Control.Event&lt;&#39;Delegate,&#39;Args&gt; Constructor (F#)"
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
  - "FSharpEvent.FSharpEvent<'Delegate,'Args>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpEvent`2.#ctor"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Event constructor [F#]"
ms.assetid: 2f112efb-a288-4640-87ec-414d6c607d31
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.Event&lt;&#39;Delegate,&#39;Args&gt; Constructor (F#)
Creates an event object suitable for delegate types following the standard .NET Framework convention of a first `sender` argument.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
new Event : unit -> Event<'Delegate,'Args> (requires delegate)  
  
// Usage:  
new Event ()  
```  
  
## Return Value  
 The created event.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Event<'Delegate,'Args> Class (F#)](../VS_csharp/control.event--delegate--args--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)