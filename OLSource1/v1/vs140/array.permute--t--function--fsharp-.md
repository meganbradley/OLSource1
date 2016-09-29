---
title: "Array.permute&lt;&#39;T&gt; Function (F#)"
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
  - "Array.permute<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Permute``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.permute function [F#]"
  - "permute function [F#]"
ms.assetid: d89598b7-7a90-4746-80b5-ff5de4ba56a8
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.permute&lt;&#39;T&gt; Function (F#)
Returns an array with all elements permuted according to the specified permutation.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.permute : (int -> int) -> 'T [] -> 'T []  
  
// Usage:  
Array.permute indexMap array  
```  
  
#### Parameters  
 `indexMap`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `->` [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The function that maps input indices to output indices.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The permuted array.  
  
## Remarks  
 This function is named `Permute` in compiled assemblies. If accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Array.permute`.  
  
 [!code[FsArrays#34](../vs140/codesnippet/FSharp/array.permute--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;1; 2; 3; 4; 5&#124;]**  
**[&#124;5; 1; 2; 3; 4&#124;]**  
**[&#124;4; 5; 1; 2; 3&#124;]**  
**[&#124;3; 4; 5; 1; 2&#124;]**  
**[&#124;2; 3; 4; 5; 1&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)