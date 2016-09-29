---
title: "bind Function"
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
  - "bind"
  - "functional/std::tr1::bind"
  - "std.tr1.bind"
  - "std::tr1::bind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bind function [TR1]"
ms.assetid: a278b579-3802-4fad-a04a-2b4120a3862b
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bind Function
Binds arguments to a callable object.  
  
## Syntax  
  
```  
template<class Fty, class T1, class T2, ..., class TN>  
   unspecified bind(Fty fn, T1 t1, T2 t2, ..., TN tN);  
template<class Ret, class Fty, class T1, class T2, ..., class TN>  
   unspecified bind(Fty fn, T1 t1, T2 t2, ..., TN tN);  
```  
  
#### Parameters  
 `Fty`  
 The type of the object to call.  
  
 `TN`  
 The type of the Nth call argument.  
  
 `fn`  
 The object to call.  
  
 `tN`  
 The Nth call argument.  
  
## Remarks  
 The types `Fty, T1, T2, ..., TN` must be copy constructible, and `INVOKE(fn, t1, ..., tN)` must be a valid expression for some values `w1, w2, ..., wN`.  
  
 The first template function returns a forwarding call wrapper `g` with a weak result type. The effect of `g(u1, u2, ..., uM)` is `INVOKE(f, v1, v2, ..., vN,` [result_of](../vs140/result_of-class2.md)`<Fty` `cv` `(V1, V2, ..., VN)>::type)`, where `cv` is the cv-qualifiers of `g` and the values and types of the bound arguments `v1, v2, ..., vN` are determined as specified below. You use it to bind arguments to a callable object to make a callable object with a tailored argument list.  
  
 The second template function returns a forwarding call wrapper `g` with a nested type `result_type` that is a synonym for `Ret`. The effect of `g(u1, u2, ..., uM)` is `INVOKE(f, v1, v2, ..., vN, Ret)`, where `cv` is the cv-qualifiers of `g` and the values and types of the bound arguments `v1, v2, ..., vN` are determined as specified below. You use it to bind arguments to a callable object to make a callable object with a tailored argument list and with a specified return type.  
  
 The values of the bound arguments `v1, v2, ..., vN` and their corresponding types `V1, V2, ..., VN` depend on the type of the corresponding argument `ti` of type `Ti` in the call to `bind` and the cv-qualifiers `cv` of the call wrapper `g` as follows:  
  
 if `ti` is of type `reference_wrapper<T>` the argument `vi` is `ti.get()` and its type `Vi` is `T&`;  
  
 if the value of `std::is_bind_expression<Ti>::value` is `true` the argument `vi` is `ti(u1, u2, ..., uM)` and its type `Vi` is `result_of<Ti` `cv` `(U1&, U2&, ..., UN&>::type`;  
  
 if the value `j` of `std::is_placeholder<Ti>::value` is not zero the argument `vi` is `uj` and its type `Vi` is `Uj&`;  
  
 otherwise the argument `vi` is `ti` and its type `Vi` is `Ti` `cv` `&`.  
  
 For example, given a function `f(int, int)` the expression `bind(f, _1, 0)` returns a forwarding call wrapper `cw` such that `cw(x)` calls `f(x, 0)`. The expression `bind(f, 0, _1)` returns a forwarding call wrapper `cw` such that `cw(x)` calls `f(0, x)`.  
  
 The number of arguments in a call to `bind` in addition to the argument `fn` must be equal to the number of arguments that can be passed to the callable object `fn`. Thus, `bind(cos, 1.0)` is correct, and both `bind(cos)` and `bind(cos, _1, 0.0)` are incorrect.  
  
 The number of arguments in the function call to the call wrapper returned by `bind` must be at least as large as the highest numbered value of `is_placeholder<PH>::value` for all of the placeholder arguments in the call to `bind`. Thus, `bind(cos, _2)(0.0, 1.0)` is correct (and returns `cos(1.0)`), and `bind(cos, _2)(0.0)` is incorrect.  
  
## Example  
  
```  
// std_tr1__functional__bind.cpp   
// compile with: /EHsc   
#include <functional>   
#include <algorithm>   
#include <iostream>   
  
using namespace std::placeholders;   
  
void square(double x)   
    {   
    std::cout << x << "^2 == " << x * x << std::endl;   
    }   
  
void product(double x, double y)   
    {   
    std::cout << x << "*" << y << " == " << x * y << std::endl;   
    }   
  
int main()   
    {   
    double arg[] = {1, 2, 3};   
  
    std::for_each(&arg[0], arg + 3, square);   
    std::cout << std::endl;   
  
    std::for_each(&arg[0], arg + 3, std::bind(product, _1, 2));   
    std::cout << std::endl;   
  
    std::for_each(&arg[0], arg + 3, std::bind(square, _1));   
  
    return (0);   
    }  
  
```  
  
 **1^2 == 1**  
**2^2 == 4**  
**3^2 == 9**  
**1\*2 == 2**  
**2\*2 == 4**  
**3\*2 == 6**  
**1^2 == 1**  
**2^2 == 4**  
**3^2 == 9**   
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [is_bind_expression](../vs140/is_bind_expression-class.md)   
 [_1](../vs140/_1-object.md)