---
title: "shared_ptr::operator="
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
  - "memory/std::tr1::shared_ptr::operator="
  - "operator="
  - "shared_ptr.operator="
  - "shared_ptr::operator="
  - "tr1::shared_ptr::operator="
  - "std::tr1::shared_ptr::operator="
  - "tr1.shared_ptr.operator="
  - "std.tr1.shared_ptr.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
  - "operator="
ms.assetid: 99be34c1-2c13-4119-964d-ce0a7e341337
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::operator=
Replaces the owned resource.  
  
## Syntax  
  
```  
shared_ptr& operator=(const shared_ptr& sp);  
template<class Other>  
    shared_ptr& operator=(const shared_ptr<Other>& sp);  
template<class Other>  
    shared_ptr& operator=(auto_ptr<Other>& ap);  
template<class Other>  
    shared_ptr& operator=(auto_ptr<Other>& ap);  
template<class Other>  
    shared_ptr& operator=(auto_ptr<Other>&& ap);  
template<class Other, class Deletor>  
    shared_ptr& operator=(unique_ptr<Other, Deletor>&& ap);  
```  
  
#### Parameters  
 `sp`  
 The shared pointer to copy.  
  
 `ap`  
 The auto pointer to copy.  
  
## Remarks  
 The operators all decrement the reference count for the resource currently owned by `*this` and assign ownership of the resource named by the operand sequence to `*this`. If the reference count falls to zero, the resource is released. If an operator fails it leaves `*this` unchanged.  
  
## Example  
  
```  
// std_tr1__memory__shared_ptr_operator_as.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0;   
    std::shared_ptr<int> sp1(new int(5));   
    std::auto_ptr<int> ap(new int(10));   
  
    sp0 = sp1;   
    std::cout << "*sp0 == " << *sp0 << std::endl;   
  
    sp0 = ap;   
    std::cout << "*sp0 == " << *sp0 << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **\*sp0 == 5**  
**\*sp0 == 10**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::reset](../vs140/shared_ptr--reset.md)