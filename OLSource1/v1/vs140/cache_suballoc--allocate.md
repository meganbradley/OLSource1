---
title: "cache_suballoc::allocate"
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
  - "stdext.cache_suballoc.allocate"
  - "allocators/stdext::cache_suballoc::allocate"
  - "stdext::cache_suballoc::allocate"
  - "cache_suballoc::allocate"
  - "cache_suballoc.allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate method"
ms.assetid: bf5d44c2-eb37-4aae-902c-3629800535f8
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cache_suballoc::allocate
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
 [cache_suballoc Class](../vs140/cache_suballoc-class.md)