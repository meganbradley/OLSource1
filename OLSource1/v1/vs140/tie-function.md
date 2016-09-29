---
title: "tie Function"
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
  - "std::tr1::tie"
  - "tie"
  - "std.tr1.tie"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tie function [TR1]"
ms.assetid: 311bf8f6-7543-4d59-8245-c34846488f44
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tie Function
Makes a `tuple` from element references.  
  
## Syntax  
  
```  
template<class T1, class T2, ..., class TN>  
    tuple<T1&, T2&, ..., TN&>  
    tie(T1& t1, T2& t2, ..., TN& tN);  
```  
  
#### Parameters  
 `TN`  
 The base type of the Nth tuple element.  
  
## Remarks  
 The template function returns `tuple<T1&, T2&, ..., TN&>(t1, t2, ..., tN)`.  
  
## Example  
  
```  
// std_tr1__tuple__tie.cpp   
// compile with: /EHsc   
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
  
    int v4 = 4;   
    double v5 = 5;   
    int v6 = 6;   
    double v7 = 7;   
    std::tie(v4, v5, v6, v7) = c0;   
  
// display contents " 0 1 2 3"   
    std::cout << " " << v4;   
    std::cout << " " << v5;   
    std::cout << " " << v6;   
    std::cout << " " << v7;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0 1 2 3**   
## Requirements  
 **Header:** <tuple\>  
  
 **Namespace:** std  
  
## See Also  
 [<tuple\>](../vs140/-tuple-.md)   
 [make_tuple](../vs140/make_tuple-function.md)