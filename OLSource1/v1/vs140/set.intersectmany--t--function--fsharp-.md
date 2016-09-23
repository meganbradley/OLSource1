---
title: "Set.intersectMany&lt;&#39;T&gt; Function (F#)"
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
  - Set.intersectMany<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SetModule.IntersectMany``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Set.intersectMany function [F#]
  - intersectMany function [F#]
ms.assetid: 2a0a9352-205f-4ea2-9b4c-c58f73a8e784
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Set.intersectMany&lt;&#39;T&gt; Function (F#)
Computes the intersection of a sequence of sets. The sequence must be non-empty.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Set  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.intersectMany : seq<Set<'T>> -> Set<'T> (requires comparison)  
  
// Usage:  
Set.intersectMany sets  
```  
  
#### Parameters  
 `sets`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<`[Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>>`  
  
 The sequence of sets to intersect.  
  
## Return Value  
 The intersection of the input sets.  
  
## Remarks  
 This function is named `IntersectMany` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of the `Set.intersectMany` function.  
  
 [!code[FsSets#5](../vs140/codesnippet/FSharp/set.intersectmany--t--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **Numbers between 1 and 10,000 that are divisible by**   
**all the numbers from 1 to 9:**  
**set [2520; 5040; 7560]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)