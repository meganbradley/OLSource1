---
title: "List.iteri2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - List.iteri2<'T1,'T2>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ListModule.IterateIndexed2``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - IterateIndexed2 function [F#]
  - iteri2 function [F#]
  - List.iteri2 function [F#]
  - List.IterateIndexed2 function [F#]
ms.assetid: 9658d740-9be5-4bf7-b663-c8ab2b3e196c
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# List.iteri2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Applies the given function to two collections simultaneously. The collections must have identical size. The integer passed to the function indicates the index of element.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.iteri2 : (int -> 'T1 -> 'T2 -> unit) -> 'T1 list -> 'T2 list -> unit  
  
// Usage:  
List.iteri2 action list1 list2  
```  
  
#### Parameters  
 `action`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `-> 'T1 -> 'T2 ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to a pair of elements from the input lists along with their index.  
  
 `list1`  
 Type: `'T1` [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 `list2`  
 Type: `'T2` [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException?qualifyHint=False>|Thrown when the input lists differ in length.|  
  
## Remarks  
 This function is named `IterateIndexed2` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.iteri2` and compares its behavior with related functions.  
  
 [!code[FsLists#17](../vs140/codesnippet/FSharp/list.iteri2--t1--t2--function--fsharp-_1.fs)]
  
  
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