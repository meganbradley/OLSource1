---
title: "atomic_fetch_or Function"
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
  - "atomic/std::atomic_fetch_or"
dev_langs: 
  - "C++"
ms.assetid: 8f72895c-eb90-420b-8713-bd24eccedf2c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_or Function
Performs a bitwise `or` on a value and an existing value that is stored in an `atomic` object.  
  
## Syntax  
  
```  
template <class T>  
inline T atomic_fetch_or (  
   volatile atomic<T>* Atom,  
   T Value); noexcept  
template <class T>  
inline T atomic_fetch_or (  
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
 The `atomic_fetch_or` function performs a `read-modify-write` operation to replace the stored value of `Atom` with a bitwise `or` of `Value` and the current value that is stored in `Atom`, using the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_or_explicit](../vs140/atomic_fetch_or_explicit-function.md)