---
title: "unordered_multiset::begin"
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
  - unordered_set/std::tr1::unordered_multiset::begin
  - std::tr1::unordered_multiset::begin
  - unordered_multiset::begin
  - std.tr1.unordered_multiset.begin
  - unordered_multiset.begin
dev_langs: 
  - C++
helpviewer_keywords: 
  - begin method [TR1]
ms.assetid: 8f395270-55bf-4549-a977-ff419f33c3bd
caps.latest.revision: 21
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multiset::begin
Designates the beginning of the controlled sequence or a bucket.  
  
## Syntax  
  
```  
iterator begin();  
const_iterator begin() const;  
local_iterator begin(size_type nbucket);  
const_local_iterator begin(size_type nbucket) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`nbucket`|The bucket number.|  
  
## Remarks  
 The first two member functions return a forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence). The last two member functions return a forward iterator that points at the first element of bucket `nbucket` (or just beyond the end of an empty bucket).  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_begin.cpp   
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
  
// inspect first two items " [c] [b]"   
    Myset::iterator it2 = c1.begin();   
    std::cout << " [" << *it2 << "]";   
    ++it2;   
    std::cout << " [" << *it2 << "]";   
    std::cout << std::endl;   
  
// inspect bucket containing 'a'   
    Myset::const_local_iterator lit = c1.begin(c1.bucket('a'));   
    std::cout << " [" << *lit << "]";   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
 **[c] [b]**  
 **[a]**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::end](../vs140/unordered_multiset--end.md)