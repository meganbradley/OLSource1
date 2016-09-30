---
title: "equal_range"
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
  - "std::_Tree::equal_range"
  - "_Tree.equal_range"
  - "xhash/std::_Hash::equal_range"
  - "std._Hash.equal_range"
  - "algorithm/std::equal_range"
  - "equal_range"
  - "std::_Hash::equal_range"
  - "_Hash::equal_range"
  - "std._Tree.equal_range"
  - "xtree/std::_Tree::equal_range"
  - "std.equal_range"
  - "_Tree::equal_range"
  - "std::equal_range"
  - "_Hash.equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range"
  - "equal_range method"
  - "equal_range function"
ms.assetid: f508fa87-41c6-4799-90dc-4ebf17d2126a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# equal_range
Given an ordered range, finds the subrange in which all elements are equivalent to a given value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value being searched for in the ordered range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is less than another.  
  
## Return Value  
 A pair of forward iterators that specify a subrange, contained within the range searched, in which all of the elements are equivalent to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the sense defined by the binary predicate used (either <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or the default, less-than).  
  
 If no elements in the range are equivalent to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the returned pair of forward iterators are equal and specify the point where <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> could be inserted without disturbing the order of the range.  
  
## Remarks  
 The first iterator of the pair returned by the algorithm is [lower_bound](../vs140/lower_bound.md), and the second iterator is [upper_bound](../vs140/upper_bound.md).  
  
 The range must be sorted according to the predicate provided to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For example, if you are going to use the greater-than predicate, the range must be sorted in descending order.  
  
 Elements in the possibly empty subrange defined by the pair of iterators returned by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> will be equivalent to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in the sense defined by the predicate used.  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [binary_search](../vs140/binary_search.md)   
 [lower_bound](../vs140/lower_bound.md)   
 [upper_bound](../vs140/upper_bound.md)   
 [Standard Template Library](../vs140/standard-template-library.md)