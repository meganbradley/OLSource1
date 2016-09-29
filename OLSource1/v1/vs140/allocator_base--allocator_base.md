---
title: "allocator_base::allocator_base"
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
  - "allocator_base"
  - "allocator_base::allocator_base"
  - "stdext::allocators::allocator_base::allocator_base"
  - "allocator_base.allocator_base"
  - "allocators.allocator_base.allocator_base"
  - "allocators/stdext::allocators::allocator_base::allocator_base"
  - "stdext.allocators.allocator_base.allocator_base"
  - "allocators::allocator_base::allocator_base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_base method"
ms.assetid: 6f0d2a5b-fa0d-4d5e-ac06-80928de0b359
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::allocator_base
Constructs an object of type `allocator_base`.  
  
## Syntax  
  
```  
allocator_base();  
template <class Other>  
    allocator_base(const allocator_base<Other, Sync>& _Right);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Right`|The allocator object to be copied.|  
  
## Remarks  
 The first constructor constructs an [allocator_base](../vs140/allocator_base-class.md) instance. The second constructor constructs an `allocator_base` instance such that for any `allocator_base<Type, _Sync>` instance `a`, `allocator_base<Type, Sync>(allocator_base<Other, Sync>(a)) == a`.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base](../vs140/allocator_base-class.md)