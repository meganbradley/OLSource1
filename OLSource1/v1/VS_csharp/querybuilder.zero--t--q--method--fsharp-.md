---
title: "QueryBuilder.Zero&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.Zero"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Zero method [F#]"
ms.assetid: f7724401-70a6-4767-a801-94b3d27ff349
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.Zero&lt;&#39;T,&#39;Q&gt; Method (F#)
A method used to support the F# query syntax. Returns an empty sequence that has the specified type argument.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Zero : unit -> QuerySource<'T,'Q>  
  
// Usage:  
queryBuilder.Zero ()  
```  
  
## Return Value  
 The resulting empty query.  
  
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