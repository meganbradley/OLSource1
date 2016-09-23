---
title: "Event.choose&lt;&#39;T,&#39;U,&#39;Del&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Control.Event.choose``3
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - choose function [F#]
ms.assetid: 454dc761-8ec6-4c52-bcf5-10955407a458
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Event.choose&lt;&#39;T,&#39;U,&#39;Del&gt; Function (F#)
Returns a new event which fires on a selection of messages from the original event. The selection function takes an original message to an optional new message.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.Event  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Event.choose : ('T -> 'U option) -> IEvent<'Del,'T> -> IEvent<'U> (requires delegate)  
  
// Usage:  
Event.choose chooser sourceEvent  
```  
  
#### Parameters  
 `chooser`  
 Type: `'T -> 'U`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The function to select and transform event values to pass on.  
  
 `sourceEvent`  
 Type: [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md)`<'Del,'T>`  
  
 The input event.  
  
## Return Value  
 An event that fires only when the chooser returns `Some`.  
  
## Remarks  
 This function is named `Choose` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use the `Event.choose` function. In this example, the function is used to select only events when the mouse button is down. At the same time, the function transforms the input data of type `MouseEventArgs` into a more convenient format, a tuple of two integers that represent the current mouse position.  
  
 [!code[FsEvents#2](../vs140/codesnippet/FSharp/event.choose--t--u--del--function--fsharp-_1.fs)]
  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Event Module (F#)](../vs140/control.event-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)