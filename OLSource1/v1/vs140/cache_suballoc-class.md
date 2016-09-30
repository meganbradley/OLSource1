---
title: "cache_suballoc Class"
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
  - "stdext.cache_suballoc"
  - "allocators/stdext::cache_suballoc"
  - "stdext::cache_suballoc"
  - "cache_suballoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cache_suballoc class"
ms.assetid: 9ea9c5e9-1dcc-45d0-b3a7-a56a93d88898
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cache_suballoc Class
Defines a [block allocator](../vs140/-allocators-.md) that allocates and deallocates memory blocks of a single size.  
  
## Syntax  
  
```  
template <std::size_t Sz, size_t Nelts = 20> class cache_suballoc  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Sz`|The number of elements in the array to be allocated.|  
  
## Remarks  
 The cache_suballoc template class stores deallocated memory blocks in a free list with unbounded length, using `freelist<sizeof(Type), max_unbounded>`, and suballocates memory blocks from a larger chunk allocated with `operator new` when the free list is empty.  
  
 Each chunk holds `Sz * Nelts` bytes of usable memory and the data that `operator new` and `operator delete` require. Allocated chunks are never freed.  
  
### Constructors  
  
|||  
|-|-|  
|[cache_suballoc](#cache_suballoc__cache_suballoc)|Constructs an object of type `cache_suballoc`.|  
  
### Member Functions  
  
|||  
|-|-|  
|[allocate](#cache_suballoc__allocate)|Allocates a block of memory.|  
|[deallocate](#cache_suballoc__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  <a name="cache_suballoc__allocate"></a>  cache_suballoc::allocate  
 Allocates a block of memory.  
  
```  
void *allocate(std::size_t _Count);  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Count`|The number of elements in the array to be allocated.|  
  
### Return Value  
 A pointer to the allocated object.  
  
### Remarks  
  
##  <a name="cache_suballoc__cache_suballoc"></a>  cache_suballoc::cache_suballoc  
 Constructs an object of type `cache_suballoc`.  
  
```  
cache_suballoc();  
```  
  
### Remarks  
  
##  <a name="cache_suballoc__deallocate"></a>  cache_suballoc::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
```  
void deallocate(void* _Ptr, std::size_t _Count);  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|A pointer to the first object to be deallocated from storage.|  
|`_Count`|The number of objects to be deallocated from storage.|  
  
### Remarks  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)