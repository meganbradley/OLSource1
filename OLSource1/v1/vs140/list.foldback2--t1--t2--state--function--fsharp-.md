---
title: "List.foldBack2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)"
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
  - "List.foldBack2<'T1,'T2,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.FoldBack2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.foldBack2 function [F#]"
  - "foldBack2 function [F#]"
ms.assetid: 56371d3e-5271-4183-9e8c-15a02eda9aa2
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.foldBack2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)
Applies a function to corresponding elements of two collections, threading an accumulator argument through the computation. The collections must have identical sizes. If the input function is `f` and the elements are `i0...iN` and `j0...jN`, then this function computes `f i0 j0 (...(f iN jN s))`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.foldBack2 : ('T1 -> 'T2 -> 'State -> 'State) -> 'T1 list -> 'T2 list -> 'State -> 'State  
  
// Usage:  
List.foldBack2 folder list1 list2 state  
```  
  
#### Parameters  
 `folder`  
 Type: `'T1 -> 'T2 -> 'State -> 'State`  
  
 The function to update the state given the input elements.  
  
 `list1`  
 Type: `'T1`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 `list2`  
 Type: `'T2`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
 `state`  
 Type: `'State`  
  
 The initial state.  
  
## Return Value  
 The final state value.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input lists differ in length.|  
  
## Remarks  
 This function is named `FoldBack2` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
 The following code examples illustrate the difference between [List.fold2](../vs140/list.fold2--t1--t2--state--function--fsharp-.md) and `List.foldBack2`.  
  
## Example  
 [!code[FsLists#31](../vs140/codesnippet/FSharp/list.foldback2--t1--t2--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **1210.020833**   
## Example  
 [!code[FsLists#32](../vs140/codesnippet/FSharp/list.foldback2--t1--t2--state--function--fsharp-_2.fs)]  
  
 **Output**  
  
 **1205.833333**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)