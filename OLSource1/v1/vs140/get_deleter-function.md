---
title: "get_deleter Function"
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
  - std::tr1::get_deleter
  - get_deleter
  - std.tr1.get_deleter
  - memory/std::tr1::get_deleter
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_deleter function [TR1]
ms.assetid: 98adaa00-79a0-477a-801e-acef04a96c3e
caps.latest.revision: 18
translation.priority.mt: 
  - de-de
  - ja-jp
---
# get_deleter Function
Get deleter from shared_ptr.  
  
## Syntax  
  
```  
template<class D, class Ty>  
    D *get_deleter(const shared_ptr<Ty>& sp);  
```  
  
#### Parameters  
 `D`  
 The type of the deleter.  
  
 `Ty`  
 The type controlled by the shared pointer.  
  
 `Other`  
 The shared pointer.  
  
## Remarks  
 The template function returns a pointer to the deleter of type `D` that belongs to the [shared_ptr](../vs140/shared_ptr-class.md) object `sp`. If `sp` has no deleter or if its deleter is not of type `D` the function returns 0.  
  
## Example  
  
```  
// std_tr1__memory__get_deleter.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
struct base   
    {   
    int val;   
    };   
  
struct deleter   
    {   
    void operator()(base *p)   
        {   
        delete p;   
        }   
    };   
  
int main()   
    {   
    std::shared_ptr<base> sp0(new base);   
  
    sp0->val = 3;   
    std::cout << "get_deleter(sp0) != 0 == " << std::boolalpha   
        << (std::get_deleter<deleter>(sp0) != 0) << std::endl;   
  
    std::shared_ptr<base> sp1(new base, deleter());   
  
    sp0->val = 3;   
    std::cout << "get_deleter(sp1) != 0 == " << std::boolalpha   
        << (std::get_deleter<deleter>(sp1) != 0) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **get_deleter(sp0) != 0 == false**  
**get_deleter(sp1) != 0 == true**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)