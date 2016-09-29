---
title: "concurrent_vector::shrink_to_fit Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::shrink_to_fit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shrink_to_fit method"
ms.assetid: b5b67a00-6198-4feb-8b78-de1ee29e4229
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::shrink_to_fit Method
Compacts the internal representation of the concurrent vector to reduce fragmentation and optimize memory usage. This method is not concurrency-safe.  
  
## Syntax  
  
```  
void shrink_to_fit();  
```  
  
## Remarks  
 This method will internally re-allocate memory move elements around, invalidating all the iterators. `shrink_to_fit` is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this function.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)