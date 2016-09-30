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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 F# and CLI multi-dimensional arrays are typically zero-based. However, CLI multi-dimensional arrays used in conjunction with external libraries (for examples, libraries associated with Visual Basic) be non-zero based, using a potentially different base for each dimension. The operations in this module will accept such arrays, and the basing on an input array will be propagated to a matching output array on the [Array2D.map](../vs140/array2d.map--t--u--function--fsharp-.md) and [Array2D.mapi](../vs140/array2d.mapi--t--u--function--fsharp-.md) operations. Non-zero-based arrays can also be created using [Array2D.zeroCreateBased](../vs140/array2d.zerocreatebased--t--function--fsharp-.md), [Array2D.createBased](../vs140/array2d.createbased--t--function--fsharp-.md) and [Array2D.initBased](../vs140/array2d.initbased--t--function--fsharp-.md).  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[base1](../vs140/array2d.base1--t--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Fetches the base-index for the first dimension of the array.|  
|[base2](../vs140/array2d.base2--t--function--fsharp-.md)  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Fetches the base-index for the second dimension of the array.|  
|[blit](../vs140/array2d.blit--t--function--fsharp-.md)  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Reads a range of elements from the first array and writes them into the second.|  
|[copy](../vs140/array2d.copy--t--function--fsharp-.md)  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Creates a new array whose elements are the same as the input array.|  
|[create](../vs140/array2d.create--t--function--fsharp-.md)  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Creates an array whose elements are all initially the given value.|  
|[createBased](../vs140/array2d.createbased--t--function--fsharp-.md)  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Creates a based array whose elements are all initially the given value.|  
|[get](../vs140/array2d.get--t--function--fsharp-.md)  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Fetches an element from a 2D array. You can also use the syntax <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|[init](../vs140/array2d.init--t--function--fsharp-.md)  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Creates an array given the dimensions and a generator function to compute the elements.|  
|[initBased](../vs140/array2d.initbased--t--function--fsharp-.md)  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Creates a based array given the dimensions and a generator function to compute the elements.|  
|[iter](../vs140/array2d.iter--t--function--fsharp-.md)  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Applies the given function to each element of the array.|  
|[iteri](../vs140/array2d.iteri--t--function--fsharp-.md) <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Applies the given function to each element of the array. The integer indices passed to the function indicate the index of element.|  
|[length1](../vs140/array2d.length1--t--function--fsharp-.md)  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Returns the length of an array in the first dimension.|  
|[length2](../vs140/array2d.length2--t--function--fsharp-.md)  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Returns the length of an array in the second dimension.|  
|[map](../vs140/array2d.map--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Creates a new array whose elements are the results of applying the given function to each of the elements of the array.|  
|[mapi](../vs140/array2d.mapi--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Creates a new array whose elements are the results of applying the given function to each of the elements of the array. The integer indices passed to the function indicate the element being transformed.|  
|[rebase](../vs140/array2d.rebase--t--function--fsharp-.md)  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Creates a new array whose elements are the same as the input array but where a non-zero-based input array generates a corresponding zero-based output array.|  
|[set](../vs140/array2d.set--t--function--fsharp-.md)  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Sets the value of an element in an array. You can also use the syntax <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|[zeroCreate](../vs140/array2d.zerocreate--t--function--fsharp-.md)  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Creates an array where the entries are initially [Unchecked.defaultof\<'T>](../vs140/unchecked.defaultof--t--type-function--fsharp-.md).|  
|[zeroCreateBased](../vs140/array2d.zerocreatebased--t--function--fsharp-.md)  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Creates a based array where the entries are initially [Unchecked.defaultof\<'T>](../vs140/unchecked.defaultof--t--type-function--fsharp-.md).|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)