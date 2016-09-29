---
title: "rts_alloc::allocate"
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
  - "stdext.rts_alloc.allocate"
  - "rts_alloc.allocate"
  - "rts_alloc::allocate"
  - "stdext::rts_alloc::allocate"
  - "allocators/stdext::rts_alloc::allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate method"
ms.assetid: d3c55aad-e31e-448d-8aae-c9d107acfd4c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rts_alloc::allocate
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
 The member function returns `caches[_IDX].allocate(_Count)`, where the index `_IDX` is determined by the requested block size `_Count`, or, if `_Count` is too large, it returns `operator new(_Count)`.`cache`, which represents the cache object.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [rts_alloc Class](../vs140/rts_alloc-class.md)