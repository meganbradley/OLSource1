---
title: "lexicographical_compare"
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
  - "std.lexicographical_compare"
  - "std::lexicographical_compare"
  - "xutility/std::lexicographical_compare"
  - "lexicographical_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lexicographical_compare"
  - "lexicographical_compare function"
ms.assetid: 403f8526-50a4-4c1c-865e-391b1095fc32
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# lexicographical_compare
Compares element by element between two sequences to determine which is lesser of the two.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first range to be compared.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the first range to be compared.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second range to be compared.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the second range to be compared.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 **true** if the first range is lexicographically less than the second range; otherwise **false**.  
  
## Remarks  
 A lexicographical comparison between sequences compares them element by element until:  
  
-   It finds two corresponding elements unequal, and the result of their comparison is taken as the result of the comparison between sequences.  
  
-   No inequalities are found, but one sequence has more elements than the other, and the shorter sequence is considered less than the longer sequence.  
  
-   No inequalities are found and the sequences have the same number of elements, and so the sequences are equal and the result of the comparison is false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Vector v1 = ( 0 5 10 15 20 25 )**  
**List L1 = ( 0 5 10 15 20 25 30 )**  
**Vector v2 = ( 0 10 20 30 40 50 )**  
**Vector v1 is not lexicographically_less than v1.**  
**Vector v1 is lexicographically_less than L1.**  
**Vector v1 is not lexicographically_less than v2 under twice.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)