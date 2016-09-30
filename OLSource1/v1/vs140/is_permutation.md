---
title: "is_permutation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 3384e786-e210-4648-b2bc-3896b5e14f1f
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_permutation
Returns true if both ranges contain the same elements, whether or not the elements are in the same order. Use the dual-range overloads in C++14 code because the overloads that only take a single iterator for the second range will not detect differences if the second range is longer than the first range, and will result in undefined behavior if the second range is shorter than the first range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator that refers to the first element of the range.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator that refers one past the last element of the range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator that refers to the first element of a second range, used for comparison.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A forward iterator that refers to one past the last element of a second range, used for comparison.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A predicate that tests for equivalence and returns a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when the ranges can be rearranged so as to be identical according to the comparator predicate; otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> has quadratic complexity in the worst case.  
  
 The first template function assumes that there are as many elements in the range beginning at <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as there are in the range designated by [<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). If there are more elements in the second range, they are ignored; if there are less, undefined behavior will occur. The third template function (C++14 and later) does not make this assumption.  Both return <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> only if, for each element X in the range designated by [<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) there are as many elements Y in the same range for which X == Y as there are in the range beginning at <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or [<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> Here, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> must perform a pairwise comparison between its operands.  
  
 The second and fourth template functions behave the same, except that they replace <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. To behave correctly, the predicate must be symmetric, reflexive and transitive.  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)