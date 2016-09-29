---
title: "Array.iteri&lt;&#39;T&gt; Function (F#)"
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
  - "Array.iteri<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.IterateIndexed``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "iteri function [F#]"
  - "Array.IterateIndexed function [F#]"
  - "Array.iteri function [F#]"
  - "IterateIndexed function [F#]"
ms.assetid: 8bbe2ed4-ada7-4906-ac3e-cb09f9db6486
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.iteri&lt;&#39;T&gt; Function (F#)
Applies the given function to each element of the array. The integer passed to the function indicates the index of element.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.iteri : (int -> 'T -> unit) -> 'T [] -> unit  
  
// Usage:  
Array.iteri action array  
```  
  
#### Parameters  
 `action`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `-> 'T ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to each index and element.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Remarks  
 This function is named `IterateIndexed` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code examples shows the differences between [Array.iter](../vs140/array.iter--t--function--fsharp-.md), [Array.iter2](../vs140/array.iter2--t1--t2--function--fsharp-.md), `Array.iteri`, and [Array.iteri2](../vs140/array.iteri2--t1--t2--function--fsharp-.md).  
  
 [!code[FsArrays#49](../vs140/codesnippet/FSharp/array.iteri--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Array.iter: element is 1**  
**Array.iter: element is 2**  
**Array.iter: element is 3**  
**Array.iteri: element 0 is 1**  
**Array.iteri: element 1 is 2**  
**Array.iteri: element 2 is 3**  
**Array.iter2: elements are 1 4**  
**Array.iter2: elements are 2 5**  
**Array.iter2: elements are 3 6**  
**Array.iteri2: element 0 of array1 is 1 element 0 of array2 is 4**  
**Array.iteri2: element 1 of array1 is 2 element 1 of array2 is 5**  
**Array.iteri2: element 2 of array1 is 3 element 2 of array2 is 6**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)