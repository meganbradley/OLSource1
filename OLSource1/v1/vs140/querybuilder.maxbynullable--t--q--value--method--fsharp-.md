---
title: "QueryBuilder.MaxByNullable&lt;&#39;T,&#39;Q,&#39;Value&gt; Method (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder.MaxByNullable"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "maxByNullable query operator [F#]"
  - "MaxByNullable method [F#]"
ms.assetid: b561d7ff-be4e-46dd-99c6-6f69008f2b74
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryBuilder.MaxByNullable&lt;&#39;T,&#39;Q,&#39;Value&gt; Method (F#)
A query operator that selects a nullable value for each element selected so far and returns the maximum of these values. If any nullable does not have a value, it is ignored.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)\<'T,'Q>  
  
 The input query.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: 'T ->   \<xref:System.Nullable`1*>\<'Value>  
  
 A function that computes the values to compare.  
  
## Return Value  
 The maximum value.  
  
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