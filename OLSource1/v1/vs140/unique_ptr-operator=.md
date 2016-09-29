---
title: "unique_ptr operator="
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
  - "="
  - "operator="
  - "unique_ptr::operator="
  - "unique_ptr.operator="
  - "memory/std::unique_ptr::operator="
  - "std.unique_ptr.operator="
  - "std::unique_ptr::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator"
ms.assetid: 2435e903-d7ef-4fa9-8b88-7c0a8b15115a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_ptr operator=
Assigns the address of the provided `unique_ptr` to the current one.  
  
## Syntax  
  
```  
unique_ptr& operator=(  
    unique_ptr&& _Right  
);  
template<class Type2, Class Del2>  
    unique_ptr& operator=(  
        unique_ptr<Type, Del>&& _Right  
    );  
unique_ptr& operator=(  
    pointer-type  
);  
```  
  
#### Parameters  
 A `unique_ptr` reference used to assign the value of to the current `unique_ptr`.  
  
## Remarks  
 The member functions call `reset(``_Right``.release())` and move `_Right``.stored_deleter` to `stored_deleter`, then return `*this`.  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [unique_ptr Class](../vs140/unique_ptr-class.md)   
 [<memory\>](../vs140/-memory-.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)