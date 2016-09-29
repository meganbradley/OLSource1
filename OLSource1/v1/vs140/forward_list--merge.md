---
title: "forward_list::merge"
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
  - "merge"
  - "std.forward_list.merge"
  - "forward_list/std::forward_list::merge"
  - "forward_list::merge"
  - "forward_list.merge"
  - "std::forward_list::merge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "merge method"
ms.assetid: 23f97869-c9fa-41d6-bf86-46fb2acd88ea
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::merge
Combines two sorted sequences into a single sorted sequence in linear time. Removes the elements from the argument list, and inserts them into this `forward_list`. The two lists should be sorted by the same compare function object before the call to `merge`. The combined list will be sorted by that compare function object.  
  
## Syntax  
  
```  
void merge(forward_list& _Right);  
template<class Predicate>  
    void merge(forward_list& _Right, Predicate _Comp);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Right`|The forward list to merge from.|  
|`_Comp`|The compare function object that is used to sort elements.|  
  
## Remarks  
 `forward_list::merge` removes the elements from the `forward_list``_Right``,` and inserts them into this `forward_list`. Both sequences must be ordered by the same predicate, described below. The combined sequence is also ordered by that compare function object.  
  
 For the iterators `Pi` and `Pj` designating elements at positions `i` and `j`, the first member function imposes the order `!(*Pj < *Pi)` whenever `i < j`. (The elements are sorted in `ascending` order.) The second member function imposes the order `!_Comp(*Pj, *Pi)` whenever `i < j`.  
  
 No pairs of elements in the original controlled sequence are reversed in the resulting controlled sequence. If a pair of elements in the resulting controlled sequence compares equal (`!(*Pi < *Pj) && !(*Pj < *Pi)`), an element from the original controlled sequence appears before an element from the sequence controlled by `_Right`.  
  
 An exception occurs only if `_Comp` throws an exception. In that case, the controlled sequence is left in unspecified order and the exception is rethrown.  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)