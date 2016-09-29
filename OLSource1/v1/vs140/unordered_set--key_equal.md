---
title: "unordered_set::key_equal"
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
  - "unordered_set.key_equal"
  - "unordered_set::key_equal"
  - "tr1::unordered_set::key_equal"
  - "std::tr1::unordered_set::key_equal"
  - "tr1.unordered_set.key_equal"
  - "std.tr1.unordered_set.key_equal"
  - "key_equal"
  - "unordered_set/std::tr1::unordered_set::key_equal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_equal typedef [TR1]"
  - "key_equal typedef"
ms.assetid: e996a98d-9ec6-41b5-9c46-f935f91418f7
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::key_equal
The type of the comparison function.  
  
## Syntax  
  
```  
typedef Pred key_equal;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Pred`.  
  
## Example  
  
```  
// std_tr1__unordered_set__unordered_set_key_equal.cpp   
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