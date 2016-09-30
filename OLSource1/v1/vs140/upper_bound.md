---
title: "upper_bound"
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
  - "_Tree.upper_bound"
  - "algorithm/std::upper_bound"
  - "xtree/std::_Tree::upper_bound"
  - "std._Hash.upper_bound"
  - "std::_Tree::upper_bound"
  - "upper_bound"
  - "_Tree::upper_bound"
  - "_Hash.upper_bound"
  - "_Hash::upper_bound"
  - "std::upper_bound"
  - "std._Tree.upper_bound"
  - "std::_Hash::upper_bound"
  - "std.upper_bound"
  - "xhash/std::_Hash::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
  - "upper_bound"
  - "upper_bound function"
ms.assetid: dc465786-0704-42b4-af2a-3fabc917c928
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# upper_bound
Finds the position of the first element in an ordered range that has a value that is greater than a specified value, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value in the ordered range that needs to be exceeded by the value of the element addressed by the iterator returned.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator to the position of the first element that has a value greater than a specified value.  
  
## Remarks  
 The sorted source range referenced must be valid; all iterators must be dereferenceable and within the sequence the last position must be reachable from the first by incrementation.  
  
 A sorted range is a precondition of the use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and where the ordering criterion is the same as specified by the binary predicate.  
  
 The range is not modified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The value types of the forward iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [lower_bound](../vs140/lower_bound.md)   
 [equal_range](../vs140/equal_range.md)   
 [binary_search](../vs140/binary_search.md)   
 [Predicate Version of upper_bound](../vs140/predicate-version-of-upper_bound.md)   
 [upper_bound](../vs140/upper_bound--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)