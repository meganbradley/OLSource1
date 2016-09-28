---
title: "Set.( - )&lt;&#39;T&gt; Method (F#)"
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
  - "Set.( - )<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpSet`1.op_Subtraction"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Set.op_Subtraction operator [F#]"
  - "op_Subtraction operator [F#]"
  - "- operator [F#]"
  - "Set.( - ) operator [F#]"
ms.assetid: 25274a0f-01e0-4e11-8ca0-42f664cb5405
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.( - )&lt;&#39;T&gt; Method (F#)
Returns a new set with the elements of the second set removed from the first.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member ( - ) : Set<'T> * Set<'T> -> Set<'T> (requires comparison)  
  
// Usage:  
set1 - set2  
```  
  
#### Parameters  
 `set1`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The first input set.  
  
 `set2`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The second input set.  
  
## Return Value  
 A set containing elements of the first set that are not contained in the second set.  
  
## Remarks  
  
## Example  
 The following code illustrates the use of the + and - operators on sets.  
  
 [!code[FsSets#1](../vs140/codesnippet/FSharp/set.-------t--method--fsharp-_1.fs)]  
  
 **Output**  
  
 **set1: set [1; 2; 3]set2: set [4; 5; 6]set3 = set1 + set2: set [1; 2; 3; 4; 5; 6]set3 - set1: set [4; 5; 6]set3 - set2: set [1; 2; 3]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set<'T> Class (F#)](../vs140/collections.set--t--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)