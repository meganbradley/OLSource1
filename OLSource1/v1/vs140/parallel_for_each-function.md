---
title: "parallel_for_each Function"
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
  - "ppl/concurrency::parallel_for_each"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_for_each function"
ms.assetid: ff7ec2dd-63fd-4838-b202-225036b30f28
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_for_each Function
`parallel_for_each` applies a specified function to each element within a range, in parallel. It is semantically equivalent to the `for_each` function in the `std` namespace, except that iteration over the elements is performed in parallel, and the order of iteration is unspecified. The argument `_Func` must support a function call operator of the form `operator()(T)` where the parameter `T` is the item type of the container being iterated over.  
  
## Syntax  
  
```  
template <  
   typename _Iterator,  
   typename _Function  
>  
void parallel_for_each(  
   _Iterator_First,  
   _Iterator_Last,  
   const _Function& _Func  
);  
  
template <  
   typename _Iterator,  
   typename _Function,  
   typename _Partitioner  
>  
void parallel_for_each(  
   _Iterator_First,  
   _Iterator_Last,  
   const _Function& _Func,  
   _Partitioner&& _Part  
);  
```  
  
#### Parameters  
 `_Iterator`  
 The type of the iterator being used to iterate over the container.  
  
 `_Function`  
 The type of the function that will be applied to each element within the range.  
  
 `_Partitioner`  
 `_First`  
 An iterator addressing the position of the first element to be included in parallel iteration.  
  
 `_Last`  
 An iterator addressing the position one past the final element to be included in parallel iteration.  
  
 `_Func`  
 A user-defined function object that is applied to each element in the range.  
  
 `_Part`  
 A reference to the partitioner object. The argument can be one of `const`[auto_partitioner](../vs140/auto_partitioner-class.md)`&`, `const`[static_partitioner](../vs140/static_partitioner-class.md)`&`, `const`[simple_partitioner](../vs140/simple_partitioner-class.md)`&` or [affinity_partitioner](../vs140/affinity_partitioner-class.md)`&` If an [affinity_partitioner](../vs140/affinity_partitioner-class.md) object is used, the reference must be a non-const l-value reference, so that the algorithm can store state for future loops to re-use.  
  
## Remarks  
 [auto_partitioner](../vs140/auto_partitioner-class.md) will be used for the overload without an explicit partitioner.  
  
 For iterators that do not support random access, only [auto_partitioner](../vs140/auto_partitioner-class.md) is supported.  
  
 For more information, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)