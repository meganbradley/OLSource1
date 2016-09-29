---
title: "unordered_multiset::max_size"
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
  - "unordered_multiset.max_size"
  - "std.tr1.unordered_multiset.max_size"
  - "unordered_set/std::tr1::unordered_multiset::max_size"
  - "max_size"
  - "unordered_multiset::max_size"
  - "std::tr1::unordered_multiset::max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method [TR1]"
ms.assetid: ca160005-05b7-4e6d-ae04-f0dfb30cde73
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::max_size
Gets the maximum size of the controlled sequence.  
  
## Syntax  
  
```  
size_type max_size() const;  
```  
  
## Remarks  
 The member function returns the length of the longest sequence that the object can control.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_max_size.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_multiset<char> Myset;   
int main()   
    {   
    Myset c1;   
  
    std::cout << "max_size() == " << c1.max_size() << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **max_size() == 4294967295**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::size](../vs140/unordered_multiset--size.md)