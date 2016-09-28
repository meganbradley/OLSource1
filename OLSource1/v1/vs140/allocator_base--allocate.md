---
title: "allocator_base::allocate"
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
  - "allocators/stdext::allocators::allocator_base::allocate"
  - "allocators.allocator_base.allocate"
  - "allocate"
  - "allocators::allocator_base::allocate"
  - "allocators/stdext::allocator_base::allocate"
  - "allocator_base::allocate"
  - "allocator_base.allocate"
  - "stdext::allocators::allocator_base::allocate"
  - "stdext.allocators.allocator_base.allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate method"
ms.assetid: d04e4bbb-e1c2-4291-be64-057cbbc6cae8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::allocate
Allocates a block of memory large enough to store at least some specified number of elements.  
  
## Syntax  
  
```  
template <class Other>  
    pointer allocate(size_type _Nx, const Other* _Hint = 0);  
pointer allocate(size_type _Nx);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Nx`|The number of elements in the array to be allocated.|  
|`_Hint`|This parameter is ignored.|  
  
## Return Value  
 A pointer to the allocated object.  
  
## Remarks  
 The member function implements memory allocation for the user-defined allocator by returning the result of a call to the `allocate` function of the synchronization filter of type Type`*` if `_Nx == 1`, otherwise by returning the result of a call to `operator new(_Nx * sizeof(Type))` cast to type Type`*`.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base](../vs140/allocator_base-class.md)