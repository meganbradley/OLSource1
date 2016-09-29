---
title: "QueryBuilder.LastOrDefault&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.LastOrDefault"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "lastOrDefault query operator [F#]"
  - "LastOrDefault method [F#]"
ms.assetid: 67cce080-1b2b-49ee-94bc-3f18b085daed
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.LastOrDefault&lt;&#39;T,&#39;Q&gt; Method (F#)
A query operator that selects the last element of those selected so far, or a default value if no element is found.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.LastOrDefault : QuerySource<'T,'Q> -> 'T  
  
// Usage:  
queryBuilder.LastOrDefault (source)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
## Return Value  
 The last element of the query, or the default value for the type.  
  
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
 [Query Expressions (F#)](../VS_csharp/query-expressions--fsharp-.md)