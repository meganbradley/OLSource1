---
title: "tiled_extent::tile_extent Data Member"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - amp/Concurrency::tiled_extent::tile_extent
dev_langs: 
  - C++
ms.assetid: 8dfc2b9d-94e7-4aa5-8085-b49213448b73
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# tiled_extent::tile_extent Data Member
Gets an `extent` object that captures the values of the `tiled_extent` template arguments `_Dim0`, `_Dim1`, and `_Dim2`.  
  
## Syntax  
  
```  
__declspec(property(get=get_tile_extent)) Concurrency::extent<rank> tile_extent;  
```  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [tiled_extent Class](../vs140/tiled_extent-class.md)