---
title: "accumulate"
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
  - "std.accumulate"
  - "accumulate"
  - "std::accumulate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accumulate function"
ms.assetid: 9908525b-967c-402d-9ee9-aadacc241efc
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accumulate
Computes the sum of all the elements in a specified range including some initial value by computing successive partial sums or computes the result of successive partial results similarly obtained from using a specified binary operation other than the sum.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the range to be summed or combined according to a specified binary operation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the range to be summed or combined according to a specified binary operation that is one position beyond the final element actually included in the iterated accumulation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An initial value to which each element is in turn added or combined with according to a specified binary operation.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The binary operation that is to be applied to the each element in the specified range and the result of its previous applications.  
  
## Return Value  
 The sum of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and all the elements in the specified range for the first template function, or, for the second template function, the result of applying the binary operation specified, instead of the sum operation, to (*PartialResult, \*Iter*), where *PartialResult* is the result of previous applications of the operation and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an iterator pointing to an element in the range.  
  
## Remarks  
 The initial value insures that there will be a well-defined result when the range is empty, in which case <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is returned. The binary operation does not need to be associative or commutative. The result is initialized to the initial value <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and then *result* = <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (*result*, **\***<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) is calculated iteratively through the range, where <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is an iterator pointing to successive element in the range. The range must be valid and the complexity is linear with the size of the range. The return type of the binary operator must be convertible to **Type** to ensure closure during the iteration.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v1 is:**  
 **( 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 ).**  
**The sum of the integers from 1 to 20 is: 210.**  
**The vector of partial sums is:**  
 **( 1 3 6 10 15 21 28 36 45 55 66 78 91 105 120 136 153 171 190 210 ).**  
**The original vector v3 is:**  
 **( 1 2 3 4 5 6 7 8 9 10 ).**  
**The product of the integers from 1 to 10 is: 3628800.**  
**The vector of partial products is:**  
 **( 1 2 6 24 120 720 5040 40320 362880 3628800 ).**   
## Requirements  
 **Header:** \<numeric>  
  
 **Namespace:** std  
  
## See Also  
 [accumulate, copy, and vector::push_back](../vs140/accumulate--copy--and-vector--push_back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)