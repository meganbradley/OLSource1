---
title: "atomic_load Function"
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
  - "atomic/std::atomic_load"
dev_langs: 
  - "C++"
ms.assetid: 852ae780-ac9a-4616-bc1d-ce8b20a71c6e
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_load Function
Retrieves the stored value in an `atomic` object.  
  
## Syntax  
  
```  
template <class Ty>  
inline Ty atomic_load(  
   const volatile atomic<Ty> *Atom) _NOEXCEPT;  
template <class Ty>  
inline Ty atomic_load(  
   const atomic<Ty> *Atom) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that contains a value of type `Ty`.  
  
## Return Value  
 The retrieved value that is stored in `Atom`.  
  
## Remarks  
 `atomic_load` implicitly uses the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_load_explicit](../vs140/atomic_load_explicit-function.md)