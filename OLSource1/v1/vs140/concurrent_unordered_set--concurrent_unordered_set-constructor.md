---
title: "concurrent_unordered_set::concurrent_unordered_set Constructor"
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
  - "concurrent_unordered_set/concurrency::concurrent_unordered_set::concurrent_unordered_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_set, constructor"
ms.assetid: ae86d264-8e7a-4ae1-ac7b-b2abe25863de
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_set::concurrent_unordered_set Constructor
Constructs a concurrent unordered set.  
  
## Syntax  
  
```  
explicit concurrent_unordered_set(  
   size_type _Number_of_buckets = 8,  
   const hasher& _Hasher = hasher(),  
   const key_equal& _Key_equality = key_equal(),  
   const allocator_type& _Allocator = allocator_type()  
);  
  
concurrent_unordered_set(  
   const allocator_type& _Allocator  
);  
  
template <  
   typename _Iterator  
>  
concurrent_unordered_set(  
   _Iterator_First,  
   _Iterator_Last,  
   size_type _Number_of_buckets = 8,  
   const hasher& _Hasher = hasher(),  
   const key_equal& _Key_equality = key_equal(),  
   const allocator_type& _Allocator = allocator_type()  
);  
  
concurrent_unordered_set(  
   const concurrent_unordered_set& _Uset  
);  
  
concurrent_unordered_set(  
   const concurrent_unordered_set& _Uset,  
   const allocator_type& _Allocator  
);  
  
concurrent_unordered_set(  
   concurrent_unordered_set&& _Uset  
);  
```  
  
#### Parameters  
 `_Iterator`  
 The type of the input iterator.  
  
 `_Number_of_buckets`  
 The initial number of buckets for this unordered set.  
  
 `_Hasher`  
 The hash function for this unordered set.  
  
 `_Key_equality`  
 The equality comparison function for this unordered set.  
  
 `_Allocator`  
 The allocator for this unordered set.  
  
 `_First`  
 `_Last`  
 `_Uset`  
 The source `concurrent_unordered_set` object to copy or move elements from.  
  
## Remarks  
 All constructors store an allocator object `_Allocator` and initialize the unordered set.  
  
 The first constructor specifies an empty initial set and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered set.  
  
 The third constructor specifies values supplied by the iterator range [`_Begin`, `_End`).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered set `_Uset`.  
  
 The last constructor specifies a move of the concurrent unordered set `_Uset`.  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)