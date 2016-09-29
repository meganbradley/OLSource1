---
title: "concurrent_vector::grow_to_at_least Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::grow_to_at_least"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "grow_to_at_least method"
ms.assetid: d514c0d3-3d22-44b5-b651-1290ffac7c40
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::grow_to_at_least Method
Grows this concurrent vector until it has at least `_N` elements. This method is concurrency-safe.  
  
## Syntax  
  
```  
iterator grow_to_at_least(  
   size_type _N  
);  
```  
  
#### Parameters  
 `_N`  
 The new minimum size for the `concurrent_vector` object.  
  
## Return Value  
 An iterator that points to beginning of appended sequence, or to the element at index `_N` if no elements were appended.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)