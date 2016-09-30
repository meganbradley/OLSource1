---
title: "count"
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
  - "std::_Hash::count"
  - "_Hash::count"
  - "std::count"
  - "xhash/std::_Hash::count"
  - "std.count"
  - "_Hash.count"
  - "std._Hash.count"
  - "std._Tree.count"
  - "std::_Tree::count"
  - "xtree/std::_Tree::count"
  - "count"
  - "Count"
  - "algorithm/std::count"
  - "_Tree::count"
  - "_Tree.count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count function, about count function"
  - "count method"
  - "count"
ms.assetid: 42d33762-e593-4719-ad85-6fb27a83bf41
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# count
Returns the number of elements in a range whose values match a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be traversed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be traversed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value of the elements to be counted.  
  
## Return Value  
 The difference type of the **InputIterator** that counts the number of elements in the range [ <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> ) that have value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 This algorithm is generalized to count elements that satisfy any predicate with the template function [count_if](../vs140/count_if.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **v1 = ( 10 20 10 40 10 )**  
**The number of 10s in v2 is: 3.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [count](../vs140/count--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)