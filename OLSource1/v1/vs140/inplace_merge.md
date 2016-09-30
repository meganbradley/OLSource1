---
title: "inplace_merge"
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
  - "inplace_merge"
  - "algorithm/std::inplace_merge"
  - "std.inplace_merge"
  - "std::inplace_merge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inplace_merge function"
  - "inplace_merge"
ms.assetid: a3a7d861-2b47-4b0c-a2ac-df805c813437
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# inplace_merge
Combines the elements from two consecutive sorted ranges into a single sorted range, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the first of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the second of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position one past the last element in the second of two consecutive sorted ranges to be combined and sorted into a single range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
## Remarks  
 The sorted consecutive ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted consecutive ranges must each be arranged as a precondition to the application of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges. The operation is stable as the relative order of elements within each range is preserved. When there are equivalent elements in both source ranges, the element is the first range precedes the element from the second in the combined range.  
  
 The complexity depends on the available memory as the algorithm allocates memory to a temporary buffer. If sufficient memory is available, the best case is linear with (*_Last – _First*) – 1 comparisons; if no auxiliary memory is available, the worst case is *N* log*(N)*, where *N* = (*_Last – _First*).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Original vector v1 with subranges sorted by the**  
 **binary predicate less than is  v1 = ( 0 1 2 3 4 5 -5 -4 -3 -2 -1 0 )**  
**Original vector v2 with subranges sorted by the**  
 **binary predicate greater is v2 = ( 5 4 3 2 1 0 0 -1 -2 -3 -4 -5 )**  
**Original vector v3 with subranges sorted by the**  
 **binary predicate mod_lesser is v3 = ( 0 1 2 3 4 5 0 -1 -2 -3 -4 -5 )**  
**Merged inplace with default order,**  
 **vector v1mod = ( -5 -4 -3 -2 -1 0 0 1 2 3 4 5 )**  
**Merged inplace with binary predicate greater specified,**  
 **vector v2mod = ( 5 4 3 2 1 0 0 -1 -2 -3 -4 -5 )**  
**Merged inplace with binary predicate mod_lesser specified,**  
 **vector v3mod = ( 0 0 1 -1 2 -2 3 -3 4 -4 5 -5 )**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [inplace_merge](../vs140/inplace_merge--stl-samples-.md)   
 [Predicate Version of inplace_merge](../vs140/predicate-version-of-inplace_merge.md)   
 [Standard Template Library](../vs140/standard-template-library.md)