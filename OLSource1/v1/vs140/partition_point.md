---
title: "partition_point"
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
  - "partition_point"
  - "algorithm/std::partition_point"
  - "std.partition_point"
  - "std::partition_point"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partition_point function"
  - "partition_point"
ms.assetid: 38751968-b720-429d-aca0-865f34ffad11
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partition_point
Returns the first element in the given range that does not satisfy the condition. The elements are sorted so that those that satisfy the condition come before those that do not.  
  
## Syntax  
  
```  
template<class ForwardIterator, class Predicate>  
    ForwardIterator partition_point(  
        ForwardIterator _First,   
        ForwardIterator _Last,  
        Predicate _Comp  
    );  
```  
  
#### Parameters  
 `_First`  
 A `ForwardIterator` that indicates the start of a range to check for a condition.  
  
 `_Last`  
 A `ForwardIterator` that indicates the end of a range.  
  
 `_Comp`  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be satisfied by the element being searched for. A predicate takes a single argument and returns `true` or `false`.  
  
## Return Value  
 Returns a `ForwardIterator` that refers to the first element that does not fulfill the condition tested for by `_Comp`, or returns `_Last` if one is not found.  
  
## Remarks  
 The template function finds the first iterator `it` in `[``_First``,``_Last``)` for which `_Comp(*it)` is `false`. The sequence must be ordered by `_Comp`.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)