---
title: "sync_per_thread Class"
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
  - "stdext::sync_per_thread"
  - "sync_per_thread"
  - "allocators/stdext::sync_per_thread"
  - "stdext.sync_per_thread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sync_per_thread class"
ms.assetid: 47bf75f8-5b02-4760-b1d3-3099d08fe14c
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_per_thread Class
Describes a [synchronization filter](../vs140/-allocators-.md) that provides a separate cache object for each thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The type of cache associated with the synchronization filter. This can be [cache_chunklist](../vs140/cache_chunklist-class.md), [cache_freelist](../vs140/cache_freelist-class.md), or [cache_suballoc](../vs140/cache_suballoc-class.md).|  
  
## Remarks  
 Allocators that use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can compare equal even though blocks allocated in one thread cannot be deallocated from another thread. When using one of these allocators memory blocks allocated in one thread should not be made visible to other threads. In practice this means that a container that uses one of these allocators should only be accessed by a single thread.  
  
### Member Functions  
  
|||  
|-|-|  
|[allocate](#sync_per_thread__allocate)|Allocates a block of memory.|  
|[deallocate](#sync_per_thread__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
|[equals](#sync_per_thread__equals)|Compares two caches for equality.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="sync_per_thread__allocate">\</a>  sync_per_thread::allocate  
 Allocates a block of memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
### Remarks  
 The member function returns the result of a call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on the cache object belonging to the current thread. If no cache object has been allocated for the current thread, it first allocates one.  
  
##  \<a name="sync_per_thread__deallocate">\</a>  sync_per_thread::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
### Remarks  
 The member function calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> on the cache object belonging to the current thread. If no cache object has been allocated for the current thread, it first allocates one.  
  
##  \<a name="sync_per_thread__equals">\</a>  sync_per_thread::equals  
 Compares two caches for equality.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The cache object of the synchronization filter.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The cache object to compare for equality.|  
  
### Return Value  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if no cache object has been allocated for this object or for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in the current thread. Otherwise it returns the result of applying <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to the two cache objects.  
  
### Remarks  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)