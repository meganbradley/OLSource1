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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_heap_until
Returns an iterator positioned at the first element in the range [`begin`, `end`) that does not satisfy the heap ordering condition, or `end` if the range forms a heap.  
  
## Syntax  
  
```  
template<class RandomAccessIterator>  
    RandomAccessIterator is_heap_until(  
        RandomAccessIterator begin,   
        RandomAccessIterator end  
    );  
template<class RandomAccessIterator, class BinaryPredicate>   
    RandomAccessIterator is_heap_until(  
        RandomAccessIterator begin,   
        RandomAccessIterator end,   
        BinaryPredicate compare  
    );  
```  
  
#### Parameters  
 `begin`  
 A random access iterator that specifies the first element of a range to check for a heap.  
  
 `end`  
 A random access iterator that specifies the end of the range to check for a heap.  
  
 `compare`  
 A binary predicate that specifies the strict weak ordering condition that defines a heap. The default predicate when `compare` is not specified is `std::less<>`.  
  
## Return Value  
 Returns `end` if the specified range forms a heap or contains one or fewer elements. Otherwise, returns an iterator for the first element found that does not satisfy the heap condition.  
  
## Remarks  
 The first template function returns the last iterator `next` in `[``begin``,` `end``]` where `[``begin``, next)` is a heap ordered by the function object `std::less<>`. If the distance `end` `-` `begin` `< 2`, the function returns `end`.  
  
 The second template function behaves the same as the first, except that it uses the predicate `compare` instead of `std::less<>` as the heap ordering condition.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Is_heap](../vs140/is_heap.md)   
 [less Struct](../vs140/less-struct.md)   
 [<algorithm\>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)