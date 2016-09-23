---
title: "Array.collect&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - Array.collect<'T,'U>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ArrayModule.Collect``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - collect function [F#]
  - Array.collect function [F#]
ms.assetid: c3b60c3b-9455-48c9-bc2b-e88f0434342a
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array.collect&lt;&#39;T,&#39;U&gt; Function (F#)
For each element of the array, applies the given function. Concatenates all the results and return the combined array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.collect : ('T -> 'U []) -> 'T [] -> 'U []  
  
// Usage:  
Array.collect mapping array  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T -> 'U`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The function to create sub-arrays from the input array elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The concatenation of the subarrays.  
  
## Example  
 The following code demonstrates the use of `Array.collect` to concatenate subarrays that are generated from each array element.  
  
 [!code[FsArrays#15](../vs140/codesnippet/FSharp/array.collect--t--u--function--fsharp-_1.fs)]
  
  
 **[&#124;0; 1; 0; 1; 2; 3; 4; 5; 0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10&#124;]**   
## Remarks  
 This function is named `Collect` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)