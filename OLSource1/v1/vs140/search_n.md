---
title: "search_n"
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
  - "std.search_n"
  - "search_n"
  - "std::search_n"
  - "algorithm/std::search_n"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "search_n"
  - "search_n function"
ms.assetid: 8daa0c12-bac4-4cef-9213-45ef9a8d86af
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# search_n
Searches for the first subsequence in a range that of a specified number of elements having a particular value or a relation to that value as specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of the subsequence being searched for.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value of the elements in the sequence being searched for.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator addressing the position of the first element of the first subsequence that matches the specified sequence or that is equivalent in a sense specified by a binary predicate.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Complexity is linear with respect to the size of the searched.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Vector v1 = ( 0 5 10 15 20 25 5 5 5 0 5 10 15 20 25 10 10 10 )**  
**There is at least one match of a sequence ( 5 5 5 )**  
 **in v1 and the first one begins at position 6.**  
**There is a match of a sequence ( 5 5 5 ) under the equivalence**  
 **predicate one_half in v1 and the first one begins at position 15.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)