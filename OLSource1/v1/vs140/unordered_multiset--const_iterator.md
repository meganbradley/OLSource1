---
title: "unordered_multiset::const_iterator"
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
  - "unordered_set/std::tr1::unordered_multiset::const_iterator"
  - "tr1.unordered_multiset.const_iterator"
  - "const_iterator"
  - "std::tr1::unordered_multiset::const_iterator"
  - "unordered_multiset::const_iterator"
  - "tr1::unordered_multiset::const_iterator"
  - "unordered_multiset.const_iterator"
  - "std.tr1.unordered_multiset.const_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_iterator typedef [TR1]"
  - "const_iterator typedef"
ms.assetid: 13f4475c-a909-471e-9a46-8d477ae8f18d
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::const_iterator
The type of a constant iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T1 const_iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type `T1`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_const_iterator.cpp   
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
    for (Myset::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << *it << "]";   
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
 [unordered_multiset::const_local_iterator](../vs140/unordered_multiset--const_local_iterator.md)   
 [unordered_multiset::iterator](../vs140/unordered_multiset--iterator.md)   
 [unordered_multiset::local_iterator](../vs140/unordered_multiset--local_iterator.md)