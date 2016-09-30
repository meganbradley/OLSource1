---
title: "min_element"
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
  - "min_element"
  - "std.min_element"
  - "algorithm/std::min_element"
  - "std::min_element"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "min_element function"
  - "min_element"
ms.assetid: 4cf188f9-59f6-4d2c-a1aa-a259c0b1ac6c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# min_element
Finds the first occurrence of smallest element in a specified range where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched for the smallest element.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched for the smallest element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
## Return Value  
 A forward iterator addressing the position of the first occurrence of the smallest element in the range searched.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear: (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) – 1 comparisons are required for a nonempty range.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **s1 = ( CInt( -3 ), CInt( 1 ), CInt( 2 ) ).**  
**The smallest element in s1 is: CInt( -3 )**  
**Vector v1 is ( 0 1 2 3 -2 -4 -6 -8 ).**  
**The smallest element in v1 is: -8**  
**The smallest element in v1 under the mod_lesser**  
 **binary predicate is: 0**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [min_element](../vs140/min_element--stl-samples-.md)   
 [Predicate Version of min_element](../vs140/predicate-version-of-min_element.md)   
 [Standard Template Library](../vs140/standard-template-library.md)