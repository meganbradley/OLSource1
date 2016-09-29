---
title: "Control.Event Module (F#)"
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
  - "Control.Event"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.EventModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "EventModule module [F#]"
  - "Event module [F#]"
ms.assetid: 8b883baa-a460-4840-9baa-de8260351bc7
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.Event Module (F#)
Provides functions for managing event streams.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Event  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[add](../VS_csharp/event.add--t--del--function--fsharp-.md)  `: ('T -> unit) -> Event<'Del,'T> -> unit`|Runs the given function each time the given event is triggered.|  
|[choose](../VS_csharp/event.choose--t--u--del--function--fsharp-.md)  `: ('T -> 'U option) -> IEvent<'Del,'T> -> IEvent<'U>`|Returns a new event which fires on a selection of messages from the original event. The selection function takes an original message to an optional new message.|  
|[filter](../VS_csharp/event.filter--t--del--function--fsharp-.md)  `: ('T -> bool) -> IEvent<'Del,'T> -> IEvent<'T>`|Returns a new event that listens to the original event and triggers the resulting event only when the argument to the event passes the given function.|  
|[map](../VS_csharp/event.map--t--u--del--function--fsharp-.md)  `: ('T -> 'U) -> IEvent<'Del, 'T> -> IEvent<'U>`|Returns a new event that passes values transformed by the given function.|  
|[merge](../VS_csharp/event.merge--del1--t--del2--function--fsharp-.md)  `: IEvent<'Del1,'T> -> IEvent<'Del2,'T> -> IEvent<'T>`|Fires the output event when either of the input events fire.|  
|[pairwise](../VS_csharp/event.pairwise--del--t--function--fsharp-.md)  `: IEvent<'Del,'T> -> IEvent<'T * 'T>`|Returns a new event that triggers on the second and subsequent triggerings of the input event. The Nth triggering of the input event passes the arguments from the N-1th and Nth triggering as a pair. The argument passed to the N-1th triggering is held in hidden internal state until the Nth triggering occurs.|  
|[partition](../VS_csharp/event.partition--t--del--function--fsharp-.md)  `: ('T -> bool) -> IEvent<'Del,'T> -> IEvent<'T> * IEvent<'T>`|Returns a new event that listens to the original event and triggers the first resulting event if the application of the predicate to the event arguments returned `true`, and the second event if it returned `false`.|  
|[scan](../VS_csharp/event.scan--u--t--del--function--fsharp-.md)  `: ('U -> 'T -> 'U) -> 'U -> IEvent<'Del,'T> -> IEvent<'U>`|Returns a new event consisting of the results of applying the given accumulating function to successive values triggered on the input event. An item of internal state records the current value of the state parameter. The internal state is not locked during the execution of the accumulation function, so care should be taken that the input [IEvent](../VS_csharp/control.ievent--delegate--args--interface--fsharp-.md) not triggered by multiple threads simultaneously.|  
|[split](../VS_csharp/event.split--t--u1--u2--del--function--fsharp-.md)  `: ('T -> Choice<'U1,'U2>) -> IEvent<'Del,'T> -> IEvent<'U1> * IEvent<'U2>`|Returns a new event that listens to the original event and triggers the first resulting event if the application of the function to the event arguments returned a `Choice1Of2`, and the second event if it returns a `Choice2Of2`.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)   
 [Event Class](../VS_csharp/control.event--t--class--fsharp-.md)   
 [Events (F#)](../VS_csharp/events--fsharp-.md)   
 [IEvent Interface](../VS_csharp/control.ievent--delegate--args--interface--fsharp-.md)