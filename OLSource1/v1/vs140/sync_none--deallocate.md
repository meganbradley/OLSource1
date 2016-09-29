---
title: "sync_none::deallocate"
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
  - "stdext::sync_none::deallocate"
  - "sync_none::deallocate"
  - "stdext.sync_none.deallocate"
  - "allocators/stdext::sync_none::deallocate"
  - "sync_none.deallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocate method"
ms.assetid: 593a21ed-0fb2-4b58-bb9b-79eaacea59bb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_none::deallocate
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
 The member function calls `cache.deallocate(_Ptr, _Count)`, where `cache` represents the cache object.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [sync_none Class](../vs140/sync_none-class.md)