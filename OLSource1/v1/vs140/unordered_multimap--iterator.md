---
title: "unordered_multimap::iterator"
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
  - "unordered_multimap.iterator"
  - "iterator"
  - "unordered_map/std::tr1::unordered_multimap::iterator"
  - "std.tr1.unordered_multimap.iterator"
  - "std::tr1::unordered_multimap::iterator"
  - "unordered_multimap::iterator"
  - "tr1.unordered_multimap.iterator"
  - "tr1::unordered_multimap::iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_eq method [TR1]"
  - "iterator typedef"
ms.assetid: 62bcf94f-5fa5-48f0-ad43-6e51fb122d3e
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::iterator
The type of an iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T0 iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type `T0`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_iterator.cpp   
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
        std::cout << " [" << it->first << ", " << it->second << "]";   
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
 [unordered_multimap::const_iterator](../vs140/unordered_multimap--const_iterator.md)   
 [unordered_multimap::const_local_iterator](../vs140/unordered_multimap--const_local_iterator.md)   
 [unordered_multimap::local_iterator](../vs140/unordered_multimap--local_iterator.md)