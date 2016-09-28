---
title: "make_tuple Function"
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
  - "std.tr1.make_tuple"
  - "std::tr1::make_tuple"
  - "make_tuple"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_tuple function [TR1]"
ms.assetid: 54ad5240-3afe-40b6-97df-27bbc8b995fa
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_tuple Function
Makes a `tuple` from element values.  
  
## Syntax  
  
```  
template<class T1, class T2, ..., class TN>  
    tuple<V1, V2, ..., VN>  
    make_tuple(const T1& t1, const T2& t2, ..., const TN& tN);  
```  
  
#### Parameters  
 `TN`  
 The type of the Nth function parameter.  
  
 `tN`  
 The value of the Nth function parameter.  
  
## Remarks  
 The template function returns `tuple<V1, V2, ..., VN>(t1, t2, ..., tN)`, where each type `Vi` is `X&` when the corresponding type `Ti` is `cv` `reference_wrapper<X>`; otherwise, it is `Ti`.  
  
 One advantage of `make_tuple` is that the types of objects that are being stored are determined automatically by the compiler and do not have to be explicitly specified. Don't use explicit template arguments such as `make_tuple<int, int>(1, 2)` when you use `make_tuple` because it is unnecessarily verbose and adds complex rvalue reference problems that might cause compilation failure.  
  
## Example  
  
```cpp  
  
      // std_tr1__tuple__make_tuple.cpp   
// compile by using: /EHsc   
#include <tuple>   
#include <iostream>   
  
typedef std::tuple<int, double, int, double> Mytuple;   
int main()   
    {   
    Mytuple c0(0, 1, 2, 3);   
  
// display contents " 0 1 2 3"   
    std::cout << " " << std::get<0>(c0);   
    std::cout << " " << std::get<1>(c0);   
    std::cout << " " << std::get<2>(c0);   
    std::cout << " " << std::get<3>(c0);   
    std::cout << std::endl;   
  
    c0 = std::make_tuple(4, 5, 6, 7);   
  
// display contents " 4 5 6 7"   
    std::cout << " " << std::get<0>(c0);   
    std::cout << " " << std::get<1>(c0);   
    std::cout << " " << std::get<2>(c0);   
    std::cout << " " << std::get<3>(c0);   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
 `0 1 2 3  4 5 6 7`  
  
## Requirements  
 **Header:** <tuple\>  
  
 **Namespace:** std  
  
## See Also  
 [<tuple\>](../vs140/-tuple-.md)   
 [tie](../vs140/tie-function.md)