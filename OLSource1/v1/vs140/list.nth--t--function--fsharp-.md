---
title: "List.nth&lt;&#39;T&gt; Function (F#)"
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
  - "List.nth<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Get``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "nth function [F#]"
  - "GetAtIndex function [F#]"
  - "List.nth function [F#]"
  - "List.GetAtIndex function [F#]"
ms.assetid: 1f717d57-89be-4007-a971-9cf5a28d83b1
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.nth&lt;&#39;T&gt; Function (F#)
Indexes into the list. The first element has index 0.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.nth : 'T list -> int -> 'T  
  
// Usage:  
List.nth list index  
```  
  
#### Parameters  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
 `index`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index to retrieve.  
  
## Return Value  
 The value at the given index.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown if the index is outside the length of the list.|  
  
## Remarks  
 This function is named `Get` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use **List.nth**.  
  
 [!code[FsLists#49](../vs140/codesnippet/FSharp/list.nth--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The fifth element: -5**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)