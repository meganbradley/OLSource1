---
title: "QueryBuilder.MaxBy&lt;&#39;T,&#39;Q,&#39;Value&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.MaxBy"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "maxBy query operator [F#]"
  - "MaxBy method [F#]"
ms.assetid: a4c11a06-592d-4b9c-b8d5-284c93189dfe
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.MaxBy&lt;&#39;T,&#39;Q,&#39;Value&gt; Method (F#)
A query operator that selects a value for each element selected so far and returns the maximum resulting value.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.MaxBy : QuerySource<'T,'Q> * ('T -> 'Value) -> 'Value when 'Value : (IComparable)  
  
// Usage:  
queryBuilder.MaxBy (source, valueSelector)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `valueSelector`  
 Type: 'T -> 'Value  
  
 A function that computes the values to compare.  
  
## Return Value  
 The maximum value.  
  
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