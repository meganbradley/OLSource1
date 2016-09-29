---
title: "operator&lt;= &lt;tuple&gt;"
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
  - "std.tr1.tuple.operator<="
  - "tuple.operator<="
  - "tuple::operator<="
  - "std::tr1::tuple::operator<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<= operator [TR1]"
ms.assetid: 365ab30a-9d89-4ccc-b149-f33157201078
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= &lt;tuple&gt;
Compare `tuple` objects for less or equal.  
  
## Syntax  
  
```  
template<class T1, class T2, ..., class TN,  
    class U1, class U2, ..., class UN>  
    bool operator<=(const tuple<T1, T2, ..., TN>& tpl1,  
    const tuple<U1, U2, ..., UN>& tpl2);  
```  
  
#### Parameters  
 `TN`  
 The type of the Nth tuple element.  
  
## Remarks  
 The function returns `!(tpl2 < tpl1)`.  
  
## Example  
  
```  
// std_tr1__tuple__operator_le.cpp   
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
  
    Mytuple c1 = std::make_tuple(4, 5, 6, 7);   
  
// display contents " 4 5 6 7"   
    std::cout << " " << std::get<0>(c0);   
    std::cout << " " << std::get<1>(c0);   
    std::cout << " " << std::get<2>(c0);   
    std::cout << " " << std::get<3>(c0);   
    std::cout << std::endl;   
  
// display results of comparisons   
    std::cout << std::boolalpha << " " << (c0 <= c0);   
    std::cout << std::endl;   
    std::cout << std::boolalpha << " " << (c1 <= c0);   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0 1 2 3**  
 **true**  
 **false**   
## Requirements  
 **Header:** <tuple\>  
  
 **Namespace:** std  
  
## See Also  
 [<tuple\>](../vs140/-tuple-.md)   
 [operator==](../vs140/operator==--tuple-.md)   
 [operator!==](../vs140/operator!=--tuple-.md)   
 [operator<](../vs140/operator---tuple-.md)   
 [operator>](../vs140/operator---tuple-.md)   
 [operator>=](../vs140/operator-=--tuple-.md)