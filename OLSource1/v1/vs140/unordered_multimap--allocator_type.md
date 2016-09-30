---
title: "unordered_multimap::allocator_type"
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
  - "unordered_multimap.allocator_type"
  - "std.tr1.unordered_multimap.allocator_type"
  - "allocator_type"
  - "unordered_multimap::allocator_type"
  - "unordered_map/std::tr1::unordered_multimap::allocator_type"
  - "tr1::unordered_multimap::allocator_type"
  - "std::tr1::unordered_multimap::allocator_type"
  - "tr1.unordered_multimap.allocator_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_type typedef [TR1]"
  - "allocator_type typedef"
ms.assetid: bc3d2fc1-d741-47ce-8196-9138fe878749
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::allocator_type
The type of an allocator for managing storage.  
  
## Syntax  
  
```  
typedef Alloc allocator_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Alloc`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_allocator_type.cpp   
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