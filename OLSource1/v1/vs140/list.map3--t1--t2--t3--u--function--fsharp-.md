---
title: "List.map3&lt;&#39;T1,&#39;T2,&#39;T3,&#39;U&gt; Function (F#)"
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
  - "List.map3<'T1,'T2,'T3,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Map3``4"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.map3 function [F#]"
  - "map3 function [F#]"
ms.assetid: dd9fb190-6980-4537-be96-5645a64908f8
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.map3&lt;&#39;T1,&#39;T2,&#39;T3,&#39;U&gt; Function (F#)
Creates a new collection whose elements are the results of applying the given function to the corresponding elements of the three collections simultaneously.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.map3 : ('T1 -> 'T2 -> 'T3 -> 'U) -> 'T1 list -> 'T2 list -> 'T3 list -> 'U list  
  
// Usage:  
List.map3 mapping list1 list2 list3  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T1 -> 'T2 -> 'T3 -> 'U`  
  
 The function to transform triples of elements from the input lists.  
  
 `list1`  
 Type: `'T1` [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 `list2`  
 Type: `'T2` [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
 `list3`  
 Type: `'T3` [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The third input list.  
  
## Return Value  
 The list of transformed elements.  
  
## Remarks  
 This function is named `Map3` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.map3`.  
  
 [!code[FsLists#35](../vs140/codesnippet/FSharp/list.map3--t1--t2--t3--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[7; 10; 13]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)