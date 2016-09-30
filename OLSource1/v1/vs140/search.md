---
title: "search"
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
  - "search"
  - "algorithm/std::search"
  - "std.search"
  - "std::search"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "search function"
  - "searches"
ms.assetid: fe692c77-c55e-4f4c-b6da-9fe456fff540
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# search
Searches for the first occurrence of a sequence within a target range whose elements are equal to those in a given sequence of elements or whose elements are equivalent in a sense specified by a binary predicate to the elements in the given sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be matched.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be matched.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator addressing the position of the first element of the first subsequence that matches the specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation.  
  
 Average complexity is linear with respect to the size of the searched range, and worst case complexity is also linear with respect to the size of the sequence being searched for.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Vector v1 = ( 0 5 10 15 20 25 0 5 10 15 20 25 )**  
**List L1 = ( 20 25 )**  
**Vector v2 = ( 20 30 40 )**  
**There is at least one match of L1 in v1**  
 **and the first one begins at position 4.**  
**There is a sequence of elements in v1 that are equivalent**  
 **to those in v2 under the binary predicate twice**  
 **and the first one begins at position 2.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)