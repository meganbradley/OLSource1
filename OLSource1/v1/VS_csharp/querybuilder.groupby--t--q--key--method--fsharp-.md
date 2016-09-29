---
title: "QueryBuilder.GroupBy&lt;&#39;T,&#39;Q,&#39;Key&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.GroupBy"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GroupBy method [F#]"
  - "groupBy query operator [F#]"
ms.assetid: 1f3eeef6-c5f8-4942-87cd-94d7db5d6e99
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.GroupBy&lt;&#39;T,&#39;Q,&#39;Key&gt; Method (F#)
A query operator that groups the elements selected so far according to a specified key selector.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.GroupBy : QuerySource<'T,'Q> * ('T -> 'Key) -> QuerySource<IGrouping<'Key,'T>,'Q> when 'Key : equality  
  
// Usage:  
queryBuilder.GroupBy (source, keySelector)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `keySelector`  
 Type: 'T -> 'Key  
  
 A function that specifies a grouping for each element.  
  
## Return Value  
 The grouped query.  
  
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