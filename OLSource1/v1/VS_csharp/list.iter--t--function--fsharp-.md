---
title: "List.iter&lt;&#39;T&gt; Function (F#)"
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
  - "List.iter<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Iterate``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Iterate function [F#]"
  - "iter function [F#]"
  - "List.Iterate function [F#]"
  - "List.iter function [F#]"
ms.assetid: f778d075-81a9-4994-af60-cddcc53a201f
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.iter&lt;&#39;T&gt; Function (F#)
Applies the given function to each element of the collection.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.iter : ('T -> unit) -> 'T list -> unit  
  
// Usage:  
List.iter action list  
```  
  
#### Parameters  
 `action`  
 Type: `'T ->` [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to elements from the input list.  
  
 `list`  
 Type: `'T` [list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Remarks  
 This function is named `Iterate` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `List.iter`.  
  
 [!code[FsSamples101#3004](../VS_csharp/codesnippet/FSharp/list.iter--t--function--fsharp-_1.fs)]  
  
 **item: Cats**  
**item: Dogs**  
**item: Mice**  
**item: Elephants**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../VS_csharp/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)