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
Returns `true` if the elements in the specified range form a heap.  
  
## Syntax  
  
```  
template<class RandomAccessIterator>  
    bool is_heap(  
        RandomAccessIterator _First,  
        RandomAccessIterator _Last  
    );  
template<class RandomAccessIterator, class BinaryPredicate>  
    bool is_heap(  
        RandomAccessIterator _First,  
        RandomAccessIterator _Last,  
        BinaryPredicate _Comp  
    );   
```  
  
#### Parameters  
 `_First`  
 A random access iterator that indicates the start of a range to check for a heap.  
  
 `_Last`  
 A random access iterator that indicates the end of a range.  
  
 `_Comp`  
 A condition to test to order elements. A binary predicate takes a single argument and returns `true`or `false`.  
  
## Return Value  
 Returns `true` if the elements in the specified range form a heap, `false` if they do not.  
  
## Exceptions  
  
## Remarks  
 The first template function returns [is_heap_until](../vs140/is_heap_until.md)`(``_First``,` `_Last``) ==` `_Last`.  
  
 The second template function returns  
  
 `is_heap_until` `(` `_First` `,`  `_Last` `,`  `_Comp` `) ==`  `_Last`.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [is_heap_until](../vs140/is_heap_until.md)   
 [<algorithm\>](../vs140/-algorithm-.md)