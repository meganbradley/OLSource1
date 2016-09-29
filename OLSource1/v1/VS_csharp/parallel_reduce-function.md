---
title: "parallel_reduce Function"
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
  - "ppl/concurrency::parallel_reduce"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_reduce function"
ms.assetid: 275a2706-c12a-4c87-9ad6-f07d4fc205cc
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_reduce Function
Computes the sum of all elements in a specified range by computing successive partial sums, or computes the result of successive partial results similarly obtained from using a specified binary operation other than sum, in parallel. `parallel_reduce` is semantically similar to `std::accumulate`, except that it requires the binary operation to be associative, and requires an identity value instead of an initial value.  
  
## Syntax  
  
```  
template<  
   typename _Forward_iterator  
>  
inline typename std::iterator_traits<_Forward_iterator>::value_type parallel_reduce(  
   _Forward_iterator_Begin,  
   _Forward_iterator_End,  
   const typename std::iterator_traits<_Forward_iterator>::value_type &_Identity  
);  
  
template<  
   typename _Forward_iterator,  
   typename _Sym_reduce_fun  
>  
inline typename std::iterator_traits<_Forward_iterator>::value_type parallel_reduce(  
   _Forward_iterator_Begin,  
   _Forward_iterator_End,  
   const typename std::iterator_traits<_Forward_iterator>::value_type &_Identity,  
   _Sym_reduce_fun_Sym_fun  
);  
  
template<  
   typename _Reduce_type,  
   typename _Forward_iterator,  
   typename _Range_reduce_fun,  
   typename _Sym_reduce_fun  
>  
inline _Reduce_type parallel_reduce(  
   _Forward_iterator_Begin,  
   _Forward_iterator_End,  
   const _Reduce_type& _Identity,  
   const _Range_reduce_fun &_Range_fun,  
   const _Sym_reduce_fun &_Sym_fun  
);  
```  
  
#### Parameters  
 `_Forward_iterator`  
 The iterator type of input range.  
  
 `_Sym_reduce_fun`  
 The type of the symmetric reduction function. This must be a function type with signature `_Reduce_type _Sym_fun(_Reduce_type, _Reduce_type)`, where _Reduce_type is the same as the identity type and the result type of the reduction. For the third overload, this should be consistent with the output type of `_Range_reduce_fun`.  
  
 `_Reduce_type`  
 The type that the input will reduce to, which can be different from the input element type. The return value and identity value will has this type.  
  
 `_Range_reduce_fun`  
 The type of the range reduction function. This must be a function type with signature `_Reduce_type _Range_fun(_Forward_iterator, _Forward_iterator, _Reduce_type)`, _Reduce_type is the same as the identity type and the result type of the reduction.  
  
 `_Begin`  
 An input iterator addressing the first element in the range to be reduced.  
  
 `_End`  
 An input iterator addressing the element that is one position beyond the final element in the range to be reduced.  
  
 `_Identity`  
 The identity value `_Identity` is of the same type as the result type of the reduction and also the `value_type` of the iterator for the first and second overloads. For the third overload, the identity value must have the same type as the result type of the reduction, but can be different from the `value_type` of the iterator. It must have an appropriate value such that the range reduction operator `_Range_fun`, when applied to a range of a single element of type `value_type` and the identity value, behaves like a type cast of the value from type `value_type` to the identity type.  
  
 `_Sym_fun`  
 The symmetric function that will be used in the second of the reduction. Refer to Remarks for more information.  
  
 `_Range_fun`  
 The function that will be used in the first phase of the reduction. Refer to Remarks for more information.  
  
## Return Value  
 The result of the reduction.  
  
## Remarks  
 To perform a parallel reduction, the function divides the range into chunks based on the number of workers available to the underlying scheduler. The reduction takes place in two phases, the first phase performs a reduction within each chunk, and the second phase performs a reduction between the partial results from each chunk.  
  
 The first overload requires that the iterator's `value_type`, `T`, be the same as the identity value type as well as the reduction result type. The element type T must provide the operator `T T::operator + (T)` to reduce elements in each chunk. The same operator is used in the second phase as well.  
  
 The second overload also requires that the iterator's `value_type` be the same as the identity value type as well as the reduction result type. The supplied binary operator `_Sym_fun` is used in both reduction phases, with the identity value as the initial value for the first phase.  
  
 For the third overload, the identity value type must be the same as the reduction result type, but the iterator's `value_type` may be different from both. The range reduction function `_Range_fun` is used in the first phase with the identity value as the initial value, and the binary function `_Sym_reduce_fun` is applied to sub results in the second phase.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)