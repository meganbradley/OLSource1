---
title: "Array.reduce&lt;&#39;T&gt; Function (F#)"
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
  - "Array.reduce<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Reduce``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "reduce function [F#]"
  - "Array.reduce function [F#]"
ms.assetid: fd62a985-89fe-4f49-a9d4-0c808ac6749d
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.reduce&lt;&#39;T&gt; Function (F#)
Applies a function to each element of the array, threading an accumulator argument through the computation. If the input function is `f` and the elements are `i0...iN`, then computes `f (... (f i0 i1)...) iN`. Raises \<xref:System.ArgumentException*> if the array has size zero.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.reduce : ('T -> 'T -> 'T) -> 'T [] -> 'T  
  
// Usage:  
Array.reduce reduction array  
```  
  
#### Parameters  
 `reduction`  
 Type: `'T -> 'T -> 'T`  
  
 The function to reduce a pair of elements to a single element.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input array is empty.|  
  
## Return Value  
 The final result of the reductions.  
  
## Remarks  
 This function is named `Reduce` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Array.reduce`.  
  
 [!code[FsSamples101#1006](../vs140/codesnippet/FSharp/array.reduce--t--function--fsharp-_1.fs)]  
  
 **sentence = A man landed on the moon**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)