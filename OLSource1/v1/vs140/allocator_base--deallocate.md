---
title: "allocator_base::deallocate"
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
  - "allocator_base::deallocate"
  - "allocators/stdext::allocators::allocator_base::deallocate"
  - "allocator_base.deallocate"
  - "stdext.allocators.allocator_base.deallocate"
  - "deallocate"
  - "allocators/stdext::allocator_base::deallocate"
  - "stdext::allocators::allocator_base::deallocate"
  - "allocators.allocator_base.deallocate"
  - "allocators::allocator_base::deallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocate method"
ms.assetid: 8e669643-4185-4dba-b721-07ce6f03df71
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::deallocate
Frees a specified number of objects from storage beginning at a specified position.  
  
## Syntax  
  
```  
void deallocate(pointer _Ptr, size_type _Nx);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|A pointer to the first object to be deallocated from storage.|  
|`_Nx`|The number of objects to be deallocated from storage.|  
  
## Remarks  
 This member function is implemented for the user-defined allocator by calling `deallocate(_Ptr)` on the synchronization filter `Sync` if `_Nx == 1`, otherwise by calling `operator delete(_Nx * _Ptr)`.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base Class](../vs140/allocator_base-class.md)