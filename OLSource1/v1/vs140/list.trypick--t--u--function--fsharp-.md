---
title: "List.tryPick&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - List.tryPick<'T,'U>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ListModule.TryPick``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - tryPick function [F#]
  - List.tryPick function [F#]
ms.assetid: b316b7de-78b2-4c0f-a3d6-184b0f7bdce8
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# List.tryPick&lt;&#39;T,&#39;U&gt; Function (F#)
Applies the given function to successive elements, returning the first result where function returns `Some` for some value. If no such element exists then return `None`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.tryPick : ('T -> 'U option) -> 'T list -> 'U option  
  
// Usage:  
List.tryPick chooser list  
```  
  
#### Parameters  
 `chooser`  
 Type: `'T -> 'U`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The function to generate options from the elements.  
  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The first resulting value or `None`.  
  
## Remarks  
 This function is named `TryPick` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use `List.tryPick`.  
  
 [!code[FsLists#65](../vs140/codesnippet/FSharp/list.trypick--t--u--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **Found an element 1 with square root 1 and cube root 1.**  
**Found an element 64 with square root 8 and cube root 4.**  
**Found an element 729 with square root 27 and cube root 9.**  
**Found an element 4096 with square root 64 and cube root 16.**  
**Did not find an element that is both a perfect square and a perfect cube.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)