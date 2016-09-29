---
title: "Array.findIndex&lt;&#39;T&gt; Function (F#)"
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
  - "Array.findIndex<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.FindIndex``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "findIndex function [F#]"
  - "Array.findIndex function [F#]"
ms.assetid: 5ae3a8f9-7b8f-44ea-a740-d5700f4d899f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.findIndex&lt;&#39;T&gt; Function (F#)
Returns the index of the first element in the array that satisfies the given predicate. Raise <xref:System.Collections.Generic.KeyNotFoundException*> if none of the elements satisfy the predicate.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.findIndex : ('T -> bool) -> 'T [] -> int  
  
// Usage:  
Array.findIndex predicate array  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->` [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `array`  
 Type: `'T` [&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.Collections.Generic.KeyNotFoundException*>|Thrown if `predicate` does not return `true` for any element.|  
  
## Return Value  
 The index of the first element in the array that satisfies the given predicate.  
  
## Remarks  
 This function is named `FindIndex` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Array.find` and `Array.findIndex` to identify the first integer greater than 1 that is both a square and a cube.  
  
 [!code[FsArrays#25](../VS_csharp/codesnippet/FSharp/array.findindex--t--function--fsharp-_1.fs)]  
  
 **The first element that is both a square and a cube is 64 and its index is 62.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../VS_csharp/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)   
 [Array.find Function (F#)](../VS_csharp/array.find--t--function--fsharp-.md)