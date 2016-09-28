---
title: "allocator_traits::destroy Method"
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
  - "memory/std::allocator_traits::destroy"
dev_langs: 
  - "C++"
ms.assetid: c2569333-4212-461f-b0b5-9e01ea37ada5
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# allocator_traits::destroy Method
Static method that uses a specified allocator to call the destructor on an object without deallocating its memory.  
  
## Syntax  
  
```cpp  
template<class Uty>  
    static void destroy(Alloc& al, Uty *ptr);  
```  
  
#### Parameters  
 `al`  
 An allocator object.  
  
 `ptr`  
 A pointer to the location of the object.  
  
## Remarks  
 This method calls `al.destroy(ptr)`, if that expression is well formed; otherwise it evaluates `ptr->~Uty()`.  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator::destroy](../vs140/allocator--destroy.md)   
 [allocator_traits Class](../vs140/allocator_traits-class.md)