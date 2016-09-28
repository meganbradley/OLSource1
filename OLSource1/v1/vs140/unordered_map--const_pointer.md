---
title: "unordered_map::const_pointer"
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
  - "unordered_map/std::tr1::unordered_map::const_pointer"
  - "std::tr1::unordered_map::const_pointer"
  - "tr1::unordered_map::const_pointer"
  - "const_pointer"
  - "std.tr1.unordered_map.const_pointer"
  - "tr1.unordered_map.const_pointer"
  - "unordered_map::const_pointer"
  - "unordered_map.const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer typedef [TR1]"
ms.assetid: 5279d50e-0e3d-4212-97e4-7d1ccea1b591
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::const_pointer
The type of a constant pointer to an element.  
  
## Syntax  
  
```  
typedef Alloc::const_pointer const_pointer;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant pointer to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_const_pointer.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_map<char, int> Mymap;   
int main()   
    {   
    Mymap c1;   
  
    c1.insert(Mymap::value_type('a', 1));   
    c1.insert(Mymap::value_type('b', 2));   
    c1.insert(Mymap::value_type('c', 3));   
  
// display contents " [c 3] [b 2] [a 1]"   
    for (Mymap::iterator it = c1.begin();   
        it != c1.end(); ++it)   
        {   
        Mymap::const_pointer p = &*it;   
        std::cout << " [" << p->first << ", " << p->second << "]";   
        }   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::pointer](../vs140/unordered_map--pointer.md)   
 [unordered_map::value_type](../vs140/unordered_map--value_type.md)