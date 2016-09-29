---
title: "atomic::store Method"
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
  - "atomic/std::atomic::store"
dev_langs: 
  - "C++"
ms.assetid: 84759413-d664-47ef-a1f3-a73c5a62007b
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# atomic::store Method
Stores a specified value.  
  
## Syntax  
  
```  
void atomic<Ty>::store(  
   Ty Value,  
   memory_order Order = memory_order_seq_cst  
) volatile _NOEXCEPT;  
void atomic<Ty>::store(  
   Ty Value,  
   memory_order Order = memory_order_seq_cst  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Value`  
 A `Ty` object.  
  
 `Order`  
 A [memory_order](../vs140/memory_order-enum.md) constraint.  
  
## Remarks  
 This method atomically stores `Value` in `*this`, within the memory constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic Structure](../vs140/atomic-structure.md)   
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic::operator=](../vs140/atomic--operator=-operator.md)