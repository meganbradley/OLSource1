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
|module [CommonExtensions](../VS_csharp/control.commonextensions-module--fsharp-.md)|A module of extension members providing asynchronous operations for some basic CLI types related to concurrency and I/O.|  
|module [Event](../VS_csharp/control.event-module--fsharp-.md)|Provides functions for managing event streams.|  
|module [LazyExtensions](../VS_csharp/control.lazyextensions-module--fsharp-.md)|Extensions related to Lazy values.|  
|module [Observable](../VS_csharp/control.observable-module--fsharp-.md)|Basic operations on first class event and other observable objects.|  
|module [WebExtensions](../VS_csharp/control.webextensions-module--fsharp-.md)|A module of extension members providing asynchronous operations for some basic Web operations.|  
  
## Type Definitions  
  
|Type|Description|  
|----------|-----------------|  
|type [Async<'T>](../VS_csharp/control.async--t--type--fsharp-.md)|A compositional asynchronous computation, which, when run, will eventually produce a value of type T, or else raises an exception.|  
|type [Async](../VS_csharp/control.async-class--fsharp-.md)|This static class holds members for creating and manipulating asynchronous computations.|  
|type [AsyncBuilder](../VS_csharp/control.asyncbuilder-class--fsharp-.md)|The type of the `async` operator, used to build workflows for asynchronous computations.|  
|type [AsyncReplyChannel<'Reply>](../VS_csharp/control.asyncreplychannel--reply--class--fsharp-.md)|A handle to a capability to reply to a PostAndReply message.|  
|type [DelegateEvent<'Delegate>](../VS_csharp/control.delegateevent--delegate--class--fsharp-.md)|Event implementations for an arbitrary type of delegate.|  
|type [Event<'Delegate,'Args>](../VS_csharp/control.event--delegate--args--class--fsharp-.md)|Event implementations for a delegate types following the standard .NET Framework convention of a first 'sender' argument.|  
|type [Event<'T>](../VS_csharp/control.event--t--class--fsharp-.md)|Event implementations for the IEvent<_> type.|  
|type [Handler<'T>](../VS_csharp/control.handler--t--class--fsharp-.md)|A delegate type associated with the F# event type `IEvent<_>`|  
|type [IDelegateEvent<'Delegate>](../VS_csharp/control.idelegateevent--delegate--interface--fsharp-.md)|First class event values for arbitrary delegate types.|  
|type [IEvent<'Delegate,'Args>](../VS_csharp/control.ievent--delegate--args--interface--fsharp-.md)|First class event values for CLI events conforming to CLI Framework standards.|  
|type [MailboxProcessor<'Msg>](../VS_csharp/control.mailboxprocessor--msg--class--fsharp-.md)|A message-processing agent which executes an asynchronous computation.|  
  
## Type Abbreviations  
  
|Type|Description|  
|----------|-----------------|  
|type [IEvent<'T>](../VS_csharp/control.ievent--t--type-abbreviation--fsharp-.md)|First-class listening points (i.e. objects that permit you to register a callback activated when the event is triggered).|  
|type [lazy<'T>](../VS_csharp/control.lazy--t--type-abbreviation.md)|An abbreviation for the type of delayed computations.|  
|type [Lazy<'T>](../VS_csharp/control.lazy--t--type-abbreviation--fsharp-.md)|An abbreviation for the type of delayed computations.|  
  
## See Also  
 [F# Library Reference](../VS_csharp/fsharp-core-library-reference.md)