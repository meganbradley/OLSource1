---
title: "parallel_sort Function"
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
  - "ppl/concurrency::parallel_sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_sort function"
ms.assetid: 9c84defe-c8c2-4b56-806e-484b1ce73ef5
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_sort Function
Arranges the elements in a specified range into a nondescending order, or according to an ordering criterion specified by a binary predicate, in parallel. This function is semantically similar to `std::sort` in that it is a compare-based, unstable, in-place sort.  
  
## Syntax  
  
```  
template<  
   typename _Random_iterator  
>  
inline void parallel_sort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End  
);  
  
template<  
   typename _Random_iterator,  
   typename _Function  
>  
inline void parallel_sort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End,  
   const _Function &_Func,  
   const size_t _Chunk_size = 2048  
);  
```  
  
#### Parameters  
 `_Random_iterator`  
 The iterator type of the input range.  
  
 `_Function`  
 The type of the binary comparison functor.  
  
 `_Begin`  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 `_End`  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 `_Func`  
 A user-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns `true` when satisfied and `false` when not satisfied. This comparator function must impose a strict weak ordering on pairs of elements from the sequence.  
  
 `_Chunk_size`  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
## Remarks  
 The first overload uses the the binary comparator `std::less`.  
  
 The second overloaded uses the supplied binary comparator that should have the signature `bool _Func(T, T)` where `T` is the type of the elements in the input range.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument `_Chunk_size` can be used to indicate to the algorithm that it should handles chunks of size < `_Chunk_size` serially.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)