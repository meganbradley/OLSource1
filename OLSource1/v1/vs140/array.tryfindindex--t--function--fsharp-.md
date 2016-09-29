---
title: "Array.tryFindIndex&lt;&#39;T&gt; Function (F#)"
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
  - "Array.tryFindIndex<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.TryFindIndex``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.tryFindIndex function [F#]"
  - "tryFindIndex function [F#]"
ms.assetid: da82f7fe-95e9-4fd5-a924-cd3c9d10618a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.tryFindIndex&lt;&#39;T&gt; Function (F#)
Returns the index of the first element in the array that satisfies the given predicate.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.tryFindIndex : ('T -> bool) -> 'T [] -> int option  
  
// Usage:  
Array.tryFindIndex predicate array  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The index of the first element that satisfies the predicate, or `None`.  
  
## Remarks  
 This function is named `TryFindIndex` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)