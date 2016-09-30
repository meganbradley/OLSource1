---
title: "List.forall2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "List.forall2<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.ForAll2``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "forall2 function [F#]"
  - "List.forall2 function [F#]"
ms.assetid: bb611f02-8277-48f5-9af3-6194ae27d07e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.forall2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Tests if all corresponding elements of the collection satisfy the given predicate pairwise.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.forall2 : ('T1 -> 'T2 -> bool) -> 'T1 list -> 'T2 list -> bool  
  
// Usage:  
List.forall2 predicate list1 list2  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T1 -> 'T2 ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `list1`  
 Type: `'T1`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 `list2`  
 Type: `'T2`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input lists differ in length.|  
  
## Return Value  
 `true` if all of the pairs of elements satisfy the predicate. Otherwise, returns `false`.  
  
## Remarks  
 The predicate is applied to matching elements in the two collections. If any application returns `false` then the overall result is `false` and no further elements are tested. Otherwise, if one collection is longer than the other then the \<xref:System.ArgumentException*> exception is raised. Otherwise, `true` is returned.  
  
 This function is named `ForAll2` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.forall2`.  
  
 [!code[FsLists#4](../vs140/codesnippet/FSharp/list.forall2--t1--t2--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **true**  
**false**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)