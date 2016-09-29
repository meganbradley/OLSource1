---
title: "atomic::compare_exchange_weak Method"
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
  - "atomic/std::atomic::compare_exchange_weak"
dev_langs: 
  - "C++"
ms.assetid: e15e421a-f7a3-4272-993a-f487d2242e4f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::compare_exchange_weak Method
Performs a *weak atomic compare and exchange* operation on `*this`.  
  
## Syntax  
  
```  
bool compare_exchange_weak(  
   Ty& Exp,  
   Ty Value,  
   memory_order Order1,  
   memory_order Order2  
) volatile _NOEXCEPT;  
bool compare_exchange_weak(  
   Ty& Exp,  
   Ty Value,  
   memory_order Order1,  
   memory_order Order2  
) _NOEXCEPT;  
bool compare_exchange_weak(  
   Ty& Exp,  
   Ty Value,  
   memory_order Order1 = memory_order_seq_cst  
) volatile _NOEXCEPT;  
bool compare_exchange_weak(  
   Ty& Exp,  
   Ty Value,  
   memory_order Order1 = memory_order_seq_cst  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Exp`  
 A value of type `Ty`.  
  
 `Value`  
 A value of type `Ty`.  
  
 `Order1`  
 First [memory_order](../vs140/memory_order-enum.md) argument.  
  
 `Order2`  
 Second `memory_order` argument.  
  
## Return Value  
 A `bool` that indicates the result of the value comparison.  
  
## Remarks  
 This *atomic compare and exchange* operation compares the value that is stored in `*this` with `Exp`. If the values are equal, the operation replaces the value that is stored in `*this` with `Val` by using a `read-modify-write` operation and applying the memory order constraints that are specified by `Order1`. If the values are not equal, the operation uses the value that is stored in `*this` to replace `Exp` and applies the memory order constraints that are specified by `Order2`.  
  
 A *weak* atomic compare and exchange operation performs an exchange if the compared values are equal. If the values are not equal, the operation is not guaranteed to perform an exchange.  
  
 Overloads that do not have a second `memory_order` use an implicit `Order2` that is based on the value of `Order1`. If `Order1` is `memory_order_acq_rel`, `Order2` is `memory_order_acquire`. If `Order1` is `memory_order_release`, `Order2` is `memory_order_relaxed`. In all other cases, `Order2` is equal to `Order1`.  
  
 For overloads that take two `memory_order` parameters, the value of `Order2` must not be `memory_order_release` or `memory_order_acq_rel`, and must not be stronger than the value of `Order1`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic_compare_exchange_weak_explicit](../vs140/atomic_compare_exchange_weak_explicit-function.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [\<atomic>](../vs140/-atomic-.md)   
 [memory_order](../vs140/memory_order-enum.md)