---
title: "RuntimeHelpers.Grouping&lt;&#39;K,&#39;T&gt; Class (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.Grouping``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Grouping class [F#]"
ms.assetid: 4a6ac4d6-5b30-44bb-b34d-c6773f86dedf
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeHelpers.Grouping&lt;&#39;K,&#39;T&gt; Class (F#)
Reconstructs a grouping after applying a mutable to immutable mapping transformation on a result of a query. This type is used to implement `groupBy` and `groupValBy` for F# query expressions.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type Grouping<'K,'T> =  
 class  
  inherit IEnumerable<'T>  
  inherit IEnumerable  
  inherit IGrouping<'K,'T>  
  new Grouping : 'K * seq<'T> -> Grouping<'K,'T>  
 end  
```  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/runtimehelpers.grouping--k--t--constructor--fsharp-.md)|Constructs a new instance of `Grouping`.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Linq.RuntimeHelpers Namespace (F#)](../vs140/microsoft.fsharp.linq.runtimehelpers-namespace--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)