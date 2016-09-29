---
title: "extent::tile Method"
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
  - "amp/Concurrency::extent::tile"
dev_langs: 
  - "C++"
ms.assetid: 208390e6-dfe8-4abf-9d4c-54f2405d8b35
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extent::tile Method
Produces a [tiled_extent](../vs140/tiled_extent-class.md) object with the specified tile dimensions.  
  
## Syntax  
  
```  
template <  
   int _Dim0  
>  
tiled_extent<_Dim0> tile() const ;  
  
template <  
   int _Dim0,  
   int _Dim1  
>  
tiled_extent<_Dim0, _Dim1> tile() const ;  
  
template <  
   int _Dim0,  
   int _Dim1,  
   int _Dim2  
>  
tiled_extent<_Dim0, _Dim1, _Dim2> tile() const ;  
```  
  
#### Parameters  
 `_Dim0`  
 The most significant component of the tiled extent.  
  
 `_Dim1`  
 The next-to-most-significant component of the tiled extent.  
  
 `_Dim2`  
 The least significant component of the tiled extent.  
  
## Return Value  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [extent Class  (C++ Accelerated Massive Parallelism)](../vs140/extent-class--c---amp-.md)