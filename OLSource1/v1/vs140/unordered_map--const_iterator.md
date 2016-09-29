---
title: "unordered_map::const_iterator"
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
  - "unordered_map/std::tr1::unordered_map::const_iterator"
  - "const_iterator"
  - "unordered_map::const_iterator"
  - "std::tr1::unordered_map::const_iterator"
  - "tr1.unordered_map.const_iterator"
  - "tr1::unordered_map::const_iterator"
  - "unordered_map.const_iterator"
  - "std.tr1.unordered_map.const_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_iterator typedef [TR1]"
  - "const_iterator typedef"
ms.assetid: 758ffd33-d68c-410b-9f65-cd8c79660108
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::const_iterator
The type of a constant iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T1 const_iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type `T1`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_const_iterator.cpp   
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
 [unordered_map::const_local_iterator](../vs140/unordered_map--const_local_iterator.md)   
 [unordered_map::iterator](../vs140/unordered_map--iterator.md)   
 [unordered_map::local_iterator](../vs140/unordered_map--local_iterator.md)