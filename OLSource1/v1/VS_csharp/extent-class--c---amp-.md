---
title: "extent Class (C++ AMP)"
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
  - "amp/Concurrency::extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extent structure"
ms.assetid: edb5de3d-3935-4dbb-8365-4cc6c4fb0269
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extent Class (C++ AMP)
Represents a vector of *N* integer values that specify the bounds of an *N*-dimensional space that has an origin of 0. The values in the vector are ordered from most significant to least significant.  
  
## Syntax  
  
```  
template <  
   int _Rank>  
class extent;  
```  
  
#### Parameters  
 `_Rank`  
 The rank of the `extent` object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[extent::extent Constructor](../VS_csharp/extent--extent-constructor.md)|Initializes a new instance of the `extent` class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[extent::contains Method](../VS_csharp/extent--contains-method.md)|Verifies that the specified `extent` object has the specified rank.|  
|[extent::size Method](../VS_csharp/extent--size-method.md)|Returns the total linear size of the extent (in units of elements).|  
|[extent::tile method](../VS_csharp/extent--tile-method.md)|Produces a `tiled_extent` object with the tile extents given by specified dimensions.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[extent::operator- Operator](../VS_csharp/extent--operator--operator.md)|Returns a new `extent` object that's created by subtracting the `index` elements from the corresponding `extent` elements.|  
|[extent::operator-- Operator](../VS_csharp/extent--operator---operator.md)|Decrements each element of the `extent` object.|  
|[extent::operator%= Operator](../VS_csharp/extent--operator-mod-=-operator.md)|Calculates the modulus (remainder) of each element in the `extent` object when that element is divided by a number.|  
|[extent::operator*= Operator](../VS_csharp/extent--operator-=-operator.md)|Multiplies each element of the `extent` object by a number.|  
|[extent::operator/= Operator](../VS_csharp/extent--operator-=-operator1.md)|Divides each element of the `extent` object by a number.|  
|[extent::operator&#91;&#93; Operator](../VS_csharp/extent--operatoroperator.md)|Returns the element that's at the specified index.|  
|[extent::operator+ Operator](../VS_csharp/extent--operator--operator.md)|Returns a new `extent` object that's created by adding the corresponding `index` and `extent` elements.|  
|[extent::operator++ Operator](../VS_csharp/extent--operator---operator.md)|Increments each element of the `extent` object.|  
|[extent::operator+= Operator](../VS_csharp/extent--operator-=-operator.md)|Adds the specified number to each element of the `extent` object.|  
|[extent::operator= Operator](../VS_csharp/extent--operator=-operator.md)|Copies the contents of another `extent` object into this one.|  
|[extent::operator-= Operator](../VS_csharp/extent--operator-=-operator2.md)|Subtracts the specified number from each element of the `extent` object.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[extent::rank Constant](../VS_csharp/extent--rank-constant.md)|Gets the rank of the `extent` object.|  
  
## Inheritance Hierarchy  
 `extent`  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../VS_csharp/concurrency-namespace--c---amp-.md)