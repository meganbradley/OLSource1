---
title: "concurrent_unordered_multiset::concurrent_unordered_multiset Constructor"
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
  - "concurrent_unordered_set/concurrency::concurrent_unordered_multiset::concurrent_unordered_multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_multiset, constructor"
ms.assetid: 060982f3-e4da-43c6-a2fd-a612483ea106
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multiset::concurrent_unordered_multiset Constructor
Constructs a concurrent unordered multiset.  
  
## Syntax  
  
```  
explicit concurrent_unordered_multiset(  
   size_type _Number_of_buckets = 8,  
   const hasher& _Hasher = hasher(),  
   const key_equal& _Key_equality = key_equal(),  
   const allocator_type& _Allocator = allocator_type()  
);  
  
concurrent_unordered_multiset(  
   const allocator_type& _Allocator  
);  
  
template <  
   typename _Iterator  
>  
concurrent_unordered_multiset(  
   _Iterator_First,  
   _Iterator_Last,  
   size_type _Number_of_buckets = 8,  
   const hasher& _Hasher = hasher(),  
   const key_equal& _Key_equality = key_equal(),  
   const allocator_type& _Allocator = allocator_type()  
);  
  
concurrent_unordered_multiset(  
   const concurrent_unordered_multiset& _Uset  
);  
  
concurrent_unordered_multiset(  
   const concurrent_unordered_multiset& _Uset,  
   const allocator_type& _Allocator  
);  
  
concurrent_unordered_multiset(  
   concurrent_unordered_multiset&& _Uset  
);  
```  
  
#### Parameters  
 `_Iterator`  
 The type of the input iterator.  
  
 `_Number_of_buckets`  
 The initial number of buckets for this unordered multiset.  
  
 `_Hasher`  
 The hash function for this unordered multiset.  
  
 `_Key_equality`  
 The equality comparison function for this unordered multiset.  
  
 `_Allocator`  
 The allocator for this unordered multiset.  
  
 `_First`  
 `_Last`  
 `_Uset`  
 The source `concurrent_unordered_multiset` object to move elements from.  
  
## Remarks  
 All constructors store an allocator object `_Allocator` and initialize the unordered multiset.  
  
 The first constructor specifies an empty initial multiset and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered multiset.  
  
 The third constructor specifies values supplied by the iterator range [`_Begin`, `_End`).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered multiset `_Uset`.  
  
 The last constructor specifies a move of the concurrent unordered multiset `_Uset`.  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../VS_csharp/concurrent_unordered_multiset-class.md)