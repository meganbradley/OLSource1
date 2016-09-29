---
title: "unordered_multiset::const_reference"
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
  - "std::tr1::unordered_multiset::const_reference"
  - "tr1.unordered_multiset.const_reference"
  - "unordered_multiset::const_reference"
  - "const_reference"
  - "unordered_set/std::tr1::unordered_multiset::const_reference"
  - "tr1::unordered_multiset::const_reference"
  - "unordered_multiset.const_reference"
  - "std.tr1.unordered_multiset.const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference typedef [TR1]"
  - "const_reference typedef"
ms.assetid: ff9076a5-d9cb-43f6-9679-71ea86f64934
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::const_reference
The type of a constant reference to an element.  
  
## Syntax  
  
```  
typedef Alloc::const_reference const_reference;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_const_reference.cpp   
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
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::reference](../vs140/unordered_multiset--reference.md)   
 [unordered_multiset::value_type](../vs140/unordered_multiset--value_type.md)