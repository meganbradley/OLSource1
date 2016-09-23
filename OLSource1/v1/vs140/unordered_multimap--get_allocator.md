---
title: "unordered_multimap::get_allocator"
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
  - unordered_multimap::get_allocator
  - get_allocator
  - unordered_map/std::tr1::unordered_multimap::get_allocator
  - std::tr1::unordered_multimap::get_allocator
  - std.tr1.unordered_multimap.get_allocator
  - unordered_multimap.get_allocator
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_allocator method [TR1]
ms.assetid: 5bd76cfd-5afe-43c7-9d8a-8e8e892e991e
caps.latest.revision: 20
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multimap::get_allocator
Gets the stored allocator object.  
  
## Syntax  
  
```  
Alloc get_allocator() const;  
```  
  
## Remarks  
 The member function returns the stored allocator object.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_get_allocator.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_multimap<char, int> Mymap;   
typedef std::allocator<std::pair<const char, int> > Myalloc;   
int main()   
    {   
    Mymap c1;   
  
    Mymap::allocator_type al = c1.get_allocator();   
    std::cout << "al == std::allocator() is "   
        << std::boolalpha << (al == Myalloc()) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **al == std::allocator() is true**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)