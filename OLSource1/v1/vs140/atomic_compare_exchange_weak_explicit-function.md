---
title: "atomic_compare_exchange_weak_explicit Function"
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
  - "atomic/std::atomic_compare_exchange_weak_explicit"
dev_langs: 
  - "C++"
ms.assetid: b2571200-322c-4d00-8da7-9a4599203374
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_compare_exchange_weak_explicit Function
Performs a *weak atomic compare and exchange* operation.  
  
## Syntax  
  
```  
template <class Ty>  
inline bool atomic_compare_exchange_weak_explicit(  
   volatile atomic<Ty> *Atom,  
   Ty *Exp,  
   Ty Value,  
   memory_order Order1,  
   memory_order Order2  
) _NOEXCEPT;  
template <class Ty>  
inline bool atomic_compare_exchange_weak_explicit(  
   atomic<Ty> *Atom,  
   Ty *Exp,  
   Ty Value,  
   memory_order Order1,  
   memory_order Order2  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that stores a value of type `Ty`.  
  
 `Exp`  
 A pointer to a value of type `Ty`.  
  
 `Value`  
 A value of type `Ty`.  
  
 `Order1`  
 First [memory_order](../vs140/memory_order-enum.md) argument.  
  
 `Order2`  
 Second `memory_order` argument. The value of `Order2` cannot be `memory_order_release` or `memory_order_acq_rel`, nor can it be stronger than the value of `Order1`.  
  
## Return Value  
 A `bool` that indicates the result of the value comparison.  
  
## Remarks  
 An *atomic compare and exchange operation* compares the value that is stored in the object that is pointed to by `Atom` with the value that is pointed to by `Exp`. If the values are equal, the operation replaces the value that is stored in the object that is pointed to by `Atom` with `Val` by using a `read-modify-write` operation and applying the memory-order constraints that are specified by `Order1`. If the values are not equal, the operation replaces the value that is pointed to by `Exp` with the value that is stored in the object that is pointed to by `Atom` and applies the memory-order constraints that are specified by `Order2`.  
  
 A *weak* atomic compare and exchange operation performs an exchange if the compared values are equal. However, if the values are not equal, the operation is not guaranteed to perform an exchange.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)