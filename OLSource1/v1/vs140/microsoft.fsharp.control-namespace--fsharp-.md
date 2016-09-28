---
title: "Microsoft.FSharp.Control Namespace (F#)"
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
  - "Microsoft.FSharp.Control"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Microsoft.FSharp.Control namespace [F#]"
ms.assetid: 8dc8478e-41dd-4abc-9f9c-27171f1d25df
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Microsoft.FSharp.Control Namespace (F#)
This namespace contains several types that common scenarios in F# programs, including asynchronous programming, message passing, and event-based programming.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
namespace Microsoft.FSharp.Control  
```  
  
## Remarks  
  
## Modules  
  
|Module|Description|  
|------------|-----------------|  
|module [CommonExtensions](../vs140/control.commonextensions-module--fsharp-.md)|A module of extension members providing asynchronous operations for some basic CLI types related to concurrency and I/O.|  
|module [Event](../vs140/control.event-module--fsharp-.md)|Provides functions for managing event streams.|  
|module [LazyExtensions](../vs140/control.lazyextensions-module--fsharp-.md)|Extensions related to Lazy values.|  
|module [Observable](../vs140/control.observable-module--fsharp-.md)|Basic operations on first class event and other observable objects.|  
|module [WebExtensions](../vs140/control.webextensions-module--fsharp-.md)|A module of extension members providing asynchronous operations for some basic Web operations.|  
  
## Type Definitions  
  
|Type|Description|  
|----------|-----------------|  
|type [Async<'T>](../vs140/control.async--t--type--fsharp-.md)|A compositional asynchronous computation, which, when run, will eventually produce a value of type T, or else raises an exception.|  
|type [Async](../vs140/control.async-class--fsharp-.md)|This static class holds members for creating and manipulating asynchronous computations.|  
|type [AsyncBuilder](../vs140/control.asyncbuilder-class--fsharp-.md)|The type of the `async` operator, used to build workflows for asynchronous computations.|  
|type [AsyncReplyChannel<'Reply>](../vs140/control.asyncreplychannel--reply--class--fsharp-.md)|A handle to a capability to reply to a PostAndReply message.|  
|type [DelegateEvent<'Delegate>](../vs140/control.delegateevent--delegate--class--fsharp-.md)|Event implementations for an arbitrary type of delegate.|  
|type [Event<'Delegate,'Args>](../vs140/control.event--delegate--args--class--fsharp-.md)|Event implementations for a delegate types following the standard .NET Framework convention of a first 'sender' argument.|  
|type [Event<'T>](../vs140/control.event--t--class--fsharp-.md)|Event implementations for the IEvent<_> type.|  
|type [Handler<'T>](../vs140/control.handler--t--class--fsharp-.md)|A delegate type associated with the F# event type `IEvent<_>`|  
|type [IDelegateEvent<'Delegate>](../vs140/control.idelegateevent--delegate--interface--fsharp-.md)|First class event values for arbitrary delegate types.|  
|type [IEvent<'Delegate,'Args>](../vs140/control.ievent--delegate--args--interface--fsharp-.md)|First class event values for CLI events conforming to CLI Framework standards.|  
|type [MailboxProcessor<'Msg>](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)|A message-processing agent which executes an asynchronous computation.|  
  
## Type Abbreviations  
  
|Type|Description|  
|----------|-----------------|  
|type [IEvent<'T>](../vs140/control.ievent--t--type-abbreviation--fsharp-.md)|First-class listening points (i.e. objects that permit you to register a callback activated when the event is triggered).|  
|type [lazy<'T>](../vs140/control.lazy--t--type-abbreviation.md)|An abbreviation for the type of delayed computations.|  
|type [Lazy<'T>](../vs140/control.lazy--t--type-abbreviation--fsharp-.md)|An abbreviation for the type of delayed computations.|  
  
## See Also  
 [F# Library Reference](../vs140/fsharp-core-library-reference.md)