---
title: "unordered_multiset::get_allocator"
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
  - "unordered_multiset::get_allocator"
  - "get_allocator"
  - "unordered_multiset.get_allocator"
  - "std::tr1::unordered_multiset::get_allocator"
  - "std.tr1.unordered_multiset.get_allocator"
  - "unordered_set/std::tr1::unordered_multiset::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method [TR1]"
ms.assetid: 1f885f6b-f390-4acf-a448-f472d952795e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::get_allocator
Gets the stored allocator object.  
  
## Syntax  
  
```  
Alloc get_allocator() const;  
```  
  
## Remarks  
 The member function returns the stored allocator object.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_get_allocator.cpp   
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