---
title: "find_end"
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
  - "std::find_end"
  - "find_end"
  - "std.find_end"
  - "algorithm/std::find_end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_end function"
  - "find_end"
ms.assetid: 831c0501-75d0-4ed8-9519-9b8c1dfef98a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# find_end
Looks in a range for the last subsequence that is identical to a specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the last element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to search for.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the last element in the range to search for.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator addressing the position of the first element of the last subsequence within [First1, Last1) that matches the specified sequence [First2, Last2).  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position is reachable from the first by incrementation.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Vector v1 = ( 0 5 10 15 20 25 0 5 10 15 20 25 )**  
**List L1 = ( 5 10 15 20 )**  
**Vector v2 = ( 20 30 40 )**  
**There is a match of L1 in v1 that begins at position 7.**  
**There is a sequence of elements in v1 that are equivalent to those**  
 **in v2 under the binary predicate twice and that begins at position 8.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)