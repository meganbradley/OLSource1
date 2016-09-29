---
title: "unordered_set::rehash"
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
  - "std::tr1::unordered_set::rehash"
  - "std.tr1.unordered_set.rehash"
  - "unordered_set::rehash"
  - "unordered_set.rehash"
  - "rehash"
  - "unordered_set/std::tr1::unordered_set::rehash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rehash method [TR1]"
ms.assetid: 89f575c7-4616-4e47-bca0-8abdc5af9e44
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::rehash
Rebuilds the hash table.  
  
## Syntax  
  
```  
void rehash(size_type nbuckets);  
```  
  
#### Parameters  
 `nbuckets`  
 The requested number of buckets.  
  
## Remarks  
 The member function alters the number of buckets to be at least `nbuckets` and rebuilds the hash table as needed.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_rehash.cpp   
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
  
// inspect current parameters   
    std::cout << "bucket_count() == " << c1.bucket_count() << std::endl;   
    std::cout << "load_factor() == " << c1.load_factor() << std::endl;   
    std::cout << "max_load_factor() == " << c1.max_load_factor() << std::endl;   
    std::cout << std::endl;   
  
// change max_load_factor and redisplay   
    c1.max_load_factor(0.10f);   
    std::cout << "bucket_count() == " << c1.bucket_count() << std::endl;   
    std::cout << "load_factor() == " << c1.load_factor() << std::endl;   
    std::cout << "max_load_factor() == " << c1.max_load_factor() << std::endl;   
    std::cout << std::endl;   
  
// rehash and redisplay   
    c1.rehash(100);   
    std::cout << "bucket_count() == " << c1.bucket_count() << std::endl;   
    std::cout << "load_factor() == " << c1.load_factor() << std::endl;   
    std::cout << "max_load_factor() == " << c1.max_load_factor() << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_load_factor() == 0.1**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::max_load_factor](../vs140/unordered_set--max_load_factor.md)