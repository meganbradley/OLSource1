---
title: "atomic_load_explicit Function"
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
  - "atomic/std::atomic_load_explicit"
dev_langs: 
  - "C++"
ms.assetid: baa97c0b-7ca1-49c4-aa5c-16c3ec33709c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_load_explicit Function
Retrieves the stored value in an `atomic` object, within a specified [memory_order](../vs140/memory_order-enum.md).  
  
## Syntax  
  
```  
template <class Ty>  
inline Ty atomic_load_explicit(  
   const volatile atomic<Ty> *Atom,  
   memory_order Order  
) _NOEXCEPT;  
template <class Ty>  
inline Ty atomic_load_explicit(  
   const atomic<Ty> *Atom,  
   memory_order Order  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that contains a value of type `Ty`.  
  
 `Order`  
 A [memory_order](../vs140/memory_order-enum.md). Do not use `memory_order_release` or `memory_order_acq_rel`.  
  
## Return Value  
 The retrieved value that is stored in `Atom`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)