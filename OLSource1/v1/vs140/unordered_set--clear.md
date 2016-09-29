---
title: "unordered_set::clear"
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
  - "unordered_set::clear"
  - "unordered_set.clear"
  - "std.tr1.unordered_set.clear"
  - "unordered_set/std::tr1::unordered_set::clear"
  - "std::tr1::unordered_set::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method [TR1]"
ms.assetid: 40506306-519d-4b11-b46c-8765ee26c4cb
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::clear
Removes all elements.  
  
## Syntax  
  
```  
void clear();  
```  
  
## Remarks  
 The member function calls [erase](../vs140/unordered_set--erase.md)`(` [begin](../vs140/unordered_set--begin.md)`(),` [end](../vs140/unordered_set--end.md)`())`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_clear.cpp   
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
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::erase](../vs140/unordered_set--erase.md)