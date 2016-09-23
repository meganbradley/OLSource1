---
title: "hash Class"
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
  - std.hash
  - xfunctional/std::hash
  - hash
  - typeindex/std::hash
  - std::hash
  - std.tr1.hash
  - std::tr1::hash
dev_langs: 
  - C++
helpviewer_keywords: 
  - hash class
  - hash class [TR1]
ms.assetid: e1b500c6-a5c8-4f6f-ad33-7ec52eb8e2e4
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash Class
Computes hash code for a value.  
  
## Syntax  
  
```  
template<class Ty>  
    struct hash  
        : public unary_function<Ty, size_t> {  
    size_t operator()(Ty _Val) const;  
    };  
```  
  
## Remarks  
 The member function defines a hash function, suitable for mapping values of type `Ty` to a distribution of index values. The member operator returns a hash code for `_Val`, suitable for use with template classes `unordered_map`, `unordered_multimap`, `unordered_set`, and `unordered_multiset`. `Ty` may be any scalar type, `string`, `wstring`, `error_code`, `error_condition`, `u16string`, or `u32string`.  
  
## Example  
  
```  
// std_tr1__functional__hash.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
#include <unordered_set>   
  
int main()   
    {   
    std::unordered_set<int, std::hash<int> > c0;   
    c0.insert(3);   
    std::cout << *c0.find(3) << std::endl;   
  
    return (0);   
    }  
  
```  
  
  **3**    
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [unordered_map](../vs140/-unordered_map-.md)   
 [unordered_multimap Class](../vs140/unordered_multimap-class.md)   
 [unordered_multiset Class](../vs140/unordered_multiset-class.md)   
 [unordered_set](../vs140/-unordered_set-.md)