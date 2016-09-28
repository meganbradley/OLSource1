---
title: "Set.partition&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Set.partition<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.Partition``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "partition function [F#]"
  - "Set.partition function [F#]"
ms.assetid: e5406822-361f-441b-ab6f-f22326b66320
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.partition&lt;&#39;T&gt; Function (F#)
Splits the set into two sets containing the elements for which the given predicate returns `true` and `false` respectively.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Set  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.partition : ('T -> bool) -> Set<'T> -> Set<'T> * Set<'T> (requires comparison)  
  
// Usage:  
Set.partition predicate set  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->` [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test set elements.  
  
 `set`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The input set.  
  
## Return Value  
 A pair of sets. The first contains the elements for which `predicate` returns `true` and the second contains the elements for which `predicate` returns `false`.  
  
## Remarks  
 This function is named `Partition` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)