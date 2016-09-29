---
title: "QueryBuilder.SortByNullable&lt;&#39;T,&#39;Q,&#39;Key&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.SortByNullable"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "SortByNullable method [F#]"
  - "sortByNullable query operator [F#]"
ms.assetid: 5e804c59-b88a-48f0-9ccd-f9a61019ced3
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.SortByNullable&lt;&#39;T,&#39;Q,&#39;Key&gt; Method (F#)
A query operator that sorts the elements selected so far in ascending order by the given nullable sorting key.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.SortByNullable : QuerySource<'T,'Q> * ('T -> Nullable<'Key>) -> QuerySource<'T,'Q> when 'Key : (IComparable) and 'Key : (new : unit ->  'Key) and 'Key : struct and 'Key :> ValueType  
  
// Usage:  
queryBuilder.SortByNullable (source, keySelector)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `keySelector`  
 Type: 'T ->   <xref:System.Nullable`1*><'Key>  
  
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