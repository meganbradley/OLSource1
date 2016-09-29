---
title: "unordered_set::local_iterator"
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
  - "std.tr1.unordered_set.local_iterator"
  - "tr1.unordered_set.local_iterator"
  - "unordered_set/std::tr1::unordered_set::local_iterator"
  - "unordered_set.local_iterator"
  - "local_iterator"
  - "std::tr1::unordered_set::local_iterator"
  - "unordered_set::local_iterator"
  - "tr1::unordered_set::local_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "local_iterator typedef"
  - "local_iterator typedef [TR1]"
ms.assetid: 174df4ac-ce15-4d81-b1d4-939de14abddd
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::local_iterator
The type of a bucket iterator.  
  
## Syntax  
  
```  
typedef T4 local_iterator;  
```  
  
## Remarks  
 The type describes an object that can serve as a forward iterator for a bucket. It is described here as a synonym for the implementation-defined type `T4`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_local_iterator.cpp   
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
    for (Myset::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
// inspect bucket containing 'a'   
    Myset::local_iterator lit = c1.begin(c1.bucket('a'));   
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
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::const_iterator](../vs140/unordered_set--const_iterator.md)   
 [unordered_set::const_local_iterator](../vs140/unordered_set--const_local_iterator.md)   
 [unordered_set::iterator](../vs140/unordered_set--iterator.md)