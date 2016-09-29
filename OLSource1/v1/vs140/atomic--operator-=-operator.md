---
title: "atomic::operator&amp;= Operator"
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
  - "atomic/std::atomic::operator&="
dev_langs: 
  - "C++"
ms.assetid: 90e730ac-12e1-4abb-98f5-4eadd6861a89
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::operator&amp;= Operator
Performs a bitwise `and` on a specified value and the stored value of `*this`. Used only by integral specializations.  
  
## Syntax  
  
```vb  
atomic<Ty>::operator&= (  
   Ty Value  
) volatile _NOEXCEPT;  
atomic<Ty>::operator&= (  
   Ty Value  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Value`  
 A value of type `Ty`.  
  
## Return Value  
 The result of the bitwise `and`.  
  
## Remarks  
 This operator performs a `read-modify-write` operation to replace the stored value of `*this` with a bitwise `and` of `Value` and the current value that is stored in `*this`, within the constraints of the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic Structure](../vs140/atomic-structure.md)   
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic::operator&#124;=](../vs140/atomic--operator-=-operator.md)   
 [atomic::operator^=](../vs140/atomic--operator^=-operator.md)   
 [atomic_fetch_and_explicit](../vs140/atomic_fetch_add_explicit-function.md)