---
title: "Collections.Array2D Module (F#)"
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
  - "Collections.Array2D"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array2DModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array2D module [F#]"
  - "Array2DModule module [F#]"
ms.assetid: ae1a9746-7817-4430-bcdb-a79c2411bbd3
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.Array2D Module (F#)
Basic operations on 2-dimensional arrays.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Array2D  
```  
  
## Remarks  
 F# and CLI multi-dimensional arrays are typically zero-based. However, CLI multi-dimensional arrays used in conjunction with external libraries (for examples, libraries associated with Visual Basic) be non-zero based, using a potentially different base for each dimension. The operations in this module will accept such arrays, and the basing on an input array will be propagated to a matching output array on the [Array2D.map](../VS_csharp/array2d.map--t--u--function--fsharp-.md) and [Array2D.mapi](../VS_csharp/array2d.mapi--t--u--function--fsharp-.md) operations. Non-zero-based arrays can also be created using [Array2D.zeroCreateBased](../VS_csharp/array2d.zerocreatebased--t--function--fsharp-.md), [Array2D.createBased](../VS_csharp/array2d.createbased--t--function--fsharp-.md) and [Array2D.initBased](../VS_csharp/array2d.initbased--t--function--fsharp-.md).  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[base1](../VS_csharp/array2d.base1--t--function--fsharp-.md)  `: 'T [,] -> int`|Fetches the base-index for the first dimension of the array.|  
|[base2](../VS_csharp/array2d.base2--t--function--fsharp-.md)  `: 'T [,] -> int`|Fetches the base-index for the second dimension of the array.|  
|[blit](../VS_csharp/array2d.blit--t--function--fsharp-.md)  `: 'T [,] -> int -> int -> 'T[,] -> int -> int -> int -> int -> unit`|Reads a range of elements from the first array and writes them into the second.|  
|[copy](../VS_csharp/array2d.copy--t--function--fsharp-.md)  `: 'T [,] -> 'T [,]`|Creates a new array whose elements are the same as the input array.|  
|[create](../VS_csharp/array2d.create--t--function--fsharp-.md)  `: int -> int -> 'T -> 'T [,]`|Creates an array whose elements are all initially the given value.|  
|[createBased](../VS_csharp/array2d.createbased--t--function--fsharp-.md)  `: int -> int -> int -> int -> 'T -> 'T [,]`|Creates a based array whose elements are all initially the given value.|  
|[get](../VS_csharp/array2d.get--t--function--fsharp-.md)  `: 'T [,] -> int -> int -> 'T`|Fetches an element from a 2D array. You can also use the syntax `array.[index1,index2]`.|  
|[init](../VS_csharp/array2d.init--t--function--fsharp-.md)  `: int -> int -> (int -> int -> 'T) -> 'T [,]`|Creates an array given the dimensions and a generator function to compute the elements.|  
|[initBased](../VS_csharp/array2d.initbased--t--function--fsharp-.md)  `: int -> int -> int -> int -> (int -> int -> 'T) -> 'T [,]`|Creates a based array given the dimensions and a generator function to compute the elements.|  
|[iter](../VS_csharp/array2d.iter--t--function--fsharp-.md)  `: ('T -> unit) -> 'T [,] -> unit`|Applies the given function to each element of the array.|  
|[iteri](../VS_csharp/array2d.iteri--t--function--fsharp-.md) `: int -> int -> 'T -> unit`|Applies the given function to each element of the array. The integer indices passed to the function indicate the index of element.|  
|[length1](../VS_csharp/array2d.length1--t--function--fsharp-.md)  `: 'T [,] -> int`|Returns the length of an array in the first dimension.|  
|[length2](../VS_csharp/array2d.length2--t--function--fsharp-.md)  `: 'T [,] -> int`|Returns the length of an array in the second dimension.|  
|[map](../VS_csharp/array2d.map--t--u--function--fsharp-.md)  `: ('T -> 'U) -> 'T [,] -> 'U [,]`|Creates a new array whose elements are the results of applying the given function to each of the elements of the array.|  
|[mapi](../VS_csharp/array2d.mapi--t--u--function--fsharp-.md)  `: (int -> int -> 'T -> 'U) -> 'T [,] -> 'U [,]`|Creates a new array whose elements are the results of applying the given function to each of the elements of the array. The integer indices passed to the function indicate the element being transformed.|  
|[rebase](../VS_csharp/array2d.rebase--t--function--fsharp-.md)  `: 'T [,] -> 'T [,]`|Creates a new array whose elements are the same as the input array but where a non-zero-based input array generates a corresponding zero-based output array.|  
|[set](../VS_csharp/array2d.set--t--function--fsharp-.md)  `: 'T [,] -> int -> int -> 'T -> unit`|Sets the value of an element in an array. You can also use the syntax `array.[index1,index2] <- value`.|  
|[zeroCreate](../VS_csharp/array2d.zerocreate--t--function--fsharp-.md)  `: int -> int -> 'T [,]`|Creates an array where the entries are initially [Unchecked.defaultof<'T>](../VS_csharp/unchecked.defaultof--t--type-function--fsharp-.md).|  
|[zeroCreateBased](../VS_csharp/array2d.zerocreatebased--t--function--fsharp-.md)  `: int -> int -> int -> int -> 'T [,]`|Creates a based array where the entries are initially [Unchecked.defaultof<'T>](../VS_csharp/unchecked.defaultof--t--type-function--fsharp-.md).|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)