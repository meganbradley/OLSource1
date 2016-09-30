---
title: "List.average&lt;^T&gt; Function (F#)"
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
  - "List.average<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Average``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "average function [F#]"
  - "List.average function [F#]"
ms.assetid: 2b9a627b-106d-4548-8c4c-ab5058b8f8e1
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.average&lt;^T&gt; Function (F#)
Returns the average of the elements in the list.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.average : ^T list -> ^T (requires ^T with static member (+) and ^T with static member DivideByInt and ^T with static member Zero)  
  
// Usage:  
List.average list  
```  
  
#### Parameters  
 `list`  
 Type: `^T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the list is empty.|  
  
## Return Value  
 The resulting average.  
  
## Remarks  
 This function cannot be used directly on a list of integers since it requires that the type support an exact division operation, which is indicated by the constraint that the element type must support [DivideByInt](../vs140/languageprimitives.dividebyint-^t--function--fsharp-.md) Floating point types support `DivideByInt`. To compute the average of a list of integers, see the example in [List.averageBy](../vs140/list.averageby--t-^u--function--fsharp-.md).  
  
 This function is named `Average` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `List.average`.  
  
 [!code[FsLists#111](../vs140/codesnippet/FSharp/list.average-^t--function--fsharp-_1.fs)]  
  
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