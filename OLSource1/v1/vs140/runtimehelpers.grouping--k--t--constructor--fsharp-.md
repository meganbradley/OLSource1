---
title: "RuntimeHelpers.Grouping&lt;&#39;K,&#39;T&gt; Constructor (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.Grouping``2.#ctor"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Grouping constructor [F#]"
ms.assetid: 6372a867-5fcd-41e1-9616-8d3d094d5103
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeHelpers.Grouping&lt;&#39;K,&#39;T&gt; Constructor (F#)
Constructs a new instance of a grouping for use in F# query expressions.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
new Grouping : 'K * seq<'T> -> Grouping<'K,'T>  
  
// Usage:  
new Grouping (key, values)  
```  
  
#### Parameters  
 `key`  
 Type: 'K  
  
 The grouping key.  
  
 `values`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<'T>  
  
 The values to be grouped.  
  
## Return Value  
 A collection that represents the grouped values.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [RuntimeHelpers.Grouping<'K,'T> Class (F#)](../vs140/runtimehelpers.grouping--k--t--class--fsharp-.md)   
 [Microsoft.FSharp.Linq.RuntimeHelpers Namespace (F#)](../vs140/microsoft.fsharp.linq.runtimehelpers-namespace--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)