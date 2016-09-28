---
title: "unordered_set::const_reference"
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
  - "tr1.unordered_set.const_reference"
  - "unordered_set::const_reference"
  - "const_reference"
  - "tr1::unordered_set::const_reference"
  - "unordered_set.const_reference"
  - "std.tr1.unordered_set.const_reference"
  - "unordered_set/std::tr1::unordered_set::const_reference"
  - "std::tr1::unordered_set::const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference typedef [TR1]"
  - "const_reference typedef"
ms.assetid: 6c9c68bf-9328-424b-a9fa-e42e84dee3c6
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::const_reference
The type of a constant reference to an element.  
  
## Syntax  
  
```  
typedef Alloc::const_reference const_reference;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_const_reference.cpp   
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
        Myset::const_reference ref = *it;   
        std::cout << " [" << ref << "]";   
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
 [unordered_set::reference](../vs140/unordered_set--reference.md)   
 [unordered_set::value_type](../vs140/unordered_set--value_type.md)