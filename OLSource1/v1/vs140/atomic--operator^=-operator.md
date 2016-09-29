---
title: "atomic::operator^= Operator"
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
  - "atomic/std::atomic::operator^="
dev_langs: 
  - "C++"
ms.assetid: f2a4da9d-67e8-4249-9161-9998e72a33c2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::operator^= Operator
Performs a bitwise `exclusive or` on a specified value and the stored value of `*this`. Used only by integral specializations.  
  
## Syntax  
  
```vb  
atomic<Ty>::operator^= (  
   Ty Value  
) volatile _NOEXCEPT;  
atomic<Ty>::operator^= (  
   Ty Value  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Value`  
 A value of type `Ty`.  
  
## Return Value  
 The result of the bitwise `exclusive or`.  
  
## Remarks  
 This operator performs a `read-modify-write` operation to replace the stored value of `*this` with a bitwise `exclusive or` of `Value` and the current value that is stored in `*this`, within the constraints of the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md) constraints.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic Structure](../vs140/atomic-structure.md)   
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic::operator&=](../vs140/atomic--operator-=-operator.md)   
 [atomic::operator&#124;=](../vs140/atomic--operator-=-operator.md)   
 [atomic_fetch_xor_explicit](../vs140/atomic_fetch_xor_explicit-function.md)