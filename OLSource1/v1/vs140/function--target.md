---
title: "function::target"
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
  - target
  - std::tr1::function::target
  - std.tr1.function.target
  - function::target
  - function.target
  - functional/std::tr1::function::target
dev_langs: 
  - C++
helpviewer_keywords: 
  - target method [TR1]
ms.assetid: 244ed813-3dfa-47bb-b3b5-a42d66b19348
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# function::target
Tests if stored callable object is callable as specified.  
  
## Syntax  
  
```  
template<class Fty2>  
    Fty2 *target();  
template<class Fty2>  
    const Fty2 *target() const;  
```  
  
#### Parameters  
 `Fty2`  
 The target callable object type to test.  
  
## Remarks  
 The type `Fty2` must be callable for the argument types `T1, T2, ..., TN` and the return type `Ret`. If `target_type() == typeid(Fty2)`, the member template function returns the address of the target object; otherwise, it returns 0.  
  
 A type `Fty2` is callable for the argument types `T1, T2, ..., TN` and the return type `Ret` if, for lvalues `fn, t1, t2, ..., tN` of types `Fty2, T1, T2, ..., TN`, respectively, `INVOKE(fn, t1, t2, ..., tN)` is well-formed and, if `Ret` is not `void`, convertible to `Ret`.  
  
## Example  
  
```  
// std_tr1__functional__function_target.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
int neg(int val)   
    {   
    return (-val);   
    }   
  
int main()   
    {   
    typedef int (*Myfun)(int);   
    std::function<int (int)> fn0(neg);   
    std::cout << std::boolalpha << "empty == " << !fn0 << std::endl;   
    std::cout << "no target == " << (fn0.target<Myfun>() == 0) << std::endl;   
  
    Myfun *fptr = fn0.target<Myfun>();   
    std::cout << "val == " << (*fptr)(3) << std::endl;   
  
    std::function<int (int)> fn1;   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << "no target == " << (fn1.target<Myfun>() == 0) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **empty == false**  
**no target == false**  
**val == -3**  
**empty == true**  
**no target == true**   
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::target_type](../vs140/function--target_type.md)