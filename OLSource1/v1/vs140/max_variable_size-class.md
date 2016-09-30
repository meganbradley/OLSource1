---
title: "max_variable_size Class"
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
  - "stdext::max_variable_size"
  - "allocators/stdext::max_variable_size"
  - "stdext.max_variable_size"
  - "max_variable_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_variable_size class"
ms.assetid: 9f2e9df0-4148-4b37-bc30-f8eca0ef86ae
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# max_variable_size Class
Describes a [max class](../vs140/-allocators-.md) object that limits a [freelist](../vs140/freelist-class.md) object to a maximum length that is roughly proportional to the number of allocated memory blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Constructors  
  
|||  
|-|-|  
|[max_variable_size](#max_variable_size__max_variable_size)|Constructs an object of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[allocated](#max_variable_size__allocated)|Increments the count of allocated memory blocks.|  
|[deallocated](#max_variable_size__deallocated)|Decrements the count of allocated memory blocks.|  
|[full](#max_variable_size__full)|Returns a value that specifies whether more memory blocks should be added to the free list.|  
|[released](#max_variable_size__released)|Decrements the count of memory blocks on the free list.|  
|[saved](#max_variable_size__saved)|Increments the count of memory blocks on the free list.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="max_variable_size__allocated">\</a>  max_variable_size::allocated  
 Increments the count of allocated memory blocks.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The increment value.|  
  
### Remarks  
 This member function adds <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the stored value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This member function is called after each successful call by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the number of memory blocks in the chunk allocated by operator <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
##  \<a name="max_variable_size__deallocated">\</a>  max_variable_size::deallocated  
 Decrements the count of allocated memory blocks.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The increment value.|  
  
### Remarks  
 The member function subtracts <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> from the stored value <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. This member function is called after each call by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is the number of memory blocks in the chunk deallocated by operator <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
##  \<a name="max_variable_size__full">\</a>  max_variable_size::full  
 Returns a value that specifies whether more memory blocks should be added to the free list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function is called by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If the call returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> puts the memory block on the free list; if it returns false, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> calls operator <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to deallocate the block.  
  
##  \<a name="max_variable_size__max_variable_size">\</a>  max_variable_size::max_variable_size  
 Constructs an object of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The constructor initializes the stored values <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to zero.  
  
##  \<a name="max_variable_size__released">\</a>  max_variable_size::released  
 Decrements the count of memory blocks on the free list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This member function decrements the stored value <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> member function of the current max class is called by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> whenever it removes a memory block from the free list.  
  
##  \<a name="max_variable_size__saved">\</a>  max_variable_size::saved  
 Increments the count of memory blocks on the free list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This member function increments the stored value <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. This member function is called by <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> whenever it puts a memory block on the free list.  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)