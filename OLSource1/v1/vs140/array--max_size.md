---
title: "array::max_size"
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
  - std::tr1::array::max_size
  - std.tr1.array.max_size
  - tr1.array.max_size
  - array.max_size
  - array::max_size
  - tr1::array::max_size
  - array/std::tr1::array::max_size
dev_langs: 
  - C++
helpviewer_keywords: 
  - max_size method [TR1]
  - max_size method
ms.assetid: 7dc63fe5-81f8-40e6-80f5-c855c7bed130
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::max_size
Counts the number of elements.  
  
## Syntax  
  
```  
constexpr size_type max_size() const;  
```  
  
## Remarks  
 The member function returns `N`.  
  
## Example  
  
```  
// std__array__array_max_size.cpp   
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
  
// display (maximum) size " 4"   
    std::cout << " " << c0.max_size();   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **4**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [size](../vs140/array--size.md)