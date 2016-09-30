---
title: "partial_sort"
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
  - "std.partial_sort"
  - "partial_sort"
  - "std::partial_sort"
  - "algorithm/std::partial_sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partial_sort"
  - "partial_sort function"
ms.assetid: 327453e4-16c0-423c-bc1a-abea8ca63157
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partial_sort
Arranges a specified number of the smaller elements in a range into a nondescending order or according to an ordering criterion specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the subrange to be sorted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be partially sorted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other. The **sort** algorithm is not stable and does not guarantee that the relative ordering of equivalent elements will be preserved. The algorithm <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does preserve this original ordering.  
  
 The average partial sort complexity is *O*((<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>-<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) log (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>-<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>)).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Original vector:**  
 **v1 = ( 0 2 4 6 8 10 1 3 5 7 9 11 )**  
**Partially sorted vector:**  
 **v1 = ( 0 1 2 3 4 5 10 8 6 7 9 11 )**  
**Partially resorted (greater) vector:**  
 **v1 = ( 11 10 9 8 0 1 2 3 4 5 6 7 )**  
**Partially resorted (UDgreater) vector:**  
 **v1 = ( 11 10 9 8 7 6 5 4 0 1 2 3 )**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [partial_sort](../vs140/partial_sort--stl-samples-.md)   
 [Predicate Version of partial_sort](../vs140/predicate-version-of-partial_sort.md)   
 [Standard Template Library](../vs140/standard-template-library.md)