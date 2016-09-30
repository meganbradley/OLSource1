---
title: "QueryBuilder.ExactlyOne&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.ExactlyOne"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ExactlyOne method [F#]"
  - "exactlyOne query operator [F#]"
ms.assetid: 821ec03c-537f-494f-a468-ab0f3910b0ae
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.ExactlyOne&lt;&#39;T,&#39;Q&gt; Method (F#)
A query operator that selects the single, specific element selected so far.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'T,'Q>  
  
 The input query.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.InvalidOperationException*>|Thrown when the query contains more than one selected element.|  
  
## Return Value  
 A single element.  
  
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