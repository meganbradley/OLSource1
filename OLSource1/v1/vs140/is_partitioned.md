---
title: "is_partitioned"
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
  - "std::is_partitioned"
  - "algorithm/std::is_partitioned"
  - "std.is_partitioned"
  - "is_partitioned"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_partitioned function"
  - "is_partitioned"
ms.assetid: a5f91d88-6f31-44e5-afe4-3fdedb18f4b2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_partitioned
Returns `true` if all the elements in the given range that test `true` for a condition come before any elements that test `false`.  
  
## Syntax  
  
```  
template<class InputIterator, class BinaryPredicate>  
    bool is_partitioned(  
        InputIterator _First,   
        InputIterator _Last,  
        BinaryPredicate _Comp  
    );  
```  
  
#### Parameters  
 `_First`  
 An input iterator that indicates where a range starts to check for a condition.  
  
 `_Last`  
 An input iterator that indicates the end of a range.  
  
 `_Comp`  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be satisfied by the element being searched for. A predicate takes a single argument and returns `true`or `false`.  
  
## Return Value  
 Returns true when all of the elements in the given range that test `true` for a condition come before any elements that test `false`, and otherwise returns `false`.  
  
## Remarks  
 The template function returns `true` only if all elements in `[``_First``,` `_Last``)` are partitioned by `_Comp`; that is, all elements `X` in `[``_First``,` `_Last``)` for which `_Comp``(X)` is true occur before all elements `Y` for which `_Comp``(Y)` is `false`.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [is_sorted](../vs140/is_sorted.md)   
 [is_sorted_until](../vs140/is_sorted_until.md)   
 [partition_point](../vs140/partition_point.md)   
 [partition_copy](../vs140/partition_copy.md)   
 [<algorithm\>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)