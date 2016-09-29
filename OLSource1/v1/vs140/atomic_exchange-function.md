---
title: "atomic_exchange Function"
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
  - "atomic/std::atomic_exchange"
dev_langs: 
  - "C++"
ms.assetid: c4d665b8-5749-4f00-910b-9d9aee30d5f7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_exchange Function
Uses `Value` to replace the stored value of `Atom`.  
  
## Syntax  
  
```  
template <class _Ty>  
inline Ty atomic_exchange(  
   volatile atomic<Ty> *_Atom,  
   TyValue  
) _NOEXCEPT;  
template <class Ty>  
inline _Ty atomic_exchange(  
   atomic<Ty> *Atom,  
   TyValue  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that stores a value of type `Ty`.  
  
 `Value`  
 A value of type `Ty`.  
  
## Return Value  
 The stored value of `Atom` before the exchange.  
  
## Remarks  
 The `atomic_exchange` function performs a `read-modify-write` operation to exchange the value that is stored in `Atom` with `Value`, using the `memory_order_seq_cst`[memory_order](../vs140/memory_order-enum.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_exchange_explicit](../vs140/atomic_exchange_explicit-function.md)