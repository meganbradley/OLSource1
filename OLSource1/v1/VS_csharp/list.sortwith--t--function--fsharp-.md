---
title: "List.sortWith&lt;&#39;T&gt; Function (F#)"
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
  - "List.sortWith<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.SortWith``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "sortWith function [F#]"
  - "List.sortWith function [F#]"
ms.assetid: 1d806a54-9166-4198-906d-15101f7916c7
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.sortWith&lt;&#39;T&gt; Function (F#)
Sorts the given list using the given comparison function.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.sortWith : ('T -> 'T -> int) -> 'T list -> 'T list  
  
// Usage:  
List.sortWith comparer list  
```  
  
#### Parameters  
 `comparer`  
 Type: `'T -> 'T ->`[int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)  
  
 The function to compare the list elements.  
  
 `list`  
 Type: `'T`[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The sorted list.  
  
## Remarks  
 This is a stable sort, that is, the original order of equal elements is preserved.  
  
 This function is named `SortWith` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `List.sortWith`.  
  
 [!code[FsLists#62](../VS_csharp/codesnippet/FSharp/list.sortwith--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Before sorting:**   
**["<>"; "&"; "&&"; "&&&"; "<"; ">"; "&#124;"; "&#124;&#124;"; "&#124;&#124;&#124;"]**  
**After sorting:**  
**["&"; "&#124;"; "<"; ">"; "&&"; "&#124;&#124;"; "<>"; "&&&"; "&#124;&#124;&#124;"]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../VS_csharp/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)