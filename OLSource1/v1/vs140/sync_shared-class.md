---
title: "sync_shared Class"
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
  - "sync_shared"
  - "allocators/stdext::sync_shared"
  - "stdext.sync_shared"
  - "stdext::sync_shared"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sync_shared class"
ms.assetid: cab3af9e-3d1a-4f2c-8580-0f89e5687d8e
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# sync_shared Class
Describes a [synchronization filter](../vs140/-allocators-.md) that uses a mutex to control access to a cache object that is shared by all allocators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The type of cache associated with the synchronization filter. This can be [cache_chunklist](../vs140/cache_chunklist-class.md), [cache_freelist](../vs140/cache_freelist-class.md), or [cache_suballoc](../vs140/cache_suballoc-class.md).|  
  
### Member Functions  
  
|||  
|-|-|  
|[allocate](#sync_shared__allocate)|Allocates a block of memory.|  
|[deallocate](#sync_shared__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
|[equals](#sync_shared__equals)|Compares two caches for equality.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="sync_shared__allocate">\</a>  sync_shared::allocate  
 Allocates a block of memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
### Return Value  
 A pointer to the allocated object.  
  
### Remarks  
 The member function locks the mutex, calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, unlocks the mutex, and returns the result of the earlier call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> represents the current cache object.  
  
##  \<a name="sync_shared__deallocate">\</a>  sync_shared::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
### Remarks  
 This member function locks the mutex, calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> represents the cache object, and then unlocks the mutex.  
  
##  \<a name="sync_shared__equals">\</a>  sync_shared::equals  
 Compares two caches for equality.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The type of cache associated with the synchronization filter.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The cache to compare for equality.|  
  
### Return Value  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the result of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> represents the cache object, is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Remarks  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)