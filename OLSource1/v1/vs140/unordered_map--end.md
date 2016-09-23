---
title: "unordered_map::end"
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
  - std::tr1::unordered_map::end
  - unordered_map/std::tr1::unordered_map::end
  - std.tr1.unordered_map.end
  - unordered_map::end
  - unordered_map.end
dev_langs: 
  - C++
helpviewer_keywords: 
  - end method [TR1]
ms.assetid: ed067b59-8acf-4de4-80c0-f7a766484a6a
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unordered_map::end
Designates the end of the controlled sequence.  
  
## Syntax  
  
```  
iterator end();  
const_iterator end() const;  
local_iterator end(size_type nbucket);  
const_local_iterator end(size_type nbucket) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`nbucket`|The bucket number.|  
  
## Remarks  
 The first two member functions return a forward iterator that points just beyond the end of the sequence. The last two member functions return a forward iterator that points just beyond the end of bucket `nbucket`.  
  
## Example  
  
### Code  
  
```  
// std_tr1__unordered_map__unordered_map_end.cpp   
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
  
// inspect last two items " [a 1] [b 2]"   
    Mymap::iterator it2 = c1.end();   
    --it2;   
    std::cout << " [" << it2->first << ", " << it2->second << "]";   
    --it2;   
    std::cout << " [" << it2->first << ", " << it2->second << "]";   
    std::cout << std::endl;   
  
// inspect bucket containing 'a'   
    Mymap::const_local_iterator lit = c1.end(c1.bucket('a'));   
    --lit;   
    std::cout << " [" << lit->first << ", " << lit->second << "]";   
  
    return (0);   
    }  
  
```  
  
### Output  
  
```  
[c, 3] [b, 2] [a, 1]  
[a, 1] [b, 2]  
[a, 1]  
```  
  
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::begin](../vs140/unordered_map--begin.md)