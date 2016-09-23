---
title: "allocate_shared"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - allocate_shared
  - xxshared/allocate_shared
  - std::allocate_shared
  - std.allocate_shared
dev_langs: 
  - C++
helpviewer_keywords: 
  - allocate_shared
  - allocate_shared function
ms.assetid: bb6b9dcd-25c4-4d35-91c7-86c69c1a66fc
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# allocate_shared
Creates a `shared_ptr` to objects that are allocated and constructed for a given type by using a specified allocator. Returns the `shared_ptr`.  
  
## Syntax  
  
```  
template<class Type, class Allocator, class... Types>  
    shared_ptr<Type> allocate_shared(  
        Allocator Alloc,   
        Types&&... Args  
    );  
```  
  
#### Parameters  
 `Alloc`  
 The allocator used to create objects.  
  
 `Args`  
 The zero or more arguments that become the objects.  
  
## Property Value/Return Value  
 Returns a `shared_ptr` that points to the allocated object.  
  
## Remarks  
 The function creates the object `shared_ptr``<Type>`, a pointer to `Type(``Args``...)` as allocated and constructed by `Alloc`.  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [<memory\>](../vs140/-memory-.md)