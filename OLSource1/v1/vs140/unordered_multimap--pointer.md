---
title: "unordered_multimap::pointer"
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
  - unordered_multimap.pointer
  - tr1.unordered_multimap.pointer
  - std.tr1.unordered_multimap.pointer
  - tr1::unordered_multimap::pointer
  - pointer
  - unordered_map/std::tr1::unordered_multimap::pointer
  - std::tr1::unordered_multimap::pointer
  - unordered_multimap::pointer
dev_langs: 
  - C++
helpviewer_keywords: 
  - pointer typedef [TR1]
  - pointer typedef
ms.assetid: 9b8ce31c-c03f-4f7f-a14d-9a67f5d0bb7e
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unordered_multimap::pointer
The type of a pointer to an element.  
  
## Syntax  
  
```  
typedef Alloc::pointer pointer;  
```  
  
## Remarks  
 The type describes an object that can serve as a pointer to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_pointer.cpp   
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
        Mymap::pointer p = &*it;   
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
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::const_pointer](../vs140/unordered_multimap--const_pointer.md)