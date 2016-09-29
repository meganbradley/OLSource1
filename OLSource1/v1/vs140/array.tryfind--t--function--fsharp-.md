---
title: "Array.tryFind&lt;&#39;T&gt; Function (F#)"
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
  - "Array.tryFind<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.TryFind``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "tryFind function [F#]"
  - "Array.tryFind function [F#]"
ms.assetid: 7bd65f6c-df77-454c-ac3a-6f7baecec9d9
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.tryFind&lt;&#39;T&gt; Function (F#)
Returns the first element for which the given function returns `true`. Return `None` if no such element exists.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.tryFind : ('T -> bool) -> 'T [] -> 'T option  
  
// Usage:  
Array.tryFind predicate array  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The first element that satisfies the predicate, or `None`.  
  
## Remarks  
 This function is named `TryFind` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Array.tryFind` to attempt to locate array elements that are both perfect cubes and perfect squares.  
  
 [!code[FsArrays#26](../vs140/codesnippet/FSharp/array.tryfind--t--function--fsharp-_1.fs)]  
  
 **Found an element: 1**  
**Found an element: 729**  
**Failed to find a matching element.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)