---
title: "atomic_fetch_and_explicit Function"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - atomic/std::atomic_fetch_and_explicit
dev_langs: 
  - C++
ms.assetid: 678f8a06-4379-41bc-a5e1-d51a487bacf9
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# atomic_fetch_and_explicit Function
Performs a bitwise `and` of a value and an existing value that is stored in an `atomic` object.  
  
## Syntax  
  
```  
template <class T>  
inline T atomic_fetch_and_explicit(  
   volatile atomic<T>* Atom,  
   T Value,  
   memory_order Order); noexcepttemplate <class T>  
inline T atomic_fetch_and_explicit(  
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
 The `atomic_fetch_and_explicit` function performs a `read-modify-write` operation to replace the stored value of `Atom` with a bitwise `and` of `Value` and the current value that is stored in `Atom`, within the memory constraints that are specified by `Order`.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [<atomic\>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_and](../vs140/atomic_fetch_and-function.md)