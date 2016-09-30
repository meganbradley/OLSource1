---
title: "QueryBuilder.SkipWhile&lt;&#39;T,&#39;Q&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.SkipWhile"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "skipWhile query operator [F#]"
  - "skipWhile method [F#]"
ms.assetid: 614605f7-7282-44f5-ac23-190a24f34fb2
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.SkipWhile&lt;&#39;T,&#39;Q&gt; Method (F#)
A query operator that bypasses elements in a sequence as long as a specified condition is true and then selects the remaining elements.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'T,'Q>  
  
 The input query.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: 'T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A Boolean function to test the elements.  
  
## Return Value  
 The resulting query.  
  
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