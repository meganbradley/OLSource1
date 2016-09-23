---
title: "cache_chunklist::allocate"
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
  - cache_chunklist::allocate
  - stdext::cache_chunklist::allocate
  - allocators/stdext::cache_chunklist::allocate
  - cache_chunklist.allocate
  - stdext.cache_chunklist.allocate
dev_langs: 
  - C++
helpviewer_keywords: 
  - allocate method
ms.assetid: b0dbff62-ade5-4576-b8db-6c8bdcd9603e
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# cache_chunklist::allocate
Allocates a block of memory.  
  
## Syntax  
  
```  
void *allocate(std::size_t _Count);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Count`|The number of elements in the array to be allocated.|  
  
## Return Value  
 A pointer to the allocated object.  
  
## Remarks  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [cache_chunklist Class](../vs140/cache_chunklist-class.md)