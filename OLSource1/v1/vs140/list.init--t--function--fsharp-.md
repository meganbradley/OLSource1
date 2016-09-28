---
title: "List.init&lt;&#39;T&gt; Function (F#)"
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
  - "List.init<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Initialize``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "init function [F#]"
  - "List.init function [F#]"
  - "List.Initialize function [F#]"
  - "Initialize function [F#]"
ms.assetid: dd38c096-0ea8-4858-be6b-794b90418b83
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.init&lt;&#39;T&gt; Function (F#)
Creates a list by calling the given generator on each index.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.init : int -> (int -> 'T) -> 'T list  
  
// Usage:  
List.init length initializer  
```  
  
#### Parameters  
 `length`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the list to generate.  
  
 `initializer`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `-> 'T`  
  
 The function to generate an element from an index.  
  
## Return Value  
 The list of generated elements.  
  
## Remarks  
 This function is named `Initialize` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `List.init`.  
  
 [!code[FsLists#46](../vs140/codesnippet/FSharp/list.init--t--function--fsharp-_1.fs)]  
  
 Output  
  
 **List of squares: [0; 1; 4; 9; 16; 25; 36; 49; 64; 81]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)