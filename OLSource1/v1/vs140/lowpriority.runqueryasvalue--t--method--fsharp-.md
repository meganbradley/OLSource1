---
title: "LowPriority.RunQueryAsValue&lt;&#39;T&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.RunQueryAsValue"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RunQueryAsValue method [F#]"
ms.assetid: 152d4f48-b7da-4085-9ce3-44318aa8b9d6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LowPriority.RunQueryAsValue&lt;&#39;T&gt; Method (F#)
Runs a query to produce a simple value.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.RunQueryAsValue : Expr<'T> -> 'T  
  
// Usage:  
queryBuilder.RunQueryAsValue (expr)  
```  
  
#### Parameters  
 `expr`  
 Type: [Expr](../vs140/quotations.expr--t--class--fsharp-.md)<'T>  
  
 The query as an expression.  
  
## Return Value  
 The query result as a simple value.  
  
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
 [QueryRunExtensions.LowPriority Module (F#)](../vs140/queryrunextensions.lowpriority-module--fsharp-.md)