---
title: "QueryBuilder.AverageByNullable&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.AverageByNullable"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AverageByNullable method [F#]"
  - "averageByNullable query operator [F#]"
ms.assetid: eeba3a2d-5bcb-4785-ac44-2e53e3f4b8b3
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.AverageByNullable&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)
A query operator that selects a nullable value for each element selected so far and returns the average of these values. If any nullable does not have a value, it is ignored.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.AverageByNullable : QuerySource<'T,'Q> * ('T -> Nullable<^Value>) -> Nullable<^Value> when ^Value with static member (+) and ^Value with static member DivideByInt and ^Value with static member Zero and ^Value : (new : unit ->  ^Value) and ^Value : struct and ^Value :> ValueType  
  
// Usage:  
queryBuilder.AverageByNullable (source, projection)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `projection`  
 Type: 'T ->   <xref:System.Nullable`1*><^Value>  
  
 A function that computes a value for each element.  
  
## Return Value  
 The average value.  
  
## Remarks  
 Null values do not affect the average.  
  
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