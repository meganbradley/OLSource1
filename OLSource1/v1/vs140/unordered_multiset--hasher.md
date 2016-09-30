---
title: "unordered_multiset::hasher"
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
  - "tr1.unordered_multiset.hasher"
  - "unordered_set/std::tr1::unordered_multiset::hasher"
  - "tr1::unordered_multiset::hasher"
  - "std::tr1::unordered_multiset::hasher"
  - "unordered_multiset.hasher"
  - "std.tr1.unordered_multiset.hasher"
  - "unordered_multiset::hasher"
  - "hasher"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hasher typedef"
  - "hasher typedef [TR1]"
ms.assetid: 0dd598df-cb32-4115-bb10-9c8cc0ac6b25
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::hasher
The type of the hash function.  
  
## Syntax  
  
```  
typedef Hash hasher;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Hash`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_hasher.cpp   
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
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)