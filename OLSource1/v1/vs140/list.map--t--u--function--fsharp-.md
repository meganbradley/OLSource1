---
title: "List.map&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "List.map<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Map``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
  - "List.map function [F#]"
ms.assetid: c6b49c99-d4f3-4ba3-b1d0-85a312683dc6
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.map&lt;&#39;T,&#39;U&gt; Function (F#)
Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.map : ('T -> 'U) -> 'T list -> 'U list  
  
// Usage:  
List.map mapping list  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T -> 'U`  
  
 The function to transform elements from the input list.  
  
 `list`  
 Type: `'T` [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The list of transformed elements.  
  
## Remarks  
 This function is named `Map` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `List.map`.  
  
 [!code[FsSamples101#3002](../vs140/codesnippet/FSharp/list.map--t--u--function--fsharp-_1.fs)]  
  
 **Adding '1' using map = [2; 3; 4; 5]**  
**Converting to strings using map = ["1"; "2"; "3"; "4"]**  
**Tupling up using map = [(1, 1); (2, 2); (3, 3); (4, 4)]**   
## Example  
 The next example demonstrates the use of `List.map` to transform data into a different format.  
  
 [!code[FsSamples101#1004](../vs140/codesnippet/FSharp/list.map--t--u--function--fsharp-_2.fs)]  
  
 **"Monday, January 01, 2001 12:00:00 AM"**  
**"Monday, February 02, 2004 12:00:00 AM"**  
**"Wednesday, June 17, 2009 12:00:00 AM"**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)