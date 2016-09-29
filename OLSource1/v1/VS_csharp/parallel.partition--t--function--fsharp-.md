---
title: "Parallel.partition&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Collections.ParallelModule.Partition`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Parallel.partition function [F#]"
  - "partition function [F#]"
ms.assetid: 1981a0bd-8d44-46a2-a3f3-3e5cc7b78fce
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parallel.partition&lt;&#39;T&gt; Function (F#)
Splits the collection into two collections, containing the elements for which the given predicate returns `true` and `false`, respectively  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.ArrayModule.Parallel  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
partition : ('T -> bool) -> 'T [] -> 'T [] * 'T []  
  
// Usage:  
partition predicate array  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->` [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `array`  
 Type: `'T` [&#91;&#93;](../VS_csharp/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The two collections.  
  
## Remarks  
 Performs the operation in parallel using System.Threading.Tasks.Parallel.For. The order in which the given function is applied to indices is not specified.  
  
 This function is named `Partition` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0  
  
## See Also  
 [Array.Parallel Module (F#)](../VS_csharp/array.parallel-module--fsharp-.md)   
 [Microsoft.FSharp.Collections.ArrayModule Namespace (F#)](../VS_csharp/collections.array-module--fsharp-.md)