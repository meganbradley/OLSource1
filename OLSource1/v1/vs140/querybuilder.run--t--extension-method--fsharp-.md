---
title: "QueryBuilder.Run&lt;&#39;T&gt; Extension Method (F#)"
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
  - Microsoft.FSharp.Linq.QueryBuilder.Run
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Run extension method [F#]
ms.assetid: d1f5e74f-fb0b-4c5d-9fa7-ba4dae215123
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# QueryBuilder.Run&lt;&#39;T&gt; Extension Method (F#)
An extension method used to support the F# query syntax. Runs the given quotation as a query using LINQ IQueryable rules.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Run : Expr<QuerySource<'T,IQueryable>> -> IQueryable<'T>  
  
// Usage:  
queryBuilder.Run (quotation)  
```  
  
#### Parameters  
 `quotation`  
 Type: [Expr](../vs140/quotations.expr--t--class--fsharp-.md)<[QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,                        <xref:System.Linq.IQueryable?qualifyHint=False>>>  
  
 A quotation expression tree that represents a query.  
  
## Return Value  
 The query as a queryable value.  
  
## Remarks  
 For more information and examples, see [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md).  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0Supported in: 4.0, Portable  
  
## See Also  
 [Linq.QueryBuilder Class (F#)](../vs140/linq.querybuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)