---
title: "tuple::operator="
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
  - "std::tr1::tuple::operator="
  - "tr1.tuple.operator="
  - "std.tr1.tuple.operator="
  - "tr1::tuple::operator="
  - "operator="
  - "tuple::operator="
  - "tuple/std::tr1::tuple::operator="
  - "tuple.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
  - "operator="
ms.assetid: 525a086d-7987-4a93-8a2a-314fc40ad0b0
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tuple::operator=
Assigns a `tuple` object.  
  
## Syntax  
  
```  
tuple& operator=(const tuple& right);  
template <class U1, class U2, ..., class UN>  
    tuple& operator=(const tuple<U1, U2, ..., UN>& right);  
template <class U1, class U2>  
    tuple& operator=(const pair<U1, U2>& right);  // N == 2  
tuple& operator=(tuple&& right);  
template <class U1, class U2>  
    tuple& operator=(pair<U1, U2>&& right);  
```  
  
#### Parameters  
 `UN`  
 The type of the Nth copied tuple element.  
  
 `right`  
 The tuple to copy from.  
  
## Remarks  
 The first two member operators assign the elements of `right` to the corresponding elements of `*this`. The third member operator assigns `right.first` to the element at index 0 of `*this` and `right.second` to the element at index 1. All three member operators return `*this`.  
  
 The remaining member operators are analogs to earlier ones, but with [rvalue references](../vs140/rvalue-reference-declarator----.md).  
  
## Example  
  
```  
// std_tr1__tuple__tuple_operator_as.cpp   
// compile with: /EHsc   
#include <tuple>   
#include <iostream>   
#include <utility>   
  
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
  
    Mytuple c1;   
    c1 = c0;   
  
// display contents " 0 1 2 3"   
    std::cout << " " << std::get<0>(c1);   
    std::cout << " " << std::get<1>(c1);   
    std::cout << " " << std::get<2>(c1);   
    std::cout << " " << std::get<3>(c1);   
    std::cout << std::endl;   
  
    std::tuple<char, int> c2;   
    c2 = std::make_pair('x', 4);   
  
// display contents " x 4"   
    std::cout << " " << std::get<0>(c2);   
    std::cout << " " << std::get<1>(c2);   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0 1 2 3**  
 **x 4**   
## Requirements  
 **Header:** \<tuple>  
  
 **Namespace:** std  
  
## See Also  
 [\<tuple>](../vs140/-tuple-.md)   
 [tuple](../vs140/tuple-class.md)