---
title: "partial_sort_copy"
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
  - "std.partial_sort_copy"
  - "algorithm/std::partial_sort_copy"
  - "std::partial_sort_copy"
  - "partial_sort_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partial_sort_copy function"
  - "partial_sort_copy"
ms.assetid: cf137213-7eb6-4109-a94b-3b3d572e19ce
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partial_sort_copy
Copies elements from a source range into a destination range where the source elements are ordered by either less than or another specified binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the source range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the source range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the sorted destination range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the sorted destination range.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when satisfied and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> when not satisfied.  
  
## Return Value  
 A random-access iterator addressing the element in the destination range one position beyond the last element inserted from the source range.  
  
## Remarks  
 The source and destination ranges must not overlap and must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The binary predicate must provide a strict weak ordering so that elements that are not equivalent are ordered, but elements that are equivalent are not. Two elements are equivalent under less than, but not necessarily equal, if neither is less than the other.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [partial_sort_copy](../vs140/partial_sort_copy--stl-samples-.md)   
 [Predicate Version of partial_sort_copy](../vs140/predicate-version-of-partial_sort_copy.md)   
 [Standard Template Library](../vs140/standard-template-library.md)