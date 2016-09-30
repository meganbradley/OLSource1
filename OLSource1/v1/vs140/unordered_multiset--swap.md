---
title: "unordered_multiset::swap"
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
  - "unordered_multiset.swap"
  - "tr1.unordered_multiset.swap"
  - "unordered_multiset::swap"
  - "unordered_set/std::tr1::unordered_multiset::swap"
  - "tr1::unordered_multiset::swap"
  - "swap"
  - "std.tr1.unordered_multiset.swap"
  - "std::tr1::unordered_multiset::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method [TR1]"
  - "swap method"
ms.assetid: 746337e0-047a-4efa-97b0-8f61f2329e86
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::swap
Swaps the contents of two containers.  
  
## Syntax  
  
```  
void swap(unordered_multiset& right);  
```  
  
#### Parameters  
 `right`  
 The container to swap with.  
  
## Remarks  
 The member function swaps the controlled sequences between `*this` and `right`. If [get_allocator](../vs140/unordered_multiset--get_allocator.md)`() == right.get_allocator()`, it does so in constant time, it throws an exception only as a result of copying the stored traits object of type `Tr`, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_swap.cpp   
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
  
    Myset c2;   
  
    c2.insert('d');   
    c2.insert('e');   
    c2.insert('f');   
  
    c1.swap(c2);   
  
// display contents " [f] [e] [d]"   
    for (Myset::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
    swap(c1, c2);   
  
// display contents " [c] [b] [a]"   
    for (Myset::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **[c] [b] [a]**  
 **[f] [e] [d]**  
 **[c] [b] [a]**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [swap](../vs140/swap-function--unordered_multiset-.md)