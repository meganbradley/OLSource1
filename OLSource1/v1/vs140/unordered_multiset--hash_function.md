---
title: "unordered_multiset::hash_function"
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
  - tr1.unordered_multiset.hash_function
  - unordered_set/std::tr1::unordered_multiset::hash_function
  - std.tr1.unordered_multiset.hash_function
  - unordered_multiset.hash_function
  - tr1::unordered_multiset::hash_function
  - hash_function
  - std::tr1::unordered_multiset::hash_function
  - unordered_multiset::hash_function
dev_langs: 
  - C++
helpviewer_keywords: 
  - hash_function method [TR1]
  - hash_function method
ms.assetid: 621936d3-3177-47f9-b372-1268b6d64046
caps.latest.revision: 20
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multiset::hash_function
Gets the stored hash function object.  
  
## Syntax  
  
```  
Hash hash_function() const;  
```  
  
## Remarks  
 The member function returns the stored hash function object.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_hash_function.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_multiset<char> Myset;   
int main()   
    {   
    Myset c1;   
  
    Myset::hasher hfn = c1.hash_function();   
    std::cout << "hfn('a') == " << hfn('a') << std::endl;   
    std::cout << "hfn('b') == " << hfn('b') << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **hfn('a') == 1630279**  
**hfn('b') == 1647086**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)