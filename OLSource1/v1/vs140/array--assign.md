---
title: "array::assign"
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
  - "tr1::array::assign"
  - "std::tr1::array::assign"
  - "std.tr1.array.assign"
  - "array::assign"
  - "tr1.array.assign"
  - "array/std::tr1::array::assign"
  - "array.assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method [TR1]"
  - "assign method"
ms.assetid: 48dc1f98-2ee4-426b-8e8e-5b826929a726
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::assign
Replaces all elements.  
  
## Syntax  
  
```  
void assign(const Ty& val);  
```  
  
#### Parameters  
 `val`  
 The value to assign.  
  
## Remarks  
 The member function replaces the sequence controlled by `*this` with a repetition of `N` elements of value `val`.  
  
## Example  
  
```  
// std_tr1__array__array_assign.cpp   
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
    c1.assign(4);   
  
// display contents " 4 4 4 4"   
    for (Myarray::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " " << *it;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **4 4 4 4**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [operator=](../vs140/array--operator=.md)