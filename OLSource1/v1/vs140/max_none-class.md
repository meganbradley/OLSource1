---
title: "max_none Class"
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
  - "max_none"
  - "stdext::max_none"
  - "stdext.max_none"
  - "allocators/stdext::max_none"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_none class"
ms.assetid: 12ab5376-412e-479c-86dc-2c3d6a3559b6
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# max_none Class
Describes a [max class](../vs140/-allocators-.md) object that limits a [freelist](../vs140/freelist-class.md) object to a maximum length of zero.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The max class that determines the maximum number of elements to store in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[allocated](#max_none__allocated)|Increments the count of allocated memory blocks.|  
|[deallocated](#max_none__deallocated)|Decrements the count of allocated memory blocks.|  
|[full](#max_none__full)|Returns a value that specifies whether more memory blocks should be added to the free list.|  
|[released](#max_none__released)|Decrements the count of memory blocks on the free list.|  
|[saved](#max_none__saved)|Increments the count of memory blocks on the free list.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="max_none__allocated">\</a>  max_none::allocated  
 Increments the count of allocated memory blocks.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The increment value.|  
  
### Remarks  
 This member function does nothing. It is called after each successful call by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the number of memory blocks in the chunk allocated by operator <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
##  \<a name="max_none__deallocated">\</a>  max_none::deallocated  
 Decrements the count of allocated memory blocks.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The increment value.|  
  
### Remarks  
 The member function does nothing. This member function is called after each call by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is the number of memory blocks in the chunk deallocated by operator <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
##  \<a name="max_none__full">\</a>  max_none::full  
 Returns a value that specifies whether more memory blocks should be added to the free list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 This member function always returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function is called by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If the call returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> puts the memory block on the free list; if it returns false, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> calls operator <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to deallocate the block.  
  
##  \<a name="max_none__released">\</a>  max_none::released  
 Decrements the count of memory blocks on the free list.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This member function does nothing. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> member function of the current max class is called by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> whenever it removes a memory block from the free list.  
  
##  \<a name="max_none__saved">\</a>  max_none::saved  
 Increments the count of memory blocks on the free list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This member function does nothing. It is called by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> whenever it puts a memory block on the free list.  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)