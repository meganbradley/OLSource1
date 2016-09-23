---
title: "unordered_multiset::load_factor"
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
  - unordered_multiset::load_factor
  - unordered_set/std::tr1::unordered_multiset::load_factor
  - std::tr1::unordered_multiset::load_factor
  - load_factor
  - std.tr1.unordered_multiset.load_factor
  - unordered_multiset.load_factor
dev_langs: 
  - C++
helpviewer_keywords: 
  - load_factor method [TR1]
ms.assetid: af7266bb-688b-4a3d-9d3b-c1f119b5a8f3
caps.latest.revision: 18
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multiset::load_factor
Counts the average elements per bucket.  
  
## Syntax  
  
```  
float load_factor() const;  
```  
  
## Remarks  
 The member function returns `(float)`[size](../vs140/unordered_multiset--size.md)`() / (float)`[bucket_count](../vs140/unordered_multiset--bucket_count.md)`()`, the average number of elements per bucket.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_load_factor.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_multiset<char> Myset;   
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
  
// inspect current parameters   
    std::cout << "bucket_count() == " << c1.bucket_count() << std::endl;   
    std::cout << "load_factor() == " << c1.load_factor() << std::endl;   
    std::cout << "max_bucket_count() == "   
        << c1.max_bucket_count() << std::endl;   
    std::cout << "max_load_factor() == "   
        << c1.max_load_factor() << std::endl;   
    std::cout << std::endl;   
  
// change max_load_factor and redisplay   
    c1.max_load_factor(0.10f);   
    std::cout << "bucket_count() == " << c1.bucket_count() << std::endl;   
    std::cout << "load_factor() == " << c1.load_factor() << std::endl;   
    std::cout << "max_bucket_count() == "   
        << c1.max_bucket_count() << std::endl;   
    std::cout << "max_load_factor() == "   
        << c1.max_load_factor() << std::endl;   
    std::cout << std::endl;   
  
// rehash and redisplay   
    c1.rehash(100);   
    std::cout << "bucket_count() == " << c1.bucket_count() << std::endl;   
    std::cout << "load_factor() == " << c1.load_factor() << std::endl;   
    std::cout << "max_bucket_count() == "   
        << c1.max_bucket_count() << std::endl;   
    std::cout << "max_load_factor() == "   
        << c1.max_load_factor() << std::endl;   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::bucket_count](../vs140/unordered_multiset--bucket_count.md)   
 [unordered_multiset::max_load_factor](../vs140/unordered_multiset--max_load_factor.md)