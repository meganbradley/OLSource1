---
title: "Parallel.choose&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Microsoft.FSharp.Collections.ParallelModule.Choose``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Parallel.choose function [F#]"
  - "choose function [F#]"
ms.assetid: 2deed2b4-eb4c-4d03-9931-0f5bbb47f1f1
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parallel.choose&lt;&#39;T,&#39;U&gt; Function (F#)
Applies a supplied function to each element of an array and returns an array that contains the results for each element where the function returns `Some`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.ArrayModule.Parallel  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
choose : ('T -> 'U option) -> 'T [] -> 'U []  
  
// Usage:  
choose chooser array  
```  
  
#### Parameters  
 `chooser`  
 Type: `'T -> 'U`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The function used to generate options from the elements.  
  
 `array`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The array that contains the results for each element where the function returns `Some`.  
  
## Remarks  
 This function performs the operation in parallel by using System.Threading.Tasks.Parallel.For. The order in which the given function is applied to elements of the input array is not specified.  
  
 This function is named `Choose` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0  
  
## See Also  
 [Array.Parallel Module (F#)](../vs140/array.parallel-module--fsharp-.md)   
 [Microsoft.FSharp.Collections.ArrayModule Namespace (F#)](../vs140/collections.array-module--fsharp-.md)