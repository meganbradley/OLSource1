---
title: "Array.exists2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "Array.exists2<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Exists2``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.exists2 function [F#]"
  - "exists2 function [F#]"
ms.assetid: 2e384a6a-f99d-4e23-b677-250ffbc1dd8e
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.exists2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Tests if any pair of corresponding elements of the arrays satisfies the given predicate.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.exists2 : ('T1 -> 'T2 -> bool) -> 'T1 [] -> 'T2 [] -> bool  
  
// Usage:  
Array.exists2 predicate array1 array2  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T1 -> 'T2 ->`[bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `array1`  
 Type: `'T1`[&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The first input array.  
  
 `array2`  
 Type: `'T2`[&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The second input array.  
  
## Return Value  
 `true` if any result from `predicate` is `true`. Otherwise, `false`.  
  
## Remarks  
 The predicate is applied to matching elements in the two collections up to the lesser of the two lengths of the collections. If any application returns `true` then the overall result is `true` and no further elements are tested. Otherwise, if one collection is longer than the other then the <xref:System.ArgumentException*> exception is raised. Otherwise, `false` is returned.  
  
 This function is named `Exists2` in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example shows the use `Array.exists2` to test whether two arrays have at least one equal element.  
  
 [!code[FsArrays#232](../VS_csharp/codesnippet/FSharp/array.exists2--t1--t2--function--fsharp-_1.fs)]  
  
 **true**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../VS_csharp/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)