---
title: "unordered_multimap::const_local_iterator"
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
  - "unordered_multimap::const_local_iterator"
  - "std.tr1.unordered_multimap.const_local_iterator"
  - "tr1.unordered_multimap.const_local_iterator"
  - "std::tr1::unordered_multimap::const_local_iterator"
  - "unordered_multimap.const_local_iterator"
  - "tr1::unordered_multimap::const_local_iterator"
  - "unordered_map/std::tr1::unordered_multimap::const_local_iterator"
  - "const_local_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_local_iterator typedef"
  - "const_local_iterator typedef [TR1]"
ms.assetid: 43f1df16-bd5a-4c6e-86e8-b692770057c3
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::const_local_iterator
The type of a constant bucket iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T5 const_local_iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant forward iterator for a bucket. It is described here as a synonym for the implementation-defined type `T5`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_const_local_iterator.cpp   
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
  
// inspect bucket containing 'a'   
    Mymap::const_local_iterator lit = c1.begin(c1.bucket('a'));   
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
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::const_iterator](../vs140/unordered_multimap--const_iterator.md)   
 [unordered_multimap::iterator](../vs140/unordered_multimap--iterator.md)   
 [unordered_multimap::local_iterator](../vs140/unordered_multimap--local_iterator.md)