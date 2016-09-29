---
title: "unordered_map::iterator"
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
  - "unordered_map::iterator"
  - "iterator"
  - "unordered_map/std::tr1::unordered_map::iterator"
  - "std::tr1::unordered_map::iterator"
  - "std.tr1.unordered_map.iterator"
  - "unordered_map.iterator"
  - "tr1::unordered_map::iterator"
  - "tr1.unordered_map.iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator typedef [TR1]"
  - "iterator typedef"
ms.assetid: 2b062b5f-0784-4b5f-8c6e-32b991f67595
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::iterator
The type of an iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T0 iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type `T0`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_iterator.cpp   
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
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::const_iterator](../vs140/unordered_map--const_iterator.md)   
 [unordered_map::const_local_iterator](../vs140/unordered_map--const_local_iterator.md)   
 [unordered_map::local_iterator](../vs140/unordered_map--local_iterator.md)