---
title: "RuntimeHelpers.CreateEvent&lt;&#39;Delegate,&#39;Args&gt; Function (F#)"
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
  - "RuntimeHelpers.CreateEvent<'Delegate,'Args>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.CreateEvent``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RuntimeHelpers.CreateEvent function [F#]"
  - "CreateEvent function [F#]"
ms.assetid: 8eca0f7b-84f9-4ffd-a9c4-4b85937b81e8
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeHelpers.CreateEvent&lt;&#39;Delegate,&#39;Args&gt; Function (F#)
Creates an anonymous event with the given handlers.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
RuntimeHelpers.CreateEvent : ('Delegate -> unit) -> ('Delegate -> unit) -> ((obj -> 'Args -> unit) -> 'Delegate) -> IEvent<'Delegate,'Args> (requires delegate)  
  
// Usage:  
RuntimeHelpers.CreateEvent addHandler removeHandler createHandler  
```  
  
#### Parameters  
 `addHandler`  
 Type: `'Delegate ->` [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)  
  
 A function to handle adding a delegate for the event to trigger.  
  
 `removeHandler`  
 Type: `'Delegate ->` [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)  
  
 A function to handle removing a delegate that the event triggers.  
  
 `createHandler`  
 Type: `(`[obj](../VS_csharp/core.obj-type-abbreviation--fsharp-.md) `-> 'Args ->` [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)`) ->   'Delegate`  
  
 A function to produce the delegate type the event can trigger.  
  
## Return Value  
 The initialized event as an object that implements [IEvent](../VS_csharp/control.ievent--delegate--args--interface--fsharp-.md).  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [CompilerServices.RuntimeHelpers Module (F#)](../VS_csharp/compilerservices.runtimehelpers-module--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../VS_csharp/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)