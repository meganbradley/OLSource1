---
title: "unordered_set::pointer"
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
  - "tr1.unordered_set.pointer"
  - "tr1::unordered_set::pointer"
  - "std.tr1.unordered_set.pointer"
  - "unordered_set::pointer"
  - "pointer"
  - "std::tr1::unordered_set::pointer"
  - "unordered_set/std::tr1::unordered_set::pointer"
  - "unordered_set.pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer typedef [TR1]"
  - "pointer typedef"
ms.assetid: a7f048f2-d62e-4465-8206-b90896d9873b
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::pointer
The type of a pointer to an element.  
  
## Syntax  
  
```  
typedef Alloc::pointer pointer;  
```  
  
## Remarks  
 The type describes an object that can serve as a pointer to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_pointer.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_set<char> Myset;   
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
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::const_pointer](../vs140/unordered_set--const_pointer.md)