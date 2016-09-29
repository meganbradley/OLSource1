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
  
```  
template <std::size_t Sz, class Max> class freelist  
    : public Max  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Sz`|The number of elements in the array to be allocated.|  
|`Max`|The max class representing the maximum number of elements to be stored in the free list. The max class can be [max_none](../VS_csharp/max_none-class.md), [max_unbounded](../VS_csharp/max_unbounded-class.md), [max_fixed_size](../VS_csharp/max_fixed_size-class.md), or [max_variable_size](../VS_csharp/max_variable_size-class.md).|  
  
## Remarks  
 This template class manages a list of memory blocks of size `Sz` with the maximum length of the list determined by the max class passed in `Max`.  
  
### Constructors  
  
|||  
|-|-|  
|[freelist](#freelist__freelist)|Constructs an object of type `freelist`.|  
  
### Member Functions  
  
|||  
|-|-|  
|[pop](#freelist__pop)|Removes the first memory block from the free list.|  
|[push](#freelist__push)|Adds a memory block to the list.|  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
##  <a name="freelist__freelist"></a>  freelist::freelist  
 Constructs an object of type `freelist`.  
  
```  
freelist();  
```  
  
### Remarks  
  
##  <a name="freelist__pop"></a>  freelist::pop  
 Removes the first memory block from the free list.  
  
```  
void *pop();  
```  
  
### Return Value  
 Returns a pointer to the memory block removed from the list.  
  
### Remarks  
 The member function returns `NULL` if the list is empty. Otherwise, it removes the first memory block from the list.  
  
##  <a name="freelist__push"></a>  freelist::push  
 Adds a memory block to the list.  
  
```  
bool push(void* _Ptr);  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|A pointer to the memory block to be added to the free list.|  
  
### Return Value  
 `true` if the `full` function of the max class returns `false`; otherwise, the `push` function returns `false`.  
  
### Remarks  
 If the `full` function of the max class returns `false`, this member function adds the memory block pointed to by `_Ptr` to the head of the list.  
  
## See Also  
 [<allocators\>](../VS_csharp/-allocators-.md)