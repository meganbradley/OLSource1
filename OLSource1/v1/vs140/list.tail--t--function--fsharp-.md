---
title: "List.tail&lt;&#39;T&gt; Function (F#)"
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
  - "List.tl<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Tail``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.tail function [F#]"
  - "tail function [F#]"
ms.assetid: da0a0638-4420-4571-84b6-d09ae601f601
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.tail&lt;&#39;T&gt; Function (F#)
Returns the list without the first element.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.tail : 'T list -> 'T list  
  
// Usage:  
List.tail list  
```  
  
#### Parameters  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
## Return Value  
 The tail of the list, that is, the list without the first element.  
  
## Remarks  
 This function is named `Tail` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `List.tail`.  
  
 [!code[FsLists#63](../vs140/codesnippet/FSharp/list.tail--t--function--fsharp-_1.fs)]  
  
 **Abbreviated Output**  
  
 **[2; 3]System.ArgumentException: The input list was empty.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)