---
title: "unordered_multiset::key_type"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::tr1::unordered_multiset::key_type
  - tr1::unordered_multiset::key_type
  - tr1.unordered_multiset.key_type
  - std.tr1.unordered_multiset.key_type
  - unordered_set/std::tr1::unordered_multiset::key_type
  - unordered_multiset::key_type
  - unordered_multiset.key_type
  - key_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - key_type typedef
  - key_type typedef [TR1]
ms.assetid: afc91a08-9eb6-4028-85ad-ece6054ebe4e
caps.latest.revision: 20
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multiset::key_type
The type of an ordering key.  
  
## Syntax  
  
```  
typedef Key key_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Key`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_key_type.cpp   
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
  
// add a value and reinspect   
    Myset::key_type key = 'd';   
    Myset::value_type val = key;   
    c1.insert(val);   
  
    for (Myset::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
 **[d] [c] [b] [a]**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::value_type](../vs140/unordered_multiset--value_type.md)