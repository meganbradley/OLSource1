---
title: "max_none::allocated"
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
  - max_none.allocated
  - allocators/stdext::max_none::allocated
  - max_none::allocated
  - stdext.max_none.allocated
  - stdext::max_none::allocated
dev_langs: 
  - C++
helpviewer_keywords: 
  - allocated method
ms.assetid: 47fa3b3d-27bb-4ab9-b990-9835e0c2f647
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# max_none::allocated
Increments the count of allocated memory blocks.  
  
## Syntax  
  
```  
void allocated(std::size_t _Nx = 1);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Nx`|The increment value.|  
  
## Remarks  
 This member function does nothing. It is called after each successful call by `cache_freelist::allocate` to operator `new`. The argument `_Nx` is the number of memory blocks in the chunk allocated by operator `new`.  
  
## See Also  
 [max_none Class](../vs140/max_none-class.md)