---
title: "partial_sum"
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
  - "partial_sum"
  - "std.partial_sum"
  - "std::partial_sum"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partial_sum function"
ms.assetid: 65f8180d-5f85-4b6a-bbb5-99bbe776f691
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partial_sum
Computes a series of sums in an input range from the first element through the *i*th element and stores the result of each such sum in the *i*th element of a destination range or computes the result of a generalized procedure where the sum operation is replaced by another specified binary operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the range to be partially summed or combined according to a specified binary operation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the range to be partially summed or combined according to a specified binary operation that is one position beyond the final element actually included in the iterated accumulation.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator addressing the first element a destination range where the series of partial sums or the results of the specified operation is to be stored.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The binary operation that is to be applied in the generalized operation replacing the operation of sum in the partial sum procedure.  
  
## Return Value  
 An output iterator addressing the end of the destination range: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> + (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>),  
  
## Remarks  
 The output iterator <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is allowed to be the same iterator as the input iterator <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, so that partial sums may be computed in place.  
  
 For a sequence of values *a*1, *a*2, *a*3,  in an input range, the first template function stores successive partial sums in the destination range, where the *i*th element is given by (  ( (*a*1 + *a*2) + *a*3)  *a*i).  
  
 For a sequence of values *a*1, *a*2, *a*3,  in an input range, the second template function stores successive partial sums in the destination range, where the ith element is given by (  ( ( *a*1 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> *a*2 ) <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> *a*3 )  *a*i).  
  
 The binary operation <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not required to be either associative or commutative, because the order of operations applies is completely specified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<numeric>  
  
 **Namespace:** std  
  
## See Also  
 [partial_sum](../vs140/partial_sum--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)