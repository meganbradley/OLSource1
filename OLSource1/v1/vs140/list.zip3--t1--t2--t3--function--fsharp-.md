---
title: "List.zip3&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)"
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
  - List.zip3<'T1,'T2,'T3>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ListModule.Zip3``3
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - List.zip3 function [F#]
  - zip3 function [F#]
ms.assetid: 003cc28e-0de3-4d99-89ed-cb19028e3c5b
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# List.zip3&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)
Combines the three lists into a list of triples. The lists must have equal lengths.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.zip3 : 'T1 list -> 'T2 list -> 'T3 list -> ('T1 * 'T2 * 'T3) list  
  
// Usage:  
List.zip3 list1 list2 list3  
```  
  
#### Parameters  
 `list1`  
 Type: `'T1`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 `list2`  
 Type: `'T2`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
 `list3`  
 Type: `'T3`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The third input list.  
  
## Return Value  
 A single list containing triples of matching elements from the input lists.  
  
## Remarks  
 This function is named `Zip3` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.zip3`.  
  
 [!code[FsLists#40](../vs140/codesnippet/FSharp/list.zip3--t1--t2--t3--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **[(1, -1, 0); (2, -2, 0); (3, -3, 0)]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)