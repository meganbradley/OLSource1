---
title: "unordered_multiset::end"
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
  - "std.tr1.unordered_multiset.end"
  - "unordered_multiset::end"
  - "unordered_set/std::tr1::unordered_multiset::end"
  - "std::tr1::unordered_multiset::end"
  - "unordered_multiset.end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method [TR1]"
ms.assetid: da426f33-26fa-44e9-8966-8af8b2d5347f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::end
Designates the end of the controlled sequence.  
  
## Syntax  
  
```  
iterator end();  
    const_iterator end() const;  
    local_iterator end(size_type nbucket);  
    const_local_iterator end(size_type nbucket) const;  
```  
  
#### Parameters  
 `nbucket`  
 The bucket number.  
  
## Remarks  
 The first two member functions return a forward iterator that points just beyond the end of the sequence. The last two member functions return a forward iterator that points just beyond the end of bucket `nbucket`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_end.cpp   
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
  
// inspect last two items " [a] [b]"   
    Myset::iterator it2 = c1.end();   
    --it2;   
    std::cout << " [" << *it2 << "]";   
    --it2;   
    std::cout << " [" << *it2 << "]";   
    std::cout << std::endl;   
  
// inspect bucket containing 'a'   
    Myset::const_local_iterator lit = c1.end(c1.bucket('a'));   
    --lit;   
    std::cout << " [" << *lit << "]";   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
 **[a] [b]**  
 **[a]**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::begin](../vs140/unordered_multiset--begin.md)