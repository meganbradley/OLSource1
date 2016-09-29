---
title: "Parallel.iteri&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Collections.ParallelModule.IterateIndexed``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "iteri function [F#]"
  - "Parallel.IterateIndexed function [F#]"
  - "Parallel.iteri function [F#]"
  - "IterateIndexed function [F#]"
ms.assetid: 5e777c6f-9b12-4a63-8168-9d7a66205482
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parallel.iteri&lt;&#39;T&gt; Function (F#)
Apply the given function to each element of the array. The integer passed to the function indicates the index of element.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.ArrayModule.Parallel  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
iteri : (int -> 'T -> unit) -> 'T [] -> unit  
  
// Usage:  
iteri action array  
```  
  
#### Parameters  
 `action`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md) `-> 'T ->` [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)  
  
 `array`  
 Type: `'T`[&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Remarks  
 Performs the operation in parallel using System.Threading.Tasks.Parallel.For. The order in which the given function is applied to elements of the input array is not specified.  
  
 This function is named `IterateIndexed` in compiled assemblies. If you are accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0  
  
## See Also  
 [Array.Parallel Module (F#)](../VS_csharp/array.parallel-module--fsharp-.md)   
 [Microsoft.FSharp.Collections.ArrayModule Namespace (F#)](../VS_csharp/collections.array-module--fsharp-.md)