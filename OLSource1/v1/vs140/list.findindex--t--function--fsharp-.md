---
title: "List.findIndex&lt;&#39;T&gt; Function (F#)"
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
  - "List.findIndex<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.FindIndex``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "findIndex function [F#]"
  - "List.findIndex function [F#]"
ms.assetid: 9e5a2077-7fd9-4240-8b73-869a9b747b4c
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.findIndex&lt;&#39;T&gt; Function (F#)
Returns the index of the first element in the list that satisfies the given predicate. Raises \<xref:System.Collections.Generic.KeyNotFoundException*> if no such element exists.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.findIndex : ('T -> bool) -> 'T list -> int  
  
// Usage:  
List.findIndex predicate list  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown if the predicate evaluates to false for all the elements of the list.|  
  
## Return Value  
 The index of the first element that satisfies the predicate.  
  
## Remarks  
 This function is named `FindIndex` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `List.findIndex` and compares its behavior to that of [List.find](../vs140/list.find--t--function--fsharp-.md).  
  
 [!code[FsLists#45](../vs140/codesnippet/FSharp/list.findindex--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The first element that is both a square and a cube is 64 and its index is 62.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)