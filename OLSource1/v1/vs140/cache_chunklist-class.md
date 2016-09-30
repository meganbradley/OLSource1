---
title: "cache_chunklist Class"
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
  - "allocators/stdext::cache_chunklist"
  - "stdext.cache_chunklist"
  - "stdext::cache_chunklist"
  - "cache_chunklist"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cache_chunklist class"
ms.assetid: af19eccc-4ae7-4a34-bbb2-81e397424cb9
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cache_chunklist Class
Defines a [block allocator](../vs140/-allocators-.md) that allocates and deallocates memory blocks of a single size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
## Remarks  
 This template class uses <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to allocate chunks of raw memory, suballocating blocks to allocate storage for a memory block when needed; it stores deallocated memory blocks in a separate free list for each chunk, and uses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to deallocate a chunk when none of its memory blocks is in use.  
  
 Each memory block holds <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> bytes of usable memory and a pointer to the chunk that it belongs to. Each chunk holds <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> memory blocks, three pointers, an int and the data that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> require.  
  
### Constructors  
  
|||  
|-|-|  
|[cache_chunklist](#cache_chunklist__cache_chunklist)|Constructs an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[allocate](#cache_chunklist__allocate)|Allocates a block of memory.|  
|[deallocate](#cache_chunklist__deallocate)|Frees a specified number of objects from storage beginning at a specified position.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="cache_chunklist__allocate">\</a>  cache_chunklist::allocate  
 Allocates a block of memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
### Return Value  
 A pointer to the allocated object.  
  
### Remarks  
  
##  \<a name="cache_chunklist__cache_chunklist">\</a>  cache_chunklist::cache_chunklist  
 Constructs an object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cache_chunklist__deallocate">\</a>  cache_chunklist::deallocate  
 Frees a specified number of objects from storage beginning at a specified position.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
### Remarks  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)