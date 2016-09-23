---
title: "any_of"
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
  - any_of
  - algorithm/std::any_of
  - std.any_of
  - std::any_of
dev_langs: 
  - C++
helpviewer_keywords: 
  - any_of function
  - any_of
ms.assetid: c0a685f6-8242-42c6-b1bc-3956d25ae535
caps.latest.revision: 17
translation.priority.mt: 
  - de-de
  - ja-jp
---
# any_of
Returns `true` when a condition is present at least once in the specified range of elements.  
  
## Syntax  
  
```  
template<class InputIterator, class UnaryPredicate>  
    bool any_of(  
        InputIterator _First,   
        InputIterator _Last,   
        UnaryPredicate _Comp  
    );  
```  
  
#### Parameters  
 `_First`  
 An input iterator that indicates where to start checking a range of elements for a condition.  
  
 `_Last`  
 An input iterator that indicates the end of the range of elements to check for a condition.  
  
 `_Comp`  
 A condition to test for. This is provided by a user-defined predicate function object. The predicate defines the condition to be satisfied by the element being tested. A predicate takes a single argument and returns `true` or `false`.  
  
## Return Value  
 Returns `true` if the condition is detected at least once in the indicated range, `false` if the condition is never detected.  
  
## Remarks  
 The template function returns `true` only if, for some `N` in the range  
  
 `[0,`  `_Last`  `-`  `_First` `)`, the predicate `_Comp``(*(``_First` `+ N))` is true.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [none_of](../vs140/none_of.md)   
 [all_of](../vs140/all_of.md)   
 [Standard Template Library](../vs140/standard-template-library.md)