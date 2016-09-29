---
title: "unordered_map::bucket"
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
  - "unordered_map::bucket"
  - "bucket"
  - "unordered_map/std::tr1::unordered_map::bucket"
  - "std.tr1.unordered_map.bucket"
  - "unordered_map.bucket"
  - "std::tr1::unordered_map::bucket"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket method [TR1]"
ms.assetid: ba18b69d-426e-44ac-bd07-dc336fa3dec5
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::bucket
Gets the bucket number for a key value.  
  
## Syntax  
  
```  
size_type bucket(const Key& keyval) const;  
```  
  
#### Parameters  
 `keyval`  
 The key value to map.  
  
## Remarks  
 The member function returns the bucket number currently corresponding to the key value `keyval`.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_bucket.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_map<char, int> Mymap;   
int main()   
    {   
    Mymap c1;   
  
    c1.insert(Mymap::value_type('a', 1));   
    c1.insert(Mymap::value_type('b', 2));   
    c1.insert(Mymap::value_type('c', 3));   
  
// display contents " [c 3] [b 2] [a 1]"   
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
// display buckets for keys   
    Mymap::size_type bs = c1.bucket('a');   
    std::cout << "bucket('a') == " << bs << std::endl;   
    std::cout << "bucket_size(" << bs << ") == " << c1.bucket_size(bs)   
        << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::bucket_count](../vs140/unordered_map--bucket_count.md)   
 [unordered_map::bucket_size](../vs140/unordered_map--bucket_size.md)