---
title: "atomic::exchange Method"
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
  - "atomic/std::atomic::exchange"
dev_langs: 
  - "C++"
ms.assetid: a1a72697-2a2a-45b4-a299-93bbffebe1c5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::exchange Method
Uses a specified value to replace the stored value of `*this`.  
  
## Syntax  
  
```  
Ty atomic<Ty>::exchange(  
   Ty Value,  
   memory_order Order = memory_order_seq_cst  
) volatile _NOEXCEPT;  
Ty atomic<Ty>::exchange(  
   Ty Value,  
   memory_order Order = memory_order_seq_cst  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Value`  
 A value of type `Ty`.  
  
 `Order`  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 The stored value of `*this` before the exchange.  
  
## Remarks  
 This operation performs a `read-modify-write` operation to use `Value` to replace the value that is stored in `*this`, within the memory constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_exchange_explicit](../vs140/atomic_exchange_explicit-function.md)