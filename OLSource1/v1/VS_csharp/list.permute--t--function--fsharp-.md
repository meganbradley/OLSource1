---
title: "List.permute&lt;&#39;T&gt; Function (F#)"
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
  - "List.permute<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Permute``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.permute function [F#]"
  - "permute function [F#]"
ms.assetid: 3de0d1b5-9526-4fc9-a4ed-5479d08009b8
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.permute&lt;&#39;T&gt; Function (F#)
Returns a list with all elements permuted according to the specified permutation.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.permute : (int -> int) -> 'T list -> 'T list  
  
// Usage:  
List.permute indexMap list  
```  
  
#### Parameters  
 `indexMap`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md) `->`[int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)  
  
 The function to map input indices to output indices.  
  
 `list`  
 Type: `'T`[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The permuted list.  
  
## Remarks  
 This function is named `Permute` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates how to use `List.permute`.  
  
 [!code[FsLists#51](../VS_csharp/codesnippet/FSharp/list.permute--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[1; 2; 3; 4; 5]**  
**[5; 1; 2; 3; 4]**  
**[4; 5; 1; 2; 3]**  
**[3; 4; 5; 1; 2]**  
**[2; 3; 4; 5; 1]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../VS_csharp/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)