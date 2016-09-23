---
title: "unordered_map::count"
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
  - std::tr1::unordered_map::count
  - std.tr1.unordered_map.count
  - unordered_map.count
  - unordered_map::count
  - count
  - unordered_map/std::tr1::unordered_map::count
dev_langs: 
  - C++
helpviewer_keywords: 
  - count method [TR1]
ms.assetid: bda30fcc-da49-463e-a602-97e00a5c0007
caps.latest.revision: 19
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_map::count
Finds the number of elements matching a specified key.  
  
## Syntax  
  
```  
size_type count(const Key& keyval) const;  
```  
  
#### Parameters  
 `keyval`  
 Key value to search for.  
  
## Remarks  
 The member function returns the number of elements in the range delimited by [equal_range](../vs140/unordered_map--equal_range.md)`(keyval)`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_count.cpp   
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
  
    std::cout << "count('A') == " << c1.count('A') << std::endl;   
    std::cout << "count('b') == " << c1.count('b') << std::endl;   
    std::cout << "count('C') == " << c1.count('C') << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
**count('A') == 0**  
**count('b') == 1**  
**count('C') == 0**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::equal_range](../vs140/unordered_map--equal_range.md)