---
title: "QueryBuilder.Last&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - Microsoft.FSharp.Linq.QueryBuilder.Last
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - last query operator [F#]
  - Last method [F#]
ms.assetid: bb3e1243-1369-4b44-8490-df8a20803dd6
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# QueryBuilder.Last&lt;&#39;T,&#39;Q&gt; Method (F#)
A query operator that selects the last element of those selected so far.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Last : QuerySource<'T,'Q> -> 'T  
  
// Usage:  
queryBuilder.Last (source)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>  
  
 The input query.  
  
## Return Value  
 The last element of the query.  
  
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