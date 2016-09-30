---
title: "allocator_base::_Chardealloc"
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
  - "allocator_base::_Chardealloc"
  - "stdext::allocator_base::_Chardealloc"
  - "allocators/stdext::allocator_base::_Chardealloc"
  - "allocator_base._Chardealloc"
  - "stdext.allocator_base._Chardealloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_Chardealloc method"
ms.assetid: a037e3df-79bd-45eb-9810-5994e2703aea
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::_Chardealloc
Frees storage for the array containing elements of type `char`.  
  
## Syntax  
  
```  
void _Chardealloc(void* _Ptr, size_type _Count);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|A pointer to the first object to be deallocated from storage.|  
|`_Count`|The number of objects to be deallocated from storage.|  
  
## Remarks  
 This member function is used by containers when compiled with a compiler that cannot compile rebind. It implements `_Chardealloc` for the user-defined allocator by calling the `deallocate` function of the synchronization filter. The pointer _Ptr must have been earlier returned by a call to `_Charalloc` for an allocator object that compares equal to `*this`, allocating an array object of the same size and type. `_Chardealloc` never throws an exception.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base](../vs140/allocator_base-class.md)