---
title: "Event.add&lt;&#39;T,&#39;Del&gt; Function (F#)"
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
  - "Microsoft.FSharp.Control.Event.add``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "add function [F#]"
ms.assetid: 10670d3b-8d47-4f6e-b8df-ebc6f64ef4fd
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event.add&lt;&#39;T,&#39;Del&gt; Function (F#)
Runs the given function each time the given event is triggered.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.Event  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Event.add : ('T -> unit) -> IEvent<'Del,'T> -> unit (requires delegate)  
  
// Usage:  
Event.add callback sourceEvent  
```  
  
#### Parameters  
 `callback`  
 Type: `'T ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to call when the event is triggered.  
  
 `sourceEvent`  
 Type: [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md)`<'Del,'T>`  
  
 The input event.  
  
## Remarks  
 This function is named `Add` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use the `Event.add` function.  
  
 [!code[FsEvents#1](../vs140/codesnippet/FSharp/event.add--t--del--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Event Module (F#)](../vs140/control.event-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)