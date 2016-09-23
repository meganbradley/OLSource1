---
title: "unordered_set::find"
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
  - std::tr1::unordered_set::find
  - std.tr1.unordered_set.find
  - unordered_set::find
  - unordered_set/std::tr1::unordered_set::find
  - unordered_set.find
dev_langs: 
  - C++
helpviewer_keywords: 
  - find method [TR1]
ms.assetid: cb499cb7-05d1-4b1c-81bd-cb7939c6dc7b
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unordered_set::find
Finds an element that matches a specified key.  
  
## Syntax  
  
```  
const_iterator find(const Key& keyval) const;  
```  
  
#### Parameters  
 `keyval`  
 Key value to search for.  
  
## Remarks  
 The member function returns [equal_range](../vs140/unordered_set--equal_range.md)`(keyval).first`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_find.cpp   
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
  
// try to find and fail   
    std::cout << "find('A') == "   
        << std::boolalpha << (c1.find('A') != c1.end()) << std::endl;   
  
// try to find and succeed   
    Myset::iterator it = c1.find('b');   
    std::cout << "find('b') == "   
        << std::boolalpha << (it != c1.end())   
        << ": [" << *it << "]" << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
**find('A') == false**  
**find('b') == true: [b]**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::equal_range](../vs140/unordered_set--equal_range.md)