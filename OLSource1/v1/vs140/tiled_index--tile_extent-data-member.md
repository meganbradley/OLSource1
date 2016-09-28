---
title: "tiled_index::tile_extent Data Member"
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
  - "amp/Concurrency::tiled_index::tile_extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tile_extent data member"
ms.assetid: e37334a4-0926-4a09-be43-137d8d6ef682
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tiled_index::tile_extent Data Member
Gets an [extent](../vs140/extent-class--c---amp-.md) object that has the values of the [tiled_index](../vs140/tiled_index-class.md) template arguments [tiled_index](../vs140/tiled_index-class.md) template arguments `_Dim0`, `_Dim1`, and `_Dim2`.  
  
## Syntax  
  
```  
__declspec(property(get=get_tile_extent)) extent<rank> tile_extent;  
```  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [tiled_index Class](../vs140/tiled_index-class.md)