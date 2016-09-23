---
title: "allocator_base::destroy"
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
  - allocator_base.destroy
  - allocator_base::destroy
  - allocators/stdext::allocator_base::destroy
  - stdext::allocator_base::destroy
  - stdext.allocator_base.destroy
dev_langs: 
  - C++
helpviewer_keywords: 
  - destroy method
ms.assetid: c16f2e0e-2349-4a49-9e24-11a03ab4979b
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# allocator_base::destroy
Calls an objects destructor without deallocating the memory where the object was stored.  
  
## Syntax  
  
```  
void destroy(pointer _Ptr);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|A pointer designating the address of the object to be destroyed.|  
  
## Remarks  
 This member function is implemented for the user-defined allocator by calling `_Ptr->~Type()`.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base Class](../vs140/allocator_base-class.md)