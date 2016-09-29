---
title: "Core.Option Module (F#)"
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
  - "Core.Option"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptionModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Option module [F#]"
  - "OptionModule module [F#]"
ms.assetid: e615e4d3-bbbb-49ba-addc-6061ea2e2f4c
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Option Module (F#)
Basic operations on options.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Option  
```  
  
## Remarks  
 For an overview of options in F#, see [Options (F#)](../VS_csharp/options--fsharp-.md).  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[bind](../VS_csharp/option.bind--t--u--function--fsharp-.md)  `: ('T -> 'U option) -> 'T option -> 'U option`|Invokes a function on an optional value that itself yields an option.|  
|[count](../VS_csharp/option.count--t--function--fsharp-.md)  `: 'T option -> int`|Evaluates the equivalent of [Set.count](../VS_csharp/set.count--t--function--fsharp-.md) for an option.|  
|[exists](../VS_csharp/option.exists--t--function--fsharp-.md)  `: ('T -> bool) -> 'T option -> bool`|Evaluates the equivalent of [List.exists](../VS_csharp/list.exists--t--function--fsharp-.md) for an option.|  
|[fold](../VS_csharp/option.fold--t--state--function--fsharp-.md)  `: ('State -> 'T -> 'State) -> 'State -> 'T option -> 'State`|Evaluates the equivalent of [List.fold](../VS_csharp/list.fold--t--state--function--fsharp-.md) for an option.|  
|[foldBack](../VS_csharp/option.foldback--t--state--function--fsharp-.md)  `: ('T -> 'State -> 'State) -> 'T option -> 'State -> 'State`|Performs the equivalent of the [List.foldBack](../VS_csharp/list.foldback--t--state--function--fsharp-.md) operation on an option.|  
|[forall](../VS_csharp/option.forall--t--function--fsharp-.md)  `: ('T -> bool) -> 'T option -> bool`|Evaluates the equivalent of [List.forall](../VS_csharp/list.forall--t--function--fsharp-.md) for an option type.|  
|[get](../VS_csharp/option.get--t--function--fsharp-.md)  `: 'T option -> 'T`|Gets the value associated with the option.|  
|[isNone](../VS_csharp/option.isnone--t--function--fsharp-.md)  `: 'T option -> bool`|Returns `true` if the option is `None`.|  
|[isSome](../VS_csharp/option.issome--t--function--fsharp-.md)  `: 'T option -> bool`|Returns `true` if the option is not `None`.|  
|[iter](../VS_csharp/option.iter--t--function--fsharp-.md)  `: ('T -> unit) -> 'T option -> unit`|Executes a function for an option value.|  
|[map](../VS_csharp/option.map--t--u--function--fsharp-.md)  `: ('T -> 'U) -> 'T option -> 'U option`|Transforms an option value by using a specified mapping function.|  
|[toArray](../VS_csharp/option.toarray--t--function--fsharp-.md)  `: 'T option -> 'T []`|Convert the option to an array of length 0 or 1.|  
|[toList](../VS_csharp/option.tolist--t--function--fsharp-.md)  `: 'T option -> 'T list`|Convert the option to a list of length 0 or 1.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)