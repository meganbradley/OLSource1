---
title: "List.tryFindIndex&lt;&#39;T&gt; Function (F#)"
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
  - "List.tryFindIndex<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.TryFindIndex``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "tryFindIndex function [F#]"
  - "List.tryFindIndex function [F#]"
ms.assetid: 5e31968c-c3d3-43d2-859a-0526825895ec
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.tryFindIndex&lt;&#39;T&gt; Function (F#)
Returns the index of the first element in the list that satisfies the given predicate. Return `None` if no such element exists.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.tryFindIndex : ('T -> bool) -> 'T list -> int option  
  
// Usage:  
List.tryFindIndex predicate list  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `list`  
 Type: `'T`[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The index of the first element for which the predicate returns `true`, or `None` if every element evaluates to `false`.  
  
## Remarks  
 This function is named `TryFindIndex` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.tryFind` and `List.tryFindIndex`.  
  
 [!code[FsLists#10](../VS_csharp/codesnippet/FSharp/list.tryfindindex--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The first even value is 22.**  
**The first even value is at position 8.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../VS_csharp/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)