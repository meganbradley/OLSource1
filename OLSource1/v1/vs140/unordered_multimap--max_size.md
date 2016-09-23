---
title: "unordered_multimap::max_size"
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
  - unordered_multimap::max_size
  - max_size
  - std::tr1::unordered_multimap::max_size
  - unordered_map/std::tr1::unordered_multimap::max_size
  - unordered_multimap.max_size
  - std.tr1.unordered_multimap.max_size
dev_langs: 
  - C++
helpviewer_keywords: 
  - max_size method [TR1]
ms.assetid: 9452d88e-c823-4ca5-9a06-a02207179c83
caps.latest.revision: 21
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multimap::max_size
Gets the maximum size of the controlled sequence.  
  
## Syntax  
  
```  
size_type max_size() const;  
```  
  
## Remarks  
 The member function returns the length of the longest sequence that the object can control.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_max_size.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_multimap<char, int> Mymap;   
int main()   
    {   
    Mymap c1;   
  
    std::cout << "max_size() == " << c1.max_size() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **max_size() == 536870911**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::size](../vs140/unordered_multimap--size.md)