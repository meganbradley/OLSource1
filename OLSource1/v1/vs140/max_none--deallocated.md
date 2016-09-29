---
title: "max_none::deallocated"
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
  - "allocators/stdext::max_none::deallocated"
  - "max_none.deallocated"
  - "max_none::deallocated"
  - "stdext::max_none::deallocated"
  - "stdext.max_none.deallocated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocated method"
ms.assetid: 5a4bc4b0-caea-4021-bf67-0b8bd2e1cef6
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_none::deallocated
Decrements the count of allocated memory blocks.  
  
## Syntax  
  
```  
void deallocated(std::size_t _Nx = 1);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Nx`|The increment value.|  
  
## Remarks  
 The member function does nothing. This member function is called after each call by `cache_freelist::deallocate` to operator `delete`. The argument `_Nx` is the number of memory blocks in the chunk deallocated by operator `delete`.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_none Class](../vs140/max_none-class.md)