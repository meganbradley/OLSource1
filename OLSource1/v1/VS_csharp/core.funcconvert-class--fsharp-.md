---
title: "Core.FuncConvert Class (F#)"
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
  - "Core.FuncConvert"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FuncConvert"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FuncConvert class [F#]"
ms.assetid: 6891aadd-43e8-43a2-a362-c0c81e73aacf
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.FuncConvert Class (F#)
Helper functions for converting F# first class function values to and from .NET Framework representations of functions using delegates.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AbstractClass>]  
[<Sealed>]  
type FuncConvert =  
 class  
  static member FuncFromTupled : ('T1 * 'T2 * 'T3 * 'T4 * 'T5 -> 'U) -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'U  
  static member FuncFromTupled : ('T1 * 'T2 * 'T3 * 'T4 -> 'U) -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'U  
  static member FuncFromTupled : ('T1 * 'T2 * 'T3 -> 'U) -> 'T1 -> 'T2 -> 'T3 -> 'U  
  static member FuncFromTupled : ('T1 * 'T2 -> 'U) -> 'T1 -> 'T2 -> 'U  
  static member ToFSharpFunc : Converter<'T,'U> -> 'T -> 'U  
  static member ToFSharpFunc : Action<'T> -> 'T -> unit  
 end  
```  
  
## Remarks  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[FuncFromTupled](../VS_csharp/funcconvert.funcfromtupled--t1--t2--t3--t4--t5--u--method--fsharp-.md)|A utility function to convert function values from tupled to curried form.|  
|[FuncFromTupled](../VS_csharp/funcconvert.funcfromtupled--t1--t2--t3--t4--u--method--fsharp-.md)|A utility function to convert function values from tupled to curried form.|  
|[FuncFromTupled](../VS_csharp/funcconvert.funcfromtupled--t1--t2--t3--u--method--fsharp-.md)|A utility function to convert function values from tupled to curried form.|  
|[FuncFromTupled](../VS_csharp/funcconvert.funcfromtupled--t1--t2--u--method--fsharp-.md)|A utility function to convert function values from tupled to curried form.|  
|[ToFSharpFunc](../VS_csharp/funcconvert.tofsharpfunc--t--u--method--fsharp-.md)|Convert the given <xref:System.Converter`2*> delegate object to an F# function value.|  
|[ToFSharpFunc](../VS_csharp/funcconvert.tofsharpfunc--t--method--fsharp-.md)|Convert the given <xref:System.Action`1*> delegate object to an F# function value.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)