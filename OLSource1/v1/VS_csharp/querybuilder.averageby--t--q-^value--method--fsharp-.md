---
title: "QueryBuilder.AverageBy&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.AverageBy"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AverageBy method [F#]"
  - "averageBy query operator [F#]"
ms.assetid: 8fc50dd7-0351-4a1c-a935-f97be6ede471
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.AverageBy&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)
A query operator that selects a value for each element selected so far and returns the average of these values.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.AverageBy : QuerySource<'T,'Q> * ('T -> ^Value) -> ^Value when ^Value with static member (+) and ^Value with static member DivideByInt and ^Value with static member Zero  
  
// Usage:  
queryBuilder.AverageBy (source, projection)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `projection`  
 Type: 'T -> ^Value  
  
 A function that determines a value for each element.  
  
## Return Value  
 The average of all the values produced by the projection function.  
  
## Remarks  
 For more information and examples, see [Query Expressions (F#)](../VS_csharp/query-expressions--fsharp-.md)  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.QueryBuilder Class (F#)](../VS_csharp/linq.querybuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../VS_csharp/microsoft.fsharp.linq-namespace--fsharp-.md)