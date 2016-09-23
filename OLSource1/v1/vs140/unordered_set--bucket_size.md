---
title: "unordered_set::bucket_size"
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
  - bucket_size
  - std::tr1::unordered_set::bucket_size
  - unordered_set/std::tr1::unordered_set::bucket_size
  - std.tr1.unordered_set.bucket_size
  - unordered_set.bucket_size
  - unordered_set::bucket_size
dev_langs: 
  - C++
helpviewer_keywords: 
  - bucket_size method [TR1]
ms.assetid: dbbacdba-4ab7-44bd-83ca-c956f2b21f29
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unordered_set::bucket_size
Gets the size of a bucket  
  
## Syntax  
  
```  
size_type bucket_size(size_type nbucket) const;  
```  
  
#### Parameters  
 `nbucket`  
 The bucket number.  
  
## Remarks  
 The member functions returns the size of bucket number `nbucket`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_bucket_size.cpp   
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
  
// display buckets for keys   
    Myset::size_type bs = c1.bucket('a');   
    std::cout << "bucket('a') == " << bs << std::endl;   
    std::cout << "bucket_size(" << bs << ") == " << c1.bucket_size(bs)   
        << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::bucket](../vs140/unordered_set--bucket.md)   
 [unordered_set::bucket_count](../vs140/unordered_set--bucket_count.md)