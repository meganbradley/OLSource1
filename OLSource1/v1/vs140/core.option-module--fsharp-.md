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
author: ""
ms.author: ""
manager: ""
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
 For an overview of options in F#, see [Options (F#)](../vs140/options--fsharp-.md).  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[bind](../vs140/option.bind--t--u--function--fsharp-.md)  `: ('T -> 'U option) -> 'T option -> 'U option`|Invokes a function on an optional value that itself yields an option.|  
|[count](../vs140/option.count--t--function--fsharp-.md)  `: 'T option -> int`|Evaluates the equivalent of [Set.count](../vs140/set.count--t--function--fsharp-.md) for an option.|  
|[exists](../vs140/option.exists--t--function--fsharp-.md)  `: ('T -> bool) -> 'T option -> bool`|Evaluates the equivalent of [List.exists](../vs140/list.exists--t--function--fsharp-.md) for an option.|  
|[fold](../vs140/option.fold--t--state--function--fsharp-.md)  `: ('State -> 'T -> 'State) -> 'State -> 'T option -> 'State`|Evaluates the equivalent of [List.fold](../vs140/list.fold--t--state--function--fsharp-.md) for an option.|  
|[foldBack](../vs140/option.foldback--t--state--function--fsharp-.md)  `: ('T -> 'State -> 'State) -> 'T option -> 'State -> 'State`|Performs the equivalent of the [List.foldBack](../vs140/list.foldback--t--state--function--fsharp-.md) operation on an option.|  
|[forall](../vs140/option.forall--t--function--fsharp-.md)  `: ('T -> bool) -> 'T option -> bool`|Evaluates the equivalent of [List.forall](../vs140/list.forall--t--function--fsharp-.md) for an option type.|  
|[get](../vs140/option.get--t--function--fsharp-.md)  `: 'T option -> 'T`|Gets the value associated with the option.|  
|[isNone](../vs140/option.isnone--t--function--fsharp-.md)  `: 'T option -> bool`|Returns `true` if the option is `None`.|  
|[isSome](../vs140/option.issome--t--function--fsharp-.md)  `: 'T option -> bool`|Returns `true` if the option is not `None`.|  
|[iter](../vs140/option.iter--t--function--fsharp-.md)  `: ('T -> unit) -> 'T option -> unit`|Executes a function for an option value.|  
|[map](../vs140/option.map--t--u--function--fsharp-.md)  `: ('T -> 'U) -> 'T option -> 'U option`|Transforms an option value by using a specified mapping function.|  
|[toArray](../vs140/option.toarray--t--function--fsharp-.md)  `: 'T option -> 'T []`|Convert the option to an array of length 0 or 1.|  
|[toList](../vs140/option.tolist--t--function--fsharp-.md)  `: 'T option -> 'T list`|Convert the option to a list of length 0 or 1.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)