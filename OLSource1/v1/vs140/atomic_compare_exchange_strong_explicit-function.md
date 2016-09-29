---
title: "atomic_compare_exchange_strong_explicit Function"
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
  - "atomic/std::atomic_compare_exchange_strong_explicit"
dev_langs: 
  - "C++"
ms.assetid: 54e12e84-d6c8-4a84-a2a5-112595335e82
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_compare_exchange_strong_explicit Function
Performs an *atomic compare and exchange* operation.  
  
## Syntax  
  
```  
template <class _Ty>  
inline bool atomic_compare_exchange_strong_explicit(  
   volatile atomic<Ty> *Atom,  
   Ty *Exp,  
   Ty Value,  
   memory_order Order1,  
   memory_order Order2  
) _NOEXCEPT;  
  
template <class Ty>  
inline bool atomic_compare_exchange_strong_explicit(  
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
 Second `memory_order` argument. The value of `Order2` cannot be `memory_order_release` or `memory_order_acq_rel`, it cannot be stronger than the value of `Order1`.  
  
## Return Value  
 A `bool` that indicates the result of the value comparison.  
  
## Remarks  
 An *atomic compare and exchange operation* compares the value that is stored in the object that is pointed to by `Atom` against the value that is pointed to by `Exp`. If the values are equal, the the value that is stored in the object that is pointed to by `atom` is replaced with `Val` by using a `read-modify-write` operation and applying the memory order constraints that are specified by `Order1`. If the values are not equal, the operation replaces the value that is pointed to by `Exp` with the value that is stored in the object that is pointed to by `Atom` and applies the memory order constraints that are specified by `Order2`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)