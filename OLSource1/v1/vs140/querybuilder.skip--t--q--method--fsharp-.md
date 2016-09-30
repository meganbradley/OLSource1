---
title: "QueryBuilder.Skip&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.Skip"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Skip method [F#]"
  - "skip query operator [F#]"
ms.assetid: f4f212fb-9f35-4398-84ce-95f12e0b6687
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.Skip&lt;&#39;T,&#39;Q&gt; Method (F#)
A query operator that bypasses a specified number of the elements selected so far and selects the remaining elements.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'T,'Q>  
  
 The input query.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The number of elements to skip.  
  
## Return Value  
 The resulting query.  
  
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