---
title: "atomic_fetch_xor_explicit Function"
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
  - "atomic/std::atomic_fetch_xor_explicit"
dev_langs: 
  - "C++"
ms.assetid: 02b8a2ec-e7f8-4471-98b8-43b645bf5f1f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_xor_explicit Function
Performs a bitwise `exclusive or` on a value and an existing value that is stored in an `atomic` object.  
  
## Syntax  
  
```  
template <class T>  
inline T atomic_fetch_xor_explicit(  
   volatile atomic<T>* Atom,  
   T Value,  
   memory_order Order); noexcepttemplate <class T>  
inline T atomic_fetch_xor_explicit(  
   volatile atomic<T>* Atom,  
   T Value,  
   memory_order Order); noexcept  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that stores a value of type `T`.  
  
 `Value`  
 A value of type `T`.  
  
 `Order`  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
## Remarks  
 The `atomic_fetch_xor_explicit` function performs a `read-modify-write` operation to replace the stored value of `Atom` with a bitwise `exclusive or` of `Value` and the current value that is stored in `Atom`, within the [memory_order](../vs140/memory_order-enum.md) constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_xor](../vs140/atomic_fetch_xor-function.md)