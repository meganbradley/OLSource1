---
title: "unordered_set::equal_range"
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
  - "unordered_set/std::tr1::unordered_set::equal_range"
  - "std.tr1.unordered_set.equal_range"
  - "std::tr1::unordered_set::equal_range"
  - "unordered_set.equal_range"
  - "unordered_set::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method [TR1]"
ms.assetid: ed1d937b-d5a9-4e3a-a089-c228cc023cde
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::equal_range
Finds range that matches a specified key.  
  
## Syntax  
  
```  
std::pair<iterator, iterator>  
    equal_range(const Key& keyval);  
std::pair<const_iterator, const_iterator>  
    equal_range(const Key& keyval) const;  
```  
  
#### Parameters  
 `keyval`  
 Key value to search for.  
  
## Remarks  
 The member function returns a pair of iterators `X` such that `[X.first, X.second)` delimits just those elements of the controlled sequence that have equivalent ordering with `keyval`. If no such elements exist, both iterators are `end()`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_equal_range.cpp   
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
  
// display results of failed search   
    std::pair<Myset::iterator, Myset::iterator> pair1 =   
        c1.equal_range('x');   
    std::cout << "equal_range('x'):";   
    for (; pair1.first != pair1.second; ++pair1.first)   
        std::cout << " [" << *pair1.first << "]";   
    std::cout << std::endl;   
  
// display results of successful search   
    pair1 = c1.equal_range('b');   
    std::cout << "equal_range('b'):";   
    for (; pair1.first != pair1.second; ++pair1.first)   
        std::cout << " [" << *pair1.first << "]";   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
**equal_range('x'):**  
**equal_range('b'): [b]**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)