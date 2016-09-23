---
title: "QueryBuilder.LeftOuterJoin&lt;&#39;Outer,&#39;Q,&#39;Inner,&#39;Key,&#39;Result&gt; Method (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Linq.QueryBuilder.LeftOuterJoin
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - leftOuterJoin query operator [F#]
  - LeftOuterJoin method [F#]
ms.assetid: bd5c4e49-f1e8-45c0-8d26-04c2173e0204
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# QueryBuilder.LeftOuterJoin&lt;&#39;Outer,&#39;Q,&#39;Inner,&#39;Key,&#39;Result&gt; Method (F#)
A query operator that correlates two sets of selected values based on matching keys and groups the results. If any group is empty, a group with a single default value is used instead. Normal usage is `leftOuterJoin (for y in elements2 -> key1 = key2) into group`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.LeftOuterJoin : QuerySource<'Outer,'Q> * QuerySource<'Inner,'Q> * ('Outer -> 'Key) * ('Inner -> 'Key) * ('Outer -> seq<'Inner> -> 'Result) -> QuerySource<'Result,'Q>  
  
// Usage:  
queryBuilder.LeftOuterJoin (outerSource, innerSource, outerKeySelector, innerKeySelector, resultSelector)  
```  
  
#### Parameters  
 `outerSource`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Outer,'Q>  
  
 The outer query.  
  
 `innerSource`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Inner,'Q>  
  
 The inner query.  
  
 `outerKeySelector`  
 Type: 'Outer -> 'Key  
  
 A function to select the correlation key from the outer query.  
  
 `innerKeySelector`  
 Type: 'Inner -> 'Key  
  
 A function to select the correlation key from the inner query.  
  
 `resultSelector`  
 Type: 'Outer ->   [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<'Inner> ->   'Result  
  
 A function to select the resulting elements.  
  
## Return Value  
 The resulting query.  
  
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