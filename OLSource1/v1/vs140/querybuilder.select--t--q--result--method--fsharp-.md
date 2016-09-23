---
title: "QueryBuilder.Select&lt;&#39;T,&#39;Q,&#39;Result&gt; Method (F#)"
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
  - Microsoft.FSharp.Linq.QueryBuilder.Select
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - select query operator [F#]
  - Select method [F#]
ms.assetid: 5b26a6ed-0975-403a-9bca-34cd448ecc8f
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# QueryBuilder.Select&lt;&#39;T,&#39;Q,&#39;Result&gt; Method (F#)
A query operator that projects each of the elements selected so far.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Select : QuerySource<'T,'Q> * ('T -> 'Result) -> QuerySource<'Result,'Q>  
  
// Usage:  
queryBuilder.Select (source, projection)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `projection`  
 Type: 'T -> 'Result  
  
 A function that returns a result from each element in the input query.  
  
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