---
title: "unordered_multimap::find"
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
  - std::tr1::unordered_multimap::find
  - unordered_multimap.find
  - unordered_map/std::tr1::unordered_multimap::find
  - std.tr1.unordered_multimap.find
  - unordered_multimap::find
dev_langs: 
  - C++
helpviewer_keywords: 
  - find method [TR1]
ms.assetid: 4b14681c-2393-4e70-bd33-8f22c0fe6bdc
caps.latest.revision: 20
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multimap::find
Finds an element that matches a specified key.  
  
## Syntax  
  
```  
const_iterator find(const Key& keyval) const;  
```  
  
#### Parameters  
 `keyval`  
 Key value to search for.  
  
## Remarks  
 The member function returns [equal_range](../vs140/unordered_multimap--equal_range.md)`(keyval).first`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_find.cpp   
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
  
// try to find and fail   
    std::cout << "find('A') == "   
        << std::boolalpha << (c1.find('A') != c1.end()) << std::endl;   
  
// try to find and succeed   
    Mymap::iterator it = c1.find('b');   
    std::cout << "find('b') == "   
        << std::boolalpha << (it != c1.end())   
        << ": [" << it->first << ", " << it->second << "]" << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
**find('A') == false**  
**find('b') == true: [b, 2]**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::equal_range](../vs140/unordered_multimap--equal_range.md)