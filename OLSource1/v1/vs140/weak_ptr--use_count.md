---
title: "weak_ptr::use_count"
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
  - "use_count"
  - "memory/std::tr1::weak_ptr::use_count"
  - "weak_ptr::use_count"
  - "std.tr1.weak_ptr.use_count"
  - "weak_ptr.use_count"
  - "std::tr1::weak_ptr::use_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "use_count method [TR1]"
ms.assetid: 492b3e7a-183b-499b-948e-fb0403de2d07
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::use_count
Counts number of designated `shared_ptr` objects.  
  
## Syntax  
  
```  
long use_count() const;  
```  
  
## Remarks  
 The member function returns the number of `shared_ptr` objects that own the resource pointed to by `*this`.  
  
## Example  
  
```  
// std_tr1__memory__weak_ptr_use_count.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp1(new int(5));   
    std::weak_ptr<int> wp(sp1);   
    std::cout << "wp.use_count() == "   
        << wp.use_count() << std::endl;   
  
    std::shared_ptr<int> sp2(sp1);   
    std::cout << "wp.use_count() == "   
        << wp.use_count() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **wp.use_count() == 1**  
**wp.use_count() == 2**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)