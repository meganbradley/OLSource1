---
title: "Set.isProperSubset&lt;&#39;T&gt; Function (F#)"
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
  - "Set.isProperSubset<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.IsProperSubset``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "isProperSubset function [F#]"
  - "Set.isProperSubset function [F#]"
ms.assetid: 5f3d1d4a-8ba5-488f-89b1-e312fd3fd29b
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.isProperSubset&lt;&#39;T&gt; Function (F#)
Evaluates to `true` if all elements of the first set are in the second, and at least one element of the second is not in the first.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.isProperSubset : Set<'T> -> Set<'T> -> bool (requires comparison)  
  
// Usage:  
Set.isProperSubset set1 set2  
```  
  
#### Parameters  
 `set1`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The potential subset.  
  
 `set2`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The set to test against.  
  
## Return Value  
 `true` if `set1` is a proper subset of `set2`. Otherwise, returns `false`.  
  
## Remarks  
 This function is named `IsProperSubset` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of the `Set.isProperSubset` function.  
  
 [!code[FsSets#7](../vs140/codesnippet/FSharp/set.ispropersubset--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **set [1; 2; 3; 4; 5] is a proper subset of set [1; 2; 3; 4; 5; 6]: true**  
**set [1; 2; 3; 4; 5; 6] is a proper subset of set [1; 2; 3; 4; 5; 6]: false**  
**set [5; 6; 7; 8; 9; 10] is a proper subset of set [1; 2; 3; 4; 5; 6]: false**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)