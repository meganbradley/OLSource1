---
title: "includes"
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
  - "Includes"
  - "std::includes"
  - "std.includes"
  - "algorithm/std::includes"
  - "includes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "includes"
  - "includes function"
ms.assetid: 7038e179-3813-46f3-9b6f-85d8214e9768
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# includes
Tests whether one sorted range contains all the elements contained in a second sorted range, where the ordering or equivalence criterion between elements may be specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be tested for whether all the elements of the second are contained in the first.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 **true** if the first sorted range contains all the elements in the second sorted range; otherwise, **false**.  
  
## Remarks  
 Another way to think of this test is that it determined whether the second source range is a subset of the first source range.  
  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the algorithm includes in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The source ranges are not modified by the algorithm **merge**.  
  
 The value types of the input iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. More precisely, the algorithm tests whether all the elements in the first sorted range under a specified binary predicate have equivalent ordering to those in the second sorted range.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (*_Last1 – _First1*) – (*_Last2 – _First2*) ) – 1 comparisons for nonempty source ranges.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Original vector v1a with range sorted by the**  
 **binary predicate less than is v1a = ( -2 -1 0 1 2 3 4 ).**  
**Original vector v1b with range sorted by the**  
 **binary predicate less than is v1b = ( -2 -1 0 1 2 3 ).**  
**Original vector v2a with range sorted by the**  
 **binary predicate greater is v2a = ( 4 3 2 1 0 -1 ).**  
**Original vector v2b with range sorted by the**  
 **binary predicate greater is v2b = ( 3 2 1 0 -1 -2 ).**  
**Original vector v3a with range sorted by the**  
 **binary predicate mod_lesser is v3a = ( 0 1 2 3 4 ).**  
**Original vector v3b with range sorted by the**  
 **binary predicate mod_lesser is v3b = ( 0 -1 1 -2 2 3 ).**  
**All the elements in vector v1b are contained in vector v1a.**  
**At least one of the elements in vector v2b is not contained in vector v2a.**  
**At least one of the elements in vector v3b is  not contained under mod_lesser in vector v3a.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [includes](../vs140/includes--stl-samples-.md)   
 [Predicate Version of includes](../vs140/predicate-version-of-includes.md)   
 [Standard Template Library](../vs140/standard-template-library.md)