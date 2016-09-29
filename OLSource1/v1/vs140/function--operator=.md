---
title: "function::operator="
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
  - "function::operator="
  - "functional/std::tr1::function::operator="
  - "std.tr1.function.operator="
  - "function.operator="
  - "std::tr1::function::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
ms.assetid: 992901b5-7366-4056-9312-350f6a096255
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::operator=
Replaces the stored callable object.  
  
## Syntax  
  
```  
function& operator=(null_ptr_type npc);  
function& operator=(const function& right);  
template<class Fty>  
    function& operator=(Fty fn);  
template<class Fty>  
    function& operator=(reference_wrapper<Fty> fnref);  
```  
  
#### Parameters  
 `npc`  
 A null pointer constant.  
  
 `right`  
 The function object to copy.  
  
 `fn`  
 The callable object to wrap.  
  
 `fnref`  
 The callable object reference to wrap.  
  
## Remarks  
 The operators each replace the callable object held by `*this` with the callable object passed as the operand.  
  
## Example  
  
```  
// std_tr1__functional__function_operator_as.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
  
int neg(int val)   
    {   
    return (-val);   
    }   
  
int main()   
    {   
    std::function<int (int)> fn0(neg);   
    std::cout << std::boolalpha << "empty == " << !fn0 << std::endl;   
    std::cout << "val == " << fn0(3) << std::endl;   
  
    std::function<int (int)> fn1;   
    fn1 = 0;   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
  
    fn1 = neg;   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << "val == " << fn1(3) << std::endl;   
  
    fn1 = fn0;   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << "val == " << fn1(3) << std::endl;   
  
    fn1 = std::cref(fn1);   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << "val == " << fn1(3) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **empty == false**  
**val == -3**  
**empty == true**  
**empty == false**  
**val == -3**  
**empty == false**  
**val == -3**  
**empty == false**  
**val == -3**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::function](../vs140/function--function.md)   
 [function::swap](../vs140/function--swap.md)