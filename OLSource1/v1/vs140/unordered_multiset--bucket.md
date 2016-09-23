---
title: "unordered_multiset::bucket"
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
  - unordered_multiset.bucket
  - bucket
  - unordered_set/std::tr1::unordered_multiset::bucket
  - std.tr1.unordered_multiset.bucket
  - std::tr1::unordered_multiset::bucket
  - unordered_multiset::bucket
dev_langs: 
  - C++
helpviewer_keywords: 
  - bucket method [TR1]
ms.assetid: ebdd0567-986d-4bca-83ba-8416b5cf8c1d
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unordered_multiset::bucket
Gets the bucket number for a key value.  
  
## Syntax  
  
```  
size_type bucket(const Key& keyval) const;  
```  
  
#### Parameters  
 keyval  
 The key value to map.  
  
## Remarks  
 The member function returns the bucket number currently corresponding to the key value `keyval`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_bucket.cpp   
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
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::bucket_count](../vs140/unordered_multiset--bucket_count.md)   
 [unordered_multiset::bucket_size](../vs140/unordered_multiset--bucket_size.md)