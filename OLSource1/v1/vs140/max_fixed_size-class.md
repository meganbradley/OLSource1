---
title: "max_fixed_size Class"
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
  - "allocators/stdext::max_fixed_size"
  - "max_fixed_size"
  - "stdext::max_fixed_size"
  - "stdext.max_fixed_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_fixed_size class"
ms.assetid: 8c8f4588-37e9-4579-8168-ba3553800914
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_fixed_size Class
Describes a [max class](../vs140/-allocators-.md) object that limits a [freelist](../vs140/freelist-class.md) object to a fixed maximum length.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The max class that determines the maximum number of elements to store in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
  
### Constructors  
  
|||  
|-|-|  
|[max_fixed_size](#max_fixed_size__max_fixed_size)|Constructs an object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[allocated](#max_fixed_size__allocated)|Increments the count of allocated memory blocks.|  
|[deallocated](#max_fixed_size__deallocated)|Decrements the count of allocated memory blocks.|  
|[full](#max_fixed_size__full)|Returns a value that specifies whether more memory blocks should be added to the free list.|  
|[released](#max_fixed_size__released)|Decrements the count of memory blocks on the free list.|  
|[saved](#max_fixed_size__saved)|Increments the count of memory blocks on the free list.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="max_fixed_size__allocated">\</a>  max_fixed_size::allocated  
 Increments the count of allocated memory blocks.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The increment value.|  
  
### Remarks  
 The member function does nothing. This member function is called after each successful call by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the number of memory blocks in the chunk allocated by operator <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
##  \<a name="max_fixed_size__deallocated">\</a>  max_fixed_size::deallocated  
 Decrements the count of allocated memory blocks.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The increment value.|  
  
### Remarks  
 The member function does nothing. This member function is called after each call by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is the number of memory blocks in the chunk deallocated by operator <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
##  \<a name="max_fixed_size__full">\</a>  max_fixed_size::full  
 Returns a value that specifies whether more memory blocks should be added to the free list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function is called by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. If the call returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> puts the memory block on the free list; if it returns false, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> calls operator <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to deallocate the block.  
  
##  \<a name="max_fixed_size__max_fixed_size">\</a>  max_fixed_size::max_fixed_size  
 Constructs an object of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This constructor initializes the stored value <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to zero.  
  
##  \<a name="max_fixed_size__released">\</a>  max_fixed_size::released  
 Decrements the count of memory blocks on the free list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Decrements the stored value <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member function of the current [max class](../vs140/-allocators-.md) is called by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> whenever it removes a memory block from the free list.  
  
##  \<a name="max_fixed_size__saved">\</a>  max_fixed_size::saved  
 Increments the count of memory blocks on the free list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This member function increments the stored value <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. This member function is called by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> whenever it puts a memory block on the free list.  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)