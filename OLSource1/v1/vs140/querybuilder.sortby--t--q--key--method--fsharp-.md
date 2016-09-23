---
title: "QueryBuilder.SortBy&lt;&#39;T,&#39;Q,&#39;Key&gt; Method (F#)"
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
  - Microsoft.FSharp.Linq.QueryBuilder.SortBy
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - sortBy query operator [F#]
  - sortBy method [F#]
ms.assetid: edbaae82-a4bf-4487-b247-de2fbf2e5ba8
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# QueryBuilder.SortBy&lt;&#39;T,&#39;Q,&#39;Key&gt; Method (F#)
A query operator that sorts the elements selected so far in ascending order by the given sorting key.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.SortBy : QuerySource<'T,'Q> * ('T -> 'Key) -> QuerySource<'T,'Q> when 'Key : (IComparable)  
  
// Usage:  
queryBuilder.SortBy (source, keySelector)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `keySelector`  
 Type: 'T -> 'Key  
  
 Specifies the field to sort by.  
  
## Return Value  
 The sorted query.  
  
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