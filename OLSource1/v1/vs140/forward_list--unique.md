---
title: "forward_list::unique"
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
  - "forward_list.unique"
  - "std::forward_list::unique"
  - "std.forward_list.unique"
  - "forward_list::unique"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique method"
ms.assetid: dee8098e-7320-42e4-938f-50b83d755f77
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::unique
Eliminates all but the first element from every consecutive group of equal elements.  
  
## Syntax  
  
```  
void unique();  
template<class BinaryPredicate>  
    void unique(BinaryPredicate _Comp);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Comp`|The binary predicate used to compare successive elements.|  
  
## Remarks  
 Keeps the first of each unique element, and removes the rest. The elements must be sorted so that elements of equal value are adjacent in the list.  
  
 The first member function removes from the controlled sequence every element that compares equal to its preceding element. For the iterators `Pi` and `Pj` designating elements at positions `i` and `j`, the second member function removes every element for which `i + 1 == j && _Comp(*Pi, *Pj)`.  
  
 For a controlled sequence of length `N` (> 0), the predicate `_Comp(*Pi, *Pj)` is evaluated `N - 1` times.  
  
 An exception occurs only if `_Comp` throws an exception. In that case, the controlled sequence is left in an unspecified state and the exception is rethrown.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)