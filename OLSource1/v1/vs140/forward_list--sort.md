---
title: "forward_list::sort"
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
  - "forward_list::sort"
  - "std.forward_list.sort"
  - "forward_list.sort"
  - "forward_list/std::forward_list::sort"
  - "sort"
  - "std::forward_list::sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sort method"
ms.assetid: 4fc4a8ab-4cdd-4d03-891a-e28cf1050aa9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::sort
Arranges the elements in ascending order or with an order specified by a predicate.  
  
## Syntax  
  
```  
void sort();  
template<class Predicate>  
    void sort(Predicate _Pred);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Pred`|The ordering predicate.|  
  
## Remarks  
 Both member functions order the elements in the controlled sequence by a predicate, described below.  
  
 For the iterators `Pi` and `Pj` designating elements at positions `i` and `j`, the first member function imposes the order `!(*Pj < *Pi)` whenever `i < j`. (The elements are sorted in `ascending` order.) The member template function imposes the order `!_Pred(*Pj, *Pi)` whenever `i < j`. No ordered pairs of elements in the original controlled sequence are reversed in the resulting controlled sequence. (The sort is stable.)  
  
 An exception occurs only if `_Pred` throws an exception. In that case, the controlled sequence is left in unspecified order and the exception is rethrown.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)