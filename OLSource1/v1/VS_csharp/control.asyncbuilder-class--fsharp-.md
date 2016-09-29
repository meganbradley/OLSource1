---
title: "Control.AsyncBuilder Class (F#)"
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
  - "Control.AsyncBuilder"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder class [F#]"
  - "FSharpAsyncBuilder class [F#]"
ms.assetid: 7f593fcf-bc6e-42fc-bd26-fb9e18951016
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.AsyncBuilder Class (F#)
The type of the `async` operator, used to build workflows for asynchronous computations.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
type AsyncBuilder =  
 class  
  new AsyncBuilder : unit -> AsyncBuilder  
  member this.Bind : Async<'T> * ('T -> Async<'U>) -> Async<'U>  
  member this.Combine : Async<unit> * Async<'T> -> Async<'T>  
  member this.Delay : (unit -> Async<'T>) -> Async<'T>  
  member this.For : seq<'T> * ('T -> Async<unit>) -> Async<unit>  
  member this.Return : 'T -> Async<'T>  
  member this.ReturnFrom : Async<'T> -> Async<'T>  
  member this.TryFinally : Async<'T> * (unit -> unit) -> Async<'T>  
  member this.TryWith : Async<'T> * (exn -> Async<'T>) -> Async<'T>  
  member this.Using : 'T * ('T -> Async<'U>) -> Async<'U>  
  member this.While : (unit -> bool) * Async<unit> -> Async<unit>  
  member this.Zero : unit -> Async<unit>  
 end  
```  
  
## Remarks  
 For general information on computation expressions and builder types, see [Computation Expressions (F#)](../VS_csharp/computation-expressions--fsharp-.md).  
  
 This type is named `FSharpAsyncBuilder` in compiled assemblies. If accessing the type from a language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../VS_csharp/control.asyncbuilder-constructor--fsharp-.md)|Generates an object used to build asynchronous computations using F# computation expressions. The value `async` is a pre-defined instance of this type. A cancellation check is performed when the computation is executed.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Bind](../VS_csharp/asyncbuilder.bind--t--u--method--fsharp-.md)|Implements `let!` in asynchronous computations.|  
|[Combine](../VS_csharp/asyncbuilder.combine--t--method--fsharp-.md)|Creates an asynchronous computation that first runs `computation1` and then runs `computation2`, returning the result of `computation2`.|  
|[Delay](../VS_csharp/asyncbuilder.delay--t--method--fsharp-.md)|Creates an asynchronous computation that runs a function.|  
|[For](../VS_csharp/asyncbuilder.for--t--method--fsharp-.md)|Implements the `for` expression in asynchronous computations.|  
|[Return](../VS_csharp/asyncbuilder.return--t--method--fsharp-.md)|Implements the `return` expression in asynchronous computations. Creates an asynchronous computation that returns the specified result.|  
|[ReturnFrom](../VS_csharp/asyncbuilder.returnfrom--t--method--fsharp-.md)|Implements the `return!` keyword for asynchronous computations. This function delegates to the input computation.|  
|[TryFinally](../VS_csharp/asyncbuilder.tryfinally--t--method--fsharp-.md)|Implements `try...finally` in asynchronous computations.|  
|[TryWith](../VS_csharp/asyncbuilder.trywith--t--method--fsharp-.md)|Implements `try...with` in asynchronous computations.|  
|[Using](../VS_csharp/asyncbuilder.using--t--u--method--fsharp-.md)|Implements the `use` and `use!` keywords in asynchronous computation expressions.|  
|[While](../VS_csharp/asyncbuilder.while-method--fsharp-.md)|Implements the `while` keyword in asynchronous computation expressions.|  
|[Zero](../VS_csharp/asyncbuilder.zero-method--fsharp-.md)|Creates an asynchronous computation that does nothing and returns `()`.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)