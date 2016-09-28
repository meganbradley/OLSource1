---
title: "atomic_flag_test_and_set Function"
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
  - "atomic/std::atomic_flag_test_and_set"
dev_langs: 
  - "C++"
ms.assetid: 5675db52-7315-47ef-acf7-746fe98410fc
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_flag_test_and_set Function
Sets the `bool` flag in an [atomic_flag](../vs140/atomic_flag-structure.md) object to `true`, within the constraints of the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md).  
  
## Syntax  
  
```  
inline bool atomic_flag_test_and_set(  
   volatile atomic_flag *Flag,  
) _NOEXCEPT;  
inline bool atomic_flag_test_and_set(  
   atomic_flag *Flag,  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Flag`  
 A pointer to an `atomic_flag` object.  
  
## Return Value  
 The initial value of `Flag`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)