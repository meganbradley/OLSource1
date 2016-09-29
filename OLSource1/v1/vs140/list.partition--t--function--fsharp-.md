---
title: "List.partition&lt;&#39;T&gt; Function (F#)"
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
  - "List.partition<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Partition``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "partition function [F#]"
  - "List.partition function [F#]"
ms.assetid: aba8252d-ba85-4ec2-a2e2-930276e63a63
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.partition&lt;&#39;T&gt; Function (F#)
Splits the collection into two collections, containing the elements for which the given predicate returns `true` and `false` respectively.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.partition : ('T -> bool) -> 'T list -> 'T list * 'T list  
  
// Usage:  
List.partition predicate list  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 A list containing the elements for which the predicate evaluated to `false` and a list containing the elements for which the predicate evaluated to `true`.  
  
## Remarks  
 This function is named `Partition` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use `List.partition`.  
  
 [!code[FsLists#50](../vs140/codesnippet/FSharp/list.partition--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Evens: [2; 4; 6; 8; 10]**  
**Odds: [1; 3; 5; 7; 9]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)