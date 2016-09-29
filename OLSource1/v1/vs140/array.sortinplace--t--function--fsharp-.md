---
title: "Array.sortInPlace&lt;&#39;T&gt; Function (F#)"
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
  - "Array.sortInPlace<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.SortInPlace``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "sortInPlace function [F#]"
  - "Array.sortInPlace function [F#]"
ms.assetid: 36f39947-8a88-4823-9e9b-e9d838d292e0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.sortInPlace&lt;&#39;T&gt; Function (F#)
Sorts the elements of an array by mutating the array in-place, using the given comparison function. Elements are compared using [Operators.compare](../vs140/operators.compare--t--function--fsharp-.md).  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.sortInPlace : 'T [] -> unit (requires comparison)  
  
// Usage:  
Array.sortInPlace array  
```  
  
#### Parameters  
 `array`  
 Type: `'T` [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Remarks  
 This function is named `SortInPlace` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Array.sortInPlace`.  
  
 [!code[FsArrays#40](../vs140/codesnippet/FSharp/array.sortinplace--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;-2; 1; 4; 5; 8&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)