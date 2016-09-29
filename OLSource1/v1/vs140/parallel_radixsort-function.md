---
title: "parallel_radixsort Function"
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
  - "ppl/concurrency::parallel_radixsort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_radixsort function"
ms.assetid: f3cf915b-b280-4bf1-bed9-ce3fb660341c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_radixsort Function
Arranges elements in a specified range into an non descending order using a radix sorting algorithm. This is a stable sort function which requires a projection function that can project elements to be sorted into unsigned integer-like keys. Default initialization is required for the elements being sorted.  
  
## Syntax  
  
```  
template<  
   typename _Random_iterator  
>  
inline void parallel_radixsort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End  
);  
  
template<  
   typename _Allocator,  
   typename _Random_iterator  
>  
inline void parallel_radixsort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End  
);  
  
template<  
   typename _Allocator,  
   typename _Random_iterator  
>  
inline void parallel_radixsort(  
   const _Allocator& _Alloc,  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End  
);  
  
template<  
   typename _Random_iterator,  
   typename _Function  
>  
inline void parallel_radixsort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End,  
   const _Function &_Proj_func,  
   const size_t _Chunk_size = 256 * 256  
);  
  
template<  
   typename _Allocator,  
   typename _Random_iterator,  
   typename _Function  
>  
inline void parallel_radixsort(  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End,  
   const _Function &_Proj_func,  
   const size_t _Chunk_size = 256 * 256  
);  
  
template<  
   typename _Allocator,  
   typename _Random_iterator,  
   typename _Function  
>  
inline void parallel_radixsort(  
   const _Allocator& _Alloc,  
   const _Random_iterator &_Begin,  
   const _Random_iterator &_End,  
   const _Function &_Proj_func,  
   const size_t _Chunk_size = 256 * 256  
);  
```  
  
#### Parameters  
 `_Random_iterator`  
 The iterator type of the input range.  
  
 `_Allocator`  
 The type of an STL compatible memory allocator.  
  
 `_Function`  
 The type of the projection function.  
  
 `_Begin`  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 `_End`  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 `_Alloc`  
 An instance of an STL compatible memory allocator.  
  
 `_Proj_func`  
 A user-defined projection function object that converts an element into an integral value.  
  
 `_Chunk_size`  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
## Remarks  
 All overloads require `n * sizeof(T)` additional space, where `n` is the number of elements to be sorted, and `T` is the element type. An unary projection functor with the signature`I _Proj_func(T)` is required to return a key when given an element, where `T` is the element type and `I` is an unsigned integer-like type.  
  
 If you do not supply a projection function, a default projection function which simply returns the element is used for integral types. The function will fail to compile if the element is not an integral type in the absence of a projection function.  
  
 If you do not supply an allocator type or instance, the STL memory allocator `std::allocator<T>` is used to allocate the buffer.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument `_Chunk_size` can be used to indicate to the algorithm that it should handles chunks of size < `_Chunk_size` serially.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)