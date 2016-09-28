---
title: "List.ofArray&lt;&#39;T&gt; Function (F#)"
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
  - "List.of_array<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.OfArray``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.ofArray function [F#]"
  - "FromArray function [F#]"
  - "ofArray function [F#]"
  - "List.FromArray function [F#]"
ms.assetid: f4bddc26-8c8f-4307-a6d7-a49dceb97032
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.ofArray&lt;&#39;T&gt; Function (F#)
Creates a list from the given array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.ofArray : 'T [] -> 'T list  
  
// Usage:  
List.ofArray array  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The list of elements from the array.  
  
## Remarks  
 This function is named `OfArray` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `List.ofArray`.  
  
 [!code[FsLists#59](../vs140/codesnippet/FSharp/list.ofarray--t--function--fsharp-_1.fs)]  
  
 **F# Interactive Output**  
  
 **val list1 : int list = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)