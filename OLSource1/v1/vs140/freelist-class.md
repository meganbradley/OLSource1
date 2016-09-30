---
title: "freelist Class"
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
  - "stdext::freelist"
  - "freelist"
  - "stdext.freelist"
  - "allocators/stdext::freelist"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "freelist class"
ms.assetid: 8ad7e35c-4c80-4479-8ede-1a2497b06d71
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# freelist Class
Manages a list of memory blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The max class representing the maximum number of elements to be stored in the free list. The max class can be [max_none](../vs140/max_none-class.md), [max_unbounded](../vs140/max_unbounded-class.md), [max_fixed_size](../vs140/max_fixed_size-class.md), or [max_variable_size](../vs140/max_variable_size-class.md).|  
  
## Remarks  
 This template class manages a list of memory blocks of size <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the maximum length of the list determined by the max class passed in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
### Constructors  
  
|||  
|-|-|  
|[freelist](#freelist__freelist)|Constructs an object of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[pop](#freelist__pop)|Removes the first memory block from the free list.|  
|[push](#freelist__push)|Adds a memory block to the list.|  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
##  \<a name="freelist__freelist">\</a>  freelist::freelist  
 Constructs an object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="freelist__pop">\</a>  freelist::pop  
 Removes the first memory block from the free list.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the memory block removed from the list.  
  
### Remarks  
 The member function returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the list is empty. Otherwise, it removes the first memory block from the list.  
  
##  \<a name="freelist__push">\</a>  freelist::push  
 Adds a memory block to the list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|A pointer to the memory block to be added to the free list.|  
  
### Return Value  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function of the max class returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; otherwise, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function of the max class returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, this member function adds the memory block pointed to by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to the head of the list.  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)