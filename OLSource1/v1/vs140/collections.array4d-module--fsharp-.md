---
title: "Collections.Array4D Module (F#)"
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
  - "Collections.Array4D"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array4DModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array4D module [F#]"
  - "Array4DModule module [F#]"
ms.assetid: 9fdbd023-7c17-4a68-a405-8a1b826ac032
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.Array4D Module (F#)
Basic operations on rank 4 arrays.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Array4D  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[create](../vs140/array4d.create--t--function--fsharp-.md)  `: int -> int -> int -> int -> 'T -> 'T [,,,]`|Creates an array whose elements are all initially the given value|  
|[get](../vs140/array4d.get--t--function--fsharp-.md)  `: 'T [,,,] -> int -> int -> int -> int -> 'T`|Fetches an element from a 4D array.|  
|[init](../vs140/array4d.init--t--function--fsharp-.md)  `: int -> int -> int -> int -> (int -> int -> int -> int -> 'T) -> 'T [,,,]`|Creates an array given the dimensions and a generator function to compute the elements.|  
|[length1](../vs140/array4d.length1--t--function--fsharp-.md)  `: 'T [,,,] -> int`|Returns the length of an array in the first dimension|  
|[length2](../vs140/array4d.length2--t--function--fsharp-.md)  `: 'T [,,,] -> int`|Returns the length of an array in the second dimension.|  
|[length3](../vs140/array4d.length3--t--function--fsharp-.md)  `: 'T [,,,] -> int`|Returns the length of an array in the third dimension.|  
|[length4](../vs140/array4d.length4--t--function--fsharp-.md)  `: 'T [,,,] -> int`|Returns the length of an array in the fourth dimension.|  
|[set](../vs140/array4d.set--t--function--fsharp-.md)  `: 'T [,,,] -> int -> int -> int -> int -> 'T -> unit`|Sets the value of an element in an array.|  
|[zeroCreate](../vs140/array4d.zerocreate--t--function--fsharp-.md)  `: int -> int -> int -> int -> 'T [,,,]`|Creates an array where the entries are initially the default value.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)