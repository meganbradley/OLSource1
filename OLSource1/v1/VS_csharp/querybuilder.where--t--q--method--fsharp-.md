---
title: "QueryBuilder.Where&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.Where"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Where method [F#]"
  - "where query operator [F#]"
ms.assetid: 2bf64a26-135f-4340-863a-d0f142c6ad45
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.Where&lt;&#39;T,&#39;Q&gt; Method (F#)
A query operator that selects those elements based on a specified predicate.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Where : QuerySource<'T,'Q> * ('T -> bool) -> QuerySource<'T,'Q>  
  
// Usage:  
queryBuilder.Where (source, predicate)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `predicate`  
 Type: 'T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 A Boolean expression that specifies elements to select.  
  
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
 [How to: Handle Exceptions in Query Expressions (C# Programming Guide)](../VS_csharp/how-to--handle-exceptions-in-query-expressions--csharp-programming-guide-.md)