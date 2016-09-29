---
title: "atomic_store_explicit Function"
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
  - "atomic/std::atomic_store_explicit"
dev_langs: 
  - "C++"
ms.assetid: daae6724-56d9-43d7-a174-c208b5dea3a3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_store_explicit Function
Atomically stores a value in an atomic object.  
  
## Syntax  
  
```  
template <class Ty>  
inline Ty atomic_store_explicit(  
   const volatile atomic<Ty> *Atom,   Ty Value,  
   memory_order Order  
) _NOEXCEPT;  
template <class Ty>  
inline Ty atomic_store_explicit(  
   const atomic<Ty> *Atom,  
   _TyValue,  
   memory_order Order  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that contains a value of type `Ty`.  
  
 `Value`  
 A value of type `Ty`.  
  
 `Order`  
 A [memory_order](../vs140/memory_order-enum.md). Do not use `memory_order_consume`, `memory_order_acquire`, or `memory_order_acq_rel`.  
  
## Remarks  
 `atomic_store` stores `Value` in the object that is pointed to by `Atom`, within the `memory_order` that is specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)