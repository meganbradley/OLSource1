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
Applies a specified function object to each element in a source range, or to a pair of elements from two source ranges, and copies the return values of the function object into a destination range, in parallel. This functional is semantically equivalent to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the first or only input iterator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the output iterator.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of the unary functor to be executed on each element in the input range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of second input iterator.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the binary functor executed pairwise on elements from the two source ranges.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first or only source range to be operated on.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the first or only source range to be operated on.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A user-defined unary function object that is applied to each element in the source range.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A reference to the partitioner object. The argument can be one of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[auto_partitioner](../vs140/auto_partitioner-class.md)<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>[static_partitioner](../vs140/static_partitioner-class.md)<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>[simple_partitioner](../vs140/simple_partitioner-class.md)<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or [affinity_partitioner](../vs140/affinity_partitioner-class.md)<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> If an [affinity_partitioner](../vs140/affinity_partitioner-class.md) object is used, the reference must be a non-const l-value reference, so that the algorithm can store state for future loops to re-use.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second source range to be operated on.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A user-defined binary function object that is applied pairwise, in a forward order, to the two source ranges.  
  
## Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the output elements transformed by the function object.  
  
## Remarks  
 [auto_partitioner](../vs140/auto_partitioner-class.md) will be used for the overloads without an explicit partitioner argument.  
  
 For iterators that do not support random access, only [auto_partitioner](../vs140/auto_partitioner-class.md) is supported.  
  
 The overloads that take the argument <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> transform the input range into the output range by applying the unary functor to each element in the input range. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> must support the function call operator with signature <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is the value type of the range being iterated over.  
  
 The overloads that take the argument <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> transform two input ranges into the output range by applying the binary functor to one element from the first input range and one element from the second input range. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> must support the function call operator with signature <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> are value types of the two input iterators.  
  
 For more information, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)