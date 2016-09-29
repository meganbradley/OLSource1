---
title: "unordered_multiset::const_local_iterator"
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
  - "unordered_multiset::const_local_iterator"
  - "std::tr1::unordered_multiset::const_local_iterator"
  - "std.tr1.unordered_multiset.const_local_iterator"
  - "unordered_multiset.const_local_iterator"
  - "unordered_set/std::tr1::unordered_multiset::const_local_iterator"
  - "const_local_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_local_iterator typedef [TR1]"
ms.assetid: 1bc80b29-7c5c-4516-8e0a-73d292f47218
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::const_local_iterator
The type of a constant bucket iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T5 const_local_iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a constant forward iterator for a bucket. It is described here as a synonym for the implementation-defined type `T5`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_const_local_iterator.cpp   
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
  
// inspect bucket containing 'a'   
    Myset::const_local_iterator lit = c1.begin(c1.bucket('a'));   
    std::cout << " [" << *lit << "]";   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
 **[a]**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::const_iterator](../vs140/unordered_multiset--const_iterator.md)   
 [unordered_multiset::iterator](../vs140/unordered_multiset--iterator.md)   
 [unordered_multiset::local_iterator](../vs140/unordered_multiset--local_iterator.md)