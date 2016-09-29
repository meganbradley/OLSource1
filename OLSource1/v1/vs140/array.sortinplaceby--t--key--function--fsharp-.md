---
title: "Array.sortInPlaceBy&lt;&#39;T,&#39;Key&gt; Function (F#)"
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
  - "Array.sortInPlaceBy<'T,'Key>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.SortInPlaceBy``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.sortInPlaceBy function [F#]"
  - "sortInPlaceBy function [F#]"
ms.assetid: 7fb9d2dd-d461-4c67-8b43-b5c59fc12c3f
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.sortInPlaceBy&lt;&#39;T,&#39;Key&gt; Function (F#)
Sorts the elements of an array by mutating the array in place, using the given projection for the keys. Elements are compared using [Operators.compare](../vs140/operators.compare--t--function--fsharp-.md).  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.sortInPlaceBy : ('T -> 'Key) -> 'T [] -> unit (requires comparison)  
  
// Usage:  
Array.sortInPlaceBy projection array  
```  
  
#### Parameters  
 `projection`  
 Type: `'T -> 'Key`  
  
 The function to transform array elements into the type that is compared.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Remarks  
 This is not a stable sort, that is, the original order of equal elements might not be preserved. For a stable sort, consider using [Seq.sort](../vs140/seq.sort--t--function--fsharp-.md).  
  
 This function is named `SortInPlaceBy` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Array.sortInPlaceBy`.  
  
 [!code[FsArrays#41](../vs140/codesnippet/FSharp/array.sortinplaceby--t--key--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;1; -2; 4; 5; 8&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)