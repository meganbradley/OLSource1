---
title: "unordered_map::const_reference"
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
  - "std.tr1.unordered_map.const_reference"
  - "unordered_map/std::tr1::unordered_map::const_reference"
  - "unordered_map::const_reference"
  - "const_reference"
  - "unordered_map.const_reference"
  - "std::tr1::unordered_map::const_reference"
  - "tr1::unordered_map::const_reference"
  - "tr1.unordered_map.const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference typedef [TR1]"
  - "const_reference typedef"
ms.assetid: ff35f9d2-8214-4069-b45e-3b91b248a0e8
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::const_reference
The type of a constant reference to an element.  
  
## Syntax  
  
```  
typedef Alloc::const_reference const_reference;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_const_reference.cpp   
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
        Mymap::const_reference ref = *it;   
        std::cout << " [" << ref.first << ", " << ref.second << "]";   
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
 [unordered_map::reference](../vs140/unordered_map--reference.md)   
 [unordered_map::value_type](../vs140/unordered_map--value_type.md)