---
title: "concurrent_priority_queue::concurrent_priority_queue Constructor"
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
  - concurrent_priority_queue/concurrency::concurrent_priority_queue::concurrent_priority_queue
dev_langs: 
  - C++
helpviewer_keywords: 
  - concurrent_priority_queue, constructor
ms.assetid: 6b56ec2d-94c6-43c6-b588-2c5b12315098
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_priority_queue::concurrent_priority_queue Constructor
Constructs a concurrent priority queue.  
  
## Syntax  
  
```  
explicit concurrent_priority_queue(  
   const allocator_type& _Al = allocator_type()  
);  
  
explicit concurrent_priority_queue(  
   size_type _Init_capacity,  
   const allocator_type& _Al = allocator_type()  
);  
  
template<  
   typename _InputIterator  
>  
concurrent_priority_queue(  
   _InputIterator_Begin,  
   _InputIterator_End,  
   const allocator_type& _Al = allocator_type()  
);  
  
concurrent_priority_queue(  
   const concurrent_priority_queue& _Src  
);  
  
concurrent_priority_queue(  
   const concurrent_priority_queue& _Src,  
   const allocator_type& _Al  
);  
  
concurrent_priority_queue(  
   concurrent_priority_queue&& _Src  
);  
  
concurrent_priority_queue(  
   concurrent_priority_queue&& _Src,  
   const allocator_type& _Al  
);  
```  
  
#### Parameters  
 `_InputIterator`  
 The type of the input iterator.  
  
 `_Al`  
 The allocator class to use with this object.  
  
 `_Init_capacity`  
 The initial capacity of the `concurrent_priority_queue` object.  
  
 `_Begin`  
 The position of the first element in the range of elements to be copied.  
  
 `_End`  
 The position of the first element beyond the range of elements to be copied.  
  
 `_Src`  
 The source `concurrent_priority_queue` object to copy or move elements from.  
  
## Remarks  
 All constructors store an allocator object `_Al` and initialize the priority queue.  
  
 The first constructor specifies an empty initial priority queue and optionally specifies an allocator.  
  
 The second constructor specifies a priority queue with an initial capacity `_Init_capacity` and optionally specifies an allocator.  
  
 The third constructor specifies values supplied by the iterator range [`_Begin`, `_End`) and optionally specifies an allocator.  
  
 The fourth and fifth constructors specify a copy of the priority queue `_Src`.  
  
 The sixth and seventh constructors specify a move of the priority queue `_Src`.  
  
## Requirements  
 **Header:** concurrent_priority_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_priority_queue Class](../vs140/concurrent_priority_queue-class.md)