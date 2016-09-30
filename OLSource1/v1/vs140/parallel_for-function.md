---
title: "parallel_for Function"
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
  - "ppl/concurrency::parallel_for"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_for function"
ms.assetid: 97521998-db27-4a52-819a-17c9cfe09b2d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_for Function
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> iterates over a range of indices and executes a user-supplied function at each iteration, in parallel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the index being used for the iteration.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the function that will be executed at each iteration.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of the partitioner that is used to partition the supplied range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The first index to be included in the iteration.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The index one past the last index to be included in the iteration.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The value by which to step when iterating from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The step must be positive. [invalid_argument](../vs140/invalid_argument-class.md) is thrown if the step is less than 1.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The function to be executed at each iteration. This may be a lambda expression, a function pointer, or any object that supports a version of the function call operator with the signature <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A reference to the partitioner object. The argument can be one of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[auto_partitioner](../vs140/auto_partitioner-class.md)<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>[static_partitioner](../vs140/static_partitioner-class.md)<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>[simple_partitioner](../vs140/simple_partitioner-class.md)<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or [affinity_partitioner](../vs140/affinity_partitioner-class.md)<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> If an [affinity_partitioner](../vs140/affinity_partitioner-class.md) object is used, the reference must be a non-const l-value reference, so that the algorithm can store state for future loops to re-use.  
  
## Remarks  
 For more information, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)