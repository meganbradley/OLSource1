---
title: "allocator_traits::allocate Method"
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
  - "memory/std::allocator_traits::allocate"
dev_langs: 
  - "C++"
ms.assetid: 444bfda4-c4df-4021-9aed-211c74dc0684
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_traits::allocate Method
Static method that allocates memory by using the given allocator parameter.  
  
## Syntax  
  
```cpp  
static pointer allocate(Alloc& al, size_type count);  
static pointer allocate(Alloc& al, size_type count,  
    typename allocator_traits<void>::const_pointer *hint);  
```  
  
#### Parameters  
 `al`  
 An allocator object.  
  
 `count`  
 The number of elements to allocate.  
  
 `hint`  
 A `const_pointer` that might assist the allocator object in satisfying the request for storage by locating the address of an allocated object prior to the request. A null pointer is treated as no hint.  
  
## Return Value  
 Each method returns a pointer to the allocated object.  
  
 The first static method returns `al.allocate(count)`.  
  
 The second method returns `al.allocate(count, hint)`, if that expression is well formed; otherwise it returns `al.allocate(count)`.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator::allocate](../vs140/allocator--allocate.md)   
 [allocator_traits Class](../vs140/allocator_traits-class.md)