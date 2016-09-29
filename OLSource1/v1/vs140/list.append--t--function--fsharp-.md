---
title: "List.append&lt;&#39;T&gt; Function (F#)"
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
  - "List.append<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Append``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.append function [F#]"
  - "append function [F#]"
ms.assetid: 2954da80-3f4a-4a4b-9371-794645c03426
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.append&lt;&#39;T&gt; Function (F#)
Returns a new list that contains the elements of the first list followed by elements of the second.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.append : 'T list -> 'T list -> 'T list  
  
// Usage:  
List.append list1 list2  
```  
  
#### Parameters  
 `list1`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 `list2`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
## Return Value  
 The resulting list.  
  
## Remarks  
 This function is named `Append` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.append` to join two lists together. Use [List.concat](../vs140/list.concat--t--function--fsharp-.md) to join more than two lists.  
  
 [!code[FsLists#26](../vs140/codesnippet/FSharp/list.append--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **1 2 3 4 5 6 7 8 9 10**   
**1 2 3 4 5 6 7 8 9**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)