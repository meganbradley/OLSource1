---
title: "weak_ptr::owner_before"
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
  - "owner_before"
  - "std::tr1::weak_ptr::owner_before"
  - "weak_ptr.owner_before"
  - "weak_ptr::owner_before"
  - "std.tr1.weak_ptr.owner_before"
  - "memory/std::tr1::weak_ptr::owner_before"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "owner_before method"
ms.assetid: 3f13676c-4df4-4190-8974-5116bdeae479
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::owner_before
Returns `true` if this `weak_ptr` is ordered before (or less than) the provided pointer.  
  
## Syntax  
  
```  
template<class Other>  
    bool owner_before(const shared_ptr<Other>& ptr);  
template<class Other>  
    bool owner_before(const weak_ptr<Other>& ptr);  
```  
  
#### Parameters  
 `ptr`  
 An `lvalue` reference to either a `shared_ptr` or a `weak_ptr`.  
  
## Property Value/Return Value  
 Returns `true` if this `weak_ptr` sorts before the pointer parameter, `false` if not.  
  
## Remarks  
 The template member function returns `true` if `*this` is `ordered before``ptr`.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr Class](../vs140/weak_ptr-class.md)   
 [\<memory>](../vs140/-memory-.md)