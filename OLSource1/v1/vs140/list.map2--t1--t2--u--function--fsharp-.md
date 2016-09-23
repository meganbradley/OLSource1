---
title: "List.map2&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)"
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
  - List.map2<'T1,'T2,'U>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ListModule.Map2``3
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - List.map2 function [F#]
  - map2 function [F#]
ms.assetid: 5f48cce7-6eaf-4e54-8996-2b04d3c31e57
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# List.map2&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)
Creates a new collection whose elements are the results of applying the given function to the corresponding elements of the two collections pairwise.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.map2 : ('T1 -> 'T2 -> 'U) -> 'T1 list -> 'T2 list -> 'U list  
  
// Usage:  
List.map2 mapping list1 list2  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T1 -> 'T2 -> 'U`  
  
 The function to transform pairs of elements from the input lists.  
  
 `list1`  
 Type: `'T1`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 `list2`  
 Type: `'T2`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
## Return Value  
 The list of resulting elements.  
  
## Remarks  
 This function is named `Map2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.map2`.  
  
 [!code[FsLists#19](../vs140/codesnippet/FSharp/list.map2--t1--t2--u--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **[5; 7; 9]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)