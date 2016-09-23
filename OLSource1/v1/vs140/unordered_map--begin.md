---
title: "unordered_map::begin"
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
  - std::tr1::unordered_map::begin
  - unordered_map.begin
  - unordered_map::begin
  - unordered_map/std::tr1::unordered_map::begin
  - std.tr1.unordered_map.begin
dev_langs: 
  - C++
helpviewer_keywords: 
  - begin method [TR1]
ms.assetid: 1d421596-13ca-4ffb-ade6-d543346acdac
caps.latest.revision: 19
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_map::begin
Designates the beginning of the controlled sequence or a bucket.  
  
## Syntax  
  
```  
iterator begin();  
const_iterator begin() const;  
local_iterator begin(size_type nbucket);  
const_local_iterator begin(size_type nbucket) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`nbucket`|The bucket number.|  
  
## Remarks  
 The first two member functions return a forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence). The last two member functions return a forward iterator that points at the first element of bucket `nbucket` (or just beyond the end of an empty bucket).  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_begin.cpp   
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
  
// inspect first two items " [c 3] [b 2]"   
    Mymap::iterator it2 = c1.begin();   
    std::cout << " [" << it2->first << ", " << it2->second << "]";   
    ++it2;   
    std::cout << " [" << it2->first << ", " << it2->second << "]";   
    std::cout << std::endl;   
  
// inspect bucket containing 'a'   
    Mymap::const_local_iterator lit = c1.begin(c1.bucket('a'));   
    std::cout << " [" << lit->first << ", " << lit->second << "]";   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
 **[c, 3] [b, 2]**  
 **[a, 1]**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::end](../vs140/unordered_map--end.md)