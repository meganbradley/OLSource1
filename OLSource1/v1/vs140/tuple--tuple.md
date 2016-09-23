---
title: "tuple::tuple"
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
  - tuple.tuple
  - tr1.tuple.tuple
  - tuple/std::tr1::tuple::tuple
  - std::tr1::tuple::tuple
  - tuple
  - std.tr1.tuple.tuple
  - tuple::tuple
  - tr1::tuple::tuple
dev_langs: 
  - C++
helpviewer_keywords: 
  - tuple constructor [TR1]
  - tuple method
ms.assetid: b3e2f5a0-96a4-475e-860d-f4ba2fc4c6c6
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# tuple::tuple
Constructs a `tuple`object.  
  
## Syntax  
  
```  
constexpr tuple();  
  
 explicit constexpr tuple(const Types&...);  
  
 template <class... UTypes>   
explicit constexpr tuple(UTypes&&...);  
  
tuple(const tuple&) = default;  
 tuple(tuple&&) = default;  
  
template <class... UTypes>  
 constexpr tuple(const tuple<UTypes...>&);  
  
 template <class... UTypes>  
 constexpr tuple(tuple<UTypes...>&&);  
  
template <class U1, class U2>   
constexpr tuple(const pair<U1, U2>&); // only if sizeof...(Types) == 2   
  
template <class U1, class U2>  
 constexpr tuple(pair<U1, U2>&&); // only if sizeof...(Types) == 2  
```  
  
#### Parameters  
 `UN`  
 The type of the Nth copied tuple element.  
  
 `right`  
 The tuple to copy from.  
  
## Remarks  
 The first constructor constructs an object whose elements are default constructed.  
  
 The second constructor constructs an object whose elements are copy constructed from the arguments `P1`, `P2`, ..., `PN` with each `Pi` initializing the element at index `i - 1`.  
  
 The third and fourth constructors construct an object whose elements are copy constructed from the corresponding element of `right`.  
  
 The fifth constructor constructs an object whose element at index 0 is copy constructed from `right.first` and whose element at index 1 is copy constructed from `right.second`.  
  
 The remaining constructors are analogs to earlier ones, but with [rvalue references](../vs140/rvalue-reference-declarator----.md).  
  
## Example  
  
```  
// std_tr1__tuple__tuple_tuple.cpp   
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
  
    std::tuple<char, int> c2(std::make_pair('x', 4));   
  
// display contents " x 4"   
    std::cout << " " << std::get<0>(c2);   
    std::cout << " " << std::get<1>(c2);   
    std::cout << std::endl;   
  
    Mytuple c3(c0);   
  
// display contents " 0 1 2 3"   
    std::cout << " " << std::get<0>(c3);   
    std::cout << " " << std::get<1>(c3);   
    std::cout << " " << std::get<2>(c3);   
    std::cout << " " << std::get<3>(c3);   
    std::cout << std::endl;   
  
    typedef std::tuple<int, float, int, float> Mytuple2;   
    Mytuple c4(Mytuple2(4, 5, 6, 7));   
  
// display contents " 4 5 6 7"   
    std::cout << " " << std::get<0>(c4);   
    std::cout << " " << std::get<1>(c4);   
    std::cout << " " << std::get<2>(c4);   
    std::cout << " " << std::get<3>(c4);   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0 1 2 3**  
 **x 4**  
 **0 1 2 3**  
 **4 5 6 7**   
## Requirements  
 **Header:** <tuple\>  
  
 **Namespace:** std  
  
## See Also  
 [<tuple\>](../vs140/-tuple-.md)   
 [tuple](../vs140/tuple-class.md)