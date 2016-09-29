---
title: "atomic::fetch_add Method"
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
  - "atomic/std::atomic::fetch_add"
dev_langs: 
  - "C++"
ms.assetid: c68b91f2-6e8a-4ffa-8991-6bb6d466e1f3
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# atomic::fetch_add Method
Fetches the value stored in `*this`, and then adds a specified value to the stored value.  
  
## Syntax  
  
```  
Ty atomic<Ty>::fetch_add (  
   Ty Value,  
   memory_order Order = memory_order_seq_cst  
) volatile _NOEXCEPT;  
Ty atomic<Ty>::fetch_add (  
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
 A `Ty` object that contains the value stored in `*this` prior to the addition.  
  
## Remarks  
 The `fetch_add` method performs a `read-modify-write` operation to atomically add `Value` to the stored value in `*this`, and applies the memory constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_add_explicit](../vs140/atomic_fetch_add_explicit-function.md)