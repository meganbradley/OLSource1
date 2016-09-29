---
title: "QueryBuilder.All&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.All"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "All method [F#]"
  - "all query operator [F#]"
ms.assetid: a8d98783-4121-40c9-82d7-3e5ac50b1d09
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.All&lt;&#39;T,&#39;Q&gt; Method (F#)
A query operator that determines whether all elements selected so far satisfy a condition.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.All : QuerySource<'T,'Q> * ('T -> bool) -> bool  
  
// Usage:  
queryBuilder.All (source, predicate)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `predicate`  
 Type: 'T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 A Boolean function to test the elements.  
  
## Return Value  
 `true` if the provided Boolean function `predicate` evaluates to true for all elements selected so far.  
  
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