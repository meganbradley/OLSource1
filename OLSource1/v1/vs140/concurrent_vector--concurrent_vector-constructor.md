---
title: "concurrent_vector::concurrent_vector Constructor"
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
  - concurrent_vector/concurrency::concurrent_vector::concurrent_vector
dev_langs: 
  - C++
helpviewer_keywords: 
  - concurrent_vector, constructor
ms.assetid: 1a3a39af-7ea4-479f-8107-ed0a9be91d0e
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_vector::concurrent_vector Constructor
Constructs a concurrent vector.  
  
## Syntax  
  
```  
explicit concurrent_vector(  
   const allocator_type &_Al = allocator_type()  
);  
  
concurrent_vector(  
   const concurrent_vector& _Vector  
);  
  
template<  
   class M  
>  
concurrent_vector(  
   const concurrent_vector<_Ty,  
   M>& _Vector,  
   const allocator_type& _Al = allocator_type()  
);  
  
concurrent_vector(  
   concurrent_vector && _Vector  
);  
  
explicit concurrent_vector(  
   size_type _N  
);  
  
concurrent_vector(  
   size_type _N,  
   const_reference _Item,  
   const allocator_type& _Al = allocator_type()  
);  
  
template<  
   class _InputIterator  
>  
concurrent_vector(  
   _InputIterator_Begin,  
   _InputIterator_End,  
   const allocator_type &_Al = allocator_type()  
);  
```  
  
#### Parameters  
 `M`  
 The allocator type of the source vector.  
  
 `_InputIterator`  
 The type of the input iterator.  
  
 `_Al`  
 The allocator class to use with this object.  
  
 `_Vector`  
 The source `concurrent_vector` object to copy or move elements from.  
  
 `_N`  
 The initial capacity of the `concurrent_vector` object.  
  
 `_Item`  
 The value of elements in the constructed object.  
  
 `_Begin`  
 Position of the first element in the range of elements to be copied.  
  
 `_End`  
 Position of the first element beyond the range of elements to be copied.  
  
## Remarks  
 All constructors store an allocator object `_Al` and initialize the vector.  
  
 The first constructor specify an empty initial vector and explicitly specifies the allocator type. to be used.  
  
 The second and third constructors specify a copy of the concurrent vector `_Vector`.  
  
 The fourth constructor specifies a move of the concurrent vector `_Vector`.  
  
 The fifth constructor specifies a repetition of a specified number (`_N`) of elements of the default value for class `_Ty`.  
  
 The sixth constructor specifies a repetition of (`_N`) elements of value `_Item`.  
  
 The last constructor specifies values supplied by the iterator range [`_Begin`, `_End`).  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)