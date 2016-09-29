---
title: "unordered_set::size"
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
  - "std.tr1.unordered_set.size"
  - "unordered_set/std::tr1::unordered_set::size"
  - "unordered_set.size"
  - "std::tr1::unordered_set::size"
  - "unordered_set::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method [TR1]"
ms.assetid: ca415a6e-690f-4b4e-94f7-df4d46dcd97d
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::size
Counts the number of elements.  
  
## Syntax  
  
```  
size_type size() const;  
```  
  
## Remarks  
 The member function returns the length of the controlled sequence.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_size.cpp   
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
 [unordered_set::max_size](../vs140/unordered_set--max_size.md)