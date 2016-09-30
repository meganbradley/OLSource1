---
title: "unordered_map::reference"
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
  - "tr1.unordered_map.reference"
  - "tr1::unordered_map::reference"
  - "unordered_map.reference"
  - "unordered_map::reference"
  - "unordered_map/std::tr1::unordered_map::reference"
  - "reference"
  - "std.tr1.unordered_map.reference"
  - "std::tr1::unordered_map::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference typedef"
  - "reference typedef [TR1]"
ms.assetid: 6dbad579-d53c-4809-8d58-d0a417d9b1b1
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::reference
The type of a reference to an element.  
  
## Syntax  
  
```  
typedef Alloc::reference reference;  
```  
  
## Remarks  
 The type describes an object that can serve as a reference to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_reference.cpp   
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
        Mymap::reference ref = *it;   
        std::cout << " [" << ref.first << ", " << ref.second << "]";   
        }   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::const_reference](../vs140/unordered_map--const_reference.md)