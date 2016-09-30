---
title: "sync_none::allocate"
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
  - "allocators/stdext::sync_none::allocate"
  - "sync_none.allocate"
  - "sync_none::allocate"
  - "stdext::sync_none::allocate"
  - "stdext.sync_none.allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate method"
ms.assetid: f34b06b3-0eea-48e7-ad07-da34d5f8e872
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_none::allocate
Allocates a block of memory.  
  
## Syntax  
  
```  
void *allocate(std::size_t _Count);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Count`|The number of elements in the array to be allocated.|  
  
## Remarks  
 The member function returns `cache.allocate(_Count)`, where `cache` is the cache object.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [sync_none Class](../vs140/sync_none-class.md)