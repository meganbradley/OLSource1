---
title: "array::rbegin"
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
  - "tr1.array.rbegin"
  - "array/std::tr1::array::rbegin"
  - "array.rbegin"
  - "array::rbegin"
  - "std::tr1::array::rbegin"
  - "tr1::array::rbegin"
  - "std.tr1.array.rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
  - "rbegin method [TR1]"
ms.assetid: 96fb6d7e-6b2a-4534-9945-24019a561f06
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::rbegin
Designates the beginning of the reversed controlled sequence.  
  
## Syntax  
  
```  
reverse_iterator rbegin()noexcept;  
const_reverse_iterator rbegin() const noexcept;  
```  
  
## Remarks  
 The member functions return a reverse iterator that points just beyond the end of the controlled sequence. Hence, it designates the beginning of the reverse sequence.  
  
## Example  
  
```  
// std_tr1__array__array_rbegin.cpp   
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
  
// display last element " 3"   
    Myarray::const_reverse_iterator it2 = c0.rbegin();   
    std::cout << " " << *it2;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **0 1 2 3**  
 **3**   
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [begin](../vs140/array--begin.md)   
 [end](../vs140/array--end.md)   
 [rend](../vs140/array--rend.md)