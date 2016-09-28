---
title: "atomic::fetch_xor Method"
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
  - "atomic/std::atomic::fetch_xor"
dev_langs: 
  - "C++"
ms.assetid: 92bbaff8-ee29-4a1e-aee4-d9d405285bfe
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::fetch_xor Method
Performs a bitwise `exclusive or` on a value and an existing value that is stored in `*this`.  
  
## Syntax  
  
```  
Ty atomic<Ty>::fetch_xor (  
   Ty Value,  
   memory_order Order = memory_order_seq_cst  
) volatile _NOEXCEPT;  
Ty atomic<Ty>::fetch_xor (  
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
 A `Ty` object that contains the result of the bitwise `exclusive or`.  
  
## Remarks  
 The `fetch_xor` method performs a `read-modify-write` operation to replace the stored value of `*this` with a bitwise `exclusive or` of `Value` and the current value that is stored in `*this`, and applies the memory constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_xor_explicit](../vs140/atomic_fetch_xor_explicit-function.md)