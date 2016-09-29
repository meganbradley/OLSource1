---
title: "List.toSeq&lt;&#39;T&gt; Function (F#)"
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
  - "List.to_seq<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.ToSeq``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.toSeq function [F#]"
  - "ToSequence function [F#]"
  - "List.ToSequence function [F#]"
  - "toSeq function [F#]"
ms.assetid: 7024be4b-ee70-43cc-8d0a-e6564a4ff7c0
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.toSeq&lt;&#39;T&gt; Function (F#)
Views the given list as a sequence.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.toSeq : 'T list -> seq<'T>  
  
// Usage:  
List.toSeq list  
```  
  
#### Parameters  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The sequence of elements in the list.  
  
## Remarks  
 This function is named `ToSeq` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `List.toSeq`.  
  
 [!code[FsLists#68](../vs140/codesnippet/FSharp/list.toseq--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **1 2 3 4 5**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)