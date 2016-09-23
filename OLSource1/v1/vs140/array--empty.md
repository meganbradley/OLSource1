---
title: "array::empty"
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
  - array::empty
  - tr1::array::empty
  - array.empty
  - std.tr1.array.empty
  - std::tr1::array::empty
  - tr1.array.empty
  - array/std::tr1::array::empty
dev_langs: 
  - C++
helpviewer_keywords: 
  - empty method [TR1]
  - empty method
ms.assetid: 4d005d15-bf97-4f85-b66f-b9660c3fd38f
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::empty
Tests whether no elements are present.  
  
## Syntax  
  
```  
constexpr bool empty() const;  
```  
  
## Remarks  
 The member function returns true only if `N == 0`.  
  
## Example  
  
```  
// std_tr1__array__array_empty.cpp   
// compile with: /EHsc   
#include <array>   
#include <iostream>   
  
typedef std::array<int, 4> Myarray;   
int main()   
    {   
    Myarray c0 = {0, 1, 2, 3};   
  
// display contents " 0 1 2 3"   
    for (Myarray::const_iterator it = c0.begin();   
        it != c0.end(); ++it)   
        std::cout << " " << *it;   
    std::cout << std::endl;   
  
// display whether c0 is empty " false"   
    std::cout << std::boolalpha << " " << c0.empty();   
    std::cout << std::endl;   
  
    std::array<int, 0> c1;   
  
// display whether c1 is empty " true"   
    std::cout << std::boolalpha << " " << c1.empty();   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **false**  
 **true**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [size](../vs140/array--size.md)