---
title: "atomic_exchange_explicit Function"
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
  - "atomic/std::atomic_exchange_explicit"
dev_langs: 
  - "C++"
ms.assetid: a49ec590-e1c0-4a98-95ce-22a5c0276aaa
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_exchange_explicit Function
Replaces the stored value of `Atom` with `Value`.  
  
## Syntax  
  
```  
template <class Ty>  
inline Ty atomic_exchange_explicit(  
   volatile atomic<Ty> *Atom,  
   Ty Value,  
   memory_order Order  
) _NOEXCEPT;  
template <class Ty>  
inline Ty atomic_exchange_explicit(  
   atomic<Ty> *Atom,  
   Ty Value,  
   memory_order Order  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that stores a value of type `Ty`.  
  
 `Value`  
 A value of type `Ty`.  
  
 `Order`  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 The stored value of `Atom` before the exchange.  
  
## Remarks  
 The `atomic_exchange_explicit` function performs a `read-modify-write` operation to exchange the value that is stored in `Atom` with `Value`, within the memory constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)