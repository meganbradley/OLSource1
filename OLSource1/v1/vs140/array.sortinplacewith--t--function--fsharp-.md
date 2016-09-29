---
title: "Array.sortInPlaceWith&lt;&#39;T&gt; Function (F#)"
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
  - "Array.sortInPlaceWith<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.SortInPlaceWith``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.sortInPlaceWith function [F#]"
  - "sortInPlaceWith function [F#]"
ms.assetid: 454f9e11-972d-47a6-a854-8031cb0c7b0b
caps.latest.revision: 27
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.sortInPlaceWith&lt;&#39;T&gt; Function (F#)
Sorts the elements of an array by mutating the array in place, using the given comparison function as the order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.sortInPlaceWith : ('T -> 'T -> int) -> 'T [] -> unit  
  
// Usage:  
Array.sortInPlaceWith comparer array  
```  
  
#### Parameters  
 `comparer`  
 Type: `'T -> 'T ->`[int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The function to compare pairs of array elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Remarks  
 This function is named `SortInPlaceWith` in compiled assemblies. If accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use `Array.sortInPlaceWith`.  
  
 [!code[FsArrays#64](../vs140/codesnippet/FSharp/array.sortinplacewith--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Before sorting:**   
**[&#124;"<>"; "&"; "&&"; "&&&"; "<"; ">"; "&#124;"; "&#124;&#124;"; "&#124;&#124;&#124;"&#124;]**  
**After sorting:**   
**[&#124;"&"; "&#124;"; "<"; ">"; "&&"; "&#124;&#124;"; "<>"; "&&&"; "&#124;&#124;&#124;"&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)