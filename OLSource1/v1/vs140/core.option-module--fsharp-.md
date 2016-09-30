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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 For an overview of options in F#, see [Options (F#)](../vs140/options--fsharp-.md).  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[bind](../vs140/option.bind--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Invokes a function on an optional value that itself yields an option.|  
|[count](../vs140/option.count--t--function--fsharp-.md)  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Evaluates the equivalent of [Set.count](../vs140/set.count--t--function--fsharp-.md) for an option.|  
|[exists](../vs140/option.exists--t--function--fsharp-.md)  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Evaluates the equivalent of [List.exists](../vs140/list.exists--t--function--fsharp-.md) for an option.|  
|[fold](../vs140/option.fold--t--state--function--fsharp-.md)  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Evaluates the equivalent of [List.fold](../vs140/list.fold--t--state--function--fsharp-.md) for an option.|  
|[foldBack](../vs140/option.foldback--t--state--function--fsharp-.md)  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Performs the equivalent of the [List.foldBack](../vs140/list.foldback--t--state--function--fsharp-.md) operation on an option.|  
|[forall](../vs140/option.forall--t--function--fsharp-.md)  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Evaluates the equivalent of [List.forall](../vs140/list.forall--t--function--fsharp-.md) for an option type.|  
|[get](../vs140/option.get--t--function--fsharp-.md)  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Gets the value associated with the option.|  
|[isNone](../vs140/option.isnone--t--function--fsharp-.md)  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the option is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[isSome](../vs140/option.issome--t--function--fsharp-.md)  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the option is not <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|[iter](../vs140/option.iter--t--function--fsharp-.md)  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Executes a function for an option value.|  
|[map](../vs140/option.map--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Transforms an option value by using a specified mapping function.|  
|[toArray](../vs140/option.toarray--t--function--fsharp-.md)  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Convert the option to an array of length 0 or 1.|  
|[toList](../vs140/option.tolist--t--function--fsharp-.md)  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Convert the option to a list of length 0 or 1.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)