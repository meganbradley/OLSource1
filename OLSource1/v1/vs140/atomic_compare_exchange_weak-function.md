---
title: "atomic_compare_exchange_weak Function"
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
  - "atomic/std::atomic_compare_exchange_weak"
dev_langs: 
  - "C++"
ms.assetid: 2353700e-4e63-44fa-8242-90b9dc8e56ca
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_compare_exchange_weak Function
Performs a *weak atomic compare and exchange* operation.  
  
## Syntax  
  
```  
template <class Ty>  
inline bool atomic_compare_exchange_strong(  
   volatile atomic<Ty> *Atom,  
   Ty *Exp,  
   Ty Value  
) _NOEXCEPT;  
template <class Ty>  
inline bool atomic_compare_exchange_strong(  
   atomic<Ty> *Atom,  
   Ty *Exp,  
   TyValue  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that stores a value of type `Ty`.  
  
 `Exp`  
 A pointer to a value of type `Ty`.  
  
 `Value`  
 A value of type `Ty`.  
  
## Return Value  
 A `bool` that indicates the result of the value comparison.  
  
## Remarks  
 This method performs a *weak atomic compare and exchange operation* that has implicit `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md) arguments. For more information, see [atomic_compare_exchange_weak_explicit Function](../vs140/atomic_compare_exchange_weak_explicit-function.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)