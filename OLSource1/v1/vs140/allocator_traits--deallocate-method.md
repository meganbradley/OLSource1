---
title: "allocator_traits::deallocate Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "memory/std::allocator_traits::deallocate"
ms.assetid: 58416492-e2f9-44df-9e13-a57cd700438f
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_traits::deallocate Method
Static method that uses a specified allocator to deallocate a specified number of objects.  
  
## Syntax  
  
```cpp  
static void deallocate(Alloc al,  
    pointer ptr, size_type count);  
```  
  
#### Parameters  
 `al`  
 An allocator object.  
  
 `ptr`  
 A pointer to the starting location of the objects to be deallocated.  
  
 `count`  
 The number of objects to deallocate.  
  
## Remarks  
 This method calls `al.deallocate(ptr, count)`.  
  
 This method throws nothing.  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator::deallocate](../vs140/allocator--deallocate.md)   
 [allocator_traits Class](../vs140/allocator_traits-class.md)