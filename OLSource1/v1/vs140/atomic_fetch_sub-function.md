---
title: "atomic_fetch_sub Function"
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
  - "atomic/std::atomic_fetch_sub"
dev_langs: 
  - "C++"
ms.assetid: f2bee484-b4d7-48ab-8bf7-1c36e6ce7978
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_sub Function
Subtracts a value from an existing value that is stored in an `atomic` object.  
  
## Syntax  
  
```  
template <class T> T* atomic_fetch_sub(  
   volatile atomic<T*> *Atom,  
   ptrdiff_t Value  
) noexcept;  
  
template <class T> T* atomic_fetch_sub(  
   atomic<T*> *Atom,  
   ptrdiff_t Value  
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
 The `atomic_fetch_sub` function performs a `read-modify-write` operation to atomically subtract `Value` from the stored value in `Atom`, using the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md) constraint.  
  
 When the atomic type is `atomic_address`, `Value` has type `ptrdiff_t` and the operation treats the stored pointer as a `char *`.  
  
 This operation is also overloaded for integral types:  
  
```cpp  
integral atomic_fetch_sub(  
    volatile atomic-integral * Atom, integral Value  
) noexcept;  
  
integral atomic_fetch_sub(  
    atomic-integral * Atom, integral Value  
) noexcept;  
```  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_sub_explicit](../vs140/atomic_fetch_sub_explicit-function.md)