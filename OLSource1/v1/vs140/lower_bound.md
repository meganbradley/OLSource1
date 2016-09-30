---
title: "lower_bound"
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
  - "algorithm/std::lower_bound"
  - "_Hash.lower_bound"
  - "xhash/std::_Hash::lower_bound"
  - "std._Tree.lower_bound"
  - "xtree/std::_Tree::lower_bound"
  - "std._Hash.lower_bound"
  - "std::lower_bound"
  - "lower_bound"
  - "_Tree::lower_bound"
  - "std::_Hash::lower_bound"
  - "std::_Tree::lower_bound"
  - "_Tree.lower_bound"
  - "std.lower_bound"
  - "_Hash::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
  - "lower_bound"
  - "lower_bound method"
ms.assetid: bf1b020c-f97a-4e2b-85f4-c09f6a0da1c4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lower_bound
Finds the position of the first element in an ordered range that has a value greater than or equivalent to a specified value, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value whose first position or possible first position is being searched for in the ordered range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator at the position of the first element in an ordered range with a value that is greater than or equivalent to a specified value, where the equivalence is specified with a binary predicate.  
  
## Remarks  
 The sorted source range referenced must be valid; all iterators must be dereferenceable and within the sequence the last position must be reachable from the first by incrementation.  
  
 A sorted range is a precondition of using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and where the ordering is the same as specified by with binary predicate.  
  
 The range is not modified by the algorithm <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
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
 [upper_bound](../vs140/upper_bound.md)   
 [equal_range](../vs140/equal_range.md)   
 [binary_search](../vs140/binary_search.md)   
 [lower_bound](../vs140/lower_bound--stl-samples-.md)   
 [Predicate Version of lower_bound](../vs140/predicate-version-of-lower_bound.md)   
 [Standard Template Library](../vs140/standard-template-library.md)