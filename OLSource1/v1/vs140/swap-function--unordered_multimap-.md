---
title: "swap Function (unordered_multimap)"
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
  - "std.tr1.swap"
  - "std::tr1::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function [TR1]"
ms.assetid: 1b431801-2c43-4b6e-97c2-a329003fa651
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# swap Function (unordered_multimap)
Swaps the contents of two containers.  
  
## Syntax  
  
```  
template<class Key, class Ty, class Hash, class Pred, class Alloc>  
    void swap(  
        unordered_multimap <Key, Ty, Hash, Pred, Alloc>& left,  
        unordered_multimap <Key, Ty, Hash, Pred, Alloc>& right);  
```  
  
#### Parameters  
 `Key`  
 The key type.  
  
 `Ty`  
 The mapped type.  
  
 `Hash`  
 The hash function object type.  
  
 `Pred`  
 The equality comparison function object type.  
  
 `Alloc`  
 The allocator class.  
  
 `left`  
 The first container to swap.  
  
 `right`  
 The second container to swap.  
  
## Remarks  
 The template function executes `left.`[swap](../vs140/unordered_multimap--swap.md)`(right)`.  
  
## Example  
  
```  
// std_tr1__unordered_map__u_mm_swap.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_multimap<char, int> Mymap;   
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
  
    Mymap c2;   
  
    c2.insert(Mymap::value_type('d', 4));   
    c2.insert(Mymap::value_type('e', 5));   
    c2.insert(Mymap::value_type('f', 6));   
  
    c1.swap(c2);   
  
// display contents " [f 6] [e 5] [d 4]"   
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
    swap(c1, c2);   
  
// display contents " [c 3] [b 2] [a 1]"   
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
 **[f, 6] [e, 5] [d, 4]**  
 **[c, 3] [b, 2] [a, 1]**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [swap](../vs140/unordered_multimap--swap.md)