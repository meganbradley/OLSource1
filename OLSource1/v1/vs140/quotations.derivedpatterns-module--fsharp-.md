---
title: "Quotations.DerivedPatterns Module (F#)"
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
  - "Quotations.DerivedPatterns"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.DerivedPatternsModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "DerivedPatternsModule module [F#]"
  - "DerivedPatterns module [F#]"
ms.assetid: d2434a6e-ae7b-4f3d-b567-c162938bc9cd
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Quotations.DerivedPatterns Module (F#)
Contains a set of derived F# active patterns to analyze F# expression objects  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module DerivedPatterns  
```  
  
## Remarks  
  
## Active Patterns  
  
|Active Pattern|Description|  
|--------------------|-----------------|  
|[AndAlso](../vs140/derivedpatterns.andalso-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr) option`|Recognizes expressions of the form `a && b.`|  
|[Applications](../vs140/derivedpatterns.applications-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr list list) option`|Recognizes expressions that represent the application of a (possibly curried or tupled) first class function value.|  
|[Bool](../vs140/derivedpatterns.bool-active-pattern--fsharp-.md)  `: Expr -> bool option`|Recognizes constant Boolean expressions.|  
|[Byte](../vs140/derivedpatterns.byte-active-pattern--fsharp-.md)  `: Expr -> byte option`|Recognizes constant byte expressions.|  
|[Char](../vs140/derivedpatterns.char-active-pattern--fsharp-.md)  `: Expr -> char option`|Recognizes constant Unicode character expressions.|  
|[Double](../vs140/derivedpatterns.double-active-pattern--fsharp-.md)  `: Expr -> float option`|Recognizes constant 64-bit floating point number expressions.|  
|[Int16](../vs140/derivedpatterns.int16-active-pattern--fsharp-.md)  `: Expr -> int16 option`|Recognizes constant int16 expressions.|  
|[Int32](../vs140/derivedpatterns.int32-active-pattern--fsharp-.md)  `: Expr -> int32 option`|Recognizes constant int32 expressions.|  
|[Int64](../vs140/derivedpatterns.int64-active-pattern--fsharp-.md)  `: Expr -> int64 option`|Recognizes constant int64 expressions.|  
|[Lambdas](../vs140/derivedpatterns.lambdas-active-pattern--fsharp-.md)  `: Expr -> (Var list list * Expr) option`|Recognizes expressions that represent a (possibly curried or tupled) first class function value.|  
|[MethodWithReflectedDefinition](../vs140/derivedpatterns.methodwithreflecteddefinition-active-pattern--fsharp-.md)  `: MethodBase -> Expr option`|Recognizes methods that have an associated ReflectedDefinition.|  
|[OrElse](../vs140/derivedpatterns.orelse-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr) option`|Recognizes expressions of the form `a &#124;&#124; b.`|  
|[PropertyGetterWithReflectedDefinition](../vs140/derivedpatterns.propertygetterwithreflecteddefinition-active-pattern--fsharp-.md)  `: PropertyInfo -> Expr option`|Recognizes property getters or values in modules that have an associated ReflectedDefinition.|  
|[PropertySetterWithReflectedDefinition](../vs140/derivedpatterns.propertysetterwithreflecteddefinition-active-pattern--fsharp-.md)  `: PropertyInfo -> Expr option`|Recognizes property setters that have an associated ReflectedDefinition.|  
|[SByte](../vs140/derivedpatterns.sbyte-active-pattern--fsharp-.md)  `: Expr -> sbyte option`|Recognizes constant signed byte expressions.|  
|[Single](../vs140/derivedpatterns.single-active-pattern--fsharp-.md)  `: Expr -> single option`|Recognizes constant 32-bit floating point number expressions.|  
|[SpecificCall](../vs140/derivedpatterns.specificcall-active-pattern--fsharp-.md)  `: Expr -> Expr -> (Expr option * Type list * Expr list) option`|A parameterized active pattern to recognize calls to a specified function or method. The returned elements are the optional target object (present if the target is an instance method), the generic type instantiation (non-empty if the target is a generic instantiation), and the arguments to the function or method.|  
|[String](../vs140/derivedpatterns.string-active-pattern--fsharp-.md)  `: Expr -> string option`|Recognizes constant string expressions.|  
|[UInt16](../vs140/derivedpatterns.uint16-active-pattern--fsharp-.md)  `: Expr -> uint16 option`|Recognizes constant unsigned int16 expressions.|  
|[UInt32](../vs140/derivedpatterns.uint32-active-pattern--fsharp-.md)  `: Expr -> uint32 option`|Recognizes constant unsigned int32 expressions.|  
|[UInt64](../vs140/derivedpatterns.uint64-active-pattern--fsharp-.md)  `: Expr -> uint64 option`|Recognizes constant unsigned int64 expressions.|  
|[Unit](../vs140/derivedpatterns.unit-active-pattern--fsharp-.md)  `: Expr -> unit option`|Recognizes `()` constant expressions.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)