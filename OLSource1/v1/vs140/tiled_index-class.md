---
title: "tiled_index Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::tiled_index"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tiled_index class"
ms.assetid: 0ce2ae26-f1bb-4436-b473-a9e1b619bb38
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tiled_index Class
Provides an index into a [tiled_extent](../vs140/tiled_extent-class.md) object. This class has properties to access elements relative to the local tile origin and relative to the global origin. For more information about tiled spaces, see [Using Tiles](../vs140/using-tiles.md).  
  
## Syntax  
  
```  
template <  
   int _Dim0,  
   int _Dim1 = 0,  
   int _Dim2 = 0  
>  
class tiled_index : public _Tiled_index_base<3>;  
  
template <  
   int _Dim0,  
   int _Dim1  
>  
class tiled_index<_Dim0, _Dim1, 0> : public _Tiled_index_base<2>;  
  
template <  
   int _Dim0  
>  
class tiled_index<_Dim0, 0, 0> : public _Tiled_index_base<1>;  
```  
  
#### Parameters  
 `_Dim0`  
 The length of the most significant dimension.  
  
 `_Dim1`  
 The length of the next-to-most significant dimension.  
  
 `_Dim2`  
 The length of the least significant dimension.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_index::tiled_index Constructor](../vs140/tiled_index--tiled_index-constructor.md)|Initializes a new instance of the `tile_index` class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_index::get_tile_extent Method](../vs140/tiled_index--get_tile_extent-method.md)|Returns an [extent](../vs140/extent-class--c---amp-.md) object that has the values of the [tiled_index](../vs140/tiled_index-class.md) template arguments `_Dim0`, `_Dim1`, and `_Dim2`.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_index::barrier Constant](../vs140/tiled_index--barrier-constant.md)|Stores a [tile_barrier](../vs140/tile_barrier-class.md) object that represents a barrier in the current tile of threads.|  
|||  
|[tiled_index::global Constant](../vs140/tiled_index--global-constant.md)|Stores an [index](../vs140/index-class.md) object of rank 1, 2, or 3 that represents the global index in a [grid](assetId:///f7d1b6a6-586c-4345-b09a-bfc26c492cb0) object.|  
|[tiled_index::local Constant](../vs140/tiled_index--local-constant.md)|Stores an `index` object of rank 1, 2, or 3 that represents the relative index in the current tile of a [tiled_extent](../vs140/tiled_extent-class.md) object.|  
|[tiled_index::rank Constant](../vs140/tiled_index--rank-constant.md)|Stores the rank of the [tiled_index](../vs140/tiled_index-class.md) object.|  
|[tiled_index::tile Constant](../vs140/tiled_index--tile-constant.md)|Stores an `index` object of rank 1, 2, or 3 that represents the coordinates of the current tile of a `tiled_extent` object.|  
|[tiled_index::tile_dim0 Constant](../vs140/tiled_index--tile_dim0-constant.md)|Stores the length of the most significant dimension.|  
|[tiled_index::tile_dim1 Constant](../vs140/tiled_index--tile_dim1-constant.md)|Stores the length of the next-to-most significant dimension.|  
|[tiled_index::tile_dim2 Constant](../vs140/tiled_index--tile_dim2-constant.md)|Stores the length of the least significant dimension.|  
|[tiled_index::tile_origin](../vs140/tiled_index--tile_origin-constant.md)|Stores an `index` object of rank 1, 2, or 3 that represents the global coordinates of the origin of the current tile in a `tiled_extent` object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_index::tile_extent Data Member](../vs140/tiled_index--tile_extent-data-member.md)|Gets an [extent](../vs140/extent-class--c---amp-.md) object that has the values of the [tiled_index](../vs140/tiled_index-class.md) template arguments [tiled_index](../vs140/tiled_index-class.md) template arguments `_Dim0`, `_Dim1`, and `_Dim2`.|  
  
## Inheritance Hierarchy  
 `_Tiled_index_base`  
  
 `tiled_index`  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)