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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The iterator type of the input range.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of an STL compatible memory allocator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the projection function.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An instance of an STL compatible memory allocator.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A user-defined projection function object that converts an element into an integral value.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
## Remarks  
 All overloads require <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> additional space, where <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the number of elements to be sorted, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the element type. An unary projection functor with the signature<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is required to return a key when given an element, where <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the element type and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is an unsigned integer-like type.  
  
 If you do not supply a projection function, a default projection function which simply returns the element is used for integral types. The function will fail to compile if the element is not an integral type in the absence of a projection function.  
  
 If you do not supply an allocator type or instance, the STL memory allocator <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is used to allocate the buffer.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can be used to indicate to the algorithm that it should handles chunks of size < <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> serially.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)