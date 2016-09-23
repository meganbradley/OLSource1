---
title: "forward_list::swap"
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
  - forward_list/std::forward_list::swap
  - std::forward_list::swap
  - std.forward_list.swap
  - forward_list.swap
  - forward_list::swap
  - swap
dev_langs: 
  - C++
helpviewer_keywords: 
  - swap method
ms.assetid: 9e984c47-d87e-4be4-a40d-5a4f809a3425
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# forward_list::swap
Exchanges the elements of two forward lists.  
  
## Syntax  
  
```  
void swap(forward_list& _Right);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Right`|The forward list providing the elements to be exchanged.|  
  
## Remarks  
 The member function swaps the controlled sequences between `*this` and `_Right`. If `get_allocator() == _Right.get_allocator()`, it does so in constant time, it throws no exceptions, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)