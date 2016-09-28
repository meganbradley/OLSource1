---
title: "unordered_multimap::mapped_type"
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
  - "unordered_multimap::mapped_type"
  - "unordered_map/std::tr1::unordered_multimap::mapped_type"
  - "tr1::unordered_multimap::mapped_type"
  - "mapped_type"
  - "std::tr1::unordered_multimap::mapped_type"
  - "tr1.unordered_multimap.mapped_type"
  - "unordered_multimap.mapped_type"
  - "std.tr1.unordered_multimap.mapped_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mapped_type typedef [TR1]"
  - "mapped_type typedef"
ms.assetid: 41fff1ea-6384-4dc1-b7b4-8a882789dc52
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::mapped_type
The type of a mapped value associated with each key.  
  
## Syntax  
  
```  
typedef Ty mapped_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Ty`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_mapped_type.cpp   
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
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
// add a value and reinspect   
    Mymap::key_type key = 'd';   
    Mymap::mapped_type mapped = 4;   
    Mymap::value_type val = Mymap::value_type(key, mapped);   
    c1.insert(val);   
  
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
 **[d, 4] [c, 3] [b, 2] [a, 1]**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::key_type](../vs140/unordered_multimap--key_type.md)   
 [unordered_multimap::value_type](../vs140/unordered_multimap--value_type.md)