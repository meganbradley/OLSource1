---
title: "unordered_multimap::hasher"
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
  - "unordered_map/std::tr1::unordered_multimap::hasher"
  - "unordered_multimap::hasher"
  - "tr1::unordered_multimap::hasher"
  - "unordered_multimap.hasher"
  - "std::tr1::unordered_multimap::hasher"
  - "std.tr1.unordered_multimap.hasher"
  - "tr1.unordered_multimap.hasher"
  - "hasher"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hasher typedef"
  - "hasher typedef [TR1]"
ms.assetid: 83ee9600-2b0a-4fb6-a502-0cec606d53f0
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::hasher
The type of the hash function.  
  
## Syntax  
  
```  
typedef Hash hasher;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Hash`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_hasher.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_multimap<char, int> Mymap;   
int main()   
    {   
    Mymap c1;   
  
    Mymap::hasher hfn = c1.hash_function();   
    std::cout << "hfn('a') == " << hfn('a') << std::endl;   
    std::cout << "hfn('b') == " << hfn('b') << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **hfn('a') == 1630279**  
**hfn('b') == 1647086**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)