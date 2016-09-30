---
title: "QueryBuilder.For&lt;&#39;T,&#39;Q,&#39;Result,&#39;Q2&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.For"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "for query operator [F#]"
  - "For method [F#]"
ms.assetid: 8f8ca87c-5648-476b-a540-af94aba2c0ca
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.For&lt;&#39;T,&#39;Q,&#39;Result,&#39;Q2&gt; Method (F#)
A method used to support the F# query syntax. Projects each element of a sequence to another sequence and combines the resulting sequences into one sequence.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.For : QuerySource<'T,'Q> * ('T -> QuerySource<'Result,'Q2>) -> QuerySource<'Result,'Q>  
  
// Usage:  
queryBuilder.For (source, body)  
```  
  
#### Parameters  
 `source`  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'T,'Q>  
  
 The input query.  
  
 `body`  
 Type: 'T ->   [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'Result,'Q2>  
  
 A function that represents the body of the for loop in a query expression.  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This method implements the for loop syntax for query expressions.  
  
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