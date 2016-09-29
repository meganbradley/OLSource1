---
title: "operator&lt; &lt;tuple&gt;"
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
  - "tuple::operator<"
  - "tuple.operator<"
  - "std::tr1::tuple::operator<"
  - "std.tr1.tuple.operator<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator< operator [TR1]"
ms.assetid: 2f5fba34-d6c5-4f08-9a9a-2ea6aafcb369
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; &lt;tuple&gt;
Compare `tuple` objects for less.  
  
## Syntax  
  
```  
template<class T1, class T2, ..., class TN,  
    class U1, class U2, ..., class UN>  
    bool operator<(const tuple<T1, T2, ..., TN>& tpl1,  
    const tuple<U1, U2, ..., UN>& tpl2);  
```  
  
#### Parameters  
 `TN`  
 The type of the Nth tuple element.  
  
## Remarks  
 The function returns true when `N` is greater than 0 and the first differing value in `tpl1` compares less than the corresponding value in `tpl2`, otherwise it returns false.  
  
## Example  
  
```  
// std_tr1__tuple__operator_lt.cpp   
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
    std::cout << std::boolalpha << " " << (c0 < c0);   
    std::cout << std::endl;   
    std::cout << std::boolalpha << " " << (c0 < c1);   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0 1 2 3**  
 **false**  
 **true**   
## Requirements  
 **Header:** \<tuple>  
  
 **Namespace:** std  
  
## See Also  
 [\<tuple>](../vs140/-tuple-.md)   
 [operator==](../vs140/operator==--tuple-.md)   
 [operator!==](../vs140/operator!=--tuple-.md)   
 [operator<=](../vs140/operator-=--tuple-.md)   
 [operator>](../vs140/operator---tuple-.md)   
 [operator>=](../vs140/operator-=--tuple-.md)