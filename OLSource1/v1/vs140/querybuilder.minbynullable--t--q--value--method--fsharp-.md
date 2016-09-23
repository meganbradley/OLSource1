---
title: "QueryBuilder.MinByNullable&lt;&#39;T,&#39;Q,&#39;Value&gt; Method (F#)"
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
  - Microsoft.FSharp.Linq.QueryBuilder.MinByNullable
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - MinByNullable method [F#]
  - minByNullable query operator [F#]
ms.assetid: 8d790531-3401-4454-a701-45752652bcb9
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# QueryBuilder.MinByNullable&lt;&#39;T,&#39;Q,&#39;Value&gt; Method (F#)
A query operator that selects a nullable value for each element selected so far and returns the minimum of these values. If any nullable does not have a value, it is ignored.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.MinByNullable : QuerySource<'T,'Q> * ('T -> Nullable<'Value>) -> Nullable<'Value> when 'Value : (IComparable) and 'Value : (new : unit ->  'Value) and 'Value : struct and 'Value :> ValueType  
  
// Usage:  
queryBuilder.MinByNullable (source, valueSelector)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
 `valueSelector`  
 Type: 'T ->   <xref:System.Nullable`1?qualifyHint=False><'Value>  
  
 A function that computes the values to compare.  
  
## Return Value  
 The minimum value, or the default value for the type.  
  
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