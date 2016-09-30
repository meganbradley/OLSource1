---
title: "mismatch"
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
  - "std::mismatch"
  - "std.mismatch"
  - "mismatch"
  - "xutility/std::mismatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mismatch"
  - "mismatch function"
ms.assetid: a9fe78f3-9a86-44dc-9400-0c2ed1083323
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mismatch
Compares two ranges element by element and locates the first position where a difference occurs.  
  
 Use the dual-range overloads in C++14 code because the overloads that only take a single iterator for the second range will not detect differences if the second range is longer than the first range, and will result in undefined behavior if the second range is shorter than the first range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first range to be tested.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first range to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second range to be tested.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator addressing the position of one past the last element in the second range to be tested.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that compares the current elements in each range and determines whether they are equivalent. It returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A pair of iterators addressing the positions of the mismatch in the two ranges, the first component iterator to the position in the first range and the second component iterator to the position in the second range. If there is no difference between the elements in the ranges compared or if the binary predicate in the second version is satisfied by all element pairs from the two ranges, then the first component iterator points to the position one past the final element in the first range and the second component iterator to position one past the final element tested in the second range.  
  
## Remarks  
 The first template function assumes that there are as many elements in the range beginning at first2 as there are in the range designated by [first1, last1). If there are more in the second range, they are ignored; if there are less then undefined behavior will result.  
  
 The range to be searched must be valid; all iterators must be dereferenceable and the last position is reachable from the first by incrementation.  
  
 The time complexity of the algorithm is linear in the number of elements contained in the shorter range.  
  
 The user-defined predicate is not required to impose an equivalence relation that symmetric, reflexive and transitive between its operands.  
  
## Example  
 The following example demonstrates how to use mismatch. The C++03 overload is shown only in order to demonstrate how it can produce an unexpected result.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)