---
title: "array::pointer"
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
  - "array/std::tr1::array::pointer"
  - "tr1::array::pointer"
  - "std::tr1::array::pointer"
  - "array::pointer"
  - "std.tr1.array.pointer"
  - "tr1.array.pointer"
  - "array.pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer typedef [TR1]"
  - "pointer typedef"
ms.assetid: 615959ef-e4ce-47ca-b5f8-011686ef3769
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::pointer
The type of a pointer to an element.  
  
## Syntax  
  
```  
typedef Ty *pointer;  
```  
  
## Remarks  
 The type describes an object that can serve as a pointer to elements of the sequence.  
  
## Example  
  
```  
// std_tr1__array__array_pointer.cpp   
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
    Myarray::pointer ptr = &*c0.begin();   
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
 [const_pointer](../vs140/array--const_pointer.md)