---
title: "parallel_transform Function"
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
  - "ppl/concurrency::parallel_transform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_transform function"
ms.assetid: 3f61f693-2a7f-45a7-8904-b6df436a2818
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_transform Function
Applies a specified function object to each element in a source range, or to a pair of elements from two source ranges, and copies the return values of the function object into a destination range, in parallel. This functional is semantically equivalent to `std::transform`.  
  
## Syntax  
  
```  
template <  
   typename _Input_iterator1,  
   typename _Output_iterator,  
   typename _Unary_operator  
>  
_Output_iterator parallel_transform(  
   _Input_iterator1_First1,  
   _Input_iterator1_Last1,  
   _Output_iterator_Result,  
   const _Unary_operator& _Unary_op,  
   const auto_partitioner& _Part = auto_partitioner()  
);  
  
template <  
   typename _Input_iterator1,  
   typename _Output_iterator,  
   typename _Unary_operator  
>  
_Output_iterator parallel_transform(  
   _Input_iterator1_First1,  
   _Input_iterator1_Last1,  
   _Output_iterator_Result,  
   const _Unary_operator& _Unary_op,  
   const static_partitioner& _Part  
);  
  
template <  
   typename _Input_iterator1,  
   typename _Output_iterator,  
   typename _Unary_operator  
>  
_Output_iterator parallel_transform(  
   _Input_iterator1_First1,  
   _Input_iterator1_Last1,  
   _Output_iterator_Result,  
   const _Unary_operator& _Unary_op,  
   const simple_partitioner& _Part  
);  
  
template <  
   typename _Input_iterator1,  
   typename _Output_iterator,  
   typename _Unary_operator  
>  
_Output_iterator parallel_transform(  
   _Input_iterator1_First1,  
   _Input_iterator1_Last1,  
   _Output_iterator_Result,  
   const _Unary_operator& _Unary_op,  
   affinity_partitioner& _Part  
);  
  
template <  
   typename _Input_iterator1,  
   typename _Input_iterator2,  
   typename _Output_iterator,  
   typename _Binary_operator,  
   typename _Partitioner  
>  
_Output_iterator parallel_transform(  
   _Input_iterator1_First1,  
   _Input_iterator1_Last1,  
   _Input_iterator2_First2,  
   _Output_iterator_Result,  
   const _Binary_operator& _Binary_op,  
   _Partitioner&& _Part  
);  
  
template <  
   typename _Input_iterator1,  
   typename _Input_iterator2,  
   typename _Output_iterator,  
   typename _Binary_operator  
>  
_Output_iterator parallel_transform(  
   _Input_iterator1_First1,  
   _Input_iterator1_Last1,  
   _Input_iterator2_First2,  
   _Output_iterator_Result,  
   const _Binary_operator& _Binary_op  
);  
```  
  
#### Parameters  
 `_Input_iterator1`  
 The type of the first or only input iterator.  
  
 `_Output_iterator`  
 The type of the output iterator.  
  
 `_Unary_operator`  
 The type of the unary functor to be executed on each element in the input range.  
  
 `_Input_iterator2`  
 The type of second input iterator.  
  
 `_Binary_operator`  
 The type of the binary functor executed pairwise on elements from the two source ranges.  
  
 `_Partitioner`  
 `_First1`  
 An input iterator addressing the position of the first element in the first or only source range to be operated on.  
  
 `_Last1`  
 An input iterator addressing the position one past the final element in the first or only source range to be operated on.  
  
 `_Result`  
 An output iterator addressing the position of the first element in the destination range.  
  
 `_Unary_op`  
 A user-defined unary function object that is applied to each element in the source range.  
  
 `_Part`  
 A reference to the partitioner object. The argument can be one of `const`[auto_partitioner](../VS_csharp/auto_partitioner-class.md)`&`, `const`[static_partitioner](../VS_csharp/static_partitioner-class.md)`&`, `const`[simple_partitioner](../VS_csharp/simple_partitioner-class.md)`&` or [affinity_partitioner](../VS_csharp/affinity_partitioner-class.md)`&` If an [affinity_partitioner](../VS_csharp/affinity_partitioner-class.md) object is used, the reference must be a non-const l-value reference, so that the algorithm can store state for future loops to re-use.  
  
 `_First2`  
 An input iterator addressing the position of the first element in the second source range to be operated on.  
  
 `_Binary_op`  
 A user-defined binary function object that is applied pairwise, in a forward order, to the two source ranges.  
  
## Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the output elements transformed by the function object.  
  
## Remarks  
 [auto_partitioner](../VS_csharp/auto_partitioner-class.md) will be used for the overloads without an explicit partitioner argument.  
  
 For iterators that do not support random access, only [auto_partitioner](../VS_csharp/auto_partitioner-class.md) is supported.  
  
 The overloads that take the argument `_Unary_op` transform the input range into the output range by applying the unary functor to each element in the input range. `_Unary_op` must support the function call operator with signature `operator()(T)` where `T` is the value type of the range being iterated over.  
  
 The overloads that take the argument `_Binary_op` transform two input ranges into the output range by applying the binary functor to one element from the first input range and one element from the second input range. `_Binary_op` must support the function call operator with signature `operator()(T, U)` where `T`, `U` are value types of the two input iterators.  
  
 For more information, see [Parallel Algorithms](../VS_csharp/parallel-algorithms.md).  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)