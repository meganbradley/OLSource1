---
title: "cache_freelist::deallocate"
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
  - "cache_freelist::deallocate"
  - "allocators/stdext::cache_freelist::deallocate"
  - "stdext::cache_freelist::deallocate"
  - "cache_freelist.deallocate"
  - "stdext.cache_freelist.deallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocate method"
ms.assetid: 7a3fde8f-e411-4ae7-99cb-9f7fbbc1ec9f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cache_freelist::deallocate
Frees a specified number of objects from storage beginning at a specified position.  
  
## Syntax  
  
```  
void deallocate(void* _Ptr, std::size_t _Count);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|A pointer to the first object to be deallocated from storage.|  
|`_Count`|The number of objects to be deallocated from storage.|  
  
## Remarks  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [cache_freelist Class](../vs140/cache_freelist-class.md)