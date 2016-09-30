---
title: "unordered_map::allocator_type"
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
  - "std::tr1::unordered_map::allocator_type"
  - "unordered_map/std::tr1::unordered_map::allocator_type"
  - "allocator_type"
  - "unordered_map::allocator_type"
  - "tr1.unordered_map.allocator_type"
  - "tr1::unordered_map::allocator_type"
  - "std.tr1.unordered_map.allocator_type"
  - "unordered_map.allocator_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_type typedef [TR1]"
  - "allocator_type typedef"
ms.assetid: 63a51a33-2a47-476e-84a2-69c7ef8e5efb
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::allocator_type
The type of an allocator for managing storage.  
  
## Syntax  
  
```  
typedef Alloc allocator_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Alloc`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_allocator_type.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_map<char, int> Mymap;   
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
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)