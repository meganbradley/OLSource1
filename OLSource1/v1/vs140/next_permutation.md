---
title: "next_permutation"
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
  - "std.next_permutation"
  - "algorithm/std::next_permutation"
  - "next_permutation"
  - "std::next_permutation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "next_permutation function"
  - "next_permutation"
ms.assetid: d412620b-73f7-4bdd-9ee6-e581504e9859
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# next_permutation
Reorders the elements in a range so that the original ordering is replaced by the lexicographically next greater permutation if it exists, where the sense of next may be specified with a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position of the first element in the range to be permuted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position one past the final element in the range to be permuted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 **true** if the lexicographically next permutation exists and has replaced the original ordering of the range; otherwise **false**, in which case the ordering is transformed into the lexicographically smallest permutation.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The default binary predicate is less than and the elements in the range must be less than comparable to insure that the next permutation is well defined.  
  
 The complexity is linear with at most (*_Last – _First*)/2 swaps.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original deque of CInts is deq1 = ( CInt( 5 ), CInt( 1 ), CInt( 10 ) ).**  
**The lexicographically next permutation exists and has**  
**replaced the original ordering of the sequence in deq1.**  
**After one application of next_permutation,**  
 **deq1 = ( CInt( 5 ), CInt( 10 ), CInt( 1 ) ).**  
**Vector v1 is ( -3 -2 -1 0 1 2 3 ).**  
**After the first next_permutation, vector v1 is:**  
 **v1 = ( -3 -2 -1 0 1 3 2 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 2 1 3 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 2 3 1 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 3 1 2 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 0 3 2 1 ).**  
**After another next_permutation of vector v1,**  
 **v1 =   ( -3 -2 -1 1 0 2 3 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [next_permutation](../vs140/next_permutation--stl-samples-.md)   
 [Predicate Version of next_permutation](../vs140/predicate-version-of-next_permutation.md)   
 [Standard Template Library](../vs140/standard-template-library.md)