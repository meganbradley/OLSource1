---
title: "unordered_multimap::size_type"
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
  - "tr1::unordered_multimap::size_type"
  - "std::tr1::unordered_multimap::size_type"
  - "unordered_map/std::tr1::unordered_multimap::size_type"
  - "unordered_multimap.size_type"
  - "std.tr1.unordered_multimap.size_type"
  - "unordered_multimap::size_type"
  - "tr1.unordered_multimap.size_type"
  - "size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef"
  - "size_type typedef [TR1]"
ms.assetid: 4ee637dc-9480-4825-8994-b4e9387b1485
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::size_type
The type of an unsigned distance between two elements.  
  
## Syntax  
  
```  
typedef T2 size_type;  
```  
  
## Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is described here as a synonym for the implementation-defined type `T2`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_size_type.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_multimap<char, int> Mymap;   
int main()   
    {   
    Mymap c1;   
    Mymap::size_type sz = c1.size();   
  
    std::cout << "size == " << sz << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **size == 0**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::difference_type](../vs140/unordered_multimap--difference_type.md)