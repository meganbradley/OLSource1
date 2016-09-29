---
title: "unordered_map::local_iterator"
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
  - "tr1::unordered_map::local_iterator"
  - "unordered_map/std::tr1::unordered_map::local_iterator"
  - "local_iterator"
  - "std::tr1::unordered_map::local_iterator"
  - "std.tr1.unordered_map.local_iterator"
  - "unordered_map.local_iterator"
  - "unordered_map::local_iterator"
  - "tr1.unordered_map.local_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "local_iterator typedef"
  - "local_iterator typedef [TR1]"
ms.assetid: ea94e571-067e-46e4-80f7-3e9f45938ad6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::local_iterator
The type of a bucket iterator.  
  
## Syntax  
  
```  
typedef T4 local_iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a forward iterator for a bucket. It is described here as a synonym for the implementation-defined type `T4`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_local_iterator.cpp   
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
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
// inspect bucket containing 'a'   
    Mymap::local_iterator lit = c1.begin(c1.bucket('a'));   
    std::cout << " [" << lit->first << ", " << lit->second << "]";   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
 **[a, 1]**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map::const_iterator](../vs140/unordered_map--const_iterator.md)   
 [unordered_map::const_local_iterator](../vs140/unordered_map--const_local_iterator.md)   
 [unordered_map::iterator](../vs140/unordered_map--iterator.md)