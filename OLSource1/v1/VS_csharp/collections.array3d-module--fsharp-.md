---
title: "Collections.Array3D Module (F#)"
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
  - "Collections.Array3D"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array3DModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array3DModule module [F#]"
  - "Array3D module [F#]"
ms.assetid: c8355e2d-add8-48a4-8aa6-1c57ae74c560
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.Array3D Module (F#)
Basic operations on rank 3 arrays.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Array3D  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[create](../VS_csharp/array3d.create--t--function--fsharp-.md)  `: int -> int -> int -> int -> 'T -> 'T [,,]`|Creates an array whose elements are all initially the given value.|  
|[get](../VS_csharp/array3d.get--t--function--fsharp-.md)  `: 'T [,,] -> int -> int -> int -> 'T`|Fetches an element from a 3D array. You can also use the syntax `array.[index1,index2,index3]`.|  
|[init](../VS_csharp/array3d.init--t--function--fsharp-.md)  `: int -> int -> int -> (int -> int -> int -> 'T) -> 'T [,,]`|Creates an array given the dimensions and a generator function to compute the elements.|  
|[iter](../VS_csharp/array3d.iter--t--function--fsharp-.md)  `: ('T -> unit) -> 'T [,,] -> unit`|Applies the given function to each element of the array.|  
|[iteri](../VS_csharp/array3d.iteri--t--function--fsharp-.md)  `: (int -> int -> int -> 'T -> unit) -> 'T [,,] -> unit`|Applies the given function to each element of the array. The integer indices passed to the function indicate the index of element.|  
|[length1](../VS_csharp/array3d.length1--t--function--fsharp-.md)  `: 'T [,,] -> int`|Returns the length of an array in the first dimension|  
|[length2](../VS_csharp/array3d.length2--t--function--fsharp-.md)  `: 'T [,,] -> int`|Returns the length of an array in the second dimension.|  
|[length3](../VS_csharp/array3d.length3--t--function--fsharp-.md)  `: 'T [,,] -> int`|Returns the length of an array in the third dimension.|  
|[map](../VS_csharp/array3d.map--t--u--function--fsharp-.md)  `: ('T -> 'U) -> 'T [,,] -> 'U [,,]`|Builds a new array whose elements are the results of applying the given function to each of the elements of the array.|  
|[mapi](../VS_csharp/array3d.mapi--t--u--function--fsharp-.md)  `: (int -> int -> int -> 'T -> 'U) -> 'T [,,] -> 'U [,,]`|Builds a new array whose elements are the results of applying the given function to each of the elements of the array. The integer indices passed to the function indicate the element being transformed.|  
|[set](../VS_csharp/array3d.set--t--function--fsharp-.md)  `: 'T [,,] -> int -> int -> int -> 'T -> unit`|Sets the value of an element in an array. You can also use the syntax `array.[index1,index2,index3] <- value`.|  
|[zeroCreate](../VS_csharp/array3d.zerocreate--t--function--fsharp-.md)  `: int -> int -> int -> 'T [,,]`|Creates an array where the entries are initially the default value.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)