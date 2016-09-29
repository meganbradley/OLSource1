---
title: "unordered_multimap::hash_function"
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
  - "unordered_map/std::tr1::unordered_multimap::hash_function"
  - "unordered_multimap.hash_function"
  - "std::tr1::unordered_multimap::hash_function"
  - "unordered_multimap::hash_function"
  - "tr1.unordered_multimap.hash_function"
  - "hash_function"
  - "std.tr1.unordered_multimap.hash_function"
  - "tr1::unordered_multimap::hash_function"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_function method [TR1]"
  - "hash_function method"
ms.assetid: 446a5743-0eb7-488c-ba14-f7c020343e8c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::hash_function
Gets the stored hash function object.  
  
## Syntax  
  
```  
Hash hash_function() const;  
```  
  
## Remarks  
 The member function returns the stored hash function object.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_multimap_hash_function.cpp   
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
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)