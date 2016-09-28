---
title: "atomic_flag::clear Method"
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
  - "atomic/std::atomic_flag::clear"
dev_langs: 
  - "C++"
ms.assetid: 2ecbc2f0-4e53-4a99-b8f5-1b2fa9e07c81
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_flag::clear Method
Sets the `bool` flag that is stored in `*this` to `false`, within the specified [memory_order](../vs140/memory_order-enum.md) constraints.  
  
## Syntax  
  
```  
void atomic_flag::clear(  
   memory_order Order = memory_order_seq_cst  
) volatile _NOEXCEPT;  
void atomic_flag::clear(  
   memory_order Order = memory_order_seq_cst  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Order`  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic_flag Structure](../vs140/atomic_flag-structure.md)   
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic_flag_clear_explicit](../vs140/atomic_flag_clear_explicit-function.md)