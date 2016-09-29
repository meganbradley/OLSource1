---
title: "weak_ptr::operator="
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
  - "operator="
  - "tr1.weak_ptr.operator="
  - "std::tr1::weak_ptr::operator="
  - "std.tr1.weak_ptr.operator="
  - "memory/std::tr1::weak_ptr::operator="
  - "weak_ptr::operator="
  - "weak_ptr.operator="
  - "tr1::weak_ptr::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
  - "operator="
ms.assetid: 1ffb152e-0f54-4376-9ed3-10cf7588a036
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::operator=
Replaces owned resource.  
  
## Syntax  
  
```  
weak_ptr& operator=(const weak_ptr& wp);  
template<class Other>  
    weak_ptr& operator=(const weak_ptr<Other>& wp);  
template<class Other>  
    weak_ptr& operator=(const shared_ptr<Other>& sp);  
```  
  
#### Parameters  
 `Other`  
 The type controlled by the argument shared/weak pointer.  
  
 `wp`  
 The weak pointer to copy.  
  
 `sp`  
 The shared pointer to copy.  
  
## Remarks  
 The operators all release the resource currently pointed to by `*this` and assign ownership of the resource named by the operand sequence to `*this`. If an operator fails it leaves `*this` unchanged.  
  
## Example  
  
```  
// std_tr1__memory__weak_ptr_operator_as.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0(new int(5));   
    std::weak_ptr<int> wp0(sp0);   
    std::cout << "*wp0.lock() == " << *wp0.lock() << std::endl;   
  
    std::shared_ptr<int> sp1(new int(10));   
    wp0 = sp1;   
    std::cout << "*wp0.lock() == " << *wp0.lock() << std::endl;   
  
    std::weak_ptr<int> wp1;   
    wp1 = wp0;   
    std::cout << "*wp1.lock() == " << *wp1.lock() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **\*wp0.lock() == 5**  
**\*wp0.lock() == 10**  
**\*wp1.lock() == 10**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)   
 [weak_ptr::reset](../vs140/weak_ptr--reset.md)