---
title: "unordered_multiset::clear"
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
  - std::tr1::unordered_multiset::clear
  - unordered_multiset.clear
  - unordered_multiset::clear
  - std.tr1.unordered_multiset.clear
  - unordered_set/std::tr1::unordered_multiset::clear
dev_langs: 
  - C++
helpviewer_keywords: 
  - clear method [TR1]
ms.assetid: 93980b55-42d0-4b1a-ac79-5828f3020a2e
caps.latest.revision: 20
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multiset::clear
Removes all elements.  
  
## Syntax  
  
```  
void clear();  
```  
  
## Remarks  
 The member function calls [erase](../vs140/unordered_multiset--erase.md)`(` [begin](../vs140/unordered_multiset--begin.md)`(),` [end](../vs140/unordered_multiset--end.md)`())`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_clear.cpp   
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
  
// clear the container and reinspect   
    c1.clear();   
    std::cout << "size == " << c1.size() << std::endl;   
    std::cout << "empty() == " << std::boolalpha << c1.empty() << std::endl;   
    std::cout << std::endl;   
  
    c1.insert('d');   
    c1.insert('e');   
  
// display contents " [e] [d]"   
    for (Myset::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
    std::cout << "size == " << c1.size() << std::endl;   
    std::cout << "empty() == " << std::boolalpha << c1.empty() << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
**size == 0**  
**empty() == true**  
 **[e] [d]**  
**size == 2**  
**empty() == false**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::erase](../vs140/unordered_multiset--erase.md)