---
title: "CompilerServices.RuntimeHelpers Module (F#)"
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
  - "CompilerServices.RuntimeHelpers"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RuntimeHelpers module [F#]"
ms.assetid: 1c8d2ee8-0173-4778-9c85-2177eb008110
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.RuntimeHelpers Module (F#)
A group of functions used as part of the compiled representation of F# sequence expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module RuntimeHelpers  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[CreateEvent](../vs140/runtimehelpers.createevent--delegate--args--function--fsharp-.md)  `: ('Delegate -> unit) -> ('Delegate -> unit) -> ((obj -> 'Args -> unit) -> 'Delegate) -> IEvent<'Delegate,'Args>`|Creates an anonymous event with the given handlers.|  
|[EnumerateFromFunctions](../vs140/runtimehelpers.enumeratefromfunctions--t--u--function--fsharp-.md)  `: (unit -> 'T) -> ('T -> bool) -> ('T -> 'U) -> seq<'U>`|The F# compiler emits calls to this function to implement the compiler-intrinsic conversions from weakly typed <xref:System.Collections.IEnumerable*> sequences to typed sequences.|  
|[EnumerateThenFinally](../vs140/runtimehelpers.enumeratethenfinally--t--function--fsharp-.md)  `: seq<'T> -> (unit -> unit) -> seq<'T>`|The F# compiler emits calls to this function to implement the `try...finally` construct for F# sequence expressions.|  
|[EnumerateUsing](../vs140/runtimehelpers.enumerateusing--t--collection--u--function--fsharp-.md)  `: 'T -> ('T -> 'Collection) -> seq<'U>`|The F# compiler emits calls to this function to implement the `use` keyword for F# sequence expressions.|  
|[EnumerateWhile](../vs140/runtimehelpers.enumeratewhile--t--function--fsharp-.md)  `: (unit -> bool) -> seq<'T> -> seq<'T>`|The F# compiler emits calls to this function to implement the `while` keyword for F# sequence expressions.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)