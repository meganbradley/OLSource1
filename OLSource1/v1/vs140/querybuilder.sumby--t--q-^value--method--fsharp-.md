---
title: "QueryBuilder.SumBy&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.SumBy"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "sumBy query operator [F#]"
  - "SumBy method [F#]"
ms.assetid: 96cbc51e-55e2-4ab4-bc8f-51edc5ac23eb
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.SumBy&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)
A query operator that selects a value for each element selected so far and returns the sum of these values.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.SumBy : QuerySource<'T,'Q> * ('T -> ^Value) -> ^Value when ^Value with static member (+) and ^Value with static member Zero  
  
// Usage:  
queryBuilder.SumBy (source, projection)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `projection`  
 Type: 'T -> ^Value  
  
 A function to compute the values to sum.  
  
## Return Value  
 The resulting sum.  
  
## Remarks  
 For more information and examples, see [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md).  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.QueryBuilder Class (F#)](../vs140/linq.querybuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)