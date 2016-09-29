---
title: "QueryBuilder.Find&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.Find"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Find method [F#]"
  - "find query operator [F#]"
ms.assetid: 8add5f31-9ca9-4f3e-8bcb-06d117015779
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.Find&lt;&#39;T,&#39;Q&gt; Method (F#)
A query operator that selects the first element selected so far that satisfies a specified condition.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Find : QuerySource<'T,'Q> * ('T -> bool) -> 'T  
  
// Usage:  
queryBuilder.Find (source, predicate)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `predicate`  
 Type: 'T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function that tests each element.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.InvalidOperationException*>|Thrown when no element returns `true` when evaluated by the predicate.|  
  
## Return Value  
 The first element for which the Boolean function `predicate` returns `true`.  
  
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