---
title: "Array.Parallel Module (F#)"
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
  - "Microsoft.FSharp.Collections.ParallelModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.Parallel module [F#]"
ms.assetid: 60f30b77-5af4-4050-9a5c-bcdb3f5cbb09
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.Parallel Module (F#)
Provides parallel operations on arrays  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Parallel  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[choose](../vs140/parallel.choose--t--u--function--fsharp-.md)  `: ('T -> 'U option) -> 'T [] -> 'U []`|Apply the given function to each element of the array. Return the array comprised of the results "x" for each element where the function returns Some(x).|  
|[collect](../vs140/parallel.collect--t--u--function--fsharp-.md)  `: ('T -> 'U []) -> 'T [] -> 'U []`|For each element of the array, apply the given function. Concatenate all the results and return the combined array.|  
|[init](../vs140/parallel.init--t--function--fsharp-.md)  `: int -> (int -> 'T) -> 'T []`|Create an array given the dimension and a generator function to compute the elements.|  
|[iter](../vs140/parallel.iter--t--function--fsharp-.md)  `: ('T -> unit) -> 'T [] -> unit`|Apply the given function to each element of the array.|  
|[iteri](../vs140/parallel.iteri--t--function--fsharp-.md)  `: (int -> 'T -> unit) -> 'T [] -> unit`|Apply the given function to each element of the array. The integer passed to the function indicates the index of element.|  
|[map](../vs140/parallel.map--t--u--function--fsharp-.md)  `: ('T -> 'U) -> 'T [] -> 'U []`|Build a new array whose elements are the results of applying the given function to each of the elements of the array.|  
|[mapi](../vs140/parallel.mapi--t--u--function--fsharp-.md)  `: (int -> 'T -> 'U) -> 'T [] -> 'U []`|Build a new array whose elements are the results of applying the given function to each of the elements of the array. The integer index passed to the function indicates the index of element being transformed.|  
|[partition](../vs140/parallel.partition--t--function--fsharp-.md)  `: ('T -> bool) -> 'T [] -> 'T [] * 'T []`|Split the collection into two collections, containing the elements for which the given predicate returns "true" and "false" respectively|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)