---
title: "Array.iteri2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "Array.iteri2<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.IterateIndexed2``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IterateIndexed2 function [F#]"
  - "iteri2 function [F#]"
  - "Array.iteri2 function [F#]"
  - "Array.IterateIndexed2 function [F#]"
ms.assetid: c041b91f-6080-45b7-867b-2ed983a90405
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.iteri2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Applies the given function to a pair of elements drawn from matching indices in two arrays, also passing the index of the elements. The two arrays must have the same lengths, otherwise <xref:System.ArgumentException*> is raised.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.iteri2 : (int -> 'T1 -> 'T2 -> unit) -> 'T1 [] -> 'T2 [] -> unit  
  
// Usage:  
Array.iteri2 action array1 array2  
```  
  
#### Parameters  
 `action`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `-> 'T1 -> 'T2 ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to each index and pair of elements.  
  
 `array1`  
 Type: `'T1` [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The first input array.  
  
 `array2`  
 Type: `'T2` [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The second input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input arrays differ in length.|  
  
## Remarks  
 This function is named `IterateIndexed2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code examples shows the differences between [Array.iter](../vs140/array.iter--t--function--fsharp-.md), [Array.iter2](../vs140/array.iter2--t1--t2--function--fsharp-.md), [Array.iteri](../vs140/array.iteri--t--function--fsharp-.md), and `Array.iteri2`.  
  
 [!code[FsArrays#49](../vs140/codesnippet/FSharp/array.iteri2--t1--t2--function--fsharp-_1.fs)]  
  
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