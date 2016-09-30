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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[add](../vs140/event.add--t--del--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Runs the given function each time the given event is triggered.|  
|[choose](../vs140/event.choose--t--u--del--function--fsharp-.md)  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Returns a new event which fires on a selection of messages from the original event. The selection function takes an original message to an optional new message.|  
|[filter](../vs140/event.filter--t--del--function--fsharp-.md)  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Returns a new event that listens to the original event and triggers the resulting event only when the argument to the event passes the given function.|  
|[map](../vs140/event.map--t--u--del--function--fsharp-.md)  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Returns a new event that passes values transformed by the given function.|  
|[merge](../vs140/event.merge--del1--t--del2--function--fsharp-.md)  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Fires the output event when either of the input events fire.|  
|[pairwise](../vs140/event.pairwise--del--t--function--fsharp-.md)  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Returns a new event that triggers on the second and subsequent triggerings of the input event. The Nth triggering of the input event passes the arguments from the N-1th and Nth triggering as a pair. The argument passed to the N-1th triggering is held in hidden internal state until the Nth triggering occurs.|  
|[partition](../vs140/event.partition--t--del--function--fsharp-.md)  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Returns a new event that listens to the original event and triggers the first resulting event if the application of the predicate to the event arguments returned <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and the second event if it returned <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|[scan](../vs140/event.scan--u--t--del--function--fsharp-.md)  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Returns a new event consisting of the results of applying the given accumulating function to successive values triggered on the input event. An item of internal state records the current value of the state parameter. The internal state is not locked during the execution of the accumulation function, so care should be taken that the input [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md) not triggered by multiple threads simultaneously.|  
|[split](../vs140/event.split--t--u1--u2--del--function--fsharp-.md)  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Returns a new event that listens to the original event and triggers the first resulting event if the application of the function to the event arguments returned a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and the second event if it returns a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)   
 [Event Class](../vs140/control.event--t--class--fsharp-.md)   
 [Events (F#)](../vs140/events--fsharp-.md)   
 [IEvent Interface](../vs140/control.ievent--delegate--args--interface--fsharp-.md)