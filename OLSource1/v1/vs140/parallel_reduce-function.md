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
Computes the sum of all elements in a specified range by computing successive partial sums, or computes the result of successive partial results similarly obtained from using a specified binary operation other than sum, in parallel. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is semantically similar to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, except that it requires the binary operation to be associative, and requires an identity value instead of an initial value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The iterator type of input range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of the symmetric reduction function. This must be a function type with signature <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, where _Reduce_type is the same as the identity type and the result type of the reduction. For the third overload, this should be consistent with the output type of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type that the input will reduce to, which can be different from the input element type. The return value and identity value will has this type.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type of the range reduction function. This must be a function type with signature <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, _Reduce_type is the same as the identity type and the result type of the reduction.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the range to be reduced.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 An input iterator addressing the element that is one position beyond the final element in the range to be reduced.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The identity value <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is of the same type as the result type of the reduction and also the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> of the iterator for the first and second overloads. For the third overload, the identity value must have the same type as the result type of the reduction, but can be different from the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> of the iterator. It must have an appropriate value such that the range reduction operator <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, when applied to a range of a single element of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and the identity value, behaves like a type cast of the value from type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to the identity type.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The symmetric function that will be used in the second of the reduction. Refer to Remarks for more information.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The function that will be used in the first phase of the reduction. Refer to Remarks for more information.  
  
## Return Value  
 The result of the reduction.  
  
## Remarks  
 To perform a parallel reduction, the function divides the range into chunks based on the number of workers available to the underlying scheduler. The reduction takes place in two phases, the first phase performs a reduction within each chunk, and the second phase performs a reduction between the partial results from each chunk.  
  
 The first overload requires that the iterator's <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, be the same as the identity value type as well as the reduction result type. The element type T must provide the operator <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to reduce elements in each chunk. The same operator is used in the second phase as well.  
  
 The second overload also requires that the iterator's <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> be the same as the identity value type as well as the reduction result type. The supplied binary operator <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is used in both reduction phases, with the identity value as the initial value for the first phase.  
  
 For the third overload, the identity value type must be the same as the reduction result type, but the iterator's <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> may be different from both. The range reduction function <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is used in the first phase with the identity value as the initial value, and the binary function <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is applied to sub results in the second phase.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)