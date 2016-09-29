---
title: "Event.partition&lt;&#39;T,&#39;Del&gt; Function (F#)"
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
  - "Microsoft.FSharp.Control.Event.partition``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "partition function [F#]"
ms.assetid: 9854e530-5bd1-4705-bec6-688f53d7a952
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event.partition&lt;&#39;T,&#39;Del&gt; Function (F#)
Returns a new event that listens to the original event and triggers the first resulting event if the application of the predicate to the event arguments returned `true`, and the second event if it returned `false`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control.Event  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Event.partition : ('T -> bool) -> IEvent<'Del,'T> -> IEvent<'T> * IEvent<'T> (requires delegate)  
  
// Usage:  
Event.partition predicate sourceEvent  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to determine which output event to trigger.  
  
 `sourceEvent`  
 Type: [IEvent](../VS_csharp/control.ievent--delegate--args--interface--fsharp-.md)`<'Del,'T>`  
  
 The input event.  
  
## Return Value  
 A tuple of events. The first is triggered when the predicate evaluates to `true` and the second when the predicate evaluates to `false`.  
  
## Remarks  
 This function is named `Partition` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use the `Event.partition` function to split an event into two events, each with its own event handling code.  
  
 [!code[FsEvents#7](../VS_csharp/codesnippet/FSharp/event.partition--t--del--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Event Module (F#)](../VS_csharp/control.event-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)