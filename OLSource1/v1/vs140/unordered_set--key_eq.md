---
title: "unordered_set::key_eq"
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
  - "std::tr1::unordered_set::key_eq"
  - "std.tr1.unordered_set.key_eq"
  - "tr1.unordered_set.key_eq"
  - "unordered_set.key_eq"
  - "key_eq"
  - "unordered_set::key_eq"
  - "unordered_set/std::tr1::unordered_set::key_eq"
  - "tr1::unordered_set::key_eq"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_eq method [TR1]"
  - "key_eq method"
ms.assetid: 822b2a8a-d85b-49c2-9964-7d86c27536a9
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::key_eq
Gets the stored comparison function object.  
  
## Syntax  
  
```  
Pred key_eq() const;  
```  
  
## Remarks  
 The member function returns the stored comparison function object.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_key_eq.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_set<char> Myset;   
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
 [unordered_set](../vs140/unordered_set-class.md)