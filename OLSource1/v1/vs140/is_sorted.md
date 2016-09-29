---
title: "is_sorted"
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
  - "std::is_sorted"
  - "std.is_sorted"
  - "is_sorted"
  - "algorithm/std::is_sorted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_sorted"
  - "is_sorted function"
ms.assetid: 18be444b-8943-4d55-8d82-a9f6d3e96aef
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_sorted
Returns `true` if the elements in the specified range are in sorted order.  
  
## Syntax  
  
```  
template<class ForwardIterator>  
    bool is_sorted(  
        ForwardIterator _First,   
        ForwardIterator _Last  
    );  
template<class ForwardIterator, class BinaryPredicate>  
    bool is_sorted(  
        ForwardIterator _First,   
        ForwardIterator _Last,   
        BinaryPredicate _Comp  
    );  
  
```  
  
#### Parameters  
 `_First`  
 A forward iterator that indicates where the range to check begins.  
  
 `_Last`  
 A forward iterator that indicates the end of a range.  
  
 `_Comp`  
 The condition to test to determine an order between two elements. A predicate takes a single argument and returns `true` or `false`. This performs the same task as `operator<`.  
  
## Property Value/Return Value  
 Returns `true` if the elements within the specified range are in sorted order, `false` if they're not.  
  
## Remarks  
 The first template function returns [is_sorted_until](assetId:///bbad99d0-deaa-4fe6-ae58-eb5b3e4dded0)`(``_First``,` `_Last``) ==` `_Last`. The operator< function performs the order comparison.  
  
 The second template function returns `is_sorted_until``(``_First``,` `_Last``,` `_Comp``) ==` `_Last`. The `_Comp` predicate function performs the order comparison.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [is_sorted_until](../vs140/is_sorted_until.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)