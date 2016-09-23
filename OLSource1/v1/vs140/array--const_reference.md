---
title: "array::const_reference"
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
  - std.tr1.array.const_reference
  - std::tr1::array::const_reference
  - tr1::array::const_reference
  - array.const_reference
  - array/std::tr1::array::const_reference
  - tr1.array.const_reference
  - array::const_reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_reference typedef [TR1]
  - const_reference typedef
ms.assetid: dc53fecb-1210-464e-8d75-9bc3a5ead173
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::const_reference
The type of a constant reference to an element.  
  
## Syntax  
  
```  
typedef const Ty& const_reference;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__array__array_const_reference.cpp   
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
    Myarray::const_reference ref = *c0.begin();   
    std::cout << " " << ref;   
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
 [reference](../vs140/array--reference.md)   
 [value_type](../vs140/array--value_type.md)