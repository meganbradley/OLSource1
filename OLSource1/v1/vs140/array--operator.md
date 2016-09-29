---
title: "array::operator"
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
  - "tr1::array::operator[]"
  - "array/std::tr1::array::operator[]"
  - "array.operator[]"
  - "array::operator[]"
  - "std.tr1.array.operator[]"
  - "std::tr1::array::operator[]"
  - "tr1.array.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[] operator [TR1]"
  - "operator[]"
ms.assetid: d26e2613-dede-41e8-a413-182879b400ad
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::operator
Accesses an element at a specified position.  
  
## Syntax  
  
```  
  
reference operator[](size_type off);  
constexpr const_reference operator[](size_type off) const;  
  
```  
  
#### Parameters  
 `off`  
 Position of element to access.  
  
## Remarks  
 The member functions return a reference to the element of the controlled sequence at position `off`. If that position is invalid, the behavior is undefined.  
  
## Example  
  
```  
// std_tr1__array__array_operator_sub.cpp   
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
  
// display odd elements " 1 3"   
    std::cout << " " << c0[1];   
    std::cout << " " << c0[3];   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **1 3**   
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [at](../vs140/array--at.md)