---
title: "QueryBuilder.AverageBy&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.AverageBy"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AverageBy method [F#]"
  - "averageBy query operator [F#]"
ms.assetid: 8fc50dd7-0351-4a1c-a935-f97be6ede471
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.AverageBy&lt;&#39;T,&#39;Q,^Value&gt; Method (F#)
A query operator that selects a value for each element selected so far and returns the average of these values.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'T,'Q>  
  
 The input query.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: 'T -> ^Value  
  
 A function that determines a value for each element.  
  
## Return Value  
 The average of all the values produced by the projection function.  
  
## Remarks  
 For more information and examples, see [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.QueryBuilder Class (F#)](../vs140/linq.querybuilder-class--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)