---
title: "weak_ptr::reset"
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
  - "std.tr1.weak_ptr.reset"
  - "std::tr1::weak_ptr::reset"
  - "memory/std::tr1::weak_ptr::reset"
  - "reset"
  - "weak_ptr::reset"
  - "tr1.weak_ptr.reset"
  - "weak_ptr.reset"
  - "tr1::weak_ptr::reset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reset method [TR1]"
  - "reset method"
ms.assetid: c6eac0ce-b5c3-41f4-a19f-c75a3f3f55d7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::reset
Releases owned resource.  
  
## Syntax  
  
```  
void reset();  
```  
  
## Remarks  
 The member function releases the resource pointed to by `*this` and converts `*this` to an empty weak_ptr object.  
  
## Example  
  
```  
// std_tr1__memory__weak_ptr_reset.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp(new int(5));   
    std::weak_ptr<int> wp(sp);   
    std::cout << "*wp.lock() == " << *wp.lock() << std::endl;   
    std::cout << "wp.expired() == " << std::boolalpha   
        << wp.expired() << std::endl;   
  
    wp.reset();   
    std::cout << "wp.expired() == " << std::boolalpha   
        << wp.expired() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **\*wp.lock() == 5**  
**wp.expired() == false**  
**wp.expired() == true**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)   
 [weak_ptr::operator=](../vs140/weak_ptr--operator=.md)