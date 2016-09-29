---
title: "atomic_flag::test_and_set Method"
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
  - "atomic/std::atomic_flag::test_and_set"
dev_langs: 
  - "C++"
ms.assetid: 1a32e921-2a84-4090-9bae-0a2331e1b683
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_flag::test_and_set Method
Sets the `bool` flag that is stored in `*this` to `true`, within the specified [memory_order](../vs140/memory_order-enum.md) constraints.  
  
## Syntax  
  
```  
bool atomic_flag::test_and_set(  
   memory_order Order = memory_order_seq_cst  
) volatile _NOEXCEPT;  
bool atomic_flag::test_and_set(  
   memory_order Order = memory_order_seq_cst  
) _NOEXCEPT;  
  
```  
  
#### Parameters  
 `Order`  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 The initial value of the flag that is stored in `*this`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic_flag Structure](../vs140/atomic_flag-structure.md)   
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic_flag_test_and_set_explicit](../vs140/atomic_flag_test_and_set_explicit-function.md)