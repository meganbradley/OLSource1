---
title: "Event.Trigger&lt;&#39;Delegate,&#39;Args&gt; Method (F#)"
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
  - "FSharpEvent.Trigger<'Delegate,'Args>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpEvent`2.Trigger"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Trigger method [F#]"
  - "Event.Trigger method [F#]"
ms.assetid: e73a5a2b-7d5f-425b-8ff6-f35780c84968
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event.Trigger&lt;&#39;Delegate,&#39;Args&gt; Method (F#)
Triggers the event using the given sender object and parameters. The sender object may be `null`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Trigger : obj * 'Args -> unit (requires delegate)  
  
// Usage:  
event.Trigger (sender, args)  
```  
  
#### Parameters  
 `sender`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The object triggering the event.  
  
 `args`  
 Type: `'Args`  
  
 The parameters for the event.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Event<'Delegate,'Args> Class (F#)](../vs140/control.event--delegate--args--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)