---
title: "Set.exists&lt;&#39;T&gt; Function (F#)"
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
  - "Set.exists<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.Exists``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Set.exists function [F#]"
  - "exists function [F#]"
ms.assetid: 55bf43f8-e5f2-4e3d-900a-e4d7ca983541
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.exists&lt;&#39;T&gt; Function (F#)
Tests if any element of the collection satisfies the given predicate. If the input function is `predicate` and the elements are `i0...iN`, then this function computes `p i0 or ... or p iN`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.exists : ('T -> bool) -> Set<'T> -> bool (requires comparison)  
  
// Usage:  
Set.exists predicate set  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test set elements.  
  
 `set`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The input set.  
  
## Return Value  
 True if any element of `set` satisfies `predicate`.  
  
## Remarks  
 This function is named `Exists` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)