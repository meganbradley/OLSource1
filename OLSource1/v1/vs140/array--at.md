---
title: "array::at"
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
  - "array::at"
  - "std.tr1.array.at"
  - "array/std::tr1::array::at"
  - "std::tr1::array::at"
  - "array.at"
  - "tr1.array.at"
  - "tr1::array::at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at method"
  - "at method [TR1]"
ms.assetid: 9383a110-e758-4d6d-be47-99b637452f3b
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::at
Accesses an element at a specified position.  
  
## Syntax  
  
```  
reference at(size_type off);  
constexpr const_reference at(size_type off) const;  
```  
  
#### Parameters  
 `off`  
 Position of element to access.  
  
## Remarks  
 The member functions return a reference to the element of the controlled sequence at position `off`. If that position is invalid, the function throws an object of class `out_of_range`.  
  
## Example  
  
```  
// std__array__array_at.cpp   
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
    std::cout << " " << c0.at(1);   
    std::cout << " " << c0.at(3);   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [operator_sub](../vs140/array--operator.md)