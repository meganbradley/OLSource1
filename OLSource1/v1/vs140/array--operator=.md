---
title: "array::operator="
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
  - array/std::tr1::array::operator=
  - std::tr1::array::operator=
  - array.operator=
  - array::operator=
  - std.tr1.array.operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator= operator [TR1]
ms.assetid: ac0003ca-3154-462a-a24f-2213ba3e972e
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::operator=
Replaces the controlled sequence.  
  
## Syntax  
  
```  
array <Value>% operator=(array <Value>% right);  
```  
  
#### Parameters  
 right  
 Container to copy.  
  
## Remarks  
 The member operator assigns each element of `right` to the corresponding element of the controlled sequence, then returns `*this`. You use it to replace the controlled sequence with a copy of the controlled sequence in `right`.  
  
## Example  
  
```  
// std_tr1__array__array_operator_as.cpp   
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
  
    Myarray c1;   
    c1 = c0;   
  
// display copied contents " 0 1 2 3"   
    for (Myarray::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " " << *it;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **0 1 2 3**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [assign](../vs140/array--assign.md)