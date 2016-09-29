---
title: "atomic_init Function"
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
  - "atomic/std::atomic_init"
dev_langs: 
  - "C++"
ms.assetid: 707e0007-df3e-4c4f-978a-34ffbf4f7af0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_init Function
Sets the stored value in an `atomic` object.  
  
## Syntax  
  
```  
template <class Ty>  
inline void atomic_init(  
   volatile atomic<Ty> *Atom,  
   Ty Value  
) _NOEXCEPT;  
template <class Ty>  
inline void atomic_init(  
   atomic<Ty> *Atom,  
   TyValue  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Atom`  
 A pointer to an `atomic` object that stores a value of type `Ty`.  
  
 `Value`  
 A value of type `Ty`.  
  
## Remarks  
 `atomic_init` is not an atomic operation. It is not thread-safe.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)