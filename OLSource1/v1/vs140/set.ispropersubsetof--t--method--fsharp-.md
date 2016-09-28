---
title: "Set.IsProperSubsetOf&lt;&#39;T&gt; Method (F#)"
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
  - "Set.IsProperSubsetOf<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpSet`1.IsProperSubsetOf"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IsProperSubsetOf method [F#]"
  - "Set.IsProperSubsetOf method [F#]"
ms.assetid: bd0a671b-51ff-4c9e-b2fb-5089244750f5
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.IsProperSubsetOf&lt;&#39;T&gt; Method (F#)
Evaluates to `true` if all elements of the first set are in the second, and at least one element of the second is not in the first.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.IsProperSubsetOf : Set<'T> -> bool (requires comparison)  
  
// Usage:  
set.IsProperSubsetOf (otherSet)  
```  
  
#### Parameters  
 `otherSet`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The set to test against.  
  
## Return Value  
 `true` if this set is a proper subset of `otherSet`. Otherwise, returns `false`.  
  
## Remarks  
  
## Example  
 The following code illustrates the use of the `IsProperSubsetOf` method.  
  
 [!code[FsSets#6](../vs140/codesnippet/FSharp/set.ispropersubsetof--t--method--fsharp-_1.fs)]  
  
 **Output**  
  
 **set [1; 2; 3; 4; 5] is a proper subset of set [1; 2; 3; 4; 5; 6]: trueset [1; 2; 3; 4; 5; 6] is a proper subset of set [1; 2; 3; 4; 5; 6]: falseset [5; 6; 7; 8; 9; 10] is a proper subset of set [1; 2; 3; 4; 5; 6]: false**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set<'T> Class (F#)](../vs140/collections.set--t--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)