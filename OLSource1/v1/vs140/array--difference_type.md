---
title: "array::difference_type"
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
  - tr1::array::difference_type
  - array/std::tr1::array::difference_type
  - array::difference_type
  - array.difference_type
  - std.tr1.array.difference_type
  - std::tr1::array::difference_type
  - tr1.array.difference_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - difference_type typedef [TR1]
  - difference_type typedef
ms.assetid: 472e7e0b-aef6-49f2-b072-f046c76ab260
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::difference_type
The type of a signed distance between two elements.  
  
## Syntax  
  
```  
typedef std::ptrdiff_t difference_type;  
```  
  
## Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence. It is a synonym for the type `std::ptrdiff_t`.  
  
## Example  
  
```  
// std_tr1__array__array_difference_type.cpp   
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
  
// display distance first-last " -4"   
    Myarray::difference_type diff = c0.begin() - c0.end();   
    std::cout << " " << diff;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **-4**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [size_type](../vs140/array--size_type.md)