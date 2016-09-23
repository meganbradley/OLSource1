---
title: "Control.DelegateEvent&lt;&#39;Delegate&gt; Class (F#)"
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
  - Control.FSharpDelegateEvent<'Delegate>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Control.FSharpDelegateEvent`1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - FSharpDelegateEvent class [F#]
  - DelegateEvent class [F#]
ms.assetid: d5c57485-4db6-4fd0-b93e-d96a99dc1051
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Control.DelegateEvent&lt;&#39;Delegate&gt; Class (F#)
Event implementations for an arbitrary type of delegate.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type DelegateEvent<'Delegate> =  
 class  
  new DelegateEvent : unit -> DelegateEvent<'Delegate>  
  member this.Trigger : obj [] -> unit  
  member this.Publish :  IDelegateEvent<'Delegate>  
 end  
```  
  
## Remarks  
 This type is named `FSharpDelegateEvent` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/control.delegateevent--delegate--constructor--fsharp-.md)|Creates an event object suitable for implementing an arbitrary type of delegate.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Publish](../vs140/delegateevent.publish--delegate--property--fsharp-.md)|Publishes the event as a first class event value.|  
|[Trigger](../vs140/delegateevent.trigger--delegate--method--fsharp-.md)|Triggers the event using the given parameters.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)