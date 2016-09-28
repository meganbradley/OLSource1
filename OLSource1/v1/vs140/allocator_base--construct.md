---
title: "allocator_base::construct"
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
  - "stdext::allocator_base::construct"
  - "allocators/stdext::allocator_base::construct"
  - "stdext.allocator_base.construct"
  - "allocator_base.construct"
  - "allocator_base::construct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "construct method"
ms.assetid: bd13f467-35cd-4031-8359-79645c4ebdf3
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::construct
Constructs a specific type of object at a specified address that is initialized with a specified value.  
  
## Syntax  
  
```  
void construct(pointer _Ptr, const Type& _Val);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|A pointer to the location where the object is to be constructed.|  
|`_Val`|The value with which the object being constructed is to be initialized.|  
  
## Remarks  
 This member function is implemented for the user-defined allocator by calling `new((void*)_Ptr Type(_Val)`.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base Class](../vs140/allocator_base-class.md)