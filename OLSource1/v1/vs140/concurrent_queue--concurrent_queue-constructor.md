---
title: "concurrent_queue::concurrent_queue Constructor"
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
  - concurrent_queue/concurrency::concurrent_queue::concurrent_queue
dev_langs: 
  - C++
helpviewer_keywords: 
  - concurrent_queue, constructor
ms.assetid: d582509e-e49e-48e2-a1bc-0a2fb1940beb
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_queue::concurrent_queue Constructor
Constructs a concurrent queue.  
  
## Syntax  
  
```  
explicit concurrent_queue(  
   const allocator_type &_Al = allocator_type()  
);  
  
concurrent_queue(  
   const concurrent_queue& _OtherQ,  
   const allocator_type &_Al = allocator_type()  
);  
  
concurrent_queue(  
   concurrent_queue&& _OtherQ,  
   const allocator_type &_Al = allocator_type()  
);  
  
template<  
   typename _InputIterator  
>  
concurrent_queue(  
   _InputIterator_Begin,  
   _InputIterator_End  
);  
```  
  
#### Parameters  
 `_InputIterator`  
 The type of the input iterator that specifies a range of values.  
  
 `_Al`  
 The allocator class to use with this object.  
  
 `_OtherQ`  
 The source `concurrent_queue` object to copy or move elements from.  
  
 `_Begin`  
 Position of the first element in the range of elements to be copied.  
  
 `_End`  
 Position of the first element beyond the range of elements to be copied.  
  
## Remarks  
 All constructors store an allocator object `_Al` and initialize the queue.  
  
 The first constructor specifies an empty initial queue and explicitly specifies the allocator type to be used.  
  
 The second constructor specifies a copy of the concurrent queue `_OtherQ`.  
  
 The third constructor specifies a move of the concurrent queue `_OtherQ`.  
  
 The fourth constructor specifies values supplied by the iterator range [`_Begin`, `_End`).  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_queue Class](../vs140/concurrent_queue-class.md)