---
title: "array::const_pointer"
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
  - "tr1::array::const_pointer"
  - "array::const_pointer"
  - "array/std::tr1::array::const_pointer"
  - "array.const_pointer"
  - "std.tr1.array.const_pointer"
  - "tr1.array.const_pointer"
  - "std::tr1::array::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer typedef [TR1]"
ms.assetid: 43912b11-f6d5-4077-841b-89cb7f0fa41d
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::const_pointer
The type of a constant pointer to an element.  
  
## Syntax  
  
```  
typedef const Ty *const_pointer;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant pointer to elements of the sequence.  
  
## Example  
  
```  
// std_tr1__array__array_const_pointer.cpp   
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
    Myarray::const_pointer ptr = &*c0.begin();   
    std::cout << " " << *ptr;   
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
 [pointer](../vs140/array--pointer.md)