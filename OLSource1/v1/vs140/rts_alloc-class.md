---
title: "rts_alloc Class"
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
  - "stdext::rts_alloc"
  - "allocators/stdext::rts_alloc"
  - "rts_alloc"
  - "stdext.rts_alloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rts_alloc class"
ms.assetid: ab41bffa-83d1-4a1c-87b9-5707d516931f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rts_alloc Class
The rts_alloc template class describes a [filter](../vs140/-allocators-.md) that holds an array of cache instances and determines which instance to use for allocation and deallocation at runtime instead of at compile time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The type of cache instances contained in the array. This can be [cache_chunklist](../vs140/cache_chunklist-class.md), [cache_freelist](../vs140/cache_freelist-class.md), or [cache_suballoc](../vs140/cache_suballoc-class.md).|  
  
## Remarks  
 This template class holds multiple block allocator instances and determines which instance to use for allocation or deallocation at runtime instead of at compile time. It is used with compilers that cannot compile rebind.  
  
### Member Functions  
  
|||  
|-|-|  
|[allocate](#rts_alloc__allocate)|Allocates a block of memory.|  
|[deallocate](#rts_alloc__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
|[equals](#rts_alloc__equals)|Compares two caches for equality.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="rts_alloc__allocate">\</a>  rts_alloc::allocate  
 Allocates a block of memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
### Return Value  
 A pointer to the allocated object.  
  
### Remarks  
 The member function returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, where the index <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is determined by the requested block size <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or, if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is too large, it returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which represents the cache object.  
  
##  \<a name="rts_alloc__deallocate">\</a>  rts_alloc::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
### Remarks  
 The member function calls <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, where the index <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is determined by the requested block size <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or, if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is too large, it returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
##  \<a name="rts_alloc__equals">\</a>  rts_alloc::equals  
 Compares two caches for equality.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The cache object associated with the filter.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|The cache object to compare for equality.|  
  
### Remarks  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if the result of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> represents the array of cache objects.  
  
## See Also  
 [ALLOCATOR_DECL](../vs140/-allocators--functions.md#allocator_decl)   
 [\<allocators>](../vs140/-allocators-.md)