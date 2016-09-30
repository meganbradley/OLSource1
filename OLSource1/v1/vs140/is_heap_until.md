---
title: "is_heap_until"
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
  - "std::is_heap_until"
  - "is_heap_until"
  - "std.is_heap_until"
  - "algorithm/std::is_heap_until"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_heap_until function"
  - "is_heap_until"
ms.assetid: 0600f029-57c6-440f-ad43-e28f30392040
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_heap_until
Returns an iterator positioned at the first element in the range [<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) that does not satisfy the heap ordering condition, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the range forms a heap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A random access iterator that specifies the first element of a range to check for a heap.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A random access iterator that specifies the end of the range to check for a heap.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A binary predicate that specifies the strict weak ordering condition that defines a heap. The default predicate when <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not specified is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the specified range forms a heap or contains one or fewer elements. Otherwise, returns an iterator for the first element found that does not satisfy the heap condition.  
  
## Remarks  
 The first template function returns the last iterator <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a heap ordered by the function object <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If the distance <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the function returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The second template function behaves the same as the first, except that it uses the predicate <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> as the heap ordering condition.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Is_heap](../vs140/is_heap.md)   
 [less Struct](../vs140/less-struct.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)