---
title: "Array.iter2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "Array.iter2<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Iterate2``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "iter2 function [F#]"
  - "Array.iter2 function [F#]"
  - "Array.Iterate2 function [F#]"
  - "Iterate2 function [F#]"
ms.assetid: 018aa9b9-f186-4142-be8a-a62462794fdc
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.iter2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Applies the given function to pair of elements drawn from matching indices in two arrays. The two arrays must have the same lengths, otherwise an <xref:System.ArgumentException*> is raised.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.iter2 : ('T1 -> 'T2 -> unit) -> 'T1 [] -> 'T2 [] -> unit  
  
// Usage:  
Array.iter2 action array1 array2  
```  
  
#### Parameters  
 `action`  
 Type: `'T1 -> 'T2 ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply.  
  
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
 This function is named `Iterate2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows the differences between [Array.iter](../vs140/array.iter--t--function--fsharp-.md), `Array.iter2`, [Array.iteri](../vs140/array.iteri--t--function--fsharp-.md), and [Array.iteri2](../vs140/array.iteri2--t1--t2--function--fsharp-.md).  
  
 [!code[FsArrays#49](../vs140/codesnippet/FSharp/array.iter2--t1--t2--function--fsharp-_1.fs)]  
  
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