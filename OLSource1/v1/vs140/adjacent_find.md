---
title: "adjacent_find"
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
  - "algorithm/std::adjacent_find"
  - "std.adjacent_find"
  - "adjacent_find"
  - "std::adjacent_find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "adjacent_find function"
  - "adjacent_find"
ms.assetid: 81efd39c-ff0e-476a-9a72-740ea788d966
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# adjacent_find
Searches for two adjacent elements that are either equal or satisfy a specified condition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The binary predicate giving the condition to be satisfied by the values of the adjacent elements in the range being searched.  
  
## Return Value  
 A forward iterator to the first element of the adjacent pair that are either equal to each other (in the first version) or that satisfy the condition given by the binary predicate (in the second version), provided that such a pair of elements is found. Otherwise, an iterator pointing to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is returned.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> algorithm is a nonmutating sequence algorithm. The range to be searched must be valid; all pointers must be dereferenceable and the last position is reachable from the first by incrementation. The time complexity of the algorithm is linear in the number of elements contained in the range.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> used to determine the match between elements must impose an equivalence relation between its operands.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **L = ( 50 40 10 20 20 )**  
**There are two adjacent elements that are equal.**  
 **They have a value of 20.**  
**There are two adjacent elements where the second is twice the first.**  
 **They have values of 10 & 20.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Nonpredicate Version of adjacent_find](../vs140/nonpredicate-version-of-adjacent_find.md)   
 [Predicate Version of adjacent_find](../vs140/predicate-version-of-adjacent_find.md)   
 [Standard Template Library](../vs140/standard-template-library.md)