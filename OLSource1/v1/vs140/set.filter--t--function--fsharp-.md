---
title: "Set.filter&lt;&#39;T&gt; Function (F#)"
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
  - "Set.filter<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.Filter``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "filter function [F#]"
  - "Set.filter function [F#]"
ms.assetid: 085960a3-1909-4ed1-985b-3f023dc4bd5f
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.filter&lt;&#39;T&gt; Function (F#)
Returns a new collection containing only the elements of the collection for which the given predicate returns `true`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.filter : ('T -> bool) -> Set<'T> -> Set<'T> (requires comparison)  
  
// Usage:  
Set.filter predicate set  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->` [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test set elements.  
  
 `set`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The input set.  
  
## Return Value  
 The set containing only the elements for which `predicate` returns `true`.  
  
## Remarks  
 This function is named `Filter` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of the `Set.filter` function.  
  
 [!code[FsSets#3](../vs140/codesnippet/FSharp/set.filter--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **set [2; 4; 6; 8; 10]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)