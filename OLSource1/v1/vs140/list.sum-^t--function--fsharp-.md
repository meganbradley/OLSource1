---
title: "List.sum&lt;^T&gt; Function (F#)"
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
  - "List.sum<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Sum``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "sum function [F#]"
  - "List.sum function [F#]"
ms.assetid: 54d47fe3-5ecf-4883-beb5-e915342a17f9
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.sum&lt;^T&gt; Function (F#)
Returns the sum of the elements in the list.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.sum : ^T list -> ^T (requires ^T with static member (+) and ^T with static member Zero)  
  
// Usage:  
List.sum list  
```  
  
#### Parameters  
 `list`  
 Type: `^T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The resulting sum.  
  
## Remarks  
 This function is named `Sum` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.sum`, [List.sumBy](../vs140/list.sumby--t-^u--function--fsharp-.md), and [List.average](../vs140/list.average-^t--function--fsharp-.md).  
  
 [!code[FsLists#11](../vs140/codesnippet/FSharp/list.sum-^t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **1.000000**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)