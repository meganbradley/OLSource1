---
title: "List.iteri&lt;&#39;T&gt; Function (F#)"
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
  - "List.iteri<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.IterateIndexed``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "iteri function [F#]"
  - "List.IterateIndexed function [F#]"
  - "List.iteri function [F#]"
  - "IterateIndexed function [F#]"
ms.assetid: 6dd21ae6-5c00-41cd-8306-821e513d8f60
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.iteri&lt;&#39;T&gt; Function (F#)
Applies the given function to each element of the collection. The integer passed to the function indicates the index of element.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.iteri : (int -> 'T -> unit) -> 'T list -> unit  
  
// Usage:  
List.iteri action list  
```  
  
#### Parameters  
 `action`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `-> 'T ->`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to the elements of the list along with their index.  
  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Remarks  
 This function is named `IterateIndexed` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `List.iteri`.  
  
 [!code[FsSamples101#3005](../vs140/codesnippet/FSharp/list.iteri--t--function--fsharp-_1.fs)]  
  
 **item 0: Cats**  
**item 1: Dogs**  
**item 2: Mice**  
**item 3: Elephants**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)