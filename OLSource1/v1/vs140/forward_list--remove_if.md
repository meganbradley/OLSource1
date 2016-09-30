---
title: "forward_list::remove_if"
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
  - "forward_list::remove_if"
  - "remove_if"
  - "std::forward_list::remove_if"
  - "forward_list.remove_if"
  - "forward_list/std::forward_list::remove_if"
  - "std.forward_list.remove_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_if method"
ms.assetid: 10b54d3f-c86b-4a96-babe-6590fc676690
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::remove_if
Erases elements from a forward list for which a specified predicate is satisfied.  
  
## Syntax  
  
```  
template<class Predicate>  
    void remove_if(Predicate _Pred);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Pred`|The unary predicate which, if satisfied by an element, results in the deletion of that element from the list.|  
  
## Remarks  
 The member function removes from the controlled sequence all elements, designated by the iterator `P`, for which `_Pred(*P)` is true.  
  
 An exception occurs only if `_Pred` throws an exception. In that case, the controlled sequence is left in an unspecified state and the exception is rethrown.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)