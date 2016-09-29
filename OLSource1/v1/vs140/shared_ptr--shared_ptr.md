---
title: "shared_ptr::shared_ptr"
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
  - "shared_ptr"
  - "memory/std::tr1::shared_ptr::shared_ptr"
  - "tr1::shared_ptr::shared_ptr"
  - "shared_ptr::shared_ptr"
  - "shared_ptr.shared_ptr"
  - "tr1.shared_ptr.shared_ptr"
  - "std.tr1.shared_ptr.shared_ptr"
  - "std::tr1::shared_ptr::shared_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared_ptr method"
  - "shared_ptr constructor [TR1]"
ms.assetid: 054bdc0c-b055-42e4-b0e2-dcb097bf83cf
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::shared_ptr
Constructs a `shared_ptr`.  
  
## Syntax  
  
```  
shared_ptr();  
shared_ptr(nullptr_t);   
shared_ptr(const shared_ptr& sp);  
shared_ptr(shared_ptr&& sp);   
template<class Other>  
    explicit shared_ptr(Other *ptr);  
template<class Other, class D>  
    shared_ptr(Other *ptr, D dtor);  
template<class D>  
    shared_ptr(nullptr_t ptr, D dtor);  
template<class Other, class D, class A>  
    shared_ptr(Other *ptr, D dtor, A alloc);  
template<class D, class A>  
    shared_ptr(nullptr_t ptr, D dtor, A alloc);  
template<class Other>  
    shared_ptr(const shared_ptr<Other>& sp);  
template<class Other>  
    shared_ptr(const weak_ptr<Other>& wp);  
template<class &>  
    shared_ptr(std::auto_ptr<Other>& ap);  
template<class &>  
    shared_ptr(std::auto_ptr<Other>&& ap);  
template<class Other, class D>  
    shared_ptr(unique_ptr<Other, D>&& up);  
template<class Other>  
    shared_ptr(const shared_ptr<Other>& sp, Ty *ptr);  
template<class Other, class D>  
    shared_ptr(const unique_ptr<Other, D>& up) = delete;  
```  
  
#### Parameters  
 `Other`  
 The type controlled by the argument pointer.  
  
 `ptr`  
 The pointer to copy.  
  
 `D`  
 The type of the deleter.  
  
 `A`  
 The type of the allocator.  
  
 `dtor`  
 The deleter.  
  
 `ator`  
 The allocator.  
  
 `sp`  
 The smart pointer to copy.  
  
 `wp`  
 The weak pointer.  
  
 `ap`  
 The auto pointer to copy.  
  
## Remarks  
 The constructors each construct an object that owns the resource named by the operand sequence. The constructor `shared_ptr(const weak_ptr<Other>& wp)` throws an exception object of type [bad_weak_ptr](../vs140/bad_weak_ptr-class.md) if `wp.expired()`.  
  
## Example  
  
```  
// std_tr1__memory__shared_ptr_construct.cpp   
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
    std::shared_ptr<int> sp0;   
    std::cout << "(bool)sp0 == " << std::boolalpha   
        << (bool)sp0 << std::endl;   
  
    std::shared_ptr<int> sp1(new int(5));   
    std::cout << "*sp1 == " << *sp1 << std::endl;   
  
    std::shared_ptr<int> sp2(new int(10), deleter());   
    std::cout << "*sp2 == " << *sp2 << std::endl;   
  
    std::shared_ptr<int> sp3(sp2);   
    std::cout << "*sp3 == " << *sp3 << std::endl;   
  
    std::weak_ptr<int> wp(sp3);   
    std::shared_ptr<int> sp4(wp);   
    std::cout << "*sp4 == " << *sp4 << std::endl;   
  
    std::auto_ptr<int> ap(new int(15));   
    std::shared_ptr<int> sp5(ap);   
    std::cout << "*sp5 == " << *sp5 << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **(bool)sp0 == false**  
**\*sp1 == 5**  
**\*sp2 == 10**  
**\*sp3 == 10**  
**\*sp4 == 10**  
**\*sp5 == 15**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)