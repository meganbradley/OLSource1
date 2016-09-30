---
title: "unordered_map::size_type"
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
  - "unordered_map.size_type"
  - "unordered_map::size_type"
  - "tr1::unordered_map::size_type"
  - "tr1.unordered_map.size_type"
  - "size_type"
  - "std::tr1::unordered_map::size_type"
  - "unordered_map/std::tr1::unordered_map::size_type"
  - "std.tr1.unordered_map.size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef"
  - "size_type typedef [TR1]"
ms.assetid: acf48786-fb49-4339-bebc-cdda249cb3a8
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::size_type
The type of an unsigned distance between two elements.  
  
## Syntax  
  
```  
typedef T2 size_type;  
```  
  
## Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is described here as a synonym for the implementation-defined type `T2`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_size_type.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_map<char, int> Mymap;   
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
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::difference_type](../vs140/unordered_map--difference_type.md)