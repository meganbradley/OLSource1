---
title: "weak_ptr::weak_ptr"
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
  - weak_ptr
  - std::tr1::weak_ptr::weak_ptr
  - weak_ptr::weak_ptr
  - weak_ptr.weak_ptr
  - memory/std::tr1::weak_ptr::weak_ptr
  - std.tr1.weak_ptr.weak_ptr
  - tr1.weak_ptr.weak_ptr
  - tr1::weak_ptr::weak_ptr
dev_langs: 
  - C++
helpviewer_keywords: 
  - weak_ptr constructor [TR1]
  - weak_ptr method
ms.assetid: 6306b77d-2ae4-4201-b21b-9efef89e828d
caps.latest.revision: 18
translation.priority.mt: 
  - de-de
  - ja-jp
---
# weak_ptr::weak_ptr
Constructs a `weak_ptr`.  
  
## Syntax  
  
```  
weak_ptr();  
weak_ptr(const weak_ptr& wp);  
template<class Other>  
    weak_ptr(const weak_ptr<Other>& wp);  
template<class Other>  
    weak_ptr(const shared_ptr<Other>& sp);  
```  
  
#### Parameters  
 `Other`  
 The type controlled by the argument shared/weak pointer.  
  
 `wp`  
 The weak pointer to copy.  
  
 `sp`  
 The shared pointer to copy.  
  
## Remarks  
 The constructors each construct an object that points to the resource named by the operand sequence.  
  
## Example  
  
```  
// std_tr1__memory__weak_ptr_construct.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::weak_ptr<int> wp0;   
    std::cout << "wp0.expired() == " << std::boolalpha   
        << wp0.expired() << std::endl;   
  
    std::shared_ptr<int> sp1(new int(5));   
    std::weak_ptr<int> wp1(sp1);   
    std::cout << "*wp1.lock() == "   
        << *wp1.lock() << std::endl;   
  
    std::weak_ptr<int> wp2(wp1);   
    std::cout << "*wp2.lock() == "   
        << *wp2.lock() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **wp0.expired() == true**  
**\*wp1.lock() == 5**  
**\*wp2.lock() == 5**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)