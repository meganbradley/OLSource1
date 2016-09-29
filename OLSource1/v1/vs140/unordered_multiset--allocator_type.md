---
title: "unordered_multiset::allocator_type"
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
  - "tr1.unordered_multiset.allocator_type"
  - "unordered_multiset::allocator_type"
  - "std.tr1.unordered_multiset.allocator_type"
  - "allocator_type"
  - "std::tr1::unordered_multiset::allocator_type"
  - "tr1::unordered_multiset::allocator_type"
  - "unordered_multiset.allocator_type"
  - "unordered_set/std::tr1::unordered_multiset::allocator_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_type typedef [TR1]"
  - "allocator_type typedef"
ms.assetid: 775b124b-7746-41ab-a541-d858c1008299
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::allocator_type
The type of an allocator for managing storage.  
  
## Syntax  
  
```  
typedef Alloc allocator_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Alloc`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_allocator_type.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_multiset<char> Myset;   
typedef std::allocator<std::pair<const char, int> > Myalloc;   
int main()   
    {   
    Myset c1;   
  
    Myset::allocator_type al = c1.get_allocator();   
    std::cout << "al == std::allocator() is "   
        << std::boolalpha << (al == Myalloc()) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **al == std::allocator() is true**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)