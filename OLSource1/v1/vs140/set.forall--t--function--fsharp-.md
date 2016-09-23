---
title: "Set.forall&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Set.forall<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SetModule.ForAll``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - forall function [F#]
  - Set.forall function [F#]
ms.assetid: 9d985cca-ad37-4402-a039-7db47442f578
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Set.forall&lt;&#39;T&gt; Function (F#)
Tests if all elements of the collection satisfy the given predicate. If the input function is `f` and the elements are `i0...iN` then computes `p i0 && ... && p iN`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Set  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.forall : ('T -> bool) -> Set<'T> -> bool (requires comparison)  
  
// Usage:  
Set.forall predicate set  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test set elements.  
  
 `set`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The input set.  
  
## Return Value  
 `true` if all elements of `set` satisfy `predicate`. Otherwise, returns `false`.  
  
## Remarks  
 This function is named `ForAll` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)