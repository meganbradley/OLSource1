---
title: "atomic_store Function"
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
  - "atomic/std::atomic_store"
dev_langs: 
  - "C++"
ms.assetid: 9c6a89c3-314d-4ad5-8144-e4d783edff94
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_store Function
Atomically stores a value in an atomic object.  
  
## Syntax  
  
```  
template <class Ty>  
inline Ty atomic_store_explicit(  
   const volatile atomic<Ty> *Atom,  
   Ty Value  
) _NOEXCEPT;  
template <class Ty>  
inline Ty atomic_store_explicit(  
   const atomic<Ty> *Atom,  
   _Ty Value  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an atomic object that contains a value of type `Ty`.  
  
 `Value`  
 A value of type `Ty`.  
  
## Remarks  
 `atomic_store` stores `Value` in the object that is pointed to by `Atom`, within the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md) constraint.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_store_explicit](../vs140/atomic_store_explicit-function.md)