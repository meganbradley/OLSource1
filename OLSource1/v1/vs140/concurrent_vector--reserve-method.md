---
title: "concurrent_vector::reserve Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::reserve"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve method"
ms.assetid: 3f531d7f-87ce-4a8c-aff2-daa00b14edd6
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::reserve Method
Allocates enough space to grow the concurrent vector to size `_N` without having to allocate more memory later. This method is not concurrency-safe.  
  
## Syntax  
  
```  
void reserve(  
   size_type _N  
);  
```  
  
#### Parameters  
 `_N`  
 The number of elements to reserve space for.  
  
## Remarks  
 `reserve` is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this method. The capacity of the concurrent vector after the method returns may be bigger than the requested reservation.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)