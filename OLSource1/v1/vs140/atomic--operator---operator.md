---
title: "atomic::operator++ Operator"
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
  - "atomic/std::atomic::operator++"
dev_langs: 
  - "C++"
ms.assetid: 492959e9-1ea8-4e02-a031-82b1b92e91a0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::operator++ Operator
Increments the stored value. Used only by integral and pointer specializations.  
  
## Syntax  
  
```  
Ty atomic<Ty>::operator++(int) volatile _NOEXCEPT;  
Ty atomic<Ty>::operator++(int) _NOEXCEPT;  
Ty atomic<Ty>::operator++() volatile _NOEXCEPT;  
Ty atomic<Ty>::operator++() _NOEXCEPT;  
```  
  
## Return Value  
 The first two operators return the incremented value; the last two operators return the value before the increment. The operators use the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic Structure](../vs140/atomic-structure.md)   
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic_fetch_add_explicit](../vs140/atomic_fetch_add_explicit-function.md)