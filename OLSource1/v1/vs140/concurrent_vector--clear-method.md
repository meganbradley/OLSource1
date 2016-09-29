---
title: "concurrent_vector::clear Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: a54a5b8e-eee6-4d41-9192-76c88a3e484a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::clear Method
Erases all elements in the concurrent vector. This method is not concurrency-safe.  
  
## Syntax  
  
```  
void clear();  
```  
  
## Remarks  
 `clear` is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this method. `clear` does not free internal arrays. To free internal arrays, call the function `shrink_to_fit` after `clear`.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)