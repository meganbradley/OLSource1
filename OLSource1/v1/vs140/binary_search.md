---
title: "binary_search"
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
  - "binary_search"
  - "std.binary_search"
  - "std::binary_search"
  - "algorithm/std::binary_search"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binary_search function"
  - "binary_search"
ms.assetid: 6dec2260-8aeb-4a66-9fb1-3afcf7a415f6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binary_search
Tests whether there is an element in a sorted range that is equal to a specified value or that is equivalent to it in a sense specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value required to be matched by the value of the element or that must satisfy the condition with the element value specified by the binary predicate.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>when satisfied and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when not satisfied.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if an element is found in the range that is equal or equivalent to the specified value; otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The sorted source range referenced must be valid; all pointers must be dereferenceable and, within the sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted range must each be arranged as a precondition to the application of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The source ranges are not modified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The value types of the forward iterators need to be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [lower_bound](../vs140/lower_bound.md)   
 [upper_bound](../vs140/upper_bound.md)   
 [equal_range](../vs140/equal_range.md)   
 [Standard Template Library](../vs140/standard-template-library.md)