---
title: "weak_ptr::swap"
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
  - "std.tr1.weak_ptr.swap"
  - "memory/std::tr1::weak_ptr::swap"
  - "std::tr1::weak_ptr::swap"
  - "weak_ptr.swap"
  - "swap"
  - "tr1.weak_ptr.swap"
  - "tr1::weak_ptr::swap"
  - "weak_ptr::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method [TR1]"
  - "swap method"
ms.assetid: c7fe1ff8-aec0-4c70-abdd-0dba6ccf8d57
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::swap
Swaps two `weak_ptr` objects.  
  
## Syntax  
  
```  
void swap(weak_ptr& wp);  
```  
  
#### Parameters  
 `wp`  
 The weak pointer to swap with.  
  
## Remarks  
 The member function leaves the resource originally pointed to by `*this` subsequently pointed to by `wp`, and the resource originally pointed to by `wp` subsequently pointed to by `*this`. The function does not change the reference counts for the two resources and it does not throw any exceptions.  
  
## Example  
  
```  
// std_tr1__memory__weak_ptr_swap.cpp   
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
    std::shared_ptr<int> sp1(new int(5));   
    std::shared_ptr<int> sp2(new int(10));   
    std::cout << "*sp1 == " << *sp1 << std::endl;   
  
    sp1.swap(sp2);   
    std::cout << "*sp1 == " << *sp1 << std::endl;   
  
    swap(sp1, sp2);   
    std::cout << "*sp1 == " << *sp1 << std::endl;   
    std::cout << std::endl;   
  
    std::weak_ptr<int> wp1(sp1);   
    std::weak_ptr<int> wp2(sp2);   
    std::cout << "*wp1 == " << *wp1.lock() << std::endl;   
  
    wp1.swap(wp2);   
    std::cout << "*wp1 == " << *wp1.lock() << std::endl;   
  
    swap(wp1, wp2);   
    std::cout << "*wp1 == " << *wp1.lock() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **\*sp1 == 5**  
**\*sp1 == 10**  
**\*sp1 == 5**  
**\*wp1 == 5**  
**\*wp1 == 10**  
**\*wp1 == 5**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)   
 [weak_ptr::operator=](../vs140/weak_ptr--operator=.md)