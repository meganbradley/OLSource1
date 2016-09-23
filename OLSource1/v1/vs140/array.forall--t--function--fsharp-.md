---
title: "Array.forall&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Array.forall<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ArrayModule.ForAll``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Array.forall function [F#]
  - forall function [F#]
ms.assetid: d88f2cd0-fa7f-45cf-ac15-31eae9086cc4
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array.forall&lt;&#39;T&gt; Function (F#)
Tests if all elements of the array satisfy the given predicate.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.forall : ('T -> bool) -> 'T [] -> bool  
  
// Usage:  
Array.forall predicate array  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 `true` if all of the array elements satisfy the predicate. Otherwise, returns `false`.  
  
## Remarks  
 The predicate is applied to the elements of the input collection. If any application returns false then the overall result is false and no further elements are tested.  
  
 This function is named `ForAll` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example shows the use of `Array.forall` to test the elements of an array.  
  
 [!code[FsArrays#241](../vs140/codesnippet/FSharp/array.forall--t--function--fsharp-_1.fs)]
  
  
 **false**  
**true**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)