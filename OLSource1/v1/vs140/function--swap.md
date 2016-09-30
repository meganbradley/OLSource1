---
title: "function::swap"
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
  - "function::swap"
  - "functional/std::tr1::function::swap"
  - "std.tr1.function.swap"
  - "function.swap"
  - "std::tr1::function::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method [TR1]"
ms.assetid: f0e99367-d73a-460c-906d-7ca053920dcf
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::swap
Swap two callable objects.  
  
## Syntax  
  
```  
void swap(function& right);  
```  
  
#### Parameters  
 `right`  
 The function object to swap with.  
  
## Remarks  
 The member function swaps the target objects between `*this` and `right`. It does so in constant time and throws no exceptions.  
  
## Example  
  
```  
// std_tr1__functional__function_swap.cpp   
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
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << std::endl;   
  
    fn0.swap(fn1);   
    std::cout << std::boolalpha << "empty == " << !fn0 << std::endl;   
    std::cout << std::boolalpha << "empty == " << !fn1 << std::endl;   
    std::cout << "val == " << fn1(3) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **empty == false**  
**val == -3**  
**empty == true**  
**empty == true**  
**empty == false**  
**val == -3**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::operator_as](../vs140/function--operator=.md)