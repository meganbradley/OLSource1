---
title: "unordered_set::hasher"
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
  - unordered_set/std::tr1::unordered_set::hasher
  - tr1::unordered_set::hasher
  - std.tr1.unordered_set.hasher
  - tr1.unordered_set.hasher
  - unordered_set.hasher
  - std::tr1::unordered_set::hasher
  - unordered_set::hasher
  - hasher
dev_langs: 
  - C++
helpviewer_keywords: 
  - hasher typedef
  - hasher typedef [TR1]
ms.assetid: 0eed0b89-0292-400e-a4e3-e5cb6ca09729
caps.latest.revision: 19
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_set::hasher
The type of the hash function.  
  
## Syntax  
  
```  
typedef Hash hasher;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Hash`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_hasher.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_set<char> Myset;   
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
 [unordered_set](../vs140/unordered_set-class.md)