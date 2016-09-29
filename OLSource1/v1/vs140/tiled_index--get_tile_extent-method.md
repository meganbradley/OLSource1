---
title: "tiled_index::get_tile_extent Method"
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
  - "amp/Concurrency::tiled_index::get_tile_extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_tile_extent method"
ms.assetid: 978ed5bd-51ef-49e4-b88f-794ea694dad2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tiled_index::get_tile_extent Method
Returns an [extent](../vs140/extent-class--c---amp-.md) object that has the values of the [tiled_index](../vs140/tiled_index-class.md) template arguments `_Dim0`, `_Dim1`, and `_Dim2`.  
  
## Syntax  
  
```  
extent<rank> get_tile_extent()restrict(amp,cpu);  
```  
  
## Return Value  
 An `extent` object that has the values of the `tiled_index` template arguments `_Dim0`, `_Dim1`, and `_Dim2`.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [tiled_index Class](../vs140/tiled_index-class.md)