---
title: "partition_copy"
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
  - std::partition_copy
  - std.partition_copy
  - algorithm/std::partition_copy
  - partition_copy
dev_langs: 
  - C++
helpviewer_keywords: 
  - partition_copy function
  - partition_copy
ms.assetid: 7e34c266-ca8f-4d97-af04-fb4e651110e2
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# partition_copy
Copies elements for which a condition is `true` to one destination, and for which the condition is `false` to another. The elements must come from a specified range.  
  
## Syntax  
  
```  
template<class InputIterator, class OutputIterator1, class OutputIterator2, class Predicate>  
    pair<OutputIterator1, OutputIterator2>  
        partition_copy(  
            InputIterator _First,   
            InputIterator _Last,  
            OutputIterator1 _Dest1,   
            OutputIterator2 _Dest2,   
            Predicate _Pred  
        );  
```  
  
#### Parameters  
 `_First`  
 An input iterator that indicates the beginning of a range to check for a condition.  
  
 `_Last`  
 An input iterator that indicates the end of a range.  
  
 `_Dest1`  
 An output iterator used to copy elements that return true for a condition tested by using `_Pred`.  
  
 `_Dest2`  
 An output iterator used to copy elements that return false for a condition tested by using `_Pred`.  
  
 `_Pred`  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be tested. A predicate takes a single argument and returns `true` or `false`.  
  
## Property Value/Return Value  
 Returns a `pair` that contains two `OutputIterator` objects, one that contains elements that exhibit the condition, the other contains elements that do not.  
  
## Remarks  
 The template function copies each element `X` in `[``_First``,` `_Last``)` to `*``_Dest1``++` if `_Pred``(X)` is true, or to `*``_Dest2``++ if not`. It returns `pair<OutputIterator1, OutputIterator2>(``_Dest1``,` `_Dest2``)`.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [<algorithm\>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)