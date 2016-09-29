---
title: "unordered_multiset::pointer"
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
  - "unordered_multiset::pointer"
  - "unordered_set/std::tr1::unordered_multiset::pointer"
  - "tr1::unordered_multiset::pointer"
  - "pointer"
  - "tr1.unordered_multiset.pointer"
  - "std::tr1::unordered_multiset::pointer"
  - "unordered_multiset.pointer"
  - "std.tr1.unordered_multiset.pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer typedef [TR1]"
  - "pointer typedef"
ms.assetid: 497f9377-e12b-4046-8d2d-ba6c2c83085f
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::pointer
The type of a pointer to an element.  
  
## Syntax  
  
```  
typedef Alloc::pointer pointer;  
```  
  
## Remarks  
 The type describes an object that can serve as a pointer to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_pointer.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_multiset<char> Myset;   
int main()   
    {   
    Myset c1;   
  
    c1.insert('a');   
    c1.insert('b');   
    c1.insert('c');   
  
// display contents " [c] [b] [a]"   
    for (Myset::iterator it = c1.begin();   
        it != c1.end(); ++it)   
        {   
        Myset::key_type key = *it;   
        Myset::pointer p = &key;   
        std::cout << " [" << *p << "]";   
        }   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::const_pointer](../vs140/unordered_multiset--const_pointer.md)