---
title: "array::front"
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
  - tr1.array.front
  - tr1::array::front
  - std::tr1::array::front
  - array.front
  - array/std::tr1::array::front
  - std.tr1.array.front
  - array::front
dev_langs: 
  - C++
helpviewer_keywords: 
  - front method
  - front method [TR1]
ms.assetid: 8eda21f0-2ce8-440a-87b1-ae423f354573
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::front
Accesses the first element.  
  
## Syntax  
  
```  
reference front();  
constexpr const_reference front() const;  
```  
  
## Remarks  
 The member functions return a reference to the first element of the controlled sequence, which must be non-empty.  
  
## Example  
  
```  
// std_tr1__array__array_front.cpp   
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
  
// display first element " 0"   
    std::cout << " " << c0.front();   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [back](../vs140/array--back.md)