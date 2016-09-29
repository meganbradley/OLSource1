---
title: "Set.intersect&lt;&#39;T&gt; Function (F#)"
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
  - "Set.intersect<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.Intersect``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "intersect function [F#]"
  - "Set.intersect function [F#]"
ms.assetid: 540f4b96-34d6-47f0-8881-e3a434abade1
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.intersect&lt;&#39;T&gt; Function (F#)
Computes the intersection of the two sets.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.intersect : Set<'T> -> Set<'T> -> Set<'T> (requires comparison)  
  
// Usage:  
Set.intersect set1 set2  
```  
  
#### Parameters  
 `set1`  
 Type: [Set](../VS_csharp/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The first input set.  
  
 `set2`  
 Type: [Set](../VS_csharp/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The second input set.  
  
## Return Value  
 The intersection of `set1` and `set2`.  
  
## Remarks  
 This function is named `Intersect` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of the `Set.intersect` function.  
  
 [!code[FsSets#4](../VS_csharp/codesnippet/FSharp/set.intersect--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Set.intersect [1 .. 3] [2 .. 6] yields set [2; 3]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../VS_csharp/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)