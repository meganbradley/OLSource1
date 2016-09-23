---
title: "initializer_list::end"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 8f3da784-440d-46fe-ace7-3b334edf7d15
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# initializer_list::end
Returns a pointer to one past the last element in an `initializer list`.  
  
## Syntax  
  
```  
constexpr const InputIterator* end() const noexcept;  
```  
  
## Return Value  
 A pointer to one past the last element in the list. If the list is empty, this is the same as the pointer to the first element in the list.  
  
## Requirements  
 **Header:** <initializer_list>  
  
 **Namespace:** std  
  
## See Also  
 [initializer_list Class](../vs140/initializer_list-class.md)