---
title: "is_heap"
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
  - "std.is_heap"
  - "algorithm/std::is_heap"
  - "std::is_heap"
  - "is_heap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_heap function"
  - "is_heap"
ms.assetid: 47779f4a-8063-403e-a3d2-067062f34fb2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_heap
Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the elements in the specified range form a heap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A random access iterator that indicates the start of a range to check for a heap.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A random access iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A condition to test to order elements. A binary predicate takes a single argument and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the elements in the specified range form a heap, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if they do not.  
  
## Exceptions  
  
## Remarks  
 The first template function returns [is_heap_until](../vs140/is_heap_until.md)<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 The second template function returns  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [is_heap_until](../vs140/is_heap_until.md)   
 [\<algorithm>](../vs140/-algorithm-.md)