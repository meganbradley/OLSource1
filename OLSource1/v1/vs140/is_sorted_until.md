---
title: "is_sorted_until"
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
  - "is_sorted_until"
  - "std::is_sorted_until"
  - "std.is_sorted_until"
  - "algorithm/std::is_sorted_until"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_sorted_until function"
  - "is_sorted_until"
ms.assetid: 45a79ce4-fbd9-47d1-bcf1-44498ae26de7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_sorted_until
Returns a `ForwardIterator` that is set to the last element that is in sorted order from a specified range.  
  
 The second version lets you provide a `BinaryPredicate` function that returns `true` when two given elements are in sorted order, and `false` otherwise.  
  
## Syntax  
  
```  
template<class ForwardIterator>  
    ForwardIterator is_sorted_until(  
        ForwardIterator _First,   
        ForwardIterator _Last  
    );  
template<class ForwardIterator, class BinaryPredicate>  
    ForwardIterator is_sorted_until(  
        ForwardIterator _First,   
        ForwardIterator _Last,   
        BinaryPredicate _Comp  
    );  
```  
  
#### Parameters  
 `_First`  
 A forward iterator that indicates where the range to check starts.  
  
 `_Last`  
 A forward iterator that indicates the end of a range.  
  
 `_Comp`  
 The condition to test to determine an order between two elements. A predicate takes a single argument and returns `true` or `false`.  
  
## Return Value  
 Returns a `ForwardIterator` set to the last element in sorted order. The sorted sequence starts from `_First`.  
  
## Remarks  
 The first template function returns the last iterator `next` in `[``_First``,` `_Last``]` so that `[``_First``, next)` is a sorted sequence ordered by `operator<`. If `distance()` `< 2` the function returns `_Last`.  
  
 The second template function behaves the same, except that it replaces `operator<(X, Y)` with `_Comp``(X, Y)`.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [is_sorted](../vs140/is_sorted.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)