---
title: "unordered_multimap::difference_type"
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
  - "std::tr1::unordered_multimap::difference_type"
  - "tr1.unordered_multimap.difference_type"
  - "std.tr1.unordered_multimap.difference_type"
  - "unordered_map/std::tr1::unordered_multimap::difference_type"
  - "tr1::unordered_multimap::difference_type"
  - "difference_type"
  - "unordered_multimap::difference_type"
  - "unordered_multimap.difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef [TR1]"
  - "difference_type typedef"
ms.assetid: a5cb8834-15dd-4e2a-a52b-b024da8d9fff
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::difference_type
The type of a signed distance between two elements.  
  
## Syntax  
  
```  
typedef T3 difference_type;  
```  
  
## Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence. It is described here as a synonym for the implementation-defined type `T3`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_difference_type.cpp   
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
  
// compute positive difference   
    Mymap::difference_type diff = 0;   
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        ++diff;   
    std::cout << "end()-begin() == " << diff << std::endl;   
  
// compute negative difference   
    diff = 0;   
    for (Mymap::const_iterator it = c1.end();   
        it != c1.begin(); --it)   
        --diff;   
    std::cout << "begin()-end() == " << diff << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
**end()-begin() == 3**  
**begin()-end() == -3**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::size_type](../vs140/unordered_multimap--size_type.md)