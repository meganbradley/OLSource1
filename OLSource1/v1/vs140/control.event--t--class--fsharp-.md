---
title: "Control.Event&lt;&#39;T&gt; Class (F#)"
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
  - "Control.FSharpEvent<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpEvent`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpEvent class [F#]"
  - "Event class [F#]"
ms.assetid: f3b47c8a-4ee5-4ce8-9a72-ad305a17c4b9
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.Event&lt;&#39;T&gt; Class (F#)
Event implementations for the [IEvent](../vs140/control.ievent--t--type-abbreviation--fsharp-.md) type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type Event<'T> =  
 class  
  new Event : unit -> Event<'T>  
  member this.Trigger : 'T -> unit  
  member this.Publish :  IEvent<'T>  
 end  
```  
  
## Remarks  
 Functions that work with events are defined in the [Event module](../vs140/control.event-module--fsharp-.md).  
  
 This type is named `FSharpEvent` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/control.event--t--constructor--fsharp-.md)|Creates an observable object.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Publish](../vs140/event.publish--t--property--fsharp-.md)|Publishes an observation as a first class value.|  
|[Trigger](../vs140/event.trigger--t--method--fsharp-.md)|Triggers an observation using the given parameters.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)   
 [IEvent\<_>](../vs140/control.ievent--t--type-abbreviation--fsharp-.md)   
 [Control.IEvent\<'Del,'Args>](../vs140/control.ievent--delegate--args--interface--fsharp-.md)