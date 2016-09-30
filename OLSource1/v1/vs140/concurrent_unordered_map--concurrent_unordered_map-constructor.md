---
title: "concurrent_unordered_map::concurrent_unordered_map Constructor"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_map::concurrent_unordered_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_map, constructor"
ms.assetid: 871fb66a-31a2-47d8-acfd-8e39aedf1529
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::concurrent_unordered_map Constructor
Constructs a concurrent unordered map.  
  
## Syntax  
  
```  
explicit concurrent_unordered_map(  
   size_type _Number_of_buckets = 8,  
   const hasher& _Hasher = hasher(),  
   const key_equal& _Key_equality = key_equal(),  
   const allocator_type& _Allocator = allocator_type()  
);  
  
concurrent_unordered_map(  
   const allocator_type& _Allocator  
);  
  
template <  
   typename _Iterator  
>  
concurrent_unordered_map(  
   _Iterator_Begin,  
   _Iterator_End,  
   size_type _Number_of_buckets = 8,  
   const hasher& _Hasher = hasher(),  
   const key_equal& _Key_equality = key_equal(),  
   const allocator_type& _Allocator = allocator_type()  
);  
  
concurrent_unordered_map(  
   const concurrent_unordered_map& _Umap  
);  
  
concurrent_unordered_map(  
   const concurrent_unordered_map& _Umap,  
   const allocator_type& _Allocator  
);  
  
concurrent_unordered_map(  
   concurrent_unordered_map&& _Umap  
);  
```  
  
#### Parameters  
 `_Iterator`  
 The type of the input iterator.  
  
 `_Number_of_buckets`  
 The initial number of buckets for this unordered map.  
  
 `_Hasher`  
 The hash function for this unordered map.  
  
 `_Key_equality`  
 The equality comparison function for this unordered map.  
  
 `_Allocator`  
 The allocator for this unordered map.  
  
 `_Begin`  
 The position of the first element in the range of elements to be copied.  
  
 `_End`  
 The position of the first element beyond the range of elements to be copied.  
  
 `_Umap`  
 The source `concurrent_unordered_map` object to copy or move elements from.  
  
## Remarks  
 All constructors store an allocator object `_Allocator` and initialize the unordered map.  
  
 The first constructor specifies an empty initial map and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered map.  
  
 The third constructor specifies values supplied by the iterator range [`_Begin`, `_End`).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered map `_Umap`.  
  
 The last constructor specifies a move of the concurrent unordered map `_Umap`.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)