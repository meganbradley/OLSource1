---
title: "replace_if"
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
  - "algorithm/std::replace_if"
  - "std.replace_if"
  - "std::replace_if"
  - "replace_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace_if function"
  - "replace_if"
ms.assetid: 3d01105a-046d-42aa-9dc9-a6b1c53ec802
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace_if
Examines each element in a range and replaces it if it satisfies a specified predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The new value being assigned to the elements whose old value satisfies the predicate.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The algorithm <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a generalization of the algorithm **replace**, allowing any predicate to be specified, rather than equality to a specified constant value.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) comparisons for equality and at most (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) assignments of new values.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [replace_if](../vs140/replace_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)