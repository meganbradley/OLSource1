---
title: "Control.IDelegateEvent&lt;&#39;Delegate&gt; Interface (F#)"
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
  - "Control.IDelegateEvent<'Delegate>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.IDelegateEvent`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IDelegateEvent interface [F#]"
ms.assetid: 3d849465-6b8e-4fc5-b36c-2941d734268a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.IDelegateEvent&lt;&#39;Delegate&gt; Interface (F#)
First class event values for arbitrary delegate types.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type IDelegateEvent<'Delegate> =  
 interface  
  abstract this.AddHandler : 'Delegate -> unit  
  abstract this.RemoveHandler : 'Delegate -> unit  
 end  
```  
  
## Remarks  
 F# gives special status to member properties compatible with type `IDelegateEvent` and tagged with the [CLIEventAttribute](../vs140/core.clieventattribute-class--fsharp-.md). In this case the F# compiler generates approriate CLI metadata to make the member appear to other CLI languages as a CLI event.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[AddHandler](../vs140/idelegateevent.addhandler--delegate--method--fsharp-.md)|Connect a handler delegate object to the event. A handler can be later removed using [RemoveHandler](../vs140/idelegateevent.removehandler--delegate--method--fsharp-.md). The listener will be invoked when the event is fired.|  
|[RemoveHandler](../vs140/idelegateevent.removehandler--delegate--method--fsharp-.md)|Remove a listener delegate from an event listener store.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)   
 [DelegateEvent](../vs140/control.delegateevent--delegate--class--fsharp-.md)