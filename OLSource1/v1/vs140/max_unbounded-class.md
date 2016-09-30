---
title: "max_unbounded Class"
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
  - "allocators/stdext::max_unbounded"
  - "stdext::max_unbounded"
  - "stdext.max_unbounded"
  - "max_unbounded"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_unbounded class"
ms.assetid: e34627a9-c231-4031-a483-cbb0514fff46
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# max_unbounded Class
Describes a [max class](../vs140/-allocators-.md) object that does not limit the maximum length of a [freelist](../vs140/freelist-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Member Functions  
  
|||  
|-|-|  
|[allocated](#max_unbounded__allocated)|Increments the count of allocated memory blocks.|  
|[deallocated](#max_unbounded__deallocated)|Decrements the count of allocated memory blocks.|  
|[full](#max_unbounded__full)|Returns a value that specifies whether more memory blocks should be added to the free list.|  
|[released](#max_unbounded__released)|Decrements the count of memory blocks on the free list.|  
|[saved](#max_unbounded__saved)|Increments the count of memory blocks on the free list.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="max_unbounded__allocated">\</a>  max_unbounded::allocated  
 Increments the count of allocated memory blocks.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The increment value.|  
  
### Remarks  
 This member function does nothing. It is called after each successful call by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the number of memory blocks in the chunk allocated by operator <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
##  \<a name="max_unbounded__deallocated">\</a>  max_unbounded::deallocated  
 Decrements the count of allocated memory blocks.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The increment value.|  
  
### Remarks  
 The member function does nothing. This member function is called after each call by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the number of memory blocks in the chunk deallocated by operator <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
##  \<a name="max_unbounded__full">\</a>  max_unbounded::full  
 Returns a value that specifies whether more memory blocks should be added to the free list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The member function always returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function is called by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If the call returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> puts the memory block on the free list; if it returns false, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> calls operator <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to deallocate the block.  
  
##  \<a name="max_unbounded__released">\</a>  max_unbounded::released  
 Decrements the count of memory blocks on the free list.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This member function does nothing. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function of the current max class is called by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> whenever it removes a memory block from the free list.  
  
##  \<a name="max_unbounded__saved">\</a>  max_unbounded::saved  
 Increments the count of memory blocks on the free list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This member function does nothing. It is called by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> whenever it puts a memory block on the free list.  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)