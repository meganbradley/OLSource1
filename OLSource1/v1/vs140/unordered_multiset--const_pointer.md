---
title: "unordered_multiset::const_pointer"
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
  - "std.tr1.unordered_multiset.const_pointer"
  - "unordered_multiset::const_pointer"
  - "unordered_multiset.const_pointer"
  - "tr1.unordered_multiset.const_pointer"
  - "const_pointer"
  - "tr1::unordered_multiset::const_pointer"
  - "unordered_set/std::tr1::unordered_multiset::const_pointer"
  - "std::tr1::unordered_multiset::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer typedef [TR1]"
ms.assetid: 641196e0-5942-443f-bc91-937c08d31630
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::const_pointer
The type of a constant pointer to an element.  
  
## Syntax  
  
```  
typedef Alloc::const_pointer const_pointer;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant pointer to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_const_pointer.cpp   
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
        Myset::const_pointer p = &*it;   
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
 [unordered_multiset::pointer](../vs140/unordered_multiset--pointer.md)   
 [unordered_multiset::value_type](../vs140/unordered_multiset--value_type.md)