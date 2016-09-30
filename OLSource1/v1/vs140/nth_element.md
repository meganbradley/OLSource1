---
title: "nth_element"
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
  - "algorithm/std::nth_element"
  - "std.nth_element"
  - "nth_element"
  - "std::nth_element"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nth_element function"
  - "nth_element"
ms.assetid: eda88e94-8840-4568-a83b-d03deeda9cf6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nth_element
Partitions a range of elements, correctly locating the *n*th element of the sequence in the range so that all the elements in front of it are less than or equal to it and all the elements that follow it in the sequence are greater than or equal to it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be partitioned.  
  
 *_Nth*  
 A random-access iterator addressing the position of element to be correctly ordered on the boundary of the partition.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be partitioned.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> algorithm does not guarantee that elements in the sub-ranges either side of the *n*th element are sorted. It thus makes fewer guarantees than <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which orders the elements in the range below some chosen element, and may be used as a faster alternative to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when the ordering of the lower range is not required.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other.  
  
 The average of a sort complexity is linear with respect to *_Last – _First*.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [nth_element](../vs140/nth_element--stl-samples-.md)   
 [Predicate Version of nth_element](../vs140/predicate-version-of-nth_element.md)   
 [Standard Template Library](../vs140/standard-template-library.md)