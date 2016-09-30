---
title: "prev_permutation"
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
  - "std.prev_permutation"
  - "std::prev_permutation"
  - "algorithm/std::prev_permutation"
  - "prev_permutation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "prev_permutation"
  - "prev_permutation function"
ms.assetid: c467e0f9-931d-4028-b835-fbbf51158d97
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# prev_permutation
Reorders the elements in a range so that the original ordering is replaced by the lexicographically previous greater permutation if it exists, where the sense of previous may be specified with a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position of the first element in the range to be permuted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position one past the final element in the range to be permuted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when satisfied and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when not satisfied.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the lexicographically previous permutation exists and has replaced the original ordering of the range; otherwise <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, in which case the ordering is transformed into the lexicographically largest permutation.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The default binary predicate is less than and the elements in the range must be less-than comparable to ensure that the previous permutation is well defined.  
  
 The complexity is linear, with at most ( <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>)/2 swaps.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original deque of CInts is deq1 = ( CInt( 1 ), CInt( 5 ), CInt( 10 ) ).**  
**The lexicographically previous permutation doesn't exist**  
 **and the lexicographically smallest permutation**  
 **has replaced the original ordering of the sequence in deq1.**  
**After one application of prev_permutation,**  
 **deq1 = ( CInt( 10 ), CInt( 5 ), CInt( 1 ) ).**  
**Vector v1 is ( -3 -2 -1 0 1 2 3 ).**  
**After the first prev_permutation, vector v1 is:**  
 **v1 = ( -3 -2 0 3 2 1 -1 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 3 -1 2 1 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 3 -1 1 2 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 2 3 1 -1 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 2 -1 3 1 ).**  
**After another prev_permutation of vector v1,**  
 **v1 =   ( -3 -2 0 2 -1 1 3 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [prev_permutation](../vs140/prev_permutation--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)