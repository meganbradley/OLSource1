---
title: "parallel_buffered_sort Function"
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
  - "ppl/concurrency::parallel_buffered_sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_buffered_sort function"
ms.assetid: fe173c7e-7986-4a31-86e5-0e03c8648824
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_buffered_sort Function
Arranges the elements in a specified range into a nondescending order, or according to an ordering criterion specified by a binary predicate, in parallel. This function is semantically similar to `std::sort` in that it is a compare-based, unstable, in-place sort except that it needs `O(n)` additional space, and requires default initialization for the elements being sorted.  
  
## Syntax  
  
```  
template<  
   typename _Random_iterator  
>  
inline void parallel_buffered_sort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End  
);  
  
template<  
   typename _Allocator,  
   typename _Random_iterator  
>  
inline void parallel_buffered_sort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End  
);  
  
template<  
   typename _Allocator,  
   typename _Random_iterator  
>  
inline void parallel_buffered_sort(  
   const _Allocator& _Alloc,  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End  
);  
  
template<  
   typename _Random_iterator,  
   typename _Function  
>  
inline void parallel_buffered_sort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End,  
   const _Function &_Func,  
   const size_t _Chunk_size = 2048  
);  
  
template<  
   typename _Allocator,  
   typename _Random_iterator,  
   typename _Function  
>  
inline void parallel_buffered_sort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End,  
   const _Function &_Func,  
   const size_t _Chunk_size = 2048  
);  
  
template<  
   typename _Allocator,  
   typename _Random_iterator,  
   typename _Function  
>  
inline void parallel_buffered_sort(  
   const _Allocator& _Alloc,  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End,  
   const _Function &_Func,  
   const size_t _Chunk_size = 2048  
);  
```  
  
#### Parameters  
 `_Random_iterator`  
 The iterator type of the input range.  
  
 `_Allocator`  
 The type of an STL compatible memory allocator.  
  
 `_Function`  
 The type of the binary comparator.  
  
 `_Begin`  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 `_End`  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 `_Alloc`  
 An instance of an STL compatible memory allocator.  
  
 `_Func`  
 A user-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns `true` when satisfied and `false` when not satisfied. This comparator function must impose a strict weak ordering on pairs of elements from the sequence.  
  
 `_Chunk_size`  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
## Remarks  
 All overloads require `n * sizeof(T)` additional space, where `n` is the number of elements to be sorted, and `T` is the element type. In most cases parallel_buffered_sort will show an improvement in performance over [parallel_sort](../vs140/parallel_sort-function.md), and you should use it over parallel_sort if you have the memory available.  
  
 If you do not supply a binary comparator `std::less` is used as the default, which requires the element type to provide the operator `operator<()`.  
  
 If you do not supply an allocator type or instance, the STL memory allocator `std::allocator<T>` is used to allocate the buffer.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument `_Chunk_size` can be used to indicate to the algorithm that it should handles chunks of size < `_Chunk_size` serially.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)