---
title: "Array.minBy&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Array.minBy<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.MinBy``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "minBy function [F#]"
  - "Array.minBy function [F#]"
ms.assetid: 24091583-be78-4cc9-9fab-de6d7506af4f
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.minBy&lt;&#39;T,&#39;U&gt; Function (F#)
Returns the lowest of all elements of the array, compared by using [Operators.min](../vs140/operators.min--t--function--fsharp-.md) on the function result.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.minBy : ('T -> 'U) -> 'T [] -> 'T (requires comparison)  
  
// Usage:  
Array.minBy projection array  
```  
  
#### Parameters  
 `projection`  
 Type: `'T -> 'U`  
  
 The function to transform the elements into a type supporting comparison.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input array is empty.|  
  
## Return Value  
 The minimum element.  
  
## Remarks  
 This function is named `MinBy` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example demonstrates the use of `Array.minBy`.  
  
 [!code[FsArrays#58](../vs140/codesnippet/FSharp/array.minby--t--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **0.0**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)