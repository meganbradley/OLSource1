---
title: "for_each"
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
  - "for_each"
  - "algorithm/std::for_each"
  - "std::for_each"
  - "std.for_each"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "for_each function"
  - "for_each"
ms.assetid: 8cb2ae72-bef6-488b-b011-0475c0787e33
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# for_each
Applies a specified function object to each element in a forward order within a range and returns the function object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be operated on.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range operated on.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-defined function object that is applied to each element in the range.  
  
## Return Value  
 A copy of the function object after it has been applied to all of the elements in the range.  
  
## Remarks  
 The algorithm <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is very flexible, allowing the modification of each element within a range in different, user-specified ways. Templatized functions may be reused in a modified form by passing different parameters. User-defined functions may accumulate information within an internal state that the algorithm may return after processing all of the elements in the range.  
  
 The range referenced must be valid; all pointers must be dereferenceable and, within the sequence, the last position must be reachable from the first by incrementation.  
  
 The complexity is linear with at most (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) comparisons.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Original vector  v1 = ( -4 -3 -2 -1 0 1 2 ).**  
**Multiplying the elements of the vector v1**  
 **by the factor -2 gives:**  
 **v1mod1 = ( 8 6 4 2 0 -2 -4 ).**  
**Multiplying the elements of the vector v1mod**  
 **by the factor 5 gives:**  
 **v1mod2 = ( 40 30 20 10 0 -10 -20 ).**  
**The average of the elements of v1 is:**  
 **Average ( v1mod2 ) = 10.**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [for_each](../vs140/for_each--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)