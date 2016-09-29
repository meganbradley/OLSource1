---
title: "Array.find&lt;&#39;T&gt; Function (F#)"
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
  - "Array.find<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Find``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.find function [F#]"
  - "find function [F#]"
ms.assetid: db6d920a-de19-4520-85a4-d83de77c1b33
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.find&lt;&#39;T&gt; Function (F#)
Returns the first element for which the given function returns `true`. Raise <xref:System.Collections.Generic.KeyNotFoundException*> if no such element exists.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.find : ('T -> bool) -> 'T [] -> 'T  
  
// Usage:  
Array.find predicate array  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.Collections.Generic.KeyNotFoundException*>|Thrown if `predicate` does not return `true` for any element.|  
  
## Return Value  
 The first element for which `predicate` returns `true`.  
  
## Remarks  
 This function is named `Find` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Array.find` and `Array.findIndex` to identify the first integer greater than 1 that is both a square and a cube.  
  
 [!code[FsArrays#25](../vs140/codesnippet/FSharp/array.find--t--function--fsharp-_1.fs)]  
  
 **The first element that is both a square and a cube is 64 and its index is 62.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)   
 [Array.findIndex Function (F#)](../vs140/array.findindex--t--function--fsharp-.md)