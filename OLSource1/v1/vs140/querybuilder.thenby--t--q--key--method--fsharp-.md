---
title: "QueryBuilder.ThenBy&lt;&#39;T,&#39;Q,&#39;Key&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.ThenBy"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ThenBy method [F#]"
  - "thenBy query operator [F#]"
ms.assetid: 9adf72a5-cff5-4a18-9d35-626d11e8ae03
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.ThenBy&lt;&#39;T,&#39;Q,&#39;Key&gt; Method (F#)
A query operator that performs a subsequent ordering of the elements selected so far in ascending order by the given sorting key. This operator may only be used immediately after a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or their nullable variants.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'T,'Q>  
  
 The input query.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Type: 'T -> 'Key  
  
 Specifies the field to sort by.  
  
## Return Value  
 The sorted query.  
  
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