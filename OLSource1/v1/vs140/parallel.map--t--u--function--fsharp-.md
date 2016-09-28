---
title: "Parallel.map&lt;&#39;T,&#39;U&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ParallelModule.Map``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
  - "Parallel.map function [F#]"
ms.assetid: 0485547d-15e9-41ed-a3a6-fb5816413fed
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parallel.map&lt;&#39;T,&#39;U&gt; Function (F#)
Creates a new array whose elements are the results of applying the given function to each of the elements of the array.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.ArrayModule.Parallel  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
map : ('T -> 'U) -> 'T [] -> 'U []  
  
// Usage:  
map mapping array  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T -> 'U`  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 An array whose elements are the result of applying the `mapping` function to each element of the input array.  
  
## Remarks  
 This function performs the operation in parallel using System.Threading.Tasks.Parallel.For. The order in which the given function is applied to elements of the input array is not specified.  
  
 This function is named `Map` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0  
  
## See Also  
 [Array.Parallel Module (F#)](../vs140/array.parallel-module--fsharp-.md)   
 [Microsoft.FSharp.Collections.ArrayModule Namespace (F#)](../vs140/collections.array-module--fsharp-.md)