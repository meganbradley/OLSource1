---
title: "atomic::fetch_sub Method"
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
  - "atomic/std::atomic::fetch_sub"
dev_langs: 
  - "C++"
ms.assetid: 8cc80d4b-0942-45a3-9db8-bbf339a903e4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::fetch_sub Method
Subtracts a specified value from the stored value.  
  
## Syntax  
  
```  
Ty atomic<Ty>::fetch_sub (  
   Ty Value,  
   memory_order Order = memory_order_seq_cst  
) volatile _NOEXCEPT;  
Ty atomic<Ty>::fetch_sub (  
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
 A `Ty` object that contains the result of the subtraction.  
  
## Remarks  
 The `fetch_sub` method performs a `read-modify-write` operation to atomically subtract `Value` from the stored value in `*this`, within the memory constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_sub_explicit](../vs140/atomic_fetch_sub_explicit-function.md)