---
title: "transform"
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
  - "locale/std::collate::transform"
  - "std::collate::transform"
  - "collate.transform"
  - "std::transform"
  - "transform"
  - "std.collate.transform"
  - "collate::transform"
  - "algorithm/std::transform"
  - "std.transform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transform function"
  - "transform"
  - "transform method"
ms.assetid: 99396865-54fb-47dd-a661-38ce03467854
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# transform
Applies a specified function object to each element in a source range or to a pair of elements from two source ranges and copies the return values of the function object into a destination range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first source range to be operated on.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the first source range operated on.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second source range to be operated on.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined unary function object used in the first version of the algorithm that is applied to each element in the first source range or A user-defined (UD) binary function object used in the second version of the algorithm that is applied pairwise, in a forward order, to the two source ranges.  
  
## Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the output elements transformed by the function object.  
  
## Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation. The destination range must be large enough to contain the transformed source range.  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set equal to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the first version of the algorithm*,* then the source and destination ranges will be the same and the sequence will be modified in place. But the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> may not address a position within the range [<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> +1, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>).  
  
 The complexity is linear with at most (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) comparisons.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Original vector  v1 = ( -4 -3 -2 -1 0 1 2 ).**  
**The elements of the vector v1 multiplied by 2 in place gives:**  
 **v1mod = ( -8 -6 -4 -2 0 2 4 ).**  
**Multiplying the elements of the vector v1mod**  
 **by the factor 5 & copying to v2 gives:**  
 **v2 = ( -40 -30 -20 -10 0 10 20 ).**  
**Multiplying elements of the vectors v1mod and v2 pairwise gives:**  
 **v3 = ( 320 180 80 20 0 20 80 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)