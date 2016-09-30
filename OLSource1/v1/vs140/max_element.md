---
title: "max_element"
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
  - "max_element"
  - "algorithm/std::max_element"
  - "std.max_element"
  - "std::max_element"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_element"
  - "max_element function"
ms.assetid: c25c9018-3a02-45a3-a234-f6576b90cd59
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_element
Finds the first occurrence of largest element in a specified range where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched for the largest element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched for the largest element.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
## Return Value  
 A forward iterator addressing the position of the first occurrence of the largest element in the range searched.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear: (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) – 1 comparisons are required for a nonempty range.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Nonpredicate Version of max_element](../vs140/nonpredicate-version-of-max_element.md)   
 [Predicate Version of max_element](../vs140/predicate-version-of-max_element.md)   
 [Standard Template Library](../vs140/standard-template-library.md)