---
title: "unordered_multimap::const_reference"
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
  - "tr1.unordered_multimap.const_reference"
  - "const_reference"
  - "unordered_map/std::tr1::unordered_multimap::const_reference"
  - "tr1::unordered_multimap::const_reference"
  - "unordered_multimap::const_reference"
  - "std::tr1::unordered_multimap::const_reference"
  - "std.tr1.unordered_multimap.const_reference"
  - "unordered_multimap.const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference typedef [TR1]"
  - "const_reference typedef"
ms.assetid: 660b9dab-f158-43c6-9cc3-71ce6dd6c69e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::const_reference
The type of a constant reference to an element.  
  
## Syntax  
  
```  
typedef Alloc::const_reference const_reference;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_const_reference.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_multimap<char, int> Mymap;   
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
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::reference](../vs140/unordered_multimap--reference.md)   
 [unordered_multimap::value_type](../vs140/unordered_multimap--value_type.md)