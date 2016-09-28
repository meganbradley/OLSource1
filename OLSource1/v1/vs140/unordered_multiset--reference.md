---
title: "unordered_multiset::reference"
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
  - "std.tr1.unordered_multiset.reference"
  - "unordered_multiset::reference"
  - "unordered_set/std::tr1::unordered_multiset::reference"
  - "unordered_multiset.reference"
  - "tr1.unordered_multiset.reference"
  - "reference"
  - "std::tr1::unordered_multiset::reference"
  - "tr1::unordered_multiset::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference typedef"
  - "reference typedef [TR1]"
ms.assetid: 68695da0-b5f9-4382-9de2-f9ebf43645e2
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::reference
The type of a reference to an element.  
  
## Syntax  
  
```  
typedef Alloc::reference reference;  
```  
  
## Remarks  
 The type describes an object that can serve as a reference to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_reference.cpp   
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
        Myset::reference ref = key;   
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
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::const_reference](../vs140/unordered_multiset--const_reference.md)