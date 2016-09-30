---
title: "concurrent_unordered_map::swap Method"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_map::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 115aa8a0-c542-4874-8bf5-c7dedb26ca95
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::swap Method
Swaps the contents of two `concurrent_unordered_map` objects. This method is not concurrency-safe.  
  
## Syntax  
  
```  
void swap(  
   concurrent_unordered_map& _Umap  
);  
```  
  
#### Parameters  
 `_Umap`  
 The `concurrent_unordered_map` object to swap with.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)