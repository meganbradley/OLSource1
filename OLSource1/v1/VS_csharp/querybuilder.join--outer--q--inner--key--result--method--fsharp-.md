---
title: "QueryBuilder.Join&lt;&#39;Outer,&#39;Q,&#39;Inner,&#39;Key,&#39;Result&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.Join"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Join method [F#]"
  - "join query operator [F#]"
ms.assetid: 4718e1d1-a70c-40bd-a690-b187b4849583
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.Join&lt;&#39;Outer,&#39;Q,&#39;Inner,&#39;Key,&#39;Result&gt; Method (F#)
A query operator that correlates two sets of selected values based on matching keys. Normal usage is `join (for y in elements2 -> key1 = key2)`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Join : QuerySource<'Outer,'Q> * QuerySource<'Inner,'Q> * ('Outer -> 'Key) * ('Inner -> 'Key) * ('Outer -> 'Inner -> 'Result) -> QuerySource<'Result,'Q>  
  
// Usage:  
queryBuilder.Join (outerSource, innerSource, outerKeySelector, innerKeySelector, resultSelector)  
```  
  
#### Parameters  
 `outerSource`  
 Type: [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Outer,'Q>  
  
 The outer query.  
  
 `innerSource`  
 Type: [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Inner,'Q>  
  
 The inner query.  
  
 `outerKeySelector`  
 Type: 'Outer -> 'Key  
  
 A function that returns the outer correlation key.  
  
 `innerKeySelector`  
 Type: 'Inner -> 'Key  
  
 A function that returns the inner correlation key.  
  
 `resultSelector`  
 Type: 'Outer -> 'Inner ->   'Result  
  
 A function to return the results of the join operation.  
  
## Return Value  
 The resulting query.  
  
## Remarks  
 For more information and examples, see [Query Expressions (F#)](../VS_csharp/query-expressions--fsharp-.md).  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.QueryBuilder Class (F#)](../VS_csharp/linq.querybuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../VS_csharp/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Query Expressions (F#)](../VS_csharp/query-expressions--fsharp-.md)