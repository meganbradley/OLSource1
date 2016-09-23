---
title: "allocator_variable_size Class"
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
  - allocators.allocator_variable_size
  - allocators::allocator_variable_size
  - allocators/stdext::allocator_variable_size
  - stdext.allocators.allocator_variable_size
  - allocator_variable_size
  - allocators/stdext::allocators::allocator_variable_size
  - stdext::allocators::allocator_variable_size
dev_langs: 
  - C++
helpviewer_keywords: 
  - allocator_variable_size class
ms.assetid: c3aa4105-ae45-4385-bbbe-9f23060478cb
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# allocator_variable_size Class
Describes an object that manages storage allocation and freeing for objects of type `Type` using a cache of type [cache_freelist](../vs140/cache_freelist-class.md) with a length managed by [max_variable_size](../vs140/max_variable_size-class.md).  
  
## Syntax  
  
```  
template <class Type>  
    class allocator_variable_size;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Type`|The type of elements allocated by the allocator.|  
  
## Remarks  
 The [ALLOCATOR_DECL](../vs140/-allocators--functions.md#allocator_decl) macro passes this class as the `name` parameter in the following statement: `ALLOCATOR_DECL(CACHE_FREELIST(stdext::allocators::max_variable_size), SYNC_DEFAULT, allocator_variable_size);`  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [<allocators\>](../vs140/-allocators-.md)