---
title: "QueryBuilder.GroupValBy&lt;&#39;T,&#39;Key,&#39;Value,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.GroupValBy"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "groupValBy query operator [F#]"
  - "GroupValBy method [F#]"
ms.assetid: 9d95eca7-906f-4369-93a7-bb8dbbd8ae87
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.GroupValBy&lt;&#39;T,&#39;Key,&#39;Value,&#39;Q&gt; Method (F#)
A query operator that selects a value for each element selected so far and groups the elements by the given key.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.GroupValBy : QuerySource<'T,'Q> * ('T -> 'Value) * ('T -> 'Key) -> QuerySource<IGrouping<'Key,'Value>,'Q> when 'Key : equality  
  
// Usage:  
queryBuilder.GroupValBy (source, resultSelector, keySelector)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'T,'Q>  
  
 The input query.  
  
 `resultSelector`  
 Type: 'T -> 'Value  
  
 A function that computes a value for each element.  
  
 `keySelector`  
 Type: 'T -> 'Key  
  
 A function that returns the grouping key for each element.  
  
## Return Value  
 The grouped query.  
  
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