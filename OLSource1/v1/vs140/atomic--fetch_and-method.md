---
title: "atomic::fetch_and Method"
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
  - "atomic/std::atomic::fetch_and"
dev_langs: 
  - "C++"
ms.assetid: a9c83001-b72c-4085-9640-f63f866714b9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::fetch_and Method
Performs a bitwise `and` on a value and an existing value that is stored in `*this`.  
  
## Syntax  
  
```  
Ty atomic<Ty>::fetch_and (  
   Ty Value,  
   memory_order Order = memory_order_seq_cst  
) volatile _NOEXCEPT;  
Ty atomic<Ty>::fetch_and (  
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
 A `Ty` object that contains the result of the bitwise `and`.  
  
## Remarks  
 The `fetch_and` method performs a `read-modify-write` operation to replace the stored value of `*this` with a bitwise `and` of `Value` and the current value that is stored in `*this`, within the memory constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_and_explicit](../vs140/atomic_fetch_and_explicit-function.md)