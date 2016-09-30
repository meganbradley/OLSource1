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
Arranges the elements in a specified range into a nondescending order, or according to an ordering criterion specified by a binary predicate, in parallel. This function is semantically similar to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in that it is a compare-based, unstable, in-place sort.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator type of the input range.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the binary comparison functor.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A user-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> when satisfied and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when not satisfied. This comparator function must impose a strict weak ordering on pairs of elements from the sequence.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
## Remarks  
 The first overload uses the the binary comparator <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The second overloaded uses the supplied binary comparator that should have the signature <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the type of the elements in the input range.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can be used to indicate to the algorithm that it should handles chunks of size < <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> serially.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)