---
title: "atomic_fetch_add_explicit Function"
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
  - "atomic/std::atomic_fetch_add_explicit"
dev_langs: 
  - "C++"
ms.assetid: bcc61caa-c576-423a-a1b3-bcf7edbfec01
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_add_explicit Function
Adds a value to an existing value that is stored in an `atomic` object.  
  
## Syntax  
  
```  
template <class T> T* atomic_fetch_add_explicit(  
   volatile atomic<T*> *Atom,  
   ptrdiff_t Value,  
   memory_order Order  
) noexcept;  
  
template <class T> T* atomic_fetch_add_explicit(  
   atomic<T*> *Atom,  
   ptrdiff_t Value,   memory_order Order  
) noexcept;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that stores a pointer to type `T`.  
  
 `Value`  
 A value of type `ptrdiff_t`.  
  
## Return Value  
 The value of the pointer contained by the atomic object immediately before the operation was performed.  
  
## Remarks  
 The `atomic_fetch_add_explicit` function performs a `read-modify-write` operation to atomically add `Value` to the stored value in `Atom`, within the [memory_order](../vs140/memory_order-enum.md) constraints that are specified by `Order`.  
  
 When the atomic type is `atomic_address`, `Value` has type `ptrdiff_t` and the operation treats the stored pointer as a `char *`.  
  
 This operation is also overloaded for integral types:  
  
```cpp  
integral atomic_fetch_add_explicit(  
    volatile atomic-integral * Atom, integral Value, memory_order Order  
) noexcept;  
  
integral atomic_fetch_add_explicit(  
    atomic-integral * Atom, integral Value, memory_order Order  
) noexcept;  
```  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_add](../vs140/atomic_fetch_add-function.md)