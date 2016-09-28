---
title: "swap (C++ Standard Library)"
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
  - "std.tr1.swap"
  - "std::tr1::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function [TR1]"
ms.assetid: fd328269-955b-4d79-8268-9038841e5c76
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (C++ Standard Library)
Swap two shared_ptr or weak_ptr objects.  
  
## Syntax  
  
```  
template<class Ty, class Other>  
    void swap(shared_ptr<Ty>& left, shared_ptr<Other>& right);  
template<class Ty, class Other>  
    void swap(weak_ptr<Ty>& left, weak_ptr<Other>& right);  
```  
  
#### Parameters  
 `Ty`  
 The type controlled by the left shared/weak pointer.  
  
 `Other`  
 The type controlled by the right shared/weak pointer.  
  
 `left`  
 The left shared/weak pointer.  
  
 `right`  
 The right shared/weak pointer.  
  
## Remarks  
 The template functions call `left.swap(right)`.  
  
## Example  
  
```  
// std_tr1__memory__swap.cpp   
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
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [weak_ptr](../vs140/weak_ptr-class.md)