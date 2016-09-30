---
title: "cache_freelist Class"
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
  - "stdext.cache_freelist"
  - "allocators/stdext::cache_freelist"
  - "stdext::cache_freelist"
  - "cache_freelist"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cache_freelist class"
ms.assetid: 840694de-36ba-470f-8dae-2b723d5a8cd9
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cache_freelist Class
Defines a [block allocator](../vs140/-allocators-.md) that allocates and deallocates memory blocks of a single size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The max class representing the maximum size of the free list. This can be [max_fixed_size](../vs140/max_fixed_size-class.md), [max_none](../vs140/max_none-class.md), [max_unbounded](../vs140/max_unbounded-class.md), or [max_variable_size](../vs140/max_variable_size-class.md).|  
  
## Remarks  
 The cache_freelist template class maintains a free list of memory blocks of size <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. When the free list is full it uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to deallocate memory blocks. When the free list is empty it uses <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to allocate new memory blocks. The maximum size of the free list is determined by the class max class passed in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.  
  
 Each memory block holds <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> bytes of usable memory and the data that <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> require.  
  
### Constructors  
  
|||  
|-|-|  
|[cache_freelist](#cache_freelist__cache_freelist)|Constructs an object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[allocate](#cache_freelist__allocate)|Allocates a block of memory.|  
|[deallocate](#cache_freelist__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="cache_freelist__allocate">\</a>  cache_freelist::allocate  
 Allocates a block of memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
### Return Value  
 A pointer to the allocated object.  
  
### Remarks  
  
##  \<a name="cache_freelist__cache_freelist">\</a>  cache_freelist::cache_freelist  
 Constructs an object of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cache_freelist__deallocate">\</a>  cache_freelist::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
### Remarks  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)