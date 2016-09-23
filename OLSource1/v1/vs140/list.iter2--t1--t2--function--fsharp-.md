---
title: "List.iter2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - List.iter2<'T1,'T2>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ListModule.Iterate2``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - iter2 function [F#]
  - List.iter2 function [F#]
  - List.Iterate2 function [F#]
  - Iterate2 function [F#]
ms.assetid: ea3b7761-916c-4016-9bd8-651124c98b40
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# List.iter2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Applies the given function to two collections simultaneously. The collections must have identical size.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.iter2 : ('T1 -> 'T2 -> unit) -> 'T1 list -> 'T2 list -> unit  
  
// Usage:  
List.iter2 action list1 list2  
```  
  
#### Parameters  
 `action`  
 Type: `'T1 -> 'T2 ->`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to pairs of elements from the input lists.  
  
 `list1`  
 Type: `'T1`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 `list2`  
 Type: `'T2`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException?qualifyHint=False>|Thrown when the input lists differ in length.|  
  
## Remarks  
 This function is named `Iterate2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.iter2` and compares its behavior with related functions.  
  
 [!code[FsLists#17](../vs140/codesnippet/FSharp/list.iter2--t1--t2--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **List.iter: element is 1**  
**List.iter: element is 2**  
**List.iter: element is 3**  
**List.iteri: element 0 is 1**  
**List.iteri: element 1 is 2**  
**List.iteri: element 2 is 3**  
**List.iter2: elements are 1 4**  
**List.iter2: elements are 2 5**  
**List.iter2: elements are 3 6**  
**List.iteri2: element 0 of list1 is 1 element 0 of list2 is 4**  
**List.iteri2: element 1 of list1 is 2 element 1 of list2 is 5**  
**List.iteri2: element 2 of list1 is 3 element 2 of list2 is 6**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)