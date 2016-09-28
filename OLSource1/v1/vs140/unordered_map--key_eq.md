---
title: "unordered_map::key_eq"
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
  - "tr1::unordered_map::key_eq"
  - "unordered_map/std::tr1::unordered_map::key_eq"
  - "tr1.unordered_map.key_eq"
  - "std::tr1::unordered_map::key_eq"
  - "key_eq"
  - "unordered_map::key_eq"
  - "std.tr1.unordered_map.key_eq"
  - "unordered_map.key_eq"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_eq method [TR1]"
  - "key_eq method"
ms.assetid: 9ce8ced4-6fc1-4f40-81f5-6c4b16b62ef5
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::key_eq
Gets the stored comparison function object.  
  
## Syntax  
  
```  
Pred key_eq() const;  
```  
  
## Remarks  
 The member function returns the stored comparison function object.  
  
## Example  
  
```  
// std_tr1__unordered_map__unordered_map_key_eq.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
typedef std::unordered_map<char, int> Mymap;   
int main()   
    {   
    Mymap c1;   
  
    Mymap::key_equal cmpfn = c1.key_eq();   
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
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)