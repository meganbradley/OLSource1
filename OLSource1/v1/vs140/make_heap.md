---
title: "make_heap"
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
  - "algorithm/std::make_heap"
  - "std::make_heap"
  - "make_heap"
  - "std.make_heap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_heap function"
  - "make_heap"
ms.assetid: b09f795c-f368-4aa8-b57e-61ee6100ddc2
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# make_heap
Converts elements from a specified range into a heap in which the first element is the largest and for which a sorting criterion may be specified with a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be converted into a heap.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be converted into a heap.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The complexity is linear, requiring 3 \* (*_Last – _First*) comparisons.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [heap](../vs140/heap.md)   
 [Standard Template Library](../vs140/standard-template-library.md)