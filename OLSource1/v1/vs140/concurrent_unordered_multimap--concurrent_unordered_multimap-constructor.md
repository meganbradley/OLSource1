---
title: "concurrent_unordered_multimap::concurrent_unordered_multimap Constructor"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_multimap::concurrent_unordered_multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_multimap, constructor"
ms.assetid: 259a5724-a83d-44aa-b6e2-98de0f24609c
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multimap::concurrent_unordered_multimap Constructor
Constructs a concurrent unordered multimap.  
  
## Syntax  
  
```  
explicit concurrent_unordered_multimap(  
   size_type _Number_of_buckets = 8,  
   const hasher& _Hasher = hasher(),  
   const key_equal& _Key_equality = key_equal(),  
   const allocator_type& _Allocator = allocator_type()  
);  
  
concurrent_unordered_multimap(  
   const allocator_type& _Allocator  
);  
  
template <  
   typename _Iterator  
>  
concurrent_unordered_multimap(  
   _Iterator_Begin,  
   _Iterator_End,  
   size_type _Number_of_buckets = 8,  
   const hasher& _Hasher = hasher(),  
   const key_equal& _Key_equality = key_equal(),  
   const allocator_type& _Allocator = allocator_type()  
);  
  
concurrent_unordered_multimap(  
   const concurrent_unordered_multimap& _Umap  
);  
  
concurrent_unordered_multimap(  
   const concurrent_unordered_multimap& _Umap,  
   const allocator_type& _Allocator  
);  
  
concurrent_unordered_multimap(  
   concurrent_unordered_multimap&& _Umap  
);  
```  
  
#### Parameters  
 `_Iterator`  
 The type of the input iterator.  
  
 `_Number_of_buckets`  
 The initial number of buckets for this unordered multimap.  
  
 `_Hasher`  
 The hash function for this unordered multimap.  
  
 `_Key_equality`  
 The equality comparison function for this unordered multimap.  
  
 `_Allocator`  
 The allocator for this unordered multimap.  
  
 `_Begin`  
 The position of the first element in the range of elements to be copied.  
  
 `_End`  
 The position of the first element beyond the range of elements to be copied.  
  
 `_Umap`  
 The source `concurrent_unordered_multimap` object to copy elements from.  
  
## Remarks  
 All constructors store an allocator object `_Allocator` and initialize the unordered multimap.  
  
 The first constructor specifies an empty initial multimap and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered multimap.  
  
 The third constructor specifies values supplied by the iterator range [`_Begin`, `_End`).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered multimap `_Umap`.  
  
 The last constructor specifies a move of the concurrent unordered multimap `_Umap`.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)