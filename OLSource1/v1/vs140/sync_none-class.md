---
title: "sync_none Class"
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
  - "stdext.sync_none"
  - "sync_none"
  - "allocators/stdext::sync_none"
  - "stdext::sync_none"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sync_none class"
ms.assetid: f7473cee-14f3-4fe1-88bc-68cd085e59e1
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_none Class
Describes a [synchronization filter](../vs140/-allocators-.md) that provides no synchronization.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The type of cache associated with the synchronization filter. This can be [cache_chunklist](../vs140/cache_chunklist-class.md), [cache_freelist](../vs140/cache_freelist-class.md), or [cache_suballoc](../vs140/cache_suballoc-class.md).|  
  
### Member Functions  
  
|||  
|-|-|  
|[allocate](#sync_none__allocate)|Allocates a block of memory.|  
|[deallocate](#sync_none__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
|[equals](#sync_none__equals)|Compares two caches for equality.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="sync_none__allocate">\</a>  sync_none::allocate  
 Allocates a block of memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
### Remarks  
 The member function returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the cache object.  
  
##  \<a name="sync_none__deallocate">\</a>  sync_none::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
### Remarks  
 The member function calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> represents the cache object.  
  
##  \<a name="sync_none__equals">\</a>  sync_none::equals  
 Compares two caches for equality.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The cache object of the synchronization filter.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The cache object to compare for equality.|  
  
### Return Value  
 The member function always returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
### Remarks  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)