---
title: "Array.foldBack&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - Array.foldBack<'T,'State>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ArrayModule.FoldBack``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - foldBack function [F#]
  - Array.foldBack function [F#]
ms.assetid: 1121a453-dead-4711-a0ca-cc147752989c
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array.foldBack&lt;&#39;T,&#39;State&gt; Function (F#)
Applies a function to each element of the array, threading an accumulator argument through the computation. If the input function is `f` and the elements are `i0...iN` then computes `f i0 (...(f iN s))`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.foldBack : ('T -> 'State -> 'State) -> 'T [] -> 'State -> 'State  
  
// Usage:  
Array.foldBack folder array state  
```  
  
#### Parameters  
 `folder`  
 Type: `'T -> 'State -> 'State`  
  
 The function to update the state given the input elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
 `state`  
 Type: `'State`  
  
 The initial state.  
  
## Return Value  
 The final state.  
  
## Remarks  
 This function is named `FoldBack` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows the difference between [Array.fold](../vs140/array.fold--t--state--function--fsharp-.md) and `Array.foldBack`.  
  
 [!code[FsArrays#46](../vs140/codesnippet/FSharp/array.foldback--t--state--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **-6**  
**2**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)