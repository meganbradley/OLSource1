---
title: "atomic_fetch_and Function"
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
  - "atomic/std::atomic_fetch_and"
dev_langs: 
  - "C++"
ms.assetid: 97dec0f9-3ec3-4c0e-8c9b-6e4fb19e631f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_and Function
Performs a bitwise `and` on a value and an existing value that is stored in an `atomic` object.  
  
## Syntax  
  
```  
template <class T>  
inline T atomic_fetch_and(  
   volatile atomic<T>* Atom,  
   T Value); noexcept  
template <class T>  
inline T atomic_fetch_and(  
   volatile atomic<T>* Atom,  
   T Value); noexcept  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that stores a value of type `T`.  
  
 `Value`  
 A value of type `T`.  
  
## Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
## Remarks  
 The `atomic_fetch_and` function performs a `read-modify-write` operation to replace the stored value of `Atom` with a bitwise `and` of `Value` and the current value that is stored in `Atom`, using the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md) constraint.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_and_explicit](../vs140/atomic_fetch_and_explicit-function.md)