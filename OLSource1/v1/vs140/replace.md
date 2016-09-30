---
title: "replace"
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
  - "replace"
  - "algorithm/std::replace"
  - "std::replace"
  - "std::basic_string::replace"
  - "basic_string::replace"
  - "xstring/std::basic_string::replace"
  - "std.basic_string.replace"
  - "std.replace"
  - "basic_string.replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace function"
  - "replace method"
  - "replace"
ms.assetid: 8324dd0c-f3f7-4035-9fbe-654010366149
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace
Examines each element in a range and replaces it if it matches a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The old value of the elements being replaced.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The new value being assigned to the elements with the old value.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) comparisons for equality and at most (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) assignments of new values.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [replace](../vs140/replace--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)