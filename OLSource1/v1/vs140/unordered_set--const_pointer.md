---
title: "unordered_set::const_pointer"
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
  - "tr1::unordered_set::const_pointer"
  - "unordered_set/std::tr1::unordered_set::const_pointer"
  - "unordered_set::const_pointer"
  - "const_pointer"
  - "std.tr1.unordered_set.const_pointer"
  - "std::tr1::unordered_set::const_pointer"
  - "unordered_set.const_pointer"
  - "tr1.unordered_set.const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer typedef [TR1]"
ms.assetid: 7ee59f52-1c12-46e4-8aa8-4d26609892e4
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::const_pointer
The type of a constant pointer to an element.  
  
## Syntax  
  
```  
typedef Alloc::const_pointer const_pointer;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant pointer to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_const_pointer.cpp   
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
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::pointer](../vs140/unordered_set--pointer.md)   
 [unordered_set::value_type](../vs140/unordered_set--value_type.md)