---
title: "Array.mapi&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Array.mapi<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.MapIndexed``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.mapi function [F#]"
  - "MapIndexed function [F#]"
  - "Array.MapIndexed function [F#]"
  - "mapi function [F#]"
ms.assetid: f7e45994-b0a1-49e6-8fb5-5641cea8fde4
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.mapi&lt;&#39;T,&#39;U&gt; Function (F#)
Builds a new array whose elements are the results of applying the given function to each of the elements of the array. The integer index passed to the function indicates the index of element being transformed.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.mapi : (int -> 'T -> 'U) -> 'T [] -> 'U []  
  
// Usage:  
Array.mapi mapping array  
```  
  
#### Parameters  
 `mapping`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md) `-> 'T -> 'U`  
  
 The function to transform elements and their indices.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The array of transformed elements.  
  
## Remarks  
 This function is named `MapIndexed` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates the use of `Array.mapi`.  
  
 [!code[FsArrays#53](../VS_csharp/codesnippet/FSharp/array.mapi--t--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;(0, 1); (1, 2); (2, 3)&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../VS_csharp/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)