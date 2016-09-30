---
title: "remove_if"
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
  - "remove_if"
  - "std.remove_if"
  - "algorithm/std::remove_if"
  - "std::remove_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_if function"
  - "remove_if"
ms.assetid: 3b784953-0db6-42a8-84fc-865101abf901
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# remove_if
Eliminates elements that satisfy a predicate from a given range without disturbing the order of the remaining elements and returning the end of a new range free of the specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position of the first element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position one past the final element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
## Return Value  
 A forward iterator addressing the new end position of the modified range, one past the final element of the remnant sequence free of the specified value.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not removed remains stable.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) comparisons for equality.  
  
 List has a more efficient member function version of remove which relinks pointers.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [remove_if](../vs140/remove_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)