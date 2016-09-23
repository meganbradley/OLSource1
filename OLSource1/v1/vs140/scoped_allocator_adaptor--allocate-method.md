---
title: "scoped_allocator_adaptor::allocate Method"
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
  - scoped_allocator/std::scoped_allocator_adaptor::allocate
dev_langs: 
  - C++
ms.assetid: cad56dee-d4ad-43e0-9d77-8f73fbc8785e
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# scoped_allocator_adaptor::allocate Method
Allocates memory by using the `Outer` allocator.  
  
## Syntax  
  
```cpp  
pointer allocate(size_type count);pointer allocate(size_type count, const_void_pointer hint);  
```  
  
#### Parameters  
 `count`  
 The number of elements for which sufficient storage is to be allocated.  
  
 `hint`  
 A pointer that might assist the allocator object by locating the address of an object allocated prior to the request.  
  
## Return Value  
 The first member function returns `Outer_traits::allocate(outer_allocator(), count)`. The second member function returns `Outer_traits::allocate(outer_allocator(), count, hint)`.  
  
## Requirements  
 **Header:** <scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)   
 [allocator_traits::allocate](../vs140/allocator_traits--allocate-method.md)