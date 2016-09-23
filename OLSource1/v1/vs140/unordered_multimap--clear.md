---
title: "unordered_multimap::clear"
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
  - unordered_map/std::tr1::unordered_multimap::clear
  - unordered_multimap.clear
  - std::tr1::unordered_multimap::clear
  - unordered_multimap::clear
  - std.tr1.unordered_multimap.clear
dev_langs: 
  - C++
helpviewer_keywords: 
  - clear method [TR1]
ms.assetid: e624a9fe-ab11-4015-8ab6-913cff34e7ed
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unordered_multimap::clear
Removes all elements.  
  
## Syntax  
  
```  
void clear();  
```  
  
## Remarks  
 The member function calls [erase](../vs140/unordered_multimap--erase.md)`(` [begin](../vs140/unordered_multimap--begin.md)`(),` [end](../vs140/unordered_multimap--end.md)`())`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_clear.cpp   
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
  
// clear the container and reinspect   
    c1.clear();   
    std::cout << "size == " << c1.size() << std::endl;   
    std::cout << "empty() == " << std::boolalpha << c1.empty() << std::endl;   
    std::cout << std::endl;   
  
    c1.insert(Mymap::value_type('d', 4));   
    c1.insert(Mymap::value_type('e', 5));   
  
// display contents " [e 5] [d 4]"   
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
    std::cout << "size == " << c1.size() << std::endl;   
    std::cout << "empty() == " << std::boolalpha << c1.empty() << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::erase](../vs140/unordered_multimap--erase.md)