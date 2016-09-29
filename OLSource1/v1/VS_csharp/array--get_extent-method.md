---
title: "array::get_extent Method"
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
  - "amp/Concurrency::array::get_extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_extent method"
ms.assetid: 624f2d27-3d2b-44b4-803a-403bf124b57d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::get_extent Method
Returns the [extent](../VS_csharp/extent-class--c---amp-.md) object of the [array](../VS_csharp/array-class.md).  
  
## Syntax  
  
```  
Concurrency::extent<_Rank> get_extent() const restrict(amp,cpu);  
```  
  
## Return Value  
 The `extent` object of the [array](../VS_csharp/array-class.md).  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../VS_csharp/array-class.md)