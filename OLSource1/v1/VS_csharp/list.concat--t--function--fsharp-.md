---
title: "List.concat&lt;&#39;T&gt; Function (F#)"
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
  - "List.concat<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Concat``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.concat function [F#]"
  - "concat function [F#]"
ms.assetid: c5afd433-8764-4ea8-a6a8-937fb4d77c4c
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.concat&lt;&#39;T&gt; Function (F#)
Returns a new list that contains the elements of each list in order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.concat : seq<'T list> -> 'T list  
  
// Usage:  
List.concat lists  
```  
  
#### Parameters  
 `lists`  
 Type: [seq](../VS_csharp/collections.seq--t--type-abbreviation--fsharp-.md)`<'T list>`  
  
 The input sequence of lists.  
  
## Return Value  
 The resulting concatenated list.  
  
## Remarks  
 This function is named `Concat` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates that [List.append](../VS_csharp/list.append--t--function--fsharp-.md) is used to join two lists together; and `List.concat` is used to join any number of lists.  
  
 [!code[FsLists#26](../VS_csharp/codesnippet/FSharp/list.concat--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **1 2 3 4 5 6 7 8 9 10**   
**1 2 3 4 5 6 7 8 9**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../VS_csharp/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)