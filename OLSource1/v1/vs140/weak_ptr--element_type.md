---
title: "weak_ptr::element_type"
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
  - weak_ptr.element_type
  - std.tr1.weak_ptr.element_type
  - memory/std::tr1::weak_ptr::element_type
  - std::tr1::weak_ptr::element_type
  - weak_ptr::element_type
  - element_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - element_type typedef [TR1]
ms.assetid: 4e1d2b24-665d-4123-b0d6-db7c3586760d
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# weak_ptr::element_type
The type of the element.  
  
## Syntax  
  
```  
typedef Ty element_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Ty`.  
  
## Example  
  
```  
// std_tr1__memory__weak_ptr_element_type.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0(new int(5));   
    std::weak_ptr<int> wp0(sp0);   
    std::weak_ptr<int>::element_type val = *wp0.lock();   
  
    std::cout << "*wp0.lock() == " << val << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **\*wp0.lock() == 5**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)