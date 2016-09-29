---
title: "QueryBuilder.YieldFrom&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.YieldFrom"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "YieldFrom method [F#]"
ms.assetid: 3b356180-969c-4901-8253-aac77731f1ac
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.YieldFrom&lt;&#39;T,&#39;Q&gt; Method (F#)
A method used to support the F# query syntax. Returns a sequence that contains the specified values.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.YieldFrom : QuerySource<'T,'Q> -> QuerySource<'T,'Q>  
  
// Usage:  
queryBuilder.YieldFrom (computation)  
```  
  
#### Parameters  
 `computation`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
## Return Value  
 A query that is the same as the input query.  
  
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