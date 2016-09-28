---
title: "List.max&lt;&#39;T&gt; Function (F#)"
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
  - "List.max<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Max``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.max function [F#]"
  - "max function [F#]"
ms.assetid: 050f18a0-a0fe-4e98-9dfd-8da37bde9959
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.max&lt;&#39;T&gt; Function (F#)
Return the greatest of all elements of the list, compared via [Operators.max](../vs140/operators.max--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.max : 'T list -> 'T (requires comparison)  
  
// Usage:  
List.max list  
```  
  
#### Parameters  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the list is empty.|  
  
## Return Value  
 The maximum element.  
  
## Remarks  
 This function is named `Max` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use `List.max`.  
  
 [!code[FsLists#55](../vs140/codesnippet/FSharp/list.max--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **4**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)