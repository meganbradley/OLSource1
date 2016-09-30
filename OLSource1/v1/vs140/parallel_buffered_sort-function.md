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
Arranges the elements in a specified range into a nondescending order, or according to an ordering criterion specified by a binary predicate, in parallel. This function is semantically similar to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in that it is a compare-based, unstable, in-place sort except that it needs <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> additional space, and requires default initialization for the elements being sorted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The iterator type of the input range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of an STL compatible memory allocator.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the binary comparator.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An instance of an STL compatible memory allocator.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A user-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when satisfied and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when not satisfied. This comparator function must impose a strict weak ordering on pairs of elements from the sequence.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
## Remarks  
 All overloads require <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> additional space, where <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the number of elements to be sorted, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is the element type. In most cases parallel_buffered_sort will show an improvement in performance over [parallel_sort](../vs140/parallel_sort-function.md), and you should use it over parallel_sort if you have the memory available.  
  
 If you do not supply a binary comparator <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is used as the default, which requires the element type to provide the operator <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 If you do not supply an allocator type or instance, the STL memory allocator <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is used to allocate the buffer.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can be used to indicate to the algorithm that it should handles chunks of size < <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> serially.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)