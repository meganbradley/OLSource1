---
title: "push_heap"
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
  - "std.push_heap"
  - "push_heap"
  - "algorithm/std::push_heap"
  - "std::push_heap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_heap"
  - "push_heap function"
ms.assetid: 451cfdac-1021-42f9-abdd-ea2e35ceb8ba
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# push_heap
Adds an element that is at the end of a range to an existing heap consisting of the prior elements in the range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the heap.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be converted into a heap.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 The element must first be pushed back to the end of an existing heap and then the algorithm is used to add this element to the existing heap.  
  
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