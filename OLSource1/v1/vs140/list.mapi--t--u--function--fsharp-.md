---
title: "List.mapi&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "List.mapi<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.MapIndexed``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.mapi function [F#]"
  - "MapIndexed function [F#]"
  - "List.MapIndexed function [F#]"
  - "mapi function [F#]"
ms.assetid: 284b9234-3d26-409b-b328-ac79638d9e14
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.mapi&lt;&#39;T,&#39;U&gt; Function (F#)
Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection. The integer index passed to the function indicates the index (from 0) of element being transformed.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.mapi : (int -> 'T -> 'U) -> 'T list -> 'U list  
  
// Usage:  
List.mapi mapping list  
```  
  
#### Parameters  
 `mapping`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `-> 'T -> 'U`  
  
 The function to transform elements and their indices.  
  
 `list`  
 Type: `'T` [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The list of transformed elements.  
  
## Remarks  
 This function is named `MapIndexed` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.mapi`.  
  
 [!code[FsLists#36](../vs140/codesnippet/FSharp/list.mapi--t--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[(0, 1); (1, 2); (2, 3)]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)