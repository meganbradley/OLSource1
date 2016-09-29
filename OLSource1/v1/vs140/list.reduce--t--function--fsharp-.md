---
title: "List.reduce&lt;&#39;T&gt; Function (F#)"
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
  - "List.reduce<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Reduce``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "reduce function [F#]"
  - "List.reduce function [F#]"
ms.assetid: 048e1f95-691b-49cb-bb99-fb85f68f3d8b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.reduce&lt;&#39;T&gt; Function (F#)
Applies a function to each element of the collection, threading an accumulator argument through the computation. This function first applies the function to the first two elements of the list. Then, it passes this result into the function along with the third element and so on. Finally, it returns the final result. If the input function is `f` and the elements are `i0...iN`, then it computes `f (... (f i0 i1) i2 ...) iN`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.reduce : ('T -> 'T -> 'T) -> 'T list -> 'T  
  
// Usage:  
List.reduce reduction list  
```  
  
#### Parameters  
 `reduction`  
 Type: `'T -> 'T -> 'T`  
  
 The function to reduce two list elements to a single element.  
  
 `list`  
 Type: `'T` [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the list is empty.|  
  
## Return Value  
 The final reduced value.  
  
## Remarks  
 This function is named `Reduce` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.reduce`.  
  
 [!code[FsLists#33](../vs140/codesnippet/FSharp/list.reduce--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **16**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)