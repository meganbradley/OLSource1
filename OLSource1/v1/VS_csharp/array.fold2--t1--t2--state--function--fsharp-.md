---
title: "Array.fold2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)"
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
  - "Array.fold2<'T1,'T2,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Fold2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.fold2 function [F#]"
  - "fold2 function [F#]"
ms.assetid: 5c845087-d041-476e-8cc4-53ae6849ef79
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.fold2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)
Applies a function to pairs of elements drawn from the two collections, left-to-right, threading an accumulator argument through the computation. The two input arrays must have the same lengths, otherwise <xref:System.ArgumentException*> is raised.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.fold2 : ('State -> 'T1 -> 'T2 -> 'State) -> 'State -> 'T1 [] -> 'T2 [] -> 'State  
  
// Usage:  
Array.fold2 folder state array1 array2  
```  
  
#### Parameters  
 `folder`  
 Type: `'State -> 'T1 -> 'T2 -> 'State`  
  
 The function to update the state given the input elements.  
  
 `state`  
 Type: `'State`  
  
 The initial state.  
  
 `array1`  
 Type: `'T1`[&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The first input array.  
  
 `array2`  
 Type: `'T2`[&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The second input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input arrays differ in length.|  
  
## Return Value  
 The final state.  
  
## Remarks  
 This function is named `Fold2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Array.fold2`.  
  
 [!code[FsArrays#45](../VS_csharp/codesnippet/FSharp/array.fold2--t1--t2--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The sum of the greater of each pair of elements in the two arrays is 8.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../VS_csharp/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)