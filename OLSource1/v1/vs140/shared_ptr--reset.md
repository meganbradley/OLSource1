---
title: "shared_ptr::reset"
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
  - shared_ptr.reset
  - tr1::shared_ptr::reset
  - shared_ptr::reset
  - memory/std::tr1::shared_ptr::reset
  - std.tr1.shared_ptr.reset
  - reset
  - tr1.shared_ptr.reset
  - std::tr1::shared_ptr::reset
dev_langs: 
  - C++
helpviewer_keywords: 
  - reset method [TR1]
  - reset method
ms.assetid: b1bc65d6-d613-495b-b46e-da59164afc56
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# shared_ptr::reset
Replace owned resource.  
  
## Syntax  
  
```  
void reset();  
template<class Other>  
    void reset(Other *ptr;);  
template<class Other, class D>  
    void reset(Other *ptr, D dtor);  
template<class Other, class D, class A>  
    void reset(Other *ptr, D dtor, A alloc);  
```  
  
#### Parameters  
 `Other`  
 The type controlled by the argument pointer.  
  
 `D`  
 The type of the deleter.  
  
 `ptr`  
 The pointer to copy.  
  
 `dtor`  
 The deleter to copy.  
  
 `A`  
 The type of the allocator.  
  
 `alloc`  
 The allocator to copy.  
  
## Remarks  
 The operators all decrement the reference count for the resource currently owned by `*this` and assign ownership of the resource named by the operand sequence to `*this`. If the reference count falls to zero, the resource is released. If an operator fails it leaves `*this` unchanged.  
  
## Example  
  
```  
// std_tr1__memory__shared_ptr_reset.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
struct deleter   
    {   
    void operator()(int *p)   
        {   
        delete p;   
        }   
    };   
  
int main()   
    {   
    std::shared_ptr<int> sp(new int(5));   
  
    std::cout << "*sp == " << std::boolalpha   
        << *sp << std::endl;   
  
    sp.reset();   
    std::cout << "(bool)sp == " << std::boolalpha   
        << (bool)sp << std::endl;   
  
    sp.reset(new int(10));   
    std::cout << "*sp == " << std::boolalpha   
        << *sp << std::endl;   
  
    sp.reset(new int(15), deleter());   
    std::cout << "*sp == " << std::boolalpha   
        << *sp << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **\*sp == 5**  
**(bool)sp == false**  
**\*sp == 10**  
**\*sp == 15**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::operator=](../vs140/shared_ptr--operator=.md)