---
title: "Core.FSharpFunc&lt;&#39;T,&#39;U&gt; Class (F#)"
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
  - "Core.FSharpFunc<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpFunc`2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpFunc class [F#]"
ms.assetid: 6fbc582c-a36a-4154-9bfe-296de5ecba53
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.FSharpFunc&lt;&#39;T,&#39;U&gt; Class (F#)
The .NET Framework type used to represent F# function values. This type is not typically used directly, though may be used from other .NET Framework languages.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AbstractClass>]  
type FSharpFunc<'T,'U> =  
 class  
  new FSharpFunc : unit -> FSharpFunc<'T,'U>  
  static member FromConverter : Converter<'T,'U> -> 'T -> 'U  
  abstract this.Invoke : 'T -> 'U  
  static member InvokeFast : FSharpFunc<'T,('U -> 'V)> * 'T * 'U -> 'V  
  static member InvokeFast : FSharpFunc<'T,('U -> 'V -> 'W)> * 'T * 'U * 'V -> 'W  
  static member InvokeFast : FSharpFunc<'T,('U -> 'V -> 'W -> 'X)> * 'T * 'U * 'V * 'W -> 'X  
  static member InvokeFast : FSharpFunc<'T,('U -> 'V -> 'W -> 'X -> 'Y)> * 'T * 'U * 'V * 'W * 'X -> 'Y  
  static member ToConverter : ('T -> 'U) -> Converter<'T,'U>  
  static member op_Implicit : Converter<'T,'U> -> 'T -> 'U  
  static member op_Implicit : ('T -> 'U) -> Converter<'T,'U>  
 end  
```  
  
## Remarks  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.fsharpfunc--t--u--constructor--fsharp-.md)|Construct an instance of an F# first class function value|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Invoke](../vs140/fsharpfunc.invoke--t--u--method--fsharp-.md)|Invoke an F# first class function value with one argument|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[FromConverter](../vs140/fsharpfunc.fromconverter--t--u--method--fsharp-.md)|Convert an value of type <xref:System.Converter`2*> to a F# first class function value|  
|[InvokeFast](../vs140/fsharpfunc.invokefast--t--u--v--method--fsharp-.md)|Invoke an F# first class function value with two curried arguments. In some cases this will result in a more efficient application than applying the arguments successively.|  
|[InvokeFast](../vs140/fsharpfunc.invokefast--t--u--v--w--method--fsharp-.md)|Invoke an F# first class function value with three curried arguments. In some cases this will result in a more efficient application than applying the arguments successively.|  
|[InvokeFast](../vs140/fsharpfunc.invokefast--t--u--v--w--x--method--fsharp-.md)|Invoke an F# first class function value with four curried arguments. In some cases this will result in a more efficient application than applying the arguments successively.|  
|[InvokeFast](../vs140/fsharpfunc.invokefast--t--u--v--w--x--y--method--fsharp-.md)|Invoke an F# first class function value with five curried arguments. In some cases this will result in a more efficient application than applying the arguments successively.|  
|[op_Implicit](../vs140/fsharpfunc.op_implicit--t--u--method--fsharp-.md)|Convert an value of type <xref:System.Converter`2*> to a F# first class function value|  
|[ToConverter](../vs140/fsharpfunc.toconverter--t--u--method--fsharp-.md)|Convert an F# first class function value to a value of type <xref:System.Converter`2*>.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)