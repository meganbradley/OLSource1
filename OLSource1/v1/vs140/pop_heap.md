---
title: "pop_heap"
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
  - "std.pop_heap"
  - "pop_heap"
  - "algorithm/std::pop_heap"
  - "std::pop_heap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop_heap function"
  - "pop_heap"
ms.assetid: 38f6eea3-d192-4597-aae7-c3ec2e659107
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pop_heap
Removes the largest element from the front of a heap to the next-to-last position in the range and then forms a new heap from the remaining elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the heap.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the heap.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> algorithm is the inverse of the operation performed by the [push_heap](../vs140/push_heap.md) algorithm, in which an element at the next-to-last position of a range is added to a heap consisting of the prior elements in the range, in the case when the element being added to the heap is larger than any of the elements already in the heap.  
  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The range excluding the newly added element at the end must be a heap.  
  
 The complexity is logarithmic, requiring at most log (*_Last – _First*) comparisons.  
  
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