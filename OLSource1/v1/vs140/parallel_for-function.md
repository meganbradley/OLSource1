---
title: "parallel_for Function"
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
  - ppl/concurrency::parallel_for
dev_langs: 
  - C++
helpviewer_keywords: 
  - parallel_for function
ms.assetid: 97521998-db27-4a52-819a-17c9cfe09b2d
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# parallel_for Function
`parallel_for` iterates over a range of indices and executes a user-supplied function at each iteration, in parallel.  
  
## Syntax  
  
```  
template <  
   typename _Index_type,  
   typename _Function,  
   typename _Partitioner  
>  
void parallel_for(  
   _Index_type_First,  
   _Index_type_Last,  
   _Index_type_Step,  
   const _Function& _Func,  
   _Partitioner&& _Part  
);  
  
template <  
   typename _Index_type,  
   typename _Function  
>  
void parallel_for(  
   _Index_type_First,  
   _Index_type_Last,  
   _Index_type_Step,  
   const _Function& _Func  
);  
  
template <  
   typename _Index_type,  
   typename _Function  
>  
void parallel_for(  
   _Index_type_First,  
   _Index_type_Last,  
   const _Function& _Func,  
   const auto_partitioner& _Part = auto_partitioner()  
);  
  
template <  
   typename _Index_type,  
   typename _Function  
>  
void parallel_for(  
   _Index_type_First,  
   _Index_type_Last,  
   const _Function& _Func,  
   const static_partitioner& _Part  
);  
  
template <  
   typename _Index_type,  
   typename _Function  
>  
void parallel_for(  
   _Index_type_First,  
   _Index_type_Last,  
   const _Function& _Func,  
   const simple_partitioner& _Part  
);  
  
template <  
   typename _Index_type,  
   typename _Function  
>  
void parallel_for(  
   _Index_type_First,  
   _Index_type_Last,  
   const _Function& _Func,  
   affinity_partitioner& _Part  
);  
```  
  
#### Parameters  
 `_Index_type`  
 The type of the index being used for the iteration.  
  
 `_Function`  
 The type of the function that will be executed at each iteration.  
  
 `_Partitioner`  
 The type of the partitioner that is used to partition the supplied range.  
  
 `_First`  
 The first index to be included in the iteration.  
  
 `_Last`  
 The index one past the last index to be included in the iteration.  
  
 `_Step`  
 The value by which to step when iterating from `_First` to `_Last`. The step must be positive. [invalid_argument](../vs140/invalid_argument-class.md) is thrown if the step is less than 1.  
  
 `_Func`  
 The function to be executed at each iteration. This may be a lambda expression, a function pointer, or any object that supports a version of the function call operator with the signature `void operator()(``_Index_type``)`.  
  
 `_Part`  
 A reference to the partitioner object. The argument can be one of `const`[auto_partitioner](../vs140/auto_partitioner-class.md)`&`, `const`[static_partitioner](../vs140/static_partitioner-class.md)`&`, `const`[simple_partitioner](../vs140/simple_partitioner-class.md)`&` or [affinity_partitioner](../vs140/affinity_partitioner-class.md)`&` If an [affinity_partitioner](../vs140/affinity_partitioner-class.md) object is used, the reference must be a non-const l-value reference, so that the algorithm can store state for future loops to re-use.  
  
## Remarks  
 For more information, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)