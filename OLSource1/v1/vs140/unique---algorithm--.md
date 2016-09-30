---
title: "unique (&lt;algorithm&gt;)"
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
  - "algorithm/std::unique"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique function"
ms.assetid: a9615038-2b77-43bf-876b-9f79be88eff0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique (&lt;algorithm&gt;)
Removes duplicate elements that are adjacent to each other in a specified range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be scanned for duplicate removal.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be scanned for duplicate removal.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator to the new end of the modified sequence that contains no consecutive duplicates, addressing the position one past the last element not removed.  
  
## Remarks  
 Both forms of the algorithm remove the second duplicate of a consecutive pair of equal elements.  
  
 The operation of the algorithm is stable so that the relative order of the undeleted elements is not changed.  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation. he number of elements in the sequence is not changed by the algorithm **unique** and the elements beyond the end of the modified sequence are dereferenceable but not specified.  
  
 The complexity is linear, requiring (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) – 1 comparisons.  
  
 List provides a more efficient member function [unique](../vs140/list--unique.md), which may perform better.  
  
 These algorithms cannot be used on an associative container.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Vector v1 is ( 5 -5 5 -5 5 -5 5 -5 4 4 4 4 7 ).**  
**Removing adjacent duplicates from vector v1 gives**  
 **( 5 -5 5 -5 5 -5 5 -5 4 7 ).**  
**Removing adjacent duplicates from vector v1 under the**  
 **binary predicate mod_equal gives**  
 **( 5 4 7 ).**  
**Removing adjacent elements satisfying the binary**  
 **predicate mod_equal from vector v1 gives ( 5 7 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)