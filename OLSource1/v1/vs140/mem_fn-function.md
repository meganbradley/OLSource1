---
title: "mem_fn Function"
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
  - "std.tr1.mem_fn"
  - "functional/std::tr1::mem_fn"
  - "std::tr1::mem_fn"
  - "mem_fn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mem_fn function [TR1]"
ms.assetid: c6f9bccf-cfb0-44c5-bdd9-64c021ceae03
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mem_fn Function
Generates a simple call wrapper.  
  
## Syntax  
  
```  
template<class Ret, class Ty>  
    unspecified mem_fn(Ret Ty::*pm);  
```  
  
#### Parameters  
 `Ret`  
 The return type of the wrapped function.  
  
 `Ty`  
 The type of the member function pointer.  
  
## Remarks  
 The template function returns a simple call wrapper `cw`, with a weak result type, such that the expression `cw(t, a2, ..., aN)` is equivalent to `INVOKE(pm, t, a2, ..., aN)`. It does not throw any exceptions.  
  
 The returned call wrapper is derived from `std::unary_function<cv Ty*, Ret>` (hence defining the nested type `result_type` as a synonym for `Ret` and the nested type `argument_type` as a synonym for `cv Ty*`) only if the type `Ty` is a pointer to member function with cv-qualifier `cv` that takes no arguments.  
  
 The returned call wrapper is derived from `std::binary_function<cv Ty*, T2, Ret>` (hence defining the nested type `result_type` as a synonym for `Ret`, the nested type `first argument_type` as a synonym for `cv Ty*`, and the nested type `second argument_type` as a synonym for `T2`) only if the type `Ty` is a pointer to member function with cv-qualifier `cv` that takes one argument, of type `T2`.  
  
## Example  
  
```  
// std_tr1__functional__mem_fn.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
class Funs   
    {   
public:   
    void square(double x)   
        {   
        std::cout << x << "^2 == " << x * x << std::endl;   
        }   
  
    void product(double x, double y)   
        {   
        std::cout << x << "*" << y << " == " << x * y << std::endl;   
        }   
    };   
  
int main()   
    {   
    Funs funs;   
  
    std::mem_fn(&Funs::square)(funs, 3.0);   
    std::mem_fn(&Funs::product)(funs, 3.0, 2.0);   
  
    return (0);   
    }  
  
```  
  
 **3^2 == 9**  
**3\*2 == 6**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)