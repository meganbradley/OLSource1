---
title: "unordered_multiset::key_eq"
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
  - unordered_set/std::tr1::unordered_multiset::key_eq
  - unordered_multiset.key_eq
  - tr1.unordered_multiset.key_eq
  - std.tr1.unordered_multiset.key_eq
  - unordered_multiset::key_eq
  - key_eq
  - std::tr1::unordered_multiset::key_eq
  - tr1::unordered_multiset::key_eq
dev_langs: 
  - C++
helpviewer_keywords: 
  - key_eq method [TR1]
  - key_eq method
ms.assetid: 390f9670-af06-49d4-a152-2f3fdf451860
caps.latest.revision: 20
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_multiset::key_eq
Gets the stored comparison function object.  
  
## Syntax  
  
```  
Pred key_eq() const;  
```  
  
## Remarks  
 The member function returns the stored comparison function object.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_key_eq.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_multiset<char> Myset;   
int main()   
    {   
    Myset c1;   
  
    Myset::key_equal cmpfn = c1.key_eq();   
    std::cout << "cmpfn('a', 'a') == "   
        << std::boolalpha << cmpfn('a', 'a') << std::endl;   
    std::cout << "cmpfn('a', 'b') == "   
        << std::boolalpha << cmpfn('a', 'b') << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **cmpfn('a', 'a') == true**  
**cmpfn('a', 'b') == false**   
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)