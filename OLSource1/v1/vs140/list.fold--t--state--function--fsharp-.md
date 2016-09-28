---
title: "List.fold&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - "List.fold<'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Fold``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.fold function [F#]"
  - "fold function [F#]"
ms.assetid: c272779e-bae7-4983-8d7f-16b345bb33a0
caps.latest.revision: 28
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.fold&lt;&#39;T,&#39;State&gt; Function (F#)
Applies a function `f` to each element of the collection, threading an accumulator argument through the computation. The `fold` function takes the second argument, and applies the function `f` to it and the first element of the list. Then, it feeds this result into the function `f` along with the second element, and so on. It returns the final result. If the input function is `f` and the elements are `i0...iN`, then this function computes `f (... (f s i0) i1 ...) iN`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.fold : ('State -> 'T -> 'State) -> 'State -> 'T list -> 'State  
  
// Usage:  
List.fold folder state list  
```  
  
#### Parameters  
 `folder`  
 Type: `'State -> 'T -> 'State`  
  
 The function to update the state given the input elements.  
  
 `state`  
 Type: `'State`  
  
 The initial state.  
  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The final state value.  
  
## Remarks  
 This function is named `Fold` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `List.fold`  
  
 [!code[FsSamples101#3006](../vs140/codesnippet/FSharp/list.fold--t--state--function--fsharp-_1.fs)]  
  
 **Total number of animals: 14**   
## Example  
 The following code example illustrates additional uses of `List.fold`. Note that library functions exist that already encapsulate the functionality implemented below. For example, [List.sum](../vs140/list.sum-^t--function--fsharp-.md) is available to add up all the elements of a list.  
  
 [!code[FsLists#27](../vs140/codesnippet/FSharp/list.fold--t--state--function--fsharp-_2.fs)]  
  
 **Output**  
  
 **Sum of the elements of list [1; 2; 3] is 6.**  
**List [1; 1; 1] average: 1.000000 stddev: 0.000000**  
**List [1; 2; 1] average: 1.333333 stddev: 0.471405**  
**List [1; 2; 3] average: 2.000000 stddev: 0.816497**  
**0.0**  
**1.0**  
**2.5**  
**5.1**  
**[10; 9; 8; 7; 6; 5; 4; 3; 2; 1]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)