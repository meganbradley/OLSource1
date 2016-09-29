---
title: "unordered_multiset::key_equal"
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
  - "unordered_multiset.key_equal"
  - "unordered_set/std::tr1::unordered_multiset::key_equal"
  - "std.tr1.unordered_multiset.key_equal"
  - "unordered_multiset::key_equal"
  - "tr1.unordered_multiset.key_equal"
  - "tr1::unordered_multiset::key_equal"
  - "std::tr1::unordered_multiset::key_equal"
  - "key_equal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_equal typedef [TR1]"
  - "key_equal typedef"
ms.assetid: 993c2fc9-c89d-4868-8689-c086f3001c5a
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::key_equal
The type of the comparison function.  
  
## Syntax  
  
```  
typedef Pred key_equal;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Pred`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_multiset_key_equal.cpp   
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