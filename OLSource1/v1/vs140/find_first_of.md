---
title: "find_first_of"
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
  - "algorithm/std::find_first_of"
  - "find_first_of"
  - "std::find_first_of"
  - "xstring/std::basic_string::find_first_of"
  - "std.basic_string.find_first_of"
  - "basic_string::find_first_of"
  - "std.find_first_of"
  - "std::basic_string::find_first_of"
  - "basic_string.find_first_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_first_of method"
  - "find_first_of function"
  - "find_first_of function, about find_first_of"
  - "find_first_of"
ms.assetid: e00a4ca9-6d56-446e-9174-14ffdbc87079
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# find_first_of
Searches for the first occurrence of any of several values within a target range or for the first occurrence of any of several elements that are equivalent in a sense specified by a binary predicate to a specified set of the elements.  
  
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
  
 The ranges referenced must be valid; all pointers must be dereferenceable and, within each sequence, the last position is reachable from the first by incrementation.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Vector v1 = ( 0 5 10 15 20 25 0 5 10 15 20 25 )**  
**List L1 = ( 15 20 )**  
**Vector v2 = ( 20 30 40 )**  
**There is at least one match of L1 in v1**  
 **and the first one begins at position 3.**  
**There is a sequence of elements in v1 that are equivalent**  
 **to those in v2 under the binary predicate twice**  
 **and the first one begins at position 2.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)