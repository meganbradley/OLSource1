---
title: "QueryBuilder.SumByNullable&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.SumByNullable"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "SumByNullable method [F#]"
  - "sumByNullable query operator [F#]"
ms.assetid: 77cd4b85-cc4d-49d3-b84f-15bc1bc97d15
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.SumByNullable&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)
A query operator that selects a nullable value for each element selected so far and returns the sum of these values. If any nullable element does not have a value, it is ignored.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.SumByNullable : QuerySource<'T,'Q> * ('T -> Nullable<^Value>) -> Nullable<^Value> when ^Value with static member (+) and ^Value with static member Zero and ^Value : (new : unit ->  ^Value) and ^Value : struct and ^Value :> ValueType  
  
// Usage:  
queryBuilder.SumByNullable (source, valueSelector)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `valueSelector`  
 Type: 'T ->   <xref:System.Nullable`1*><^Value>  
  
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