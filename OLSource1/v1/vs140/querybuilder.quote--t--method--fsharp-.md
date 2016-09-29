---
title: "QueryBuilder.Quote&lt;&#39;T&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.Quote"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Quote method [F#]"
ms.assetid: 0e0e0a24-8646-41b7-93f0-7fdc13ed0875
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.Quote&lt;&#39;T&gt; Method (F#)
A method used to support the F# query syntax. Indicates that the query should be passed as a quotation to the [Run](../vs140/querybuilder.run--t--method--fsharp-.md) method.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Quote : Expr<'T> -> Expr<'T>  
  
// Usage:  
queryBuilder.Quote ()  
```  
  
#### Parameters  
 `source`  
 Type: [Expr](../vs140/quotations.expr--t--class--fsharp-.md)<'T>  
  
 The input query.  
  
## Return Value  
 The query as an F# quotation.  
  
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