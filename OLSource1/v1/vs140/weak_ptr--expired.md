---
title: "weak_ptr::expired"
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
  - tr1.weak_ptr.expired
  - std.tr1.weak_ptr.expired
  - tr1::weak_ptr::expired
  - expired
  - weak_ptr::expired
  - memory/std::tr1::weak_ptr::expired
  - weak_ptr.expired
  - std::tr1::weak_ptr::expired
dev_langs: 
  - C++
helpviewer_keywords: 
  - expired method
  - expired method [TR1]
ms.assetid: 3db1efb2-2c7f-4845-bca7-e664a36fdc38
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# weak_ptr::expired
Tests if ownership has expired.  
  
## Syntax  
  
```  
bool expired() const;  
```  
  
## Remarks  
 The member function returns `true` if `*this` has expired, otherwise `false`.  
  
## Example  
  
```  
// std_tr1__memory__weak_ptr_expired.cpp   
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
    std::weak_ptr<int> wp;   
  
     {   
    std::shared_ptr<int> sp(new int(10));   
    wp = sp;   
    std::cout << "wp.expired() == " << std::boolalpha   
        << wp.expired() << std::endl;   
    std::cout << "*wp.lock() == " << *wp.lock() << std::endl;   
     }   
  
// check expired after sp is destroyed   
    std::cout << "wp.expired() == " << std::boolalpha   
        << wp.expired() << std::endl;   
    std::cout << "(bool)wp.lock() == " << std::boolalpha   
        << (bool)wp.lock() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **wp.expired() == false**  
**\*wp.lock() == 10**  
**wp.expired() == true**  
**(bool)wp.lock() == false**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)