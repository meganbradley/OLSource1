---
title: "Array.sort&lt;&#39;T&gt; Function (F#)"
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
  - "Array.sort<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Sort``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "sort function [F#]"
  - "Array.sort function [F#]"
ms.assetid: c6679075-e7eb-463c-9be5-c89be140c312
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.sort&lt;&#39;T&gt; Function (F#)
Sorts the elements of an array, returning a new array. Elements are compared using [Operators.compare](../vs140/operators.compare--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.sort : 'T [] -> 'T [] (requires comparison)  
  
// Usage:  
Array.sort array  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The sorted array.  
  
## Remarks  
 This is not a stable sort. Therefore, the original order of equal elements might not be preserved. For a stable sort, consider using [Seq.sort](../vs140/seq.sort--t--function--fsharp-.md).  
  
 This function is named `Sort` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Array.sort`.  
  
 [!code[FsArrays#37](../vs140/codesnippet/FSharp/array.sort--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;-2; 1; 4; 5; 8&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)