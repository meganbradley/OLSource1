---
title: "Event.map&lt;&#39;T,&#39;U,&#39;Del&gt; Function (F#)"
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
  - "Microsoft.FSharp.Control.Event.map``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
ms.assetid: 3a7ded1b-69a8-4cec-8717-f8573a9eb7d8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event.map&lt;&#39;T,&#39;U,&#39;Del&gt; Function (F#)
Returns a new event that passes values transformed by the given function.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.Event  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Event.map : ('T -> 'U) -> IEvent<'Del,'T> -> IEvent<'U> (requires delegate)  
  
// Usage:  
Event.map mapping sourceEvent  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T -> 'U`  
  
 The function to transform event values.  
  
 `sourceEvent`  
 Type: [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md)`<'Del,'T>`  
  
 The input event.  
  
## Return Value  
 An event that passes the transformed values.  
  
## Remarks  
 This function is named `Map` in the compiled assembly. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use the `Event.map` function. In this example, the event handler arguments are transformed into a more convenient format.  
  
 [!code[FsEvents#4](../vs140/codesnippet/FSharp/event.map--t--u--del--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library VersionsF# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable2.0, 4.0, Portable, Portable  
  
## See Also  
 [Control.Event Module (F#)](../vs140/control.event-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)