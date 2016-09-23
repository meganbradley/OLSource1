---
title: "none_of"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - algorithm/std::none_of
  - std.none_of
  - std::none_of
  - none_of
dev_langs: 
  - C++
helpviewer_keywords: 
  - none_of function
  - none_of
ms.assetid: 1308303a-4ccc-44d9-aeb5-6c703cccf40e
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# none_of
Returns `true` when a condition is never present among elements in the given range.  
  
## Syntax  
  
```  
  
  template<class InputIterator, class BinaryPredicate>  
bool none_of(  
    InputIterator _First,   
    InputIterator _Last,   
    BinaryPredicate _Comp  
);  
```  
  
#### Parameters  
 `_First`  
 An input iterator that indicates where to start to check a range of elements for a condition.  
  
 `_Last`  
 An input iterator that indicates the end of a range of elements.  
  
 `_Comp`  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition. A predicate takes a single argument and returns `true` or `false`.  
  
## Return Value  
 Returns `true` if the condition is not detected at least once in the indicated range, and `false` if the condition is detected.  
  
## Remarks  
 The template function returns `true` only if, for some `N` in the range `[0,` `_Last` `-` `_First``)`, the predicate `_Comp``(*(``_First` `+ N))` is always `false`.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [any_of](../vs140/any_of.md)   
 [all_of](../vs140/all_of.md)   
 [Standard Template Library](../vs140/standard-template-library.md)