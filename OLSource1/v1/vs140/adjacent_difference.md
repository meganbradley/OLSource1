---
title: "adjacent_difference"
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
  - "std.adjacent_difference"
  - "std::adjacent_difference"
  - "adjacent_difference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "adjacent_difference function"
ms.assetid: f44e205d-d480-4336-b6a6-5af60ced58e3
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# adjacent_difference
Computes the successive differences between each element and its predecessor in an input range and outputs the results to a destination range or computes the result of a generalized procedure where the difference operation is replaced by another, specified binary operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the input range whose elements are to be differenced with their respective predecessors or where the pair of values is to be operated on by another specified binary operation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the input range whose elements are to be differenced with their respective predecessors or where the pair of values is to be operated on by another specified binary operation.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator addressing the first element a destination range where the series of differences or the results of the specified operation is to be stored.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The binary operation that is to be applied in the generalized operation replacing the operation of subtraction in the differencing procedure.  
  
## Return Value  
 An output iterator addressing the end of the destination range: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> + (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
## Remarks  
 The output iterator _*Result* is allowed to be the same iterator as the input iterator *_First,* so that <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>s may be computed in place.  
  
 For a sequence of values *a*1, *a*2, *a*3, in an input range, the first template function stores successive **partial_difference**s *a*1, *a*2 - *a*1, a3 – *a*2, in the destination range.  
  
 For a sequence of values *a*1, *a*2, *a*3, in an input range, the second template function stores successive **partial_difference**s *a*1, *a*2 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> *a*1, *a*3 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> *a*2, in the destination range.  
  
 The binary operation <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not required to be either associative or commutative, because the order of operations applies is completely specified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<numeric>  
  
 **Namespace:** std  
  
## See Also  
 [adjacent_difference and vector::push_back](../vs140/adjacent_difference-and-vector--push_back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)